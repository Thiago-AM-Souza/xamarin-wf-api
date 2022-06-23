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
    public partial class ClienteSelected : ContentPage
    {
        Cliente Cliente;
        public ClienteSelected(Cliente cliente)
        {
            InitializeComponent();
            Cliente = cliente;
            ExibirInfo();
        }
        public async void ExibirInfo()
        {
            txtNome.Text = $"Nome: {Cliente.Nome}";
            txtEmail.Text = $"Email: {Cliente.Email}";
            txtTelefone.Text = $"Telefone: {Cliente.Telefone}";
        }

        private async void btnAtualizarCadastro_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new UpdateCliente(Cliente));
        }

        private async void btnDelete_Clicked(object sender, EventArgs e)
        {
            var escolha = await DisplayActionSheet("EXCLUIR REGISTRO", "Não", "Sim", $"Tem certeza que deseja excluir o registro de {Cliente.Nome.ToUpper()}?");
            if (escolha.ToUpper() == "SIM")
            {
                ApiService api = new ApiService();
                await api.DeleteCliente(Cliente);
                await Navigation.PushAsync(new ListaClientes());
            }
        }

        //private void 
    }
}