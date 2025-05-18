using System;
using System.Windows.Forms;
using System.Data.SQLite;

namespace LoginEjemplo  
{
    public class LoginForm : Form
    {
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnLogin;

        public LoginForm()
        {
            InitializeComponent();
            DB.InitializeDatabase(); //inicia DB
        }

        private void InitializeComponent()
        {
            this.Text = "Sistema de Login";
            this.Width = 350;
            this.Height = 250;

            Label lblUser = new Label();
            lblUser.Text = "Usuario:";
            lblUser.Location = new System.Drawing.Point(50, 50);
            this.Controls.Add(lblUser);

            txtUsername = new TextBox();
            txtUsername.Location = new System.Drawing.Point(150, 50);
            this.Controls.Add(txtUsername);

            Label lblPass = new Label();
            lblPass.Text = "Contraseña:";
            lblPass.Location = new System.Drawing.Point(50, 80);
            this.Controls.Add(lblPass);

            txtPassword = new TextBox();
            txtPassword.PasswordChar = '*';
            txtPassword.Location = new System.Drawing.Point(150, 80);
            this.Controls.Add(txtPassword);

            btnLogin = new Button();
            btnLogin.Text = "Iniciar Sesión";
            btnLogin.Location = new System.Drawing.Point(150, 120);
            btnLogin.Click += BtnLogin_Click;
            this.Controls.Add(btnLogin);
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (username == "admin" && password == "admin123")
            {
                MessageBox.Show("¡Bienvenido, Administrador!");
                AdminForm adminForm = new AdminForm();
                adminForm.Show();
                this.Hide();
            }
            else if (username == "socio" && password == "socio123")
            {
                MessageBox.Show("¡Bienvenido, Socio!");
                SocioForm socioForm = new SocioForm();
                socioForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Credenciales incorrectas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.Run(new LoginForm());
        }
    }
}
