using AppCadastro.API;
using Informacoes;
using Plugin.Connectivity;
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
                if(string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtSenha.Text))
                {
                    await DisplayAlert("Erro", "Informe o email e a senha.", "Ok");
                }
                ListCliente = await ApiService.GetClientes();

                var cliente = ListCliente.Where(x => x.Email.ToLower() == txtEmail.Text.ToLower() && x.Senha == txtSenha.Text).ToList();

                if (cliente.Count == 1)
                {
                    await Navigation.PushAsync(new ListaClientes());
                }
                else
                {
                    await DisplayAlert("Erro", "Login ou senha incorreta.", "Ok");
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