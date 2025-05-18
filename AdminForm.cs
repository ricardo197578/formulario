using System;
using System.Windows.Forms;
using System.Drawing;

namespace LoginEjemplo
{

public class AdminForm : Form
{
    private Button btnLogin; // Declaración del botón

    public AdminForm()
    {
        this.Text = "Administrador";
        this.Width = 400;
        this.Height = 300;

        Label lblWelcome = new Label();
        lblWelcome.Text = "Bienvenido, ADMINISTRADOR";
        lblWelcome.Font = new Font("Arial", 12,FontStyle.Bold);
	lblWelcome.AutoSize = true; // Esta es la clave,jaja.
        lblWelcome.Location = new Point(50, 50);
        this.Controls.Add(lblWelcome);
	
        // Botón de volver al login
        this.btnLogin = new Button();
        this.btnLogin.Text = "Volver";
        this.btnLogin.Location = new Point(150, 120);
        this.btnLogin.Click += new EventHandler(this.BtnLogin_Click);
        this.Controls.Add(this.btnLogin);
    }

    private void BtnLogin_Click(object sender, EventArgs e)
    {
        // Cerrar este formulario
        this.Close();
        
        //mostrar el formulario de login nuevamente
         LoginForm loginForm = new LoginForm();
         loginForm.Show();
    }
}
}