namespace Examen3P_VP.Views;
using Examen3P_VP.Controllers;
using Examen3P_VP.Models;
using System.Windows.Input;
public partial class Lista : ContentPage
{
    public Lista()
    {
        InitializeComponent();
    }
    protected override async void OnAppearing()
    {
        base.OnAppearing();
        viewLista.Header = "Cargando...";
        viewLista.ItemsSource = await App.db.SelectAll();
        viewLista.Header = string.Empty;
    }
    private async void OnItemSelected(object sender, SelectedItemChangedEventArgs args)
    {
        Notas nota = args.SelectedItem as Notas;
        await Navigation.PushAsync(new VerNota(nota));
    }
}