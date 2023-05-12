using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Rg.Plugins.Popup.Services;

namespace AgendaMVVM.Views.popUp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PopUpExample 
    {
        public PopUpExample()
        {
            InitializeComponent();
        }


        public PopUpExample(string detalle)
        {
            InitializeComponent();
            lbldet.Text = detalle;
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            PopupNavigation.Instance.PopAsync();

        }
    }
}