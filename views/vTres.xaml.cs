namespace jcastroS3A1.views;

public partial class vTres : ContentPage
{
    public vTres()
    {
        InitializeComponent();

    }

    private void btnguardar_Clicked(object sender, EventArgs e)
    {
        string usuarioc = txtusuario.Text;
        string contrase�a = txtcontrase�a.Text;
        DisplayAlert("alerta", "Usuario almacenado", "ok");
        Navigation.PushAsync(new views.vUno1(usuarioc,contrase�a));

    }
}
