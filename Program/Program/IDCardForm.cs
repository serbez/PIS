using System;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace WinFormsApp1
{
    public partial class IDCardForm : Form
    {
        public AuthController _authController;
        private TextBox txtName, txtSurname, txtLastName, txtPassword, txtPhoneNumber,
            txtDocumentNumber, txtNationality, txtSex, txtPlaceOfBirth, txtCodeOfState,
            txtIssuingAuthority, txtPlaceOfResidence, txtDateOfBirth, txtDateOfIssue,
            txtDateOfExpiry, txtCountry, txtDocumentType;

        public IDCardForm()
        {
            InitializeComponent();
            _authController = new AuthController(new AuthService());
            InitializeIDCardForm();
        }

        private void InitializeIDCardForm()
        {
            this.Text = "Форма ID Карты";

            CreateLabelAndTextBox("Имя:", 20, 20, out txtName);
            CreateLabelAndTextBox("Фамилия:", 20, 60, out txtSurname);
            CreateLabelAndTextBox("Отчество:", 20, 100, out txtLastName);
            CreateLabelAndTextBox("Пароль:", 20, 140, out txtPassword);
            CreateLabelAndTextBox("Номер телефона:", 20, 180, out txtPhoneNumber);
            CreateLabelAndTextBox("Номер документа:", 20, 220, out txtDocumentNumber);
            CreateLabelAndTextBox("Национальность:", 20, 260, out txtNationality);
            CreateLabelAndTextBox("Пол (м/ж):", 20, 300, out txtSex);
            CreateLabelAndTextBox("Место рождения:", 20, 340, out txtPlaceOfBirth);
            CreateLabelAndTextBox("Код государства:", 20, 380, out txtCodeOfState);
            CreateLabelAndTextBox("Выдающий орган:", 20, 420, out txtIssuingAuthority);
            CreateLabelAndTextBox("Место жительства:", 20, 460, out txtPlaceOfResidence);
            CreateLabelAndTextBox("Дата рождения:", 20, 500, out txtDateOfBirth);
            CreateLabelAndTextBox("Дата выдачи:", 20, 540, out txtDateOfIssue);
            CreateLabelAndTextBox("Дата окончания:", 20, 580, out txtDateOfExpiry);
            CreateLabelAndTextBox("Страна:", 20, 620, out txtCountry);
            CreateLabelAndTextBox("Тип документа:", 20, 660, out txtDocumentType);

            Button btnSubmit = new Button
            {
                Text = "Сохранить",
                Location = new System.Drawing.Point(20, 700)
            };
            btnSubmit.Click += btnSubmit_Click;

            Button btnCancel = new Button
            {
                Text = "Отмена",
                Location = new System.Drawing.Point(120, 700)
            };
            btnCancel.Click += (s, e) => this.Close();

            this.Controls.Add(txtDocumentNumber);
            this.Controls.Add(txtNationality);
            this.Controls.Add(txtSex);
            this.Controls.Add(txtPlaceOfBirth);
            this.Controls.Add(txtCodeOfState);
            this.Controls.Add(txtIssuingAuthority);
            this.Controls.Add(txtPlaceOfResidence);
            this.Controls.Add(txtDateOfBirth);
            this.Controls.Add(txtDateOfIssue);
            this.Controls.Add(txtDateOfExpiry);
            this.Controls.Add(txtCountry);
            this.Controls.Add(txtDocumentType);
            this.Controls.Add(txtName);
            this.Controls.Add(txtSurname);
            this.Controls.Add(txtLastName);
            this.Controls.Add(txtPhoneNumber);
            this.Controls.Add(txtPassword);
            this.Controls.Add(btnSubmit);
            this.Controls.Add(btnCancel);
        }

        private void CreateLabelAndTextBox(string labelText, int x, int y, out TextBox textBox)
        {
            Label label = new Label
            {
                Text = labelText,
                Location = new System.Drawing.Point(x, y),
                AutoSize = true
            };

            textBox = new TextBox
            {
                Location = new System.Drawing.Point(x + 150, y),
                Width = 200
            };

            this.Controls.Add(label);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string phone = txtPhoneNumber.Text;
            string pass = txtPassword.Text;
            string name = txtName.Text;
            string surname = txtSurname.Text;
            string lastName = txtLastName.Text;
            string documentNumber = txtDocumentNumber.Text;
            string nationality = txtNationality.Text;
            bool sex = txtSex.Text == "м";
            string placeOfBirth = txtPlaceOfBirth.Text;
            string codeOfState = txtCodeOfState.Text;
            string issuingAuthority = txtIssuingAuthority.Text;
            string placeOfResidence = txtPlaceOfResidence.Text;
            DateTime dateOfBirth = DateTime.Parse(txtDateOfBirth.Text);
            DateTime dateOfIssue = DateTime.Parse(txtDateOfIssue.Text);
            DateTime dateOfExpiry = DateTime.Parse(txtDateOfExpiry.Text);
            string country = txtCountry.Text;
            string documentType = txtDocumentType.Text;

            string message = _authController.CheckUserService(name, surname, lastName, pass, phone, documentNumber, nationality, sex, placeOfBirth, codeOfState, issuingAuthority, placeOfResidence, dateOfBirth, dateOfIssue, dateOfExpiry, country, documentType);
            if (message == "Данные успешно сохранены") 
            {
                MessageBox.Show("Данные успешно сохранены!");
                this.Close(); 
            }
            else
            {
                MessageBox.Show(message); 
            }
        }
    }
}