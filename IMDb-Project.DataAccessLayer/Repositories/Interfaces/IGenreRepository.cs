using IMDb_Project.EntityLayer.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMDb_Project.DataAccessLayer.Repositories.Interfaces
{
    public interface IGenreRepository
    // We write the methods of the operations we will do on the type entity.
    {
        void CreateGenre(string name);
        void UpdateGenre(int id,string name);
        void DeleteGenre(int id);

        void FindById(int id, TextBox textbox);

        List<Genre> GetGenre();    // We get the Genres that will come when we pull the data from the db.
        List<Genre> FindByName(string name); // It finds and lists data by name.
        List<Genre> GetAll();    // It lists everything.
    }
}
