using comida_proyectos.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace comida_proyectos.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BebidasPage : ContentPage
    {
        public BebidasPage()
        {
            InitializeComponent();
            GetCategoria();


        }

        private async void GetCategoria()
        {
            HttpClient client = new HttpClient();
            var response = await client.GetStringAsync("http://localhost:3000/api/producto/bebida");
            var helado = JsonConvert.DeserializeObject<List<producto>>(response);
            ListaBebida.ItemsSource = helado;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Ver_ProductoPage());
        }
    }
}