using IMDb_Project.DataAccessLayer.Repositories.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMDb_Project.UI.Admin
{
    public partial class AdminMoviePage : Form
    {
        public AdminMoviePage()
        {
            InitializeComponent();
        }

        string fileName;
        private void btnAddPicture_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fileName = openFileDialog1.FileName;
                TxtImageUrl.Text = fileName;
            }
        }

        EfMovieRepository efMovieRepository = new EfMovieRepository();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            efMovieRepository.CreateMovie(txtAddTitle.Text, txtAddContent.Text, fileName);
            dataGridView1.DataSource = efMovieRepository.GetMovie();
            efMovieRepository.Eraser(grpAddMovie);
        }
    }
}
