using IMDb_Project.DataAccessLayer.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMDb_Project.DataAccessLayer.Repositories.Concrete
{
    public class EfBaseRepository
    {
        public ProjectContext db;
        public EfBaseRepository()
        {
            db = new ProjectContext();
            // We new the Project context object and made it inherit all repository from it. We will not need to redefine it in every class.
        }
    }
}
