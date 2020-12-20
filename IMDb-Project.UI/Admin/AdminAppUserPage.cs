using IMDb_Project.DataAccessLayer.Repositories.Concrete;
using IMDb_Project.EntityLayer.Enums;
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
    public partial class AdminAppUserPage : Form
    {
        public AdminAppUserPage()
        {
            InitializeComponent();
        }

        EfAppUserRepository efAppUserRepository = new EfAppUserRepository();
        private void AdminAppUserPage_Load(object sender, EventArgs e)
        {
            
            efAppUserRepository.GetRole(cmbAddRole, cmbUpdateRole, cmbFindByRole);
            dataGridView1.DataSource = efAppUserRepository.GetAppUsers();
        }

        private void BtnAddUser_Click(object sender, EventArgs e)
        {
            efAppUserRepository.CreateAppUser(
                txtAddFirstname.Text, txtAddLastname.Text, txtAddUsername.Text, txtAddPassword.Text, (Role)Enum.Parse(typeof(Role), cmbAddRole.Text));
            dataGridView1.DataSource = efAppUserRepository.GetAppUsers();
            efAppUserRepository.Eraser(grpAddUser);


        }

        private void btnFindById_Click(object sender, EventArgs e)
        {
            efAppUserRepository.FindById(int.Parse(txtFindbyId.Text), txtUpdateFirstname, txtUpdateLastname, txtUpdateUsername, txtUpdatePassword);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            efAppUserRepository.UpdateAppUser(int.Parse(txtFindbyId.Text), txtUpdateFirstname.Text, txtUpdateLastname.Text, txtUpdateUsername.Text, txtUpdatePassword.Text, (Role)Enum.Parse(typeof(Role), cmbUpdateRole.Text));
            dataGridView1.DataSource = efAppUserRepository.GetAll();
            efAppUserRepository.Eraser(grpUpdateUser);
        }

        private void cmbFindByRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource=efAppUserRepository.GetByRole((Role)Enum.Parse(typeof(Role), cmbFindByRole.Text));
        }

        private void BtnDeleteUser_Click(object sender, EventArgs e)
        {
            efAppUserRepository.DeleteAppUser(int.Parse(txtDeleteID.Text));
            dataGridView1.DataSource = efAppUserRepository.GetAppUsers();
            efAppUserRepository.Eraser(grpDelete);
        }

        private void btnGetAllUser_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = efAppUserRepository.GetAll();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = efAppUserRepository.GetByCreateDate(DateTime.Parse(dateTimePicker1.Text), DateTime.Parse(dateTimePicker2.Text));
        }
    }
}
