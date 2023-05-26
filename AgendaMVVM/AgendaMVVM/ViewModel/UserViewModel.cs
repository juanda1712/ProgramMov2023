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
using AgendaMVVM.Views.MaestroDetalle;
using System.Threading.Tasks;

namespace AgendaMVVM.ViewModel
{
    internal class UserViewModel : BaseViewModel
    {
        #region Atributos

        private string user;
        private string password;
        private string name;
        private int id;
        private object listViewSource;

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
        public string Nametxt
        {
            get { return name; }
            set { SetValue(ref this.name, value); }
        }
        public int Idtxt
        {
            get { return id; }
            set { SetValue(ref this.id, value); }
        }

        public object ListViewSource
        {
            get
            {
                return this.listViewSource;
            }
            set { SetValue(ref this.listViewSource, value); }
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


        public ICommand SaveCommand
        {
            get
            {
                return new RelayCommand(SaveUser);
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


        public async void SaveUser()
        {


            if (string.IsNullOrEmpty(this.user))
            {
                await Application.Current.MainPage.DisplayAlert("Register", "Por favor Ingresar el Usuario", "Aceptar");
                PasswordTxt = "";
                return;
            }


            UserModel Usr = new UserModel();
            Usr.Nombre = name;
            Usr.Pw = password;
            Usr.User = user;
            Usr.UserId = id;


            await App.DB.SaveModel<UserModel>(Usr, true);
            await Application.Current.MainPage.DisplayAlert("Register", " Registro Exitoso", "Aceptar");


            //await App.DB.SaveModel<UserModel>(Usr, false);
            //await Application.Current.MainPage.DisplayAlert("Register", " Modificacion Exitosa", "Aceptar");


        }



        public async Task LoadList()
        {
            ListViewSource = await App.DB.GetModel<UserModel>();
      
        }

        #endregion
        public async void OpenViewRegister()
        {

            //await Application.Current.MainPage.Navigation.PushAsync(new MenuLateral());

            await Application.Current.MainPage.Navigation.PushAsync(new Register ());

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


        public UserViewModel()
        {
            LoadList();
        }

        public UserViewModel(UserModel item)
        {
            this.Nametxt = item.Nombre;
            this.Usertxt = item.User;
            this.PasswordTxt = item.Pw;
            this.Idtxt = item.UserId;
        }


    }
}
