
namespace IMDb_Project.UI.Admin
{
    partial class AdminAppUserPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpAddUser = new System.Windows.Forms.GroupBox();
            this.cmbAddRole = new System.Windows.Forms.ComboBox();
            this.BtnAddUser = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAddPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAddUsername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAddLastname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAddFirstname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.grpUpdateUser = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtFindbyId = new System.Windows.Forms.TextBox();
            this.btnFindById = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbUpdateRole = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUpdatePassword = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtUpdateUsername = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtUpdateLastname = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtUpdateFirstname = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbFindByRole = new System.Windows.Forms.ComboBox();
            this.grpDelete = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtDeleteID = new System.Windows.Forms.TextBox();
            this.BtnDeleteUser = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnGetAllUser = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.grpAddUser.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grpUpdateUser.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpDelete.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpAddUser
            // 
            this.grpAddUser.Controls.Add(this.cmbAddRole);
            this.grpAddUser.Controls.Add(this.BtnAddUser);
            this.grpAddUser.Controls.Add(this.label5);
            this.grpAddUser.Controls.Add(this.txtAddPassword);
            this.grpAddUser.Controls.Add(this.label4);
            this.grpAddUser.Controls.Add(this.txtAddUsername);
            this.grpAddUser.Controls.Add(this.label3);
            this.grpAddUser.Controls.Add(this.txtAddLastname);
            this.grpAddUser.Controls.Add(this.label2);
            this.grpAddUser.Controls.Add(this.txtAddFirstname);
            this.grpAddUser.Controls.Add(this.label1);
            this.grpAddUser.Location = new System.Drawing.Point(28, 22);
            this.grpAddUser.Name = "grpAddUser";
            this.grpAddUser.Size = new System.Drawing.Size(224, 301);
            this.grpAddUser.TabIndex = 0;
            this.grpAddUser.TabStop = false;
            this.grpAddUser.Text = "Add User";
            // 
            // cmbAddRole
            // 
            this.cmbAddRole.FormattingEnabled = true;
            this.cmbAddRole.Location = new System.Drawing.Point(18, 228);
            this.cmbAddRole.Name = "cmbAddRole";
            this.cmbAddRole.Size = new System.Drawing.Size(190, 21);
            this.cmbAddRole.TabIndex = 3;
            // 
            // BtnAddUser
            // 
            this.BtnAddUser.Location = new System.Drawing.Point(133, 263);
            this.BtnAddUser.Name = "BtnAddUser";
            this.BtnAddUser.Size = new System.Drawing.Size(75, 23);
            this.BtnAddUser.TabIndex = 2;
            this.BtnAddUser.Text = "Add";
            this.BtnAddUser.UseVisualStyleBackColor = true;
            this.BtnAddUser.Click += new System.EventHandler(this.BtnAddUser_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Choose a Role";
            // 
            // txtAddPassword
            // 
            this.txtAddPassword.Location = new System.Drawing.Point(18, 181);
            this.txtAddPassword.Name = "txtAddPassword";
            this.txtAddPassword.Size = new System.Drawing.Size(190, 20);
            this.txtAddPassword.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Password:";
            // 
            // txtAddUsername
            // 
            this.txtAddUsername.Location = new System.Drawing.Point(18, 134);
            this.txtAddUsername.Name = "txtAddUsername";
            this.txtAddUsername.Size = new System.Drawing.Size(190, 20);
            this.txtAddUsername.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "User Name:";
            // 
            // txtAddLastname
            // 
            this.txtAddLastname.Location = new System.Drawing.Point(18, 86);
            this.txtAddLastname.Name = "txtAddLastname";
            this.txtAddLastname.Size = new System.Drawing.Size(190, 20);
            this.txtAddLastname.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Last Name:";
            // 
            // txtAddFirstname
            // 
            this.txtAddFirstname.Location = new System.Drawing.Point(18, 41);
            this.txtAddFirstname.Name = "txtAddFirstname";
            this.txtAddFirstname.Size = new System.Drawing.Size(190, 20);
            this.txtAddFirstname.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(12, 356);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1173, 239);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "List of Users";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1163, 214);
            this.dataGridView1.TabIndex = 0;
            // 
            // grpUpdateUser
            // 
            this.grpUpdateUser.Controls.Add(this.btnUpdate);
            this.grpUpdateUser.Controls.Add(this.txtFindbyId);
            this.grpUpdateUser.Controls.Add(this.btnFindById);
            this.grpUpdateUser.Controls.Add(this.label11);
            this.grpUpdateUser.Controls.Add(this.cmbUpdateRole);
            this.grpUpdateUser.Controls.Add(this.label6);
            this.grpUpdateUser.Controls.Add(this.txtUpdatePassword);
            this.grpUpdateUser.Controls.Add(this.label7);
            this.grpUpdateUser.Controls.Add(this.txtUpdateUsername);
            this.grpUpdateUser.Controls.Add(this.label8);
            this.grpUpdateUser.Controls.Add(this.txtUpdateLastname);
            this.grpUpdateUser.Controls.Add(this.label9);
            this.grpUpdateUser.Controls.Add(this.txtUpdateFirstname);
            this.grpUpdateUser.Controls.Add(this.label10);
            this.grpUpdateUser.Location = new System.Drawing.Point(278, 22);
            this.grpUpdateUser.Name = "grpUpdateUser";
            this.grpUpdateUser.Size = new System.Drawing.Size(224, 344);
            this.grpUpdateUser.TabIndex = 0;
            this.grpUpdateUser.TabStop = false;
            this.grpUpdateUser.Text = "Update User";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(134, 305);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtFindbyId
            // 
            this.txtFindbyId.Location = new System.Drawing.Point(18, 39);
            this.txtFindbyId.Name = "txtFindbyId";
            this.txtFindbyId.Size = new System.Drawing.Size(119, 20);
            this.txtFindbyId.TabIndex = 5;
            // 
            // btnFindById
            // 
            this.btnFindById.Location = new System.Drawing.Point(143, 39);
            this.btnFindById.Name = "btnFindById";
            this.btnFindById.Size = new System.Drawing.Size(75, 23);
            this.btnFindById.TabIndex = 4;
            this.btnFindById.Text = "Find";
            this.btnFindById.UseVisualStyleBackColor = true;
            this.btnFindById.Click += new System.EventHandler(this.btnFindById_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Find by Id:";
            // 
            // cmbUpdateRole
            // 
            this.cmbUpdateRole.FormattingEnabled = true;
            this.cmbUpdateRole.Location = new System.Drawing.Point(19, 273);
            this.cmbUpdateRole.Name = "cmbUpdateRole";
            this.cmbUpdateRole.Size = new System.Drawing.Size(190, 21);
            this.cmbUpdateRole.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Choose a Role";
            // 
            // txtUpdatePassword
            // 
            this.txtUpdatePassword.Location = new System.Drawing.Point(19, 226);
            this.txtUpdatePassword.Name = "txtUpdatePassword";
            this.txtUpdatePassword.Size = new System.Drawing.Size(190, 20);
            this.txtUpdatePassword.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 210);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Password:";
            // 
            // txtUpdateUsername
            // 
            this.txtUpdateUsername.Location = new System.Drawing.Point(19, 179);
            this.txtUpdateUsername.Name = "txtUpdateUsername";
            this.txtUpdateUsername.Size = new System.Drawing.Size(190, 20);
            this.txtUpdateUsername.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 163);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "User Name:";
            // 
            // txtUpdateLastname
            // 
            this.txtUpdateLastname.Location = new System.Drawing.Point(19, 131);
            this.txtUpdateLastname.Name = "txtUpdateLastname";
            this.txtUpdateLastname.Size = new System.Drawing.Size(190, 20);
            this.txtUpdateLastname.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 115);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Last Name:";
            // 
            // txtUpdateFirstname
            // 
            this.txtUpdateFirstname.Location = new System.Drawing.Point(19, 86);
            this.txtUpdateFirstname.Name = "txtUpdateFirstname";
            this.txtUpdateFirstname.Size = new System.Drawing.Size(190, 20);
            this.txtUpdateFirstname.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 70);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "First Name:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.cmbFindByRole);
            this.groupBox1.Location = new System.Drawing.Point(508, 143);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 104);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Find by Role";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 21);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Choose a Role:";
            // 
            // cmbFindByRole
            // 
            this.cmbFindByRole.FormattingEnabled = true;
            this.cmbFindByRole.Location = new System.Drawing.Point(6, 44);
            this.cmbFindByRole.Name = "cmbFindByRole";
            this.cmbFindByRole.Size = new System.Drawing.Size(242, 21);
            this.cmbFindByRole.TabIndex = 3;
            this.cmbFindByRole.SelectedIndexChanged += new System.EventHandler(this.cmbFindByRole_SelectedIndexChanged);
            // 
            // grpDelete
            // 
            this.grpDelete.Controls.Add(this.BtnDeleteUser);
            this.grpDelete.Controls.Add(this.txtDeleteID);
            this.grpDelete.Controls.Add(this.label13);
            this.grpDelete.Location = new System.Drawing.Point(514, 28);
            this.grpDelete.Name = "grpDelete";
            this.grpDelete.Size = new System.Drawing.Size(258, 109);
            this.grpDelete.TabIndex = 3;
            this.grpDelete.TabStop = false;
            this.grpDelete.Text = "Delete User";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 31);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "Find by Id:";
            // 
            // txtDeleteID
            // 
            this.txtDeleteID.Location = new System.Drawing.Point(5, 54);
            this.txtDeleteID.Name = "txtDeleteID";
            this.txtDeleteID.Size = new System.Drawing.Size(138, 20);
            this.txtDeleteID.TabIndex = 5;
            // 
            // BtnDeleteUser
            // 
            this.BtnDeleteUser.Location = new System.Drawing.Point(149, 51);
            this.BtnDeleteUser.Name = "BtnDeleteUser";
            this.BtnDeleteUser.Size = new System.Drawing.Size(103, 23);
            this.BtnDeleteUser.TabIndex = 6;
            this.BtnDeleteUser.Text = "Delete";
            this.BtnDeleteUser.UseVisualStyleBackColor = true;
            this.BtnDeleteUser.Click += new System.EventHandler(this.BtnDeleteUser_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnGetAllUser);
            this.groupBox3.Location = new System.Drawing.Point(785, 31);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(193, 106);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Get All User";
            // 
            // btnGetAllUser
            // 
            this.btnGetAllUser.Location = new System.Drawing.Point(23, 26);
            this.btnGetAllUser.Name = "btnGetAllUser";
            this.btnGetAllUser.Size = new System.Drawing.Size(136, 66);
            this.btnGetAllUser.TabIndex = 0;
            this.btnGetAllUser.Text = "GetAll";
            this.btnGetAllUser.UseVisualStyleBackColor = true;
            this.btnGetAllUser.Click += new System.EventHandler(this.btnGetAllUser_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(11, 31);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.dateTimePicker2);
            this.groupBox4.Controls.Add(this.dateTimePicker1);
            this.groupBox4.Location = new System.Drawing.Point(508, 248);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(264, 105);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "groupBox4";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(11, 78);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 5;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(9, 62);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 13);
            this.label14.TabIndex = 6;
            this.label14.Text = "End Date:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(8, 16);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(58, 13);
            this.label15.TabIndex = 7;
            this.label15.Text = "Start Date:";
            // 
            // AdminAppUserPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 609);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.grpDelete);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grpUpdateUser);
            this.Controls.Add(this.grpAddUser);
            this.Name = "AdminAppUserPage";
            this.Text = "AdminAppUserPage";
            this.Load += new System.EventHandler(this.AdminAppUserPage_Load);
            this.grpAddUser.ResumeLayout(false);
            this.grpAddUser.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grpUpdateUser.ResumeLayout(false);
            this.grpUpdateUser.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpDelete.ResumeLayout(false);
            this.grpDelete.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAddUser;
        private System.Windows.Forms.ComboBox cmbAddRole;
        private System.Windows.Forms.Button BtnAddUser;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAddPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAddUsername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAddLastname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAddFirstname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox grpUpdateUser;
        private System.Windows.Forms.TextBox txtFindbyId;
        private System.Windows.Forms.Button btnFindById;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbUpdateRole;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtUpdatePassword;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtUpdateUsername;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtUpdateLastname;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtUpdateFirstname;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbFindByRole;
        private System.Windows.Forms.GroupBox grpDelete;
        private System.Windows.Forms.Button BtnDeleteUser;
        private System.Windows.Forms.TextBox txtDeleteID;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnGetAllUser;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
    }
}