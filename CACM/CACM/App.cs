using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace CACM
{
    public class App : Application
    {

        public static List<clsUsuarios> lstUsuarios;
        public App()
        {
            lstUsuarios = new List<clsUsuarios>();

            //MainPage = new NavigationPage(new LoginPage(lstUsuarios));
            MainPage = new NavigationPage(new Mapa());
            


         
            //PaginaUno _paginaUno = new PaginaUno();
            //MainPage = _paginaUno;
        }
    }
}