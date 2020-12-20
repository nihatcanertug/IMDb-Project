using IMDb_Project.DataAccessLayer.Repositories.Interfaces;
using IMDb_Project.EntityLayer.Entities.Concrete;
using IMDb_Project.EntityLayer.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMDb_Project.DataAccessLayer.Repositories.Concrete
{
    public class EfAppUserRepository : EfBaseRepository, IBaseRepository, IAppUserRepository
    {
        public void CreateAppUser(string firstname, string lastname, string username, string password, Role role)
        {
            AppUser appUser = new AppUser();
            appUser.FirstName = firstname;
            appUser.LastName = lastname;
            appUser.UserName = username;
            appUser.Password = password;
            appUser.Role = role;
            db.AppUsers.Add(appUser);
            db.SaveChanges();
        }

        public void DeleteAppUser(int id)
        {
            AppUser appUser = new AppUser();
            appUser = db.AppUsers.FirstOrDefault(x => x.Id == id);
            appUser.PassivedDate = DateTime.Now;
            appUser.Status = Status.Passive;
            db.SaveChanges();
        }

        public void Eraser(GroupBox groupBox)
        {
            foreach (Control item in groupBox.Controls)
            {
                if(item is TextBox || item is ComboBox)
                {
                    item.Text = "";
                }
            }
        }

        public void FindById(int id, TextBox txtFirstName, TextBox txtLastName, TextBox txtUserName, TextBox txtPassword)
        {
            AppUser appUser = new AppUser();
            appUser = db.AppUsers.FirstOrDefault(x => x.Id == id);
            txtFirstName.Text = appUser.FirstName;
            txtLastName.Text = appUser.LastName;
            txtUserName.Text = appUser.Password;
            txtPassword.Text = appUser.Password;
        }

        public List<AppUser> FindByName(string fullName)
        {
            return db.AppUsers.Where(x => x.FullName.ToLower().Contains(fullName)).ToList();
        }

        public List<AppUser> GetAll()
        {
            return db.AppUsers.ToList();
        }

        public List<AppUser> GetAppUsers()
        {
            return db.AppUsers.Where(x => x.Status != Status.Passive).ToList();
        }

        public List<AppUser> GetByCreateDate(DateTime startDate, DateTime endDate)
        {
            return db.AppUsers.Where(x => x.CreateDate >= startDate && x.CreateDate <= endDate).ToList();
        }

        public List<AppUser> GetByRole(Role role)
        {
            return db.AppUsers.Where(x => x.Role == role && x.Status!=Status.Passive).ToList();
        }

        public void GetRole(ComboBox cmbAddRole, ComboBox cmbUpdateRole, ComboBox cmbFindByRole)
        {
            cmbAddRole.Items.AddRange(Enum.GetNames(typeof(Role)));
            cmbAddRole.SelectedIndex = 1;

            cmbUpdateRole.Items.AddRange(Enum.GetNames(typeof(Role)));
            cmbUpdateRole.SelectedIndex = 1;

            cmbFindByRole.Items.AddRange(Enum.GetNames(typeof(Role)));
            cmbFindByRole.SelectedIndex = 1;


        }

        public void UpdateAppUser(int id, string firstname, string lastname, string username, string password, Role role)
        {
            AppUser appUser = new AppUser();
            appUser = db.AppUsers.FirstOrDefault(x => x.Id == id);
            appUser.FirstName = firstname;
            appUser.LastName = lastname;
            appUser.UserName = username;
            appUser.Password = password;
            appUser.Role = role;
            appUser.ModifiedDate = DateTime.Now;
            appUser.Status = Status.Modified;
            db.SaveChanges();



        }
    }
}
