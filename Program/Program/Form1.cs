namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public AuthController _authController;
        public Form1()
        {
            InitializeComponent();
            _authController = new AuthController(new AuthService());
        }
        private TextBox txtTel;
        private TextBox txtPas;
        private Button btnRegister;
        private Button btnLogin;
        private void btnRegister_Click(object sender, EventArgs e)
        {
            IDCardForm idCardForm = new IDCardForm();
            idCardForm.Show();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string phone = txtTel.Text;
            string pass = txtPas.Text;

            string message = _authController.LoginService(phone, pass);
            if (message == "Успешная авторизация")
            {
                new UserRoleForm(phone).Show();
            }
            else
            {
                MessageBox.Show(message);
            }
        }

    }
}
