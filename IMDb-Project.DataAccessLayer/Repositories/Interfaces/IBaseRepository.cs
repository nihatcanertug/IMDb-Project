using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMDb_Project.DataAccessLayer.Repositories.Interfaces
{
    public interface IBaseRepository   // We write our common methods in the whole project.
    {
        void Eraser(GroupBox groupBox);
    }
}
