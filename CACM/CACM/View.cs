using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace CACM.ListView
{
    public class View : ViewCell
    {
        public View()
        {
            StackLayout viewGeneral = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                BackgroundColor = Color.Transparent
            };
            StackLayout viewText = new StackLayout
            {
                BackgroundColor = Color.Transparent, Spacing=0
            };
            Image imagenAvatar = new Image {
                Source = ImageSource.FromFile("UsuarioFoto.gif"),
                WidthRequest = 60,
                HeightRequest = 60
            };
            Label nombreUsuario = new Label { Text="", FontSize=12, FontAttributes= FontAttributes.Bold};
            Label apellidoUsuario = new Label { Text = "", FontSize = 12, FontAttributes = FontAttributes.Bold };
            Label correoUsuario = new Label { Text = "", FontSize = 12 };

            nombreUsuario.SetBinding(Label.TextProperty, new Binding("stUsuario"));
            apellidoUsuario.SetBinding(Label.TextProperty, new Binding("stApellido"));
            correoUsuario.SetBinding(Label.TextProperty, new Binding("stContraseña"));

            viewText.Children.Add(nombreUsuario);
            viewText.Children.Add(apellidoUsuario);
            viewText.Children.Add(correoUsuario);

            viewGeneral.Children.Add(imagenAvatar);
            viewGeneral.Children.Add(viewText);

            View = viewGeneral;
        }
    }
}