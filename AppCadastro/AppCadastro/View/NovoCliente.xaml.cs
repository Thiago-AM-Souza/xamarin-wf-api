using AppCadastro.API;
using Informacoes;
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
    public partial class NovoCliente : ContentPage
    {
        public NovoCliente()
        {
            InitializeComponent();
        }

        private async void btnSalvar_Clicked(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            ApiService api = new ApiService();

            cliente.Nome = txtNome.Text;
            cliente.Email = txtEmail.Text;
            cliente.Telefone = txtTelefone.Text;
            cliente.Senha = txtSenha.Text;

            await api.PostCliente(cliente);
            await Navigation.PushAsync(new ListaClientes());
        }
    }
}