using AppCadastro.API;
using Plugin.Connectivity;
using Servico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppCadastro.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        List<Cliente> ListCliente;
        public LoginPage()
        {
            InitializeComponent();
            ListCliente = new List<Cliente>();

        }

        public async void Logar()
        {
            if (CrossConnectivity.Current.IsConnected)
            {
                ListCliente = await ApiService.ObterCliente();

                var cliente = ListCliente.Where(x => x.email == txtEmail.Text && x.senha == txtSenha.Text).ToList();

                if (cliente.Count > 0)
                {
                    await Navigation.PushAsync(new ListaClientes());
                }
                else
                {
                    await DisplayAlert("Erro", "Login ou senha errado", "Ok");
                }
            }
            else
            {
                await DisplayAlert("Erro", "Sem conexão com a internet.", "Ok");
            }
        }

        private void btnLogin_Clicked(object sender, EventArgs e)
        {
            Logar();
        }
    }
}