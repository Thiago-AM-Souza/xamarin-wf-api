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
    public partial class UpdateCliente : ContentPage
    {
        Cliente Cliente;
        public UpdateCliente(Cliente cliente)
        {
            InitializeComponent();
            Cliente = cliente;
        }

        private async void btnSalvar_Clicked(object sender, EventArgs e)
        {
            ApiService api = new ApiService();

            Cliente.Nome = txtNome.Text;
            Cliente.Email = txtEmail.Text;
            Cliente.Telefone = txtTelefone.Text;

            await api.UpdateCliente(Cliente);
            await Navigation.PushAsync(new ListaClientes());
        }
    }
}