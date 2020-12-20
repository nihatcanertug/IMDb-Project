
namespace IMDb_Project.UI.Admin
{
    partial class AdminGenrePage
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
            this.grpAdd = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtAddName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.grpUpdate = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFindId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUpdateName = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnFindbyId = new System.Windows.Forms.Button();
            this.grpDelete = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDeleteById = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.grpFindByName = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnGetAll = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFindByName = new System.Windows.Forms.TextBox();
            this.btnFindByName = new System.Windows.Forms.Button();
            this.grpAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grpUpdate.SuspendLayout();
            this.grpDelete.SuspendLayout();
            this.grpFindByName.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpAdd
            // 
            this.grpAdd.Controls.Add(this.btnAdd);
            this.grpAdd.Controls.Add(this.txtAddName);
            this.grpAdd.Controls.Add(this.label1);
            this.grpAdd.Location = new System.Drawing.Point(12, 12);
            this.grpAdd.Name = "grpAdd";
            this.grpAdd.Size = new System.Drawing.Size(211, 229);
            this.grpAdd.TabIndex = 0;
            this.grpAdd.TabStop = false;
            this.grpAdd.Text = "Add Genre";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(122, 102);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtAddName
            // 
            this.txtAddName.Location = new System.Drawing.Point(12, 53);
            this.txtAddName.Name = "txtAddName";
            this.txtAddName.Size = new System.Drawing.Size(189, 20);
            this.txtAddName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Genre name :";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(18, 247);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1020, 272);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "List of Genres";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 263);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1006, 256);
            this.dataGridView1.TabIndex = 0;
            // 
            // grpUpdate
            // 
            this.grpUpdate.Controls.Add(this.btnFindbyId);
            this.grpUpdate.Controls.Add(this.btnUpdate);
            this.grpUpdate.Controls.Add(this.txtUpdateName);
            this.grpUpdate.Controls.Add(this.label3);
            this.grpUpdate.Controls.Add(this.txtFindId);
            this.grpUpdate.Controls.Add(this.label2);
            this.grpUpdate.Location = new System.Drawing.Point(229, 12);
            this.grpUpdate.Name = "grpUpdate";
            this.grpUpdate.Size = new System.Drawing.Size(239, 229);
            this.grpUpdate.TabIndex = 2;
            this.grpUpdate.TabStop = false;
            this.grpUpdate.Text = "Update Genre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Id:";
            // 
            // txtFindId
            // 
            this.txtFindId.Location = new System.Drawing.Point(33, 28);
            this.txtFindId.Name = "txtFindId";
            this.txtFindId.Size = new System.Drawing.Size(112, 20);
            this.txtFindId.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Genre name :";
            // 
            // txtUpdateName
            // 
            this.txtUpdateName.Location = new System.Drawing.Point(33, 93);
            this.txtUpdateName.Name = "txtUpdateName";
            this.txtUpdateName.Size = new System.Drawing.Size(187, 20);
            this.txtUpdateName.TabIndex = 1;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(145, 119);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnFindbyId
            // 
            this.btnFindbyId.Location = new System.Drawing.Point(151, 26);
            this.btnFindbyId.Name = "btnFindbyId";
            this.btnFindbyId.Size = new System.Drawing.Size(69, 23);
            this.btnFindbyId.TabIndex = 3;
            this.btnFindbyId.Text = "Find";
            this.btnFindbyId.UseVisualStyleBackColor = true;
            this.btnFindbyId.Click += new System.EventHandler(this.btnFindbyId_Click);
            // 
            // grpDelete
            // 
            this.grpDelete.Controls.Add(this.btnDelete);
            this.grpDelete.Controls.Add(this.txtDeleteById);
            this.grpDelete.Controls.Add(this.label4);
            this.grpDelete.Location = new System.Drawing.Point(474, 12);
            this.grpDelete.Name = "grpDelete";
            this.grpDelete.Size = new System.Drawing.Size(247, 101);
            this.grpDelete.TabIndex = 3;
            this.grpDelete.TabStop = false;
            this.grpDelete.Text = "Delete Genre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Please Type Into Id Info :";
            // 
            // txtDeleteById
            // 
            this.txtDeleteById.Location = new System.Drawing.Point(9, 58);
            this.txtDeleteById.Name = "txtDeleteById";
            this.txtDeleteById.Size = new System.Drawing.Size(150, 20);
            this.txtDeleteById.TabIndex = 5;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(165, 56);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // grpFindByName
            // 
            this.grpFindByName.Controls.Add(this.btnFindByName);
            this.grpFindByName.Controls.Add(this.txtFindByName);
            this.grpFindByName.Controls.Add(this.label5);
            this.grpFindByName.Location = new System.Drawing.Point(474, 119);
            this.grpFindByName.Name = "grpFindByName";
            this.grpFindByName.Size = new System.Drawing.Size(469, 122);
            this.grpFindByName.TabIndex = 4;
            this.grpFindByName.TabStop = false;
            this.grpFindByName.Text = "Find By Name";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnGetAll);
            this.groupBox3.Location = new System.Drawing.Point(743, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 100);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "List of All Genre";
            // 
            // btnGetAll
            // 
            this.btnGetAll.Location = new System.Drawing.Point(26, 25);
            this.btnGetAll.Name = "btnGetAll";
            this.btnGetAll.Size = new System.Drawing.Size(126, 56);
            this.btnGetAll.TabIndex = 0;
            this.btnGetAll.Text = "All Genre";
            this.btnGetAll.UseVisualStyleBackColor = true;
            this.btnGetAll.Click += new System.EventHandler(this.btnGetAll_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Genre name :";
            // 
            // txtFindByName
            // 
            this.txtFindByName.Location = new System.Drawing.Point(9, 43);
            this.txtFindByName.Name = "txtFindByName";
            this.txtFindByName.Size = new System.Drawing.Size(238, 20);
            this.txtFindByName.TabIndex = 1;
            // 
            // btnFindByName
            // 
            this.btnFindByName.Location = new System.Drawing.Point(269, 40);
            this.btnFindByName.Name = "btnFindByName";
            this.btnFindByName.Size = new System.Drawing.Size(129, 23);
            this.btnFindByName.TabIndex = 2;
            this.btnFindByName.Text = "Find By Name";
            this.btnFindByName.UseVisualStyleBackColor = true;
            this.btnFindByName.Click += new System.EventHandler(this.btnFindByName_Click);
            // 
            // AdminGenrePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 531);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.grpFindByName);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.grpDelete);
            this.Controls.Add(this.grpUpdate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpAdd);
            this.Name = "AdminGenrePage";
            this.Text = "AdminGenrePage";
            this.Load += new System.EventHandler(this.AdminGenrePage_Load);
            this.grpAdd.ResumeLayout(false);
            this.grpAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grpUpdate.ResumeLayout(false);
            this.grpUpdate.PerformLayout();
            this.grpDelete.ResumeLayout(false);
            this.grpDelete.PerformLayout();
            this.grpFindByName.ResumeLayout(false);
            this.grpFindByName.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAdd;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtAddName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox grpUpdate;
        private System.Windows.Forms.Button btnFindbyId;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtUpdateName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFindId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpDelete;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtDeleteById;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grpFindByName;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnGetAll;
        private System.Windows.Forms.Button btnFindByName;
        private System.Windows.Forms.TextBox txtFindByName;
        private System.Windows.Forms.Label label5;
    }
}