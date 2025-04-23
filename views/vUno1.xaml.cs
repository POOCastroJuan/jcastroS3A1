namespace jcastroS3A1.views;

public partial class vUno1 : ContentPage
{
	public vUno1()
	{
		InitializeComponent();
	}
	string usuariof = " ";
	string contrasenaf = " ";
	public vUno1(string usuario, string contrasena)
	{
        InitializeComponent();
		this.usuariof = usuario;
		this.contrasenaf = contrasena;
    }

    private void btnInicicarSesion_Clicked(object sender, EventArgs e)
    {
		if(txtUsuario.Text==usuariof&& txtContraseña.Text==contrasenaf)
		{
			Navigation.PushAsync(new views.vDos(usuariof));
		}
		else
		{
			DisplayAlert("alerta", "Usuario contraseña incorrectos", "ok");
		}
		Navigation.PushAsync(new views.vDos(txtUsuario.Text));
    }

    private void btnRegistrar_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new views.vTres());
    }
}