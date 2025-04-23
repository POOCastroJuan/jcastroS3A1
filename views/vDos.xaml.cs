namespace jcastroS3A1.views;

public partial class vDos : ContentPage
{
	public vDos(string usuario)
	{
		InitializeComponent();
		lblusuario.Text = "Usuario conectado: " + usuario;

	}

    private void btnAbrir_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new views.vTres());
    }
}