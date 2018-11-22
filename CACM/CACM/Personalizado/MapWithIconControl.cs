using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace CACM.Personalizado
{
    public class MapWithIconControl : Map
    {
        public static BindableProperty IconProperty = BindableProperty.Create(nameof(Icon),typeof(string), typeof(MapWithIconControl),string.Empty, BindingMode.TwoWay);
        
        public string Icon
        {
            get { return GetValue(IconProperty).ToString(); }
            set { SetValue(IconProperty, value); }

        }
    }
}
