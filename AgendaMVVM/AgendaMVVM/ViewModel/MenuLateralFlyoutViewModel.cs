using AgendaMVVM.Model;
using AgendaMVVM.Views;
using System;
using System.Collections.Generic;
using System.Text;

namespace AgendaMVVM.ViewModel
{
    internal class MenuLateralFlyoutViewModel : BaseViewModel
    {
        #region Atributos
        private string icon;
        private string title;
        private object listViewSource;

        #endregion

        #region Prop

        public string Icon
        {
            get
            {
                return this.icon;
            }
            set { SetValue(ref this.icon, value); }
        }

        public string Title
        {
            get
            {
                return this.title;
            }
            set { SetValue(ref this.title, value); }
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


        public void LoadList()
        {

            this.listViewSource = new List<MenuLateralModel>( new[]
            {
                new MenuLateralModel {Id= 0 ,Title="New" ,Icon="user.png", TargetType = typeof(Register) },
                new MenuLateralModel {Id= 0 ,Title="Home" ,Icon="user.png", TargetType = typeof(Home) }
            }              
                
                );

        }
        public MenuLateralFlyoutViewModel()
        {
            LoadList();
        }
    }
}
