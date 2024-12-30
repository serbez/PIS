namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtPas = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtLogin
            // 
            this.txtTel.Location = new System.Drawing.Point(100, 100);
            this.txtTel.Name = "txtLogin";
            this.txtTel.Size = new System.Drawing.Size(200, 23);
            this.txtTel.TabIndex = 0;
            this.txtTel.PlaceholderText = "Телефон"; // Для .NET 6 и выше
            // 
            // txtPhone
            // 
            this.txtPas.Location = new System.Drawing.Point(100, 150);
            this.txtPas.Name = "txtPhone";
            this.txtPas.Size = new System.Drawing.Size(200, 23);
            this.txtPas.TabIndex = 1;
            this.txtPas.PlaceholderText = "Пароль"; // Для .NET 6 и выше
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(100, 200);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(200, 30);
            this.btnRegister.TabIndex = 2;
            this.btnRegister.Text = "Регистрация";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);

            this.btnLogin = new System.Windows.Forms.Button();
            this.btnLogin.Location = new System.Drawing.Point(100, 250);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(200, 30);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Авторизация";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPas);
            this.Controls.Add(this.txtTel);
            this.Name = "Form1";
            this.Text = "Регистрация";
            this.ResumeLayout(false);
            this.PerformLayout();


           

        }

        #endregion
    }
}
