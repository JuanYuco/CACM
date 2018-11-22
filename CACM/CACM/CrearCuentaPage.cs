using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace CACM
{
    public class CrearCuentaPage : ContentPage
    {
        Entry NombreEntry, ApellidoEntry, CorreoEntry, ContraseñaEntry, CContraseñaEntry;
        public CrearCuentaPage()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            var Relative = new RelativeLayout {
                HorizontalOptions = LayoutOptions.Center
            };
            var Image = new Image { Source = ImageSource.FromResource("CACM.FondoCAC.jpg"), Aspect= Aspect.Fill };


            var Stack = new StackLayout
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
                        Text="Crear Cuenta",
                        TextColor=Color.Blue,
                        FontSize = 50,
                        Style = Device.Styles.TitleStyle,
                        FontAttributes = FontAttributes.Bold
                    }
                }
            };

            NombreEntry = new Entry
            {
                Placeholder = "Ingrese el Nombre",
                WidthRequest = 200
            };
            var Nombre = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                Children ={
                new Label{
                    VerticalTextAlignment = TextAlignment.Center,
                    Text = "Nombre: ",
                    WidthRequest=100,
                    FontAttributes = FontAttributes.Bold,
                    TextColor=Color.Black
                },
                NombreEntry
                }
            };

            ApellidoEntry = new Entry
            {
                Placeholder = "Ingrese Apellido",
                WidthRequest = 200
            };
            var Apellido = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                Children ={
                new Label{
                    VerticalTextAlignment = TextAlignment.Center,
                    Text = "Apellido: ",
                    WidthRequest=100,
                    FontAttributes = FontAttributes.Bold,
                    TextColor=Color.Black
                },
                ApellidoEntry
                }
            };

            CorreoEntry = new Entry
            {
                Placeholder = "Ingrese Correo",
                WidthRequest = 200
            };

            var Correo = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                Children ={
                new Label{
                    VerticalTextAlignment = TextAlignment.Center,
                    Text = "Correo: ",
                    WidthRequest=100,
                    FontAttributes = FontAttributes.Bold,
                    TextColor=Color.Black
                },
                CorreoEntry
                }
            };

            ContraseñaEntry = new Entry
            {
                Placeholder = "Ingrese Contraseña",
                WidthRequest = 200,
                IsPassword = true
                
            };
            var Contraseña = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                Children ={
                new Label{
                    VerticalTextAlignment = TextAlignment.Center,
                    Text = "Contraseña: ",
                    WidthRequest=100,
                    FontAttributes = FontAttributes.Bold,
                    TextColor=Color.Black
                },
                ContraseñaEntry
                }
            };

            CContraseñaEntry = new Entry
            {
                Placeholder = "Ingrese Contraseña",
                WidthRequest = 200,
                IsPassword = true
            };
            var CContraseña = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                Children ={
                new Label{
                    VerticalTextAlignment = TextAlignment.Center,
                    Text = "Verificar Contraseña: ",
                    WidthRequest=100,
                    FontAttributes = FontAttributes.Bold,
                    TextColor=Color.Black
                },
                CContraseñaEntry
                }
            };
            var Crear = new Button
            {
                Text = "CREAR",
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
                    Crear
                }
            };
            Crear.Clicked += eventClicCrear; 

            Stack.Children.Add(titulo);
            Stack.Children.Add(Nombre);
            Stack.Children.Add(Apellido);
            Stack.Children.Add(Correo);
            Stack.Children.Add(Contraseña);
            Stack.Children.Add(CContraseña);
            Stack.Children.Add(boton);
            Relative.Children.Add(Image,Constraint.Constant(0), 
                Constraint.Constant(0));
            Relative.Children.Add(Stack, Constraint.Constant(10),
                Constraint.Constant(80));
            Content = Relative;
        }
        public void eventClicCrear(Object sender, EventArgs e)
        {
            String stMensaje = String.Empty;
            if (String.IsNullOrEmpty(NombreEntry.Text)) stMensaje += "Ingrese Nombre, ";
            if (String.IsNullOrEmpty(ApellidoEntry.Text)) stMensaje += "Ingrese Apellido, ";
            if (String.IsNullOrEmpty(CorreoEntry.Text)) stMensaje += "Ingrese Correo, ";
            if (String.IsNullOrEmpty(ContraseñaEntry.Text)) stMensaje += "Ingrese Contraseña, ";
            if (String.IsNullOrEmpty(CContraseñaEntry.Text)) stMensaje += "Ingrese la verificacion de la contraseña, ";
            if (ContraseñaEntry.Text != CContraseñaEntry.Text) stMensaje += "Las contraseñas no son iguales";
            if (!String.IsNullOrEmpty(stMensaje)) DisplayAlert("Alerta", stMensaje, "Ok");
            else
            {
                clsUsuarios user = new clsUsuarios
                {
                    stNombre = NombreEntry.Text,
                    stApellido = ApellidoEntry.Text,
                    stCorreo = CorreoEntry.Text,
                    stPassword = ContraseñaEntry.Text
                };
                App.lstUsuarios.Add(user);
                DisplayAlert("Alerta", "Se creo su cuenta con exito!", "OK");

                NombreEntry.Text = String.Empty;
                ApellidoEntry.Text = String.Empty;
                CorreoEntry.Text = String.Empty;
                ContraseñaEntry.Text = String.Empty;
                CContraseñaEntry.Text = String.Empty;
            }
        }
    }
}
