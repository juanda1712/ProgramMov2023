using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace AgendaMVVM.ViewModel
{
    internal class UserViewModel : BaseViewModel
    {
        #region Atributos

        private string user;
        private string password;

        #endregion

        #region Prop

        public string Usertxt
        {
            get 
            { 
                return this.user;
            }
            set { SetValue(ref this.user , value); }
        }


      

        public string PasswordTxt
        {
            get { return password; }
            set { SetValue(ref  this.password , value); }
        }



        #endregion

        #region Commands

        public ICommand LoginCommand
        {
            get
            {
                return new RelayCommand(Validate_login);
            }
            set { }
        }
        #endregion

        #region Method


        public async void Validate_login()
        {

            if (Usertxt == "ADMIN" && PasswordTxt == "1234")
            {

                await Application.Current.MainPage.DisplayAlert("Login", "Welcome to Xamarin", "Aceptar");
            }
            else
            {
                await Application.Current.MainPage.DisplayAlert("Login", "Error en contraseña", "Aceptar");
                PasswordTxt = "";
            }

        }
        #endregion



    }
}
