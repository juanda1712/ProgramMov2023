using AgendaMVVM.BD;
using AgendaMVVM.Model;
using AgendaMVVM.Views;
using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AgendaMVVM
{
    public partial class App : Application
    {

        static DataBaseQuery database;

        public static DataBaseQuery DB
        {
            get
            {
                if (database == null)
                {
                     database = new DataBaseQuery(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),"DBProgramMov.db"));
                }
                return database;
            }
        }

        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new Login());
        }

        protected override void OnStart()
        {

            //var user = new UserModel();
            //user.Nombre = "DAVID";
            //user.User = "AUX";
            //user.Pw = "1234";
            ////App.DB.SaveUserModel(user);
            //App.DB.SaveModel<UserModel>(user, true);


        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
