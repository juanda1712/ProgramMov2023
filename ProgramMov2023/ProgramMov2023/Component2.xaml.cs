﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProgramMov2023
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Component2 : ContentPage
    {
        public Component2()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Component3());
        }
    }
}