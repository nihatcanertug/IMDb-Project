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
    public partial class AdminGenrePage : Form
    {
        public AdminGenrePage()
        {
            InitializeComponent();
        }

        EfGenreRepository efGenreRepository = new EfGenreRepository();   // We got instance.
        private void btnAdd_Click(object sender, EventArgs e)
        {
            efGenreRepository.CreateGenre(txtAddName.Text);
            // We called the CreateGenre method using the instance we got.
            dataGridView1.DataSource = efGenreRepository.GetGenre();
            efGenreRepository.Eraser(grpAdd);


        }

        private void AdminGenrePage_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = efGenreRepository.GetGenre();
        }

        private void btnFindbyId_Click(object sender, EventArgs e)
        {
            efGenreRepository.FindById(int.Parse(txtFindId.Text), txtUpdateName);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            efGenreRepository.UpdateGenre(int.Parse(txtFindId.Text), txtUpdateName.Text);
            dataGridView1.DataSource = efGenreRepository.GetGenre();
            efGenreRepository.Eraser(grpUpdate);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            efGenreRepository.DeleteGenre(int.Parse(txtDeleteById.Text));
            efGenreRepository.Eraser(grpDelete);
            dataGridView1.DataSource = efGenreRepository.GetGenre();
        }

        private void btnGetAll_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = efGenreRepository.GetAll();
        }

        private void btnFindByName_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = efGenreRepository.FindByName(txtFindByName.Text);
            efGenreRepository.Eraser(grpFindByName);
        }
    }
}
