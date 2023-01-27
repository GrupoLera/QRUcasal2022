using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.CommunityToolkit.UI.Views;
using Xamarin.Forms;


namespace QRUcasal2022
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            MyEvents=GetEvents();
            this.BindingContext = this;

        }
        public ObservableCollection<Event> MyEvents { get; set; }

        private ObservableCollection<Event> GetEvents()
        {
            return new ObservableCollection<Event>{
                new Event { Title="Cena Graduados", Image="cena.jpg",Aula="Edificio 4-Aula 1",Duration="18:30 UTC-22:30 UTC", Description="Cena de graduadios Ucasal",Date=DateTime.Parse("11/26/2022")},
                new Event { Title="Charla Minera Ingenieros Industriales", Image="minera.jpg",Aula="Edificio 3-Aula Magna",Duration="13:00 UTC-15:30 UTC", Description="Charla sobre mineras destinado a estudiantes de Ingenieria Industrial",Date=DateTime.Parse("11/20/2022")},
                new Event { Title="Parcial Redes 2", Image="examen.jpg",Aula="Edificio 5-Aula 4",Duration="08:00 UTC-10:00 UTC", Description="Examen escrito a cargo de Armando",Date=DateTime.Parse("11/16/2022")},
                new Event { Title="Charla Hacking Etico", Image="hacking.jpg",Aula="Edificio 3-Aula 2",Duration="20:00 UTC-22:00 UTC", Description="Charla sobre hacking destinado a estudiantes de Ingenieria Informatica",Date=DateTime.Parse("11/21/2022")},

            };
        }

        private async Task OpenAnimation(View view, uint lenght = 250)
        {
            view.RotationX = -90;
            view.IsVisible = true;
            view.Opacity = 0;
            _ = view.FadeTo(1, lenght);
            await view.RotateXTo(0, lenght);
        }
        private async Task CloseAnimation(View view, uint lenght = 250)
        {
            
            _ = view.FadeTo(0,lenght);
            await view.RotateXTo(-90,lenght);
            view.IsVisible = false;
        }

        private async void MainExpander_Tapped(object sender, EventArgs e)
        {
            var expander = sender as Expander;
            var imgView = expander.FindByName<Grid>("ImageView");
            var detailsView = expander.FindByName<Grid>("DetailsView");

            if (expander.IsExpanded)
            {
                await OpenAnimation(imgView);
                await OpenAnimation(detailsView);

            }
            else
            {
                await CloseAnimation(detailsView);
                await CloseAnimation(imgView);
            }
        }
    }

    public class Event
    {
        public string Title { get; set; }
        public string Aula { get; set; }
        public string Duration { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public DateTime Date { get; set; }

    }
}
