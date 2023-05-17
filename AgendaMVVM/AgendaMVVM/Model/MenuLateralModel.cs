using AgendaMVVM.Views.MaestroDetalle;
using System;
using System.Collections.Generic;
using System.Text;

namespace AgendaMVVM.Model
{
    public class MenuLateralModel
    {

        public MenuLateralModel()
        {
            TargetType = typeof(MenuLateralModel);
        }
        public int Id { get; set; }
        public string Title { get; set; }
        public string Icon { get; set; }
        public Type TargetType { get; set; }

    }
}
