using Ingeniería.Backend.Controladores;
using Ingeniería.Backend.Modelos;
using Ingeniería.Forms;

namespace Ingeniería.Forms;

public partial class LoginForm : Form
{
    public LoginForm()
    {
        InitializeComponent();
    }

    public LoginControler controler = new LoginControler();

    private void validarLogin()
    {
        var login = new Ingeniería.Backend.Modelos.Login()
        {
            Correo = txtCorreo.Text,
            Contraseña = txtContraseña.Text
        };

        var loginValidado = controler.ValidarLogin(login);

        if (loginValidado)
        {
            this.Hide();
            var fMM = new MainMenu();
            fMM.Show();
            return;            
        }

        MessageBox.Show("Tu cuenta es incorrecta");




    }

    

}