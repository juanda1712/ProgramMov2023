using AgendaMVVM.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AgendaMVVM.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListUser : ContentPage
    {
        public ListUser()
        {
            InitializeComponent();
            BindingContext = new UserViewModel();
        }

        private void ListV_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

        }
    }
}