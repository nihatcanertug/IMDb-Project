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
    public class EfMovieRepository : EfBaseRepository, IMovieRepository, IBaseRepository
    {
        public void CreateMovie(string title, string content, string image)
        {
            Movie movie = new Movie();
            movie.Title = title;
            movie.Content = content;
            movie.ImageUrl = image;
            db.Movies.Add(movie);
            db.SaveChanges();
        }

        public void DeleteMovie(int id)
        {
            Movie movie = new Movie();
            movie = db.Movies.FirstOrDefault(x => x.Id == id);
            movie.PassivedDate = DateTime.Now;
            movie.Status = Status.Passive;
            db.SaveChanges();
        }

        public void Eraser(GroupBox groupBox)
        {
            foreach (Control item in groupBox.Controls)
            {
                if(item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        public List<Movie> GetMovie()
        {
            Movie movie = new Movie();
            return db.Movies.Where(x=>x.Status!=Status.Passive).ToList();
        }

        public void UpdateMovie(int id, string title, string content, string image)
        {
            Movie movie = new Movie();
            movie = db.Movies.FirstOrDefault(x => x.Id == id);
            movie.Title = title;
            movie.Content = content;
            movie.ImageUrl = image;
            movie.ModifiedDate = DateTime.Now;
            movie.Status = Status.Modified;
            db.SaveChanges();
        }
    }
}
