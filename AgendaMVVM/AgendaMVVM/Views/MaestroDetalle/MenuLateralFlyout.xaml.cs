using AgendaMVVM.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AgendaMVVM.Views.MaestroDetalle
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuLateralFlyout : ContentPage
    {
        public ListView ListView;

        public MenuLateralFlyout()
        {
            InitializeComponent();

            BindingContext = new MenuLateralFlyoutViewModel();
            ListView = MenuItemsListView;
        }

        //private class MenuLateralFlyoutViewModel : INotifyPropertyChanged
        //{
        //    public ObservableCollection<MenuLateralFlyoutMenuItem> MenuItems { get; set; }

        //    public MenuLateralFlyoutViewModel()
        //    {
        //        MenuItems = new ObservableCollection<MenuLateralFlyoutMenuItem>(new[]
        //        {
        //            new MenuLateralFlyoutMenuItem { Id = 0, Title = "Page 1" },
        //            new MenuLateralFlyoutMenuItem { Id = 1, Title = "Page 2" },
        //            new MenuLateralFlyoutMenuItem { Id = 2, Title = "Page 3" },
        //            new MenuLateralFlyoutMenuItem { Id = 3, Title = "Page 4" },
        //            new MenuLateralFlyoutMenuItem { Id = 4, Title = "Page 5" },
        //        });
        //    }

        //    #region INotifyPropertyChanged Implementation
        //    public event PropertyChangedEventHandler PropertyChanged;
        //    void OnPropertyChanged([CallerMemberName] string propertyName = "")
        //    {
        //        if (PropertyChanged == null)
        //            return;

        //        PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        //    }
        //    #endregion
        //}
    }
}