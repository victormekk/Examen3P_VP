namespace Examen3P_VP.Views;

public partial class VerFoto : ContentPage
{
    public VerFoto(byte[] f)
    {
        InitializeComponent();
        //
        Stream stream = new MemoryStream(f);
        foto.Source = ImageSource.FromStream(() => stream);
    }
}