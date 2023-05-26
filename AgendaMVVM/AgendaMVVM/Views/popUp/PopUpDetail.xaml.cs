using AgendaMVVM.Model;
using AgendaMVVM.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AgendaMVVM.Views.popUp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PopUpDetail 
    {
        public PopUpDetail()
        {
            InitializeComponent();
        }

        public PopUpDetail(UserModel item)
        {
            InitializeComponent();
            BindingContext = new UserViewModel(item);
        }

    }
}