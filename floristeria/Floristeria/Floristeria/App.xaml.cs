using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Floristeria
{
    using Views;
    public partial class App : Application
    {
        #region Propiedades
        public static object Navigator { get; internal set; }
        #endregion

        #region Constructores
        public App()
        {
            InitializeComponent();

            //this.MainPage = new NavigationPage(new LoginPage());
            this.MainPage = new MasterPage();

        }
        #endregion

        #region Metodos
        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        } 
        #endregion
    }
}
