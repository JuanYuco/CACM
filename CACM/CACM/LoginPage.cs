using CACM.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CACM
{
    public class LoginPage : ContentPage
    {
        private List<clsUsuarios> listUser;
        Button iniciar;
        Entry emailEntry, passwordEntry;
        ActivityIndicator activity;
        public LoginPage(List<clsUsuarios>ListUsuario)
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
            activity = new ActivityIndicator
            {
                IsRunning = true,
                IsVisible = false,
            };

             iniciar = new Button
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
            //stack.Children.Add(activity);
            stack.Children.Add(botonIniciar);
            stack.Children.Add(labelsCrear);
            stack.Children.Add(labelsOlvido);
            Relative.Children.Add(Image, Constraint.Constant(0),
                Constraint.Constant(0));
            Relative.Children.Add(stack, Constraint.Constant(4),
                Constraint.Constant(100));
            Relative.Children.Add(activity, Constraint.Constant(150),
                Constraint.Constant(250));

            Content = Relative;

        }

        private async void TapRecupera_Tapped(object sender, EventArgs e)
        {
            
            await Navigation.PushAsync(new OlvidoPage());
            
        }

        private async void TapCrear_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CrearCuentaPage());
        }

        public async void eventClic(Object sender, EventArgs e)
        {
            
            BlockAndActive();
            
            //int variable = 0;
            String stMensaje = String.Empty;
            if (String.IsNullOrEmpty(emailEntry.Text)) stMensaje += "Ingrese Email, ";
            if (String.IsNullOrEmpty(passwordEntry.Text)) stMensaje += "Ingrese Contraseña, ";
            if (!String.IsNullOrEmpty(stMensaje))
            {

                BlockAndActive();
                await DisplayAlert("Alerta", stMensaje, "Ok");
                return;
            }

            //foreach(Usuario user in listUser)
            //{
            //if (user.stCorreo.Equals(emailEntry.Text) && user.stContraseña.Equals(passwordEntry.Text))
            //{

            //variable = 1;
            //}
            //};
            
            clsUsuarios clsUsuario = new clsUsuarios
            {
                inCodigo = 0,
                stNombre = ":v",
                stApellido = ":v",
                stUsuaImagen = "luego",
                inPuntuacionMaxima = 0,
                inTipo = 0,
                stCorreo = emailEntry.Text,
                stPassword = passwordEntry.Text
                
            };
            string url = string.Format("{0}", "http://172.16.20.42/ApiCAC//api/Usuarios/validarUsuarios");
            Iservicios myServices = DependencyService.Get<Iservicios>();
            string myObject = await myServices.Login(clsUsuario);
            //string myObject = await myServices.newLogin(url,clsUsuario,Login.Methods.POST,Login.ContentType.JSON);
            //Boolean resp  = JsonConvert.DeserializeObject<Boolean>(myObject);

            if (myObject == null)
            {
                BlockAndActive();
                
                return;
            }
            if (myObject.Equals("true"))
            {
                BlockAndActive();
                
                await Navigation.PushAsync(new Mapa());
                Navigation.RemovePage(this);
                //mandar a la otra pagin
            }
            else
            {
                BlockAndActive();
                await DisplayAlert("Alerta", "Contraseña o Correo Incorrecta", "Ok");
                return;
            }
            //if(variable==0) await DisplayAlert("Alerta", "Contraseña o Correo Incorrecta", "Ok");



        }

        public  void BlockAndActive()
        {
            activity.IsVisible = !activity.IsVisible;
            emailEntry.IsEnabled = !emailEntry.IsEnabled;
            passwordEntry.IsEnabled = !passwordEntry.IsEnabled;
            iniciar.IsEnabled = !iniciar.IsEnabled ;
        }

        //public async void eventClicCrearAsync(Object sender, EventArgs e)
        //{
          //  await Navigation.PushAsync(new CrearCuentaPage());
        //}
    }
}