using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class ECard : Form
    {
        private DataGridView dataGridView;
        private Button cancelButton; 
        private Button saveButton; 
        private BidController _bidController;
        private Dictionary<string, string[]> usersData; 

        private string phone;

        public ECard(string phone)
        {
            InitializeComponent();
            this.phone = phone;
            this.SuspendLayout();
            InitializeDataGridView();
            InitializeCancelButton(); 
            InitializeSaveButton(); 
            LoadData(phone);
            LoadUsersData(); 

            // 
            // UserForm
            // 
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Name = "ECard";
            this.Text = "Ваши ECard";
            this.ResumeLayout(false);
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

            dataGridView.CellClick += DataGridView_CellClick;

            this.Controls.Add(dataGridView);
        }

        private void InitializeCancelButton()
        {
            cancelButton = new Button
            {
                Text = "Отмена",
                Location = new System.Drawing.Point(10, 260), 
                Size = new System.Drawing.Size(100, 30) 
            };

            cancelButton.Click += CancelButton_Click; 

            this.Controls.Add(cancelButton);
        }

        private void InitializeSaveButton()
        {
            saveButton = new Button
            {
                Text = "Сохранить",
                Location = new System.Drawing.Point(120, 260),
                Size = new System.Drawing.Size(100, 30) 
            };

            saveButton.Click += SaveButton_Click; 

            this.Controls.Add(saveButton);
        }

        private void LoadData(string phone)
        {
            _bidController = new BidController();
            var bids = _bidController.GetBidsFromService1();

            var filteredBids = bids
                .Where(bid => bid.Phone == phone && bid.Status.ToString() == "Given")
                .ToList();

            foreach (var bid in filteredBids)
            {
                dataGridView.Rows.Add(bid.Id, bid.Phone);
            }
        }

        private void LoadUsersData()
        {
            usersData = new Dictionary<string, string[]>();


            var filePath = "users.csv"; 

            if (!File.Exists(filePath))
            {
                MessageBox.Show($"Файл не найден: {filePath}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var lines = File.ReadAllLines(filePath);
            foreach (var line in lines)
            {
                var parts = line.Split(',');
                if (parts.Length > 0)
                {
                    usersData[parts[0]] = parts; 
                }
            }
        }


        private void DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dataGridView.Rows[e.RowIndex];
                string message = $"ID: {row.Cells["Id"].Value}\n" +
                                 $"Телефон: {row.Cells["Phone"].Value}";

                string phoneNumber = row.Cells["Phone"].Value.ToString();
                if (usersData.TryGetValue(phoneNumber, out string[] userInfo))
                {
                    string gender = userInfo[7].ToLower() == "true" ? "м" : "ж"; 

                    message += $"\n\nДанные пользователя:\n" +
                               $"Имя: {userInfo[2]} {userInfo[3]} {userInfo[4]}\n" +
                               $"Возраст: {userInfo[5]}\n" +
                               $"Национальность: {userInfo[6]}\n" +
                               $"Пол: {gender}\n" + 
                               $"Город: {userInfo[8]}\n" +
                               $"Адрес: {userInfo[10]}\n" +
                               $"Дата рождения: {userInfo[11]}";
                }
                else
                {
                    message += "\n\nДанные пользователя не найдены.";
                }

                MessageBox.Show(message, "Данные ECard", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string filePath = "ECard.csv";
            var dataRows = dataGridView.Rows
                .Cast<DataGridViewRow>()
                .Where(row => !row.IsNewRow)
                .Select(row => new DataRow
                {
                    Id = row.Cells["Id"].Value.ToString(),
                    Phone = row.Cells["Phone"].Value.ToString()
                })
                .ToList();

            var controller = new ECardController(filePath);
            controller.GetECardService(dataRows, usersData);

            MessageBox.Show("Данные успешно сохранены в файл.", "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}