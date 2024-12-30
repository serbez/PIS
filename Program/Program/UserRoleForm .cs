using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class UserRoleForm : Form
    {
        public UserRoleForm(string phone) 
        {
            InitializeComponent();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnPolice = new System.Windows.Forms.Button();
            this.btnUser = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();


            this.Phone = phone;

            this.btnAdmin.Click += new EventHandler(this.btnAdmin_Click);
            this.btnPolice.Click += new EventHandler(this.btnPolice_Click);
            this.btnUser.Click += new EventHandler(this.btnUser_Click);
            this.buttonCancel.Click += new EventHandler(this.ButtonCancel_Click);

            this.SuspendLayout();

            // 
            // btnAdmin
            // 
            this.btnAdmin.Location = new System.Drawing.Point(50, 50);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(200, 30);
            this.btnAdmin.TabIndex = 0;
            this.btnAdmin.Text = "Администрация";
            this.btnAdmin.UseVisualStyleBackColor = true;

            // 
            // btnPolice
            // 
            this.btnPolice.Location = new System.Drawing.Point(50, 100);
            this.btnPolice.Name = "btnPolice";
            this.btnPolice.Size = new System.Drawing.Size(200, 30);
            this.btnPolice.TabIndex = 1;
            this.btnPolice.Text = "Полиция";
            this.btnPolice.UseVisualStyleBackColor = true;

            // 
            // btnUser
            // 
            this.btnUser.Location = new System.Drawing.Point(50, 150);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(200, 30);
            this.btnUser.TabIndex = 2;
            this.btnUser.Text = "Пользователь";
            this.btnUser.UseVisualStyleBackColor = true;

            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(50, 200);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(200, 30);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;

            // 
            // UserRoleForm
            // 
            this.ClientSize = new System.Drawing.Size(300, 250);
            this.Controls.Add(this.btnUser);
            this.Controls.Add(this.btnPolice);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.buttonCancel);
            this.Name = "UserRoleForm";
            this.Text = "Выберите роль";
            this.ResumeLayout(false);
        }

        private Button btnAdmin;
        private Button btnPolice;
        private Button btnUser;
        private Button buttonCancel;

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            AdminForm mainForm = new AdminForm();
            mainForm.Show();
        }

        private void btnPolice_Click(object sender, EventArgs e)
        {
            PoliceForm policeForm = new PoliceForm();
            policeForm.Show();
        }


        private string Phone;

        private void btnUser_Click(object sender, EventArgs e)
        {
            UserForm userForm = new UserForm(Phone); 
            userForm.Show();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}