using Plugin.Maui.Audio;
using Examen3P_VP.Views;
using Examen3P_VP.Controllers;
using Examen3P_VP.Models;

namespace Examen3P_VP
{
    public partial class App : Application
    {
        public static FirebaseController db = new FirebaseController();
        public static Notas nota;

        public App()
        {
            InitializeComponent();

            //MainPage = new AppShell();
            MainPage = new NavigationPage(new Principal(AudioManager.Current));

        }
    }
}
