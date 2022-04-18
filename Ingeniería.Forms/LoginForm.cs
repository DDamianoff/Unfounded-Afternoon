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

    private readonly LoginControler _controller = new ();

    private void ValidarLogin()
    {
        var login = new Login()
        {
            Correo = txtCorreo.Text,
            Contraseña = txtContraseña.Text
        };

        var loginValidado = _controller.ValidarLogin(login);

        if (loginValidado)
        {
            this.Hide();
            var fMM = new MainMenu();
            fMM.Show();
            return;            
        }

        MessageBox.Show("Tu cuenta es incorrecta");
    }

    private void btnIngresar_Click(object sender, EventArgs e)
    {
        ValidarLogin();
    }
}