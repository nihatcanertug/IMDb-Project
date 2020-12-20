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
    public class EfGenreRepository : EfBaseRepository, IBaseRepository, IGenreRepository
    {
        public void CreateGenre(string name)
        {
            if (String.IsNullOrEmpty(name))
            {

                MessageBox.Show("Please type into  information..!");
            }
            else
            {
                Genre genre = new Genre();     // We got an instance from the Genre class.
                genre.Name = name;
                db.Genres.Add(genre);
                db.SaveChanges();
            }
            
        }

        public void DeleteGenre(int id)
        {
            // User may not enter id in textbox.
            try
            {
                Genre genre = new Genre();
                genre = db.Genres.FirstOrDefault(x => x.Id == id);

                // There may not be any information with the Id value entered in the textbox.
                if (genre==null)
                {

                    MessageBox.Show("Can't found..!");
                }
                else
                {
                    
                    genre.PassivedDate = DateTime.Now;
                    genre.Status = Status.Passive;
                    db.SaveChanges();
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Please type into id information..!");
            }
          
        }
        public void Eraser(GroupBox groupBox)
        {
            foreach (Control item in groupBox.Controls)
            {
                if(item is TextBox )
                {
                    item.Text = "";
                }

            }
        }

        public void FindById(int id, TextBox textbox)
        {
            try
            {
                Genre genre = new Genre();
                genre = db.Genres.FirstOrDefault(x => x.Id == id);
                if (genre == null)
                {
                    MessageBox.Show("Can't found..!");
                }
                else
                {
                    textbox.Text = genre.Name;
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Please type into id information..!");
            }
         
           
        }

        public List<Genre> FindByName(string name)
        {
            return db.Genres.Where(x=>x.Name.ToLower().Contains(name.ToLower())).ToList();
        }

        public List<Genre> GetAll()
        {
            return db.Genres.ToList();
        }

        public List<Genre> GetGenre()
        {
            return db.Genres.Where(x => x.Status != Status.Passive).ToList(); //Returns all data whose status is not passive, data not deleted.
        }

        public void UpdateGenre(int id, string name)
        {
            try
            {
                Genre genre = new Genre();
                genre = db.Genres.FirstOrDefault(x => x.Id == id);
                if (genre == null)
                {
                    MessageBox.Show("Can't found..!");
                }
                else
                {
                    genre.Name = name;
                    genre.ModifiedDate = DateTime.Now;
                    genre.Status = Status.Modified;
                    db.SaveChanges();
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Please type into id information..!");
            }
            
            
        }
    }
}
