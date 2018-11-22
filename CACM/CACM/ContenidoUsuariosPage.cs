using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace CACM
{
    public class ContenidoUsuariosPage : ContentPage
    {
        public ContenidoUsuariosPage(List<clsUsuarios> ListUsuario)
        {


            Label header = new Label
            {
                Text = "Usuarios",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                HorizontalOptions = LayoutOptions.Center,
                TextColor = Color.Blue
            };
               
            

            Xamarin.Forms.ListView userListView = new Xamarin.Forms.ListView
            {
                ItemsSource = ListUsuario,
                ItemTemplate = new DataTemplate(() =>
                {
                    Label nombreLabel = new Label();
                    nombreLabel.SetBinding(Label.TextProperty, "stUsuario");

                    Label apellidoLabel = new Label();
                    apellidoLabel.SetBinding(Label.TextProperty, "stApellido");

                    Label correoLabel = new Label();
                    correoLabel.SetBinding(Label.TextProperty, "stCorreo");

                    var FotoPerfil = new Image { Source = ImageSource.FromResource("CACM.UsuarioFoto.gif") };

                    return new ViewCell
                    {
                        View = new StackLayout
                        {
                            Padding = new Thickness(0, 5),
                            Orientation = StackOrientation.Horizontal,
                            Children =
                                {
                                FotoPerfil,
                                    new StackLayout
                                    {
                                        VerticalOptions = LayoutOptions.Center,
                                        Spacing = 0,
                                        Children =
                                        {
                                            nombreLabel,
                                            apellidoLabel
                                            
                                        }
                                    },
                                    new StackLayout
                                    {
                                        VerticalOptions = LayoutOptions.Start,
                                        Spacing=0,
                                       Children=
                                        {
                                            correoLabel
                                        }
                                    }
                                }
                        }
                    };
                })
            };

            this.Padding = new Thickness(10, Device.OnPlatform(20, 0, 0), 10, 5);
            this.Content = new StackLayout
            {
                Children =
                {
                    header,
                    userListView
                }
            };
        }
    }
}