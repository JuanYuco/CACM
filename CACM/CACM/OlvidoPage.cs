using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace CACM
{
    public class OlvidoPage : ContentPage
    {
        Entry EntryCorreo;
        public OlvidoPage(string correo)
        {
            NavigationPage.SetHasNavigationBar(this, false);
            var relative = new RelativeLayout
            {
                HorizontalOptions = LayoutOptions.Center
            };


            var Image = new Image { Source = ImageSource.FromResource("CACM.FondoCAC.jpg"), Aspect = Aspect.Fill };

            var stack = new StackLayout
            {
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };

            var titulo = new StackLayout
            {
                Children = {
                    new Label
                    {
                        VerticalTextAlignment = TextAlignment.Center,
                        HorizontalTextAlignment = TextAlignment.Center,
                        Text="Olvido Su Contraseña?",
                        TextColor=Color.Blue,
                        FontSize = 50,
                        Style = Device.Styles.TitleStyle,
                        FontAttributes = FontAttributes.Bold
                    }
                }
            };


            EntryCorreo = new Entry
            {
                Placeholder = "Ingrese el Correo",
                WidthRequest = 300
            };


            var Correo = new StackLayout
            {
               
                Children ={     
                EntryCorreo
                }
            };
            EntryCorreo.Text = correo;
            var Recuperar= new Button
            {
                Text = "RECUPERAR",
                WidthRequest = 300,
                FontSize = 25,
                BackgroundColor = Color.Blue,
                TextColor = Color.White
            };

            var boton = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                Children =
                {
                    Recuperar
                }
            };

            stack.Children.Add(titulo);
            stack.Children.Add(Correo);
            stack.Children.Add(boton);
            relative.Children.Add(Image, Constraint.Constant(0),
                Constraint.Constant(0));
            relative.Children.Add(stack, Constraint.Constant(10),
                Constraint.Constant(80));




            Content = relative;
        }
    }
}