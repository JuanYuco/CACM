using CACM.Personalizado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace CACM
{
    public class Mapa : ContentPage
    {
        Pin pin;
        Image lineas;
        MapWithIconControl map;
        Image botonMenu;
        Image botonGeografia;
        Image botonHistoria;
        Image botonGastronomia;
        Image botonMusica;
        Image botonPersonajes;
        Image botonDeportes;
        Image botonFauna;
        Image botonFlora;
        Image botonCulturas;
        public Mapa()
        {
            NavigationPage.SetHasNavigationBar(this, false);

            RelativeLayout relative = new RelativeLayout();
            lineas = new Image
            {
                Source = ImageSource.FromResource("CACM.menu.png")
            };

            

            map = new MapWithIconControl( )
            {
                
                IsShowingUser = true,
                VerticalOptions = LayoutOptions.FillAndExpand
            };
            map.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(4.570868, -74.29733299999998),
               Distance.FromKilometers(500)));
            


            botonMenu = new Image
            {
                Source = ImageSource.FromFile("menu.png"),
                WidthRequest = 45,
                HeightRequest = 45
            };

            TapGestureRecognizer tapMenu = new TapGestureRecognizer();
            tapMenu.Tapped += TapMenu_Tapped;
            botonMenu.GestureRecognizers.Add(tapMenu);

            botonGeografia = new Image
            {
                Source = ImageSource.FromFile("mundial.png"),
                WidthRequest = 45,
                HeightRequest = 45,
                IsVisible = false,
                IsEnabled = false
            };

            TapGestureRecognizer tapGeografia = new TapGestureRecognizer();
            tapGeografia.Tapped += TapGeografia_Tapped;
            botonGeografia.GestureRecognizers.Add(tapGeografia);

            botonHistoria = new Image
            {
                Source = ImageSource.FromFile("columna.png"),
                WidthRequest = 45,
                HeightRequest = 45,
                IsVisible = false,
                IsEnabled = false
            };

            TapGestureRecognizer tapHistoria = new TapGestureRecognizer();
            tapHistoria.Tapped += TapHistoria_Tapped;
            botonHistoria.GestureRecognizers.Add(tapHistoria);

            botonGastronomia = new Image
            {
                Source = ImageSource.FromFile("jamonpierna.png"),
                WidthRequest = 45,
                HeightRequest = 45,
                IsVisible = false,
                IsEnabled = false
            };

            TapGestureRecognizer tapGastronomia = new TapGestureRecognizer();
            tapGastronomia.Tapped += TapGastronomia_Tapped;
            botonGastronomia.GestureRecognizers.Add(tapGastronomia);

            botonMusica = new Image
            {
                Source = ImageSource.FromFile("acordeon.png"),
                WidthRequest = 45,
                HeightRequest = 45,
                IsVisible = false,
                IsEnabled = false
            };

            TapGestureRecognizer tapMusica = new TapGestureRecognizer();
            tapMusica.Tapped += TapMusica_Tapped;
            botonMusica.GestureRecognizers.Add(tapMusica);

            botonPersonajes = new Image
            {
                Source = ImageSource.FromFile("hombre.png"),
                WidthRequest = 45,
                HeightRequest = 45,
                IsVisible = false,
                IsEnabled = false
            };

            TapGestureRecognizer tapPersonajes = new TapGestureRecognizer();
            tapPersonajes.Tapped += TapPersonajes_Tapped;
            botonPersonajes.GestureRecognizers.Add(tapPersonajes);

            botonDeportes = new Image
            {
                Source = ImageSource.FromFile("futbol.png"),
                WidthRequest = 45,
                HeightRequest = 45,
                IsVisible = false,
                IsEnabled = false
            };

            TapGestureRecognizer tapDeportes = new TapGestureRecognizer();
            tapDeportes.Tapped += TapDeportes_Tapped;
            botonDeportes.GestureRecognizers.Add(tapDeportes);

            botonFauna = new Image
            {
                Source = ImageSource.FromFile("lobo.png"),
                WidthRequest = 45,
                HeightRequest = 45,
                IsVisible = false,
                IsEnabled = false
            };

            TapGestureRecognizer tapFauna = new TapGestureRecognizer();
            tapFauna.Tapped += TapFauna_Tapped;
            botonFauna.GestureRecognizers.Add(tapFauna);

            botonFlora = new Image
            {
                Source = ImageSource.FromFile("flor.png"),
                WidthRequest = 45,
                HeightRequest = 45,
                IsVisible = false,
                IsEnabled = false
            };

            TapGestureRecognizer tapFlora = new TapGestureRecognizer();
            tapFlora.Tapped += TapFlora_Tapped;
            botonFlora.GestureRecognizers.Add(tapFlora);


            botonCulturas = new Image
            {
                Source = ImageSource.FromFile("nativoamericano.png"),
                WidthRequest = 45,
                HeightRequest = 45,
                IsVisible = false,
                IsEnabled = false
            };

            TapGestureRecognizer tapCulturas = new TapGestureRecognizer();
            tapCulturas.Tapped += TapCulturas_Tapped;
            botonCulturas.GestureRecognizers.Add(tapCulturas);


            var stack = new StackLayout { Spacing = 0 };
            stack.Children.Add(map);


            relative.Children.Add(stack, Constraint.RelativeToParent((parent) => {
                return parent.X;
            }), Constraint.RelativeToParent((parent) => {
                return parent.Y;
            }), Constraint.RelativeToParent((parent) => {
                return parent.Width;
            }), Constraint.RelativeToParent((parent) => {
                return parent.Height;
            }));
            //Content = stack;

            

            relative.Children.Add(botonMenu, Constraint.Constant(2), Constraint.Constant(2));
            relative.Children.Add(botonGeografia, Constraint.Constant(2), Constraint.Constant(48));
            relative.Children.Add(botonHistoria, Constraint.Constant(2), Constraint.Constant(96));
            relative.Children.Add(botonGastronomia, Constraint.Constant(2), Constraint.Constant(144));
            relative.Children.Add(botonMusica, Constraint.Constant(2), Constraint.Constant(192));
            relative.Children.Add(botonPersonajes, Constraint.Constant(2), Constraint.Constant(240));
            relative.Children.Add(botonDeportes, Constraint.Constant(2), Constraint.Constant(288));
            relative.Children.Add(botonFauna, Constraint.Constant(2), Constraint.Constant(336));
            relative.Children.Add(botonFlora, Constraint.Constant(2), Constraint.Constant(384));
            relative.Children.Add(botonCulturas, Constraint.Constant(2), Constraint.Constant(432));

            Content = relative;

            
        }

        private async void Pin_Clicked(object sender, EventArgs e)
        {
            Pin objeto = (Pin)sender;
            await DisplayAlert(objeto.Label,objeto.Address, "ok");
        }

        private void TapCulturas_Tapped(object sender, EventArgs e)
        {
            try
            {
                map.Pins.Clear();
                Iservicios myServices = DependencyService.Get<Iservicios>();
                List<Model.clsCulturas> cultura = myServices.getCulturas();
                
                foreach (Model.clsCulturas obclsCulturas in cultura)
                {
                    var position = new Position(Convert.ToDouble(obclsCulturas.stLatitud), Convert.ToDouble(obclsCulturas.stLongitud)); // Latitude, Longitude
                    pin = new Pin
                    {

                        Type = PinType.Place,
                        Position = position,
                        Label = obclsCulturas.stNombre,
                        Address = "Descripcion: " + obclsCulturas.stDescripcion,
                        BindingContext = AnchorX

                    };

                    pin.Clicked += Pin_Clicked;
                    map.Pins.Add(pin);
                }
                trueorfalse();
            }
            catch (Exception ew)
            {
                throw ew;
            }
        }

        private void TapFlora_Tapped(object sender, EventArgs e)
        {
            try
            {
                map.Pins.Clear();
                Iservicios myServices = DependencyService.Get<Iservicios>();
                List<Model.clsFlora> flora = myServices.getFlora();
                foreach (Model.clsFlora obclsFlora in flora)
                {
                    var position = new Position(Convert.ToDouble(obclsFlora.stLatitud), Convert.ToDouble(obclsFlora.stLongitud)); // Latitude, Longitude
                    pin = new Pin
                    {

                        Type = PinType.Place,
                        Position = position,
                        Label = obclsFlora.stNombre,
                        Address = "Descripcion: " + obclsFlora.stDescripcion,
                        BindingContext = AnchorX

                    };

                    pin.Clicked += Pin_Clicked;
                    map.Pins.Add(pin);
                }
                trueorfalse();
            }
            catch (Exception ew)
            {
                throw ew;
            }
        }

        private void TapFauna_Tapped(object sender, EventArgs e)
        {
            try
            {
                map.Pins.Clear();
                Iservicios myServices = DependencyService.Get<Iservicios>();
                List<Model.clsFaunaxDepartamento> fauna = myServices.getFauna();
                foreach (Model.clsFaunaxDepartamento obclsFaunaxDepartamento in fauna)
                {
                    var position = new Position(Convert.ToDouble(obclsFaunaxDepartamento.stLatitud), Convert.ToDouble(obclsFaunaxDepartamento.stLongitud)); // Latitude, Longitude
                    pin = new Pin
                    {

                        Type = PinType.Place,
                        Position = position,
                        Label = obclsFaunaxDepartamento.obclsFauna.stNombre,
                        Address = "Descripcion: " + obclsFaunaxDepartamento.stDescripcion,
                        BindingContext = AnchorX

                    };

                    pin.Clicked += Pin_Clicked;
                    map.Pins.Add(pin);
                }
                trueorfalse();
            }
            catch (Exception ew)
            {
                throw ew;
            }
        }

        private void TapDeportes_Tapped(object sender, EventArgs e)
        {
            try
            {
                map.Pins.Clear();
                Iservicios myServices = DependencyService.Get<Iservicios>();
                List<Model.clsEquipo> equipo = myServices.getEquipo();
                foreach (Model.clsEquipo obclsEquipo in equipo)
                {
                    var position = new Position(Convert.ToDouble(obclsEquipo.stLatitud), Convert.ToDouble(obclsEquipo.stLongitud)); // Latitude, Longitude
                    pin = new Pin
                    {

                        Type = PinType.Place,
                        Position = position,
                        Label = obclsEquipo.stNombre,
                        Address = "Descripcion: " + obclsEquipo.stDescripcion,
                        BindingContext = AnchorX

                    };

                    pin.Clicked += Pin_Clicked;
                    map.Pins.Add(pin);
                }
                trueorfalse();
            }
            catch (Exception ew)
            {
                throw ew;
            }
        }

        private void TapPersonajes_Tapped(object sender, EventArgs e)
        {
            try
            {
                map.Pins.Clear();
                Iservicios myServices = DependencyService.Get<Iservicios>();
                List<Model.clsArtistas> artistas = myServices.getArtistas();
                foreach (Model.clsArtistas obclsArtistas in artistas)
                {
                    var position = new Position(Convert.ToDouble(obclsArtistas.stLatitud), Convert.ToDouble(obclsArtistas.stLongitud)); // Latitude, Longitude
                    pin = new Pin
                    {

                        Type = PinType.Place,
                        Position = position,
                        Label = obclsArtistas.stNombre,
                        Address = "Ciudad de Nacimiento: " + obclsArtistas.stCiudad+" Tipo de artistas: "+obclsArtistas.clsTipodeArtista.stGenero,
                        BindingContext = AnchorX

                    };

                    pin.Clicked += Pin_Clicked;
                    map.Pins.Add(pin);
                }
                trueorfalse();
            }
            catch (Exception ew)
            {
                throw ew;
            }
        }

        private void TapMusica_Tapped(object sender, EventArgs e)
        {
            try
            {
                map.Pins.Clear();
                Iservicios myServices = DependencyService.Get<Iservicios>();
                List<Model.clsMusica> musica = myServices.getMusica();
                foreach (Model.clsMusica obclsMusica in musica)
                {
                    var position = new Position(Convert.ToDouble(obclsMusica.stLatitud), Convert.ToDouble(obclsMusica.stLongitud)); // Latitude, Longitude
                    pin = new Pin
                    {

                        Type = PinType.Place,
                        Position = position,
                        Label = obclsMusica.stNombre,
                        Address = "Descripcion: " + obclsMusica.stDescripcion,
                        BindingContext = AnchorX

                    };

                    pin.Clicked += Pin_Clicked;
                    map.Pins.Add(pin);
                }
                trueorfalse();
            }
            catch (Exception ew)
            {
                throw ew;
            }
        }

        private void TapGastronomia_Tapped(object sender, EventArgs e)
        {
            try
            {
                map.Pins.Clear();
                Iservicios myServices = DependencyService.Get<Iservicios>();
                List<Model.clsGastronomia> gastronomia = myServices.getGastronomia();
                foreach (Model.clsGastronomia obclsGastronomia in gastronomia)
                {
                    var position = new Position(Convert.ToDouble(obclsGastronomia.stLatitud), Convert.ToDouble(obclsGastronomia.stLongitud)); // Latitude, Longitude
                    pin = new Pin
                    {

                        Type = PinType.Place,
                        Position = position,
                        Label = obclsGastronomia.stNombre,
                        Address = "Descripcion: " + obclsGastronomia.stDescripcion,
                        BindingContext = AnchorX

                    };

                    pin.Clicked += Pin_Clicked;
                    map.Pins.Add(pin);
                }
                trueorfalse();
            }
            catch (Exception ew)
            {
                throw ew;
            }
        }

        private void TapHistoria_Tapped(object sender, EventArgs e)
        {
            try
            {
                map.Pins.Clear();
                Iservicios myServices = DependencyService.Get<Iservicios>();
                List<Model.clsHistoria> historia = myServices.getHistoria();
                List<Model.clsPersonajesHistoricos> personajes = myServices.getPersonajesHistoricos();
                foreach (Model.clsHistoria obclsHistoria in historia)
                {
                    var position = new Position(Convert.ToDouble(obclsHistoria.stLatitud), Convert.ToDouble(obclsHistoria.stLongitud)); // Latitude, Longitude
                    pin = new Pin
                    {
                       
                        Type = PinType.Place,
                        Position = position,
                        Label = obclsHistoria.stNombre,
                        Address = "Descripción: " + obclsHistoria.stDescripcion,
                        BindingContext = AnchorX

                    };

                    pin.Clicked+=Pin_Clicked;
                    map.Pins.Add(pin);
                }


                foreach (Model.clsPersonajesHistoricos obclsPersonajes in personajes)
                {
                    var position = new Position(Convert.ToDouble(obclsPersonajes.stLatitud), Convert.ToDouble(obclsPersonajes.stLongitud)); // Latitude, Longitude
                     pin = new Pin
                    {

                        Type = PinType.Place,
                        Position = position,
                        Label = obclsPersonajes.stNombre,
                        Address = "Descripción: " + obclsPersonajes.stDescripcion,
                         BindingContext = AnchorX

                     };

                    pin.Clicked += Pin_Clicked;
                    map.Pins.Add(pin);
                }

                trueorfalse();
            }
            catch (Exception ew)
            {
                throw ew;
            }
        }

        private void TapGeografia_Tapped(object sender, EventArgs e)
        {
            try
            {
                map.Pins.Clear();
                Iservicios myServices = DependencyService.Get<Iservicios>();
                List<Model.clsDepartamentos> departamentos = myServices.getDepartamentos();
                foreach (Model.clsDepartamentos obclsDepartamentos in departamentos)
                {
                    var position = new Position(Convert.ToDouble(obclsDepartamentos.stLatitud), Convert.ToDouble(obclsDepartamentos.stLongitud)); // Latitude, Longitude
                    pin = new Pin
                    {

                        Type = PinType.Place,
                        Position = position,
                        Label = obclsDepartamentos.stNombre,
                        Address = "Capital: " + obclsDepartamentos.stCapital,
                        BindingContext = AnchorX

                    };

                    pin.Clicked += Pin_Clicked;
                    map.Pins.Add(pin);
                    map.Icon = "https://images.vexels.com/media/users/3/153168/isolated/preview/ce53e14c82752a3fa9a2940b94518fb9-icono-de-la-escuela-globo-geograf-a-by-vexels.png";
                }
                trueorfalse();
            }
            catch(Exception ew)
            {
                throw ew;
            }
        }

        private void TapMenu_Tapped(object sender, EventArgs e)
        {
            trueorfalse();
        }


        void trueorfalse()
        {
            botonGeografia.IsVisible = !botonGeografia.IsVisible;
            botonGeografia.IsEnabled = !botonGeografia.IsEnabled;

            botonHistoria.IsVisible = !botonHistoria.IsVisible;
            botonHistoria.IsEnabled = !botonHistoria.IsEnabled;

            botonGastronomia.IsVisible = !botonGastronomia.IsVisible;
            botonGastronomia.IsEnabled = !botonGastronomia.IsEnabled;

            botonMusica.IsVisible = !botonMusica.IsVisible;
            botonMusica.IsEnabled = !botonMusica.IsEnabled;

            botonPersonajes.IsVisible = !botonPersonajes.IsVisible;
            botonPersonajes.IsEnabled = !botonPersonajes.IsEnabled;

            botonDeportes.IsVisible = !botonDeportes.IsVisible;
            botonDeportes.IsEnabled = !botonDeportes.IsEnabled;

            botonFauna.IsVisible = !botonFauna.IsVisible;
            botonFauna.IsEnabled = !botonFauna.IsEnabled;

            botonFlora.IsVisible = !botonFlora.IsVisible;
            botonFlora.IsEnabled = !botonFlora.IsEnabled;

            botonCulturas.IsVisible = !botonCulturas.IsVisible;
            botonCulturas.IsEnabled = !botonCulturas.IsEnabled;
        }
    }
}