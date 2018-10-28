

namespace Floristeria.ViewModels
{
    using GalaSoft.MvvmLight.Command;
    using System.Windows.Input;
    using Xamarin.Forms;
    using Views;

    public class MenuItemViewModel
    {
        #region Propiedades
        public string Icon { get; set; }
        public string Title { get; set; }
        public string PageName { get; set; } 
        #endregion
        #region Comandos
        public ICommand NavigationCommand {
            get
            {
                return new RelayCommand(Navigate);
            }
            
        }

        private void Navigate()
        {
            if(this.PageName == "LoginPage")
            {
                Application.Current.MainPage = new NavigationPage(new LoginPage());
            }
            else if(this.PageName == "HomePage")
            {

                
            }
            else if(this.PageName == "DesayunosPage")
            {
                Application.Current.MainPage = new NavigationPage(new DesayunosPage());
            }
        }
        #endregion
    }
}
