using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace CACM
{
    public class App : Application
    {

        public static List<Usuario> lstUsuarios;
        public App()
        {
            lstUsuarios = new List<Usuario>();

            MainPage = new NavigationPage(new LoginPage(lstUsuarios));
            


         
            //PaginaUno _paginaUno = new PaginaUno();
            //MainPage = _paginaUno;
        }
    }
}