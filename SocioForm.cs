using System;
using System.Windows.Forms;
using System.Drawing;


namespace LoginEjemplo
{


public class SocioForm : Form
{
	private Button btnLogin; // Declaración del botón    

    public SocioForm()
    {
        this.Text = "Panel de Socio";
        this.Width = 400;
        this.Height = 300;

        Label lblWelcome = new Label();
        lblWelcome.Text = "Bienvenido, SOCIO";
        lblWelcome.Font = new System.Drawing.Font("Arial", 14,FontStyle.Bold);
	lblWelcome.AutoSize = true;
        lblWelcome.Location = new System.Drawing.Point(50, 50);
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
        // Cerrar formulario
        this.Close();
        
        //mostrar formulario de login nuevamente
         LoginForm loginForm = new LoginForm();
         loginForm.Show();
    }
	
}
}