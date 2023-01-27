using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace QRUcasal2022
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if(txtUsuario.Text=="admin" && txtPassword.Text=="123")
            {
                Navigation.PushAsync(new PaginaPestanias());
            }
            else
            {
                DisplayAlert("Error", "Usuario Incorrecto", "Aceptar");
            }
        }

       
    }
}