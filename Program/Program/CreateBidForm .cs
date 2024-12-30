using System;
using System.Windows.Forms;
using WinFormsApp1.Model; 

namespace WinFormsApp1
{
    public partial class CreateBidForm : Form
    {
        private string _phone;

        public CreateBidForm(string phone) 
        {
            InitializeComponent();
            _phone = phone;
        

            this.txtReason = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // 
            // txtReason
            // 
            this.txtReason.Location = new System.Drawing.Point(15, 40);
            this.txtReason.Multiline = true;
            this.txtReason.Name = "txtReason";
            this.txtReason.Size = new System.Drawing.Size(260, 100);
            this.txtReason.TabIndex = 0;

            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(15, 150);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(260, 30);
            this.btnSubmit.TabIndex = 1;
            this.btnSubmit.Text = "Отправить заявку";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);

            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Причина заявки:";

            // 
            // CreateBidForm
            // 
            this.ClientSize = new System.Drawing.Size(290, 200);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtReason);
            this.Name = "CreateBidForm";
            this.Text = "Создание заявки";
            this.ResumeLayout(false);
            this.PerformLayout();
             }
        

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            string reason = txtReason.Text.Trim(); 

            if (string.IsNullOrEmpty(reason))
            {
                MessageBox.Show("Пожалуйста, укажите причину заявки.");
                return; 
            }

            BidService bidService = new BidService();
            string newId = bidService.GetNextId();

            Bid newBid = new Bid
            {
                Id = newId,
                Phone = _phone,
                Reason = reason,
                Status = BidStatus.InProcess 
            };

            bidService.AddBidToRepository(newBid); 


            MessageBox.Show("Заявка создана: " + reason);
            this.Close();
        }

        private System.Windows.Forms.TextBox txtReason; 
        private System.Windows.Forms.Button btnSubmit; 
        private System.Windows.Forms.Label label1; 
    }
}