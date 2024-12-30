using System;
using System.Linq;
using System.Windows.Forms;
using WinFormsApp1.Model;

namespace WinFormsApp1
{
    public partial class UserForm : Form
    {
        private DataGridView dataGridView;
        private BidController _bidController;
        private Button btnCreateBid;
        private Button btnGetECard;
        private string phone; 

        public UserForm(string phone)
        {
            InitializeComponent();
            this.phone = phone; 
            this.SuspendLayout();
            InitializeDataGridView();
            LoadData(phone); 

            btnCreateBid = new Button
            {
                Location = new System.Drawing.Point(10, 260), 
                Size = new System.Drawing.Size(100, 30),
                Text = "Создать заявку",
                UseVisualStyleBackColor = true
            };

            btnCreateBid.Click += new EventHandler(this.BtnCreateBid_Click); 

            this.Controls.Add(btnCreateBid); 

            btnGetECard = new Button
            {
                Location = new System.Drawing.Point(120, 260),
                Size = new System.Drawing.Size(120, 30),
                Text = "Получить ECard",
                UseVisualStyleBackColor = true
            };

            btnGetECard.Click += new EventHandler(this.BtnGetECard_Click); 

            this.Controls.Add(btnGetECard); 

            // 
            // UserForm
            // 
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Name = "UserForm";
            this.Text = "Пользовательская форма";
            this.ResumeLayout(false);

            dataGridView.CellClick += new DataGridViewCellEventHandler(DataGridView_CellClick);
        }

        private void InitializeDataGridView()
        {
            dataGridView = new DataGridView
            {
                Location = new System.Drawing.Point(10, 10),
                Size = new System.Drawing.Size(360, 240),
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            };

            dataGridView.Columns.Add("Id", "ID");
            dataGridView.Columns.Add("Phone", "Телефон");
            dataGridView.Columns.Add("Reason", "Причина");
            dataGridView.Columns.Add("Status", "Статус");

            this.Controls.Add(dataGridView);
        }

        private void LoadData(string phone)
        {
            _bidController = new BidController();
            var bids = _bidController.GetBidsFromService1();

            var filteredBids = bids.Where(bid => bid.Phone == phone).ToList(); 

            foreach (var bid in filteredBids)
            {
                dataGridView.Rows.Add(bid.Id, bid.Phone, bid.Reason, bid.Status.ToString());
            }
        }

        private void BtnCreateBid_Click(object sender, EventArgs e)
        {
            CreateBidForm createBidForm = new CreateBidForm(phone); 
            createBidForm.ShowDialog(); 
        }

        private void BtnGetECard_Click(object sender, EventArgs e)
        {
            ECard eCardForm = new ECard(phone); 
            eCardForm.ShowDialog(); 
        }

        private void DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 0)
            {
                var result = MessageBox.Show(
                    "Удалить заявку?",
                    "Подтверждение",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    // Получаем ID выбранной заявки
                    string bidId = dataGridView.Rows[e.RowIndex].Cells["Id"].Value.ToString();
                    _bidController.DeleteBid(bidId);
                    dataGridView.Rows.RemoveAt(e.RowIndex); 
                }
            }
        }
    }
}