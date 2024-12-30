using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WinFormsApp1.Model;

namespace WinFormsApp1
{
    public partial class PoliceForm : Form
    {
        private DataGridView dataGridView;
        private Button buttonCancel;
        private BidController bidController;

        public PoliceForm()
        {
            InitializeComponent();
            this.dataGridView = new DataGridView();
            this.bidController = new BidController(); 
            this.SuspendLayout();

            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 12);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(760, 400);
            this.dataGridView.TabIndex = 0;

            this.dataGridView.CellClick += new DataGridViewCellEventHandler(this.DataGridView_CellClick);

            // 
            // buttonCancel
            // 
            this.buttonCancel = new Button();
            this.buttonCancel.Location = new System.Drawing.Point(12, 420);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(100, 30);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new EventHandler(this.ButtonCancel_Click);

            // 
            // PoliceForm
            // 
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.dataGridView); 
            this.Controls.Add(this.buttonCancel); 
            this.Name = "PoliceForm";
            this.Text = "Police Data";
            this.ResumeLayout(false);
            InitializeDataGridView(); 
            LoadBids(); 
        }

        private void InitializeDataGridView()
        {
            dataGridView.Columns.Add("Id", "ID");
            dataGridView.Columns.Add("Phone", "Phone");
            dataGridView.Columns.Add("Reason", "Reason");
            dataGridView.Columns.Add("Status", "Status");
        }

        private void LoadBids()
        {
            List<Bid> bids = bidController.GetBidsFromService();

            foreach (var bid in bids)
            {
                dataGridView.Rows.Add(bid.Id, bid.Phone, bid.Reason, bid.Status); 
            }
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {
                var reason = dataGridView.Rows[e.RowIndex].Cells["Reason"].Value.ToString(); 
                var bidId = dataGridView.Rows[e.RowIndex].Cells["Id"].Value.ToString(); 

                PoliceEdit policeEdit = new PoliceEdit(reason, bidId);
                policeEdit.ShowDialog();
            }
        }
    }
}