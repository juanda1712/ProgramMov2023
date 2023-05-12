using AgendaMVVM.Model;
using AgendaMVVM.Views;
using AgendaMVVM.Views.popUp;
using GalaSoft.MvvmLight.Command;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using Rg.Plugins.Popup.Services;
using Plugin.LocalNotification;

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


        public ICommand RegisterCommand
        {
            get
            {
                return new RelayCommand(OpenViewRegister);
            }
            set { }
        }

        public ICommand RecordarCommand
        {
            get
            {
                return new RelayCommand(OpenViewRecordar);
            }
            set { }
        }

        


        #endregion

        #region Method


        public async void Validate_login()
        {

            UserModel Usr = App.DB.GetUserModel(user, password).Result;

            if (Usr == null)
            {

                await Application.Current.MainPage.DisplayAlert("Login", "Error en contraseña", "Aceptar");
                PasswordTxt = "";
                
            }
            else
            {
                await Application.Current.MainPage.DisplayAlert("Login", "Welcome to Xamarin", "Aceptar");
                await Application.Current.MainPage.Navigation.PushAsync(new Home());

            }

        }
        #endregion
        public async void OpenViewRegister()
        {

            await Application.Current.MainPage.Navigation.PushAsync(new Register());



        }
        public async void OpenViewRecordar()
        {

            var notif = new NotificationRequest();
            notif.Title = "Alerta";
            notif.Description = "Alerta cambio de contraseña";
            notif.NotificationId = 123;
            notif.BadgeNumber = 2;
            await LocalNotificationCenter.Current.Show(notif);

            await PopupNavigation.Instance.PushAsync(new PopUpExample("detalle por parametro"));


        }

    }
}
