using System;
using System.Collections.ObjectModel;

namespace Floristeria.ViewModels
{
    public class MainViewModel
    {

        #region Propiedades
        public ObservableCollection<MenuItemViewModel> Menus { get; set; }
        #endregion
        #region ViewModels
        public LoginViewModel Login
        {
            get;
            set;
        }
        public HomePageViewModels Inicio
        {
            get;
            set;
        }
        #endregion
        #region Constructores
        public MainViewModel()
        {
            this.Login = new LoginViewModel();
            this.LoadMenu();
        }



        #endregion
        #region Metodos
        private void LoadMenu()
        {
            //instancia de los menus
            this.Menus = new ObservableCollection<MenuItemViewModel>();

            this.Menus.Add(new MenuItemViewModel
            {
                Icon = "ic_icon",
                Title = "Inicio",
                PageName="HomePage",
            });
            this.Menus.Add(new MenuItemViewModel
            {
                Icon = "ic_dar_dinero",
                Title = "Pagos",
                PageName = "LoginPage",
            });
            this.Menus.Add(new MenuItemViewModel
            {
                Icon="ic_wb_sunny",
                Title="Desayunos",
                PageName="DesayunosPage",
            });

        } 
        #endregion
    }
}
