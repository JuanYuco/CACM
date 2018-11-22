using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace CACM
{
    public class ContenidoPage : ContentPage
    {
        Xamarin.Forms.ListView listViewUsuario;
        public ContenidoPage()
        {
            StackLayout ContentPrincipal = new StackLayout { };
            listViewUsuario = new Xamarin.Forms.ListView();
            listViewUsuario.ItemsSource = App.lstUsuarios;
            listViewUsuario.ItemTemplate = new DataTemplate(typeof(View));
            listViewUsuario.RowHeight = 60;
            listViewUsuario.IsPullToRefreshEnabled = true;
            listViewUsuario.Refreshing += ListViewUsuario_Refreshing;
            Content = ContentPrincipal;
        }

        private void ListViewUsuario_Refreshing(object sender, EventArgs e)
        {
            ((Xamarin.Forms.ListView)sender).SelectedItem = null;
        }
    }
}