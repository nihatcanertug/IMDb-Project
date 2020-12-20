using IMDb_Project.EntityLayer.Entities.Concrete;
using IMDb_Project.EntityLayer.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMDb_Project.DataAccessLayer.Repositories.Interfaces
{
    public interface IAppUserRepository
    {
        void CreateAppUser(string firstname, string lastname, string username, string password, Role role);
        void UpdateAppUser(int id, string firstname, string lastname, string username, string password, Role role);
        void DeleteAppUser(int id);

        void FindById(int id, TextBox txtFirstName,TextBox txtLastName,TextBox txtUserName,TextBox txtPassword);

        void GetRole(ComboBox cmbAddRole, ComboBox cmbUpdateRole, ComboBox cmbFindByRole);


        List<AppUser> GetAppUsers();
        List<AppUser> GetAll();
        List<AppUser> FindByName(string fullName);
        List<AppUser> GetByRole(Role role);
        List<AppUser> GetByCreateDate(DateTime startDate, DateTime endDate);


    }
}
