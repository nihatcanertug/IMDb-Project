using IMDb_Project.EntityLayer.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMDb_Project.DataAccessLayer.Repositories.Interfaces
{
    public interface IMovieRepository
    {
        void CreateMovie(string title, string content, string image);
        void UpdateMovie(int id, string title, string content, string image);
        void DeleteMovie(int id);

        List<Movie> GetMovie();
    }
}
