using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace CACM
{
    public class LoginPage : ContentPage
    {
        private List<Usuario> listUser;
        Entry emailEntry, passwordEntry;
        public LoginPage(List<Usuario>ListUsuario)
        {
            TapGestureRecognizer tapRecupera = new TapGestureRecognizer();
            TapGestureRecognizer tapCrear = new TapGestureRecognizer();

            tapCrear.Tapped += TapCrear_Tapped;
            tapRecupera.Tapped += TapRecupera_Tapped;
            var Logo = new Image { Source = ImageSource.FromResource("CACM.LogoEsteSi.png")};
            var Image = new Image { Source = ImageSource.FromResource("CACM.FondoCAC.jpg"), Aspect = Aspect.Fill };
            NavigationPage.SetHasNavigationBar(this, false);
            var stack = new StackLayout {
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };
            var Relative = new RelativeLayout
            {
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };

            var logoCac = new StackLayout
            {
                HorizontalOptions = LayoutOptions.Center,
                Children =
                {
                    Logo
                }
            };
            
            
           

            emailEntry = new Entry
            {
                Placeholder = "Ingrese su Email",
                WidthRequest = 200
            };
            var email = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                Children ={
                new Label{
                    VerticalTextAlignment = TextAlignment.Center,
                    Text = "Email: ",
                    WidthRequest=100,
                    FontAttributes = FontAttributes.Bold
                },
                emailEntry
                }
            };

            passwordEntry = new Entry
            {
                Placeholder = "Ingrese Contraseña",
                IsPassword = true,
                WidthRequest = 200
            };
            var password = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                Children =
                {
                    new Label
                    {
                        VerticalTextAlignment = TextAlignment.Center,
                        Text="Password: ",
                        WidthRequest=100,
                        FontAttributes = FontAttributes.Bold
                    },
                    passwordEntry
                }
            };

            var iniciar = new Button
            {
                Text = "Iniciar Sesion",
                WidthRequest = 300,
                FontSize = 10,
                BackgroundColor = Color.Blue,
                TextColor = Color.White
              
                
            };
            iniciar.Clicked += eventClic;
            var olvido = new Label
            {
                Text = "Olvido Su Contraseña?",
                //WidthRequest = 100,
                FontSize = 20,
                TextColor = Color.Blue
            };
            olvido.GestureRecognizers.Add(tapRecupera);
            var crear = new Label
            {
                Text = "Crear Cuenta",
                //WidthRequest = 100,
                FontSize = 20,
                TextColor = Color.Blue
                
            };
            crear.GestureRecognizers.Add(tapCrear);
            var botonIniciar = new StackLayout
            {
                Orientation = StackOrientation.Vertical, 
                HorizontalOptions = LayoutOptions.Center,
                Children =
                {
                    iniciar
                }
            };

            var labelsCrear = new StackLayout()
            {
                Orientation = StackOrientation.Vertical,
                HorizontalOptions = LayoutOptions.Center,
                Children =
                {
                    crear
                    
                }
            };

            var labelsOlvido = new StackLayout()
            {
                Orientation = StackOrientation.Vertical,
                HorizontalOptions = LayoutOptions.Center,
                Children =
                {
                    olvido

                }
            };
            listUser = ListUsuario;

            stack.Children.Add(logoCac);
            stack.Children.Add(email);
            stack.Children.Add(password);
            stack.Children.Add(botonIniciar);
            stack.Children.Add(labelsCrear);
            stack.Children.Add(labelsOlvido);
            Relative.Children.Add(Image, Constraint.Constant(0),
                Constraint.Constant(0));
            Relative.Children.Add(stack, Constraint.Constant(4),
                Constraint.Constant(100));

            Content = Relative;

        }

        private async void TapRecupera_Tapped(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(emailEntry.Text)) await DisplayAlert("Alerta", "Usted no ha ingresado el correo", "Ok");
            else await Navigation.PushAsync(new OlvidoPage(emailEntry.Text));
            
        }

        private async void TapCrear_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CrearCuentaPage());
        }

        public async void eventClic(Object sender, EventArgs e)
        {
            int variable = 0;
            String stMensaje = String.Empty;
            if (String.IsNullOrEmpty(emailEntry.Text)) stMensaje += "Ingrese Email, ";
            if (String.IsNullOrEmpty(passwordEntry.Text)) stMensaje += "Ingrese Contraseña, ";
            if (!String.IsNullOrEmpty(stMensaje)) await DisplayAlert("Alerta", stMensaje, "Ok");
            
            foreach(Usuario user in listUser)
            {
                if (user.stCorreo.Equals(emailEntry.Text) && user.stContraseña.Equals(passwordEntry.Text))
                {
                    await Navigation.PushAsync(new ContenidoUsuariosPage(listUser));
                    Navigation.RemovePage(this);
                    variable = 1;
                }
            };
            if(variable==0) await DisplayAlert("Alerta", "Contraseña o Correo Incorrecta", "Ok");



        }

        //public async void eventClicCrearAsync(Object sender, EventArgs e)
        //{
          //  await Navigation.PushAsync(new CrearCuentaPage());
        //}
    }
}