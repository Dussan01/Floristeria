using GalaSoft.MvvmLight.Command;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace Floristeria.ViewModels
{
    
    
    public class LoginViewModel : BaseViewModel
    {
        #region Eventos
        
        #endregion

        #region Propiedades
        private string password;
        private bool isRunning;
        private bool isEnable;
        #endregion

        #region Propiedades
        public string Email {
            get;
            set;

        }
        public string Password {
            get { return this.password; }
            set { SetValue(ref this.password, value); }
        }
        public bool IsRunning
        {
            get { return this.isRunning; }
            set
            {
                SetValue(ref this.isRunning, value);
            }
        }
        public bool IsRecordar
        {
            get;
            set;
        }
        public bool IsEnabled {
            get { return this.isEnable; }
            set
            {
                SetValue(ref this.isEnable, value);
            }
        }
        #endregion
        #region Constructores
        public LoginViewModel()
        {
            this.IsRecordar = true;
            this.isEnable = true;
        }
        #endregion
        #region command
        public ICommand IngresarCommand {
            get
            {
                return new RelayCommand(Login);
            }
        }

        private async void Login()
        {
            if (string.IsNullOrEmpty(this.Email))
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "Debes ingresar tu correo.",
                    "Aceptar");
                return;
            }
            if (string.IsNullOrEmpty(this.Password))
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "Debes ingresar una contraseña.",
                    "Aceptar");
                return;
            }
            this.isRunning = true;
            this.IsEnabled = false;

            if (this.Email != "kevin.dussan3@gmail.com" || this.Password !="1234")
            {
                this.isRunning = false;
                this.IsEnabled = true;
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "Correo o contraseña son incorrectos",
                    "Aceptar");
                return;
            }
            await Application.Current.MainPage.DisplayAlert(
                   "Ok",
                   "Ingresaste",
                   "Aceptar");
            return;
        }
        #endregion
    }
}
