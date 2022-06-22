using AppCadastro.API;
using AppCadastro.Cell;
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
    public partial class ListaClientes : ContentPage
    {
        public List<Cliente> ListaCliente;
        public ListaClientes()
        {
            InitializeComponent();
            ListaCliente = new List<Cliente>();
            ListViewCliente.ItemTemplate = new DataTemplate(typeof(ClienteCell));
            ListViewCliente.RowHeight = 120;
            ListViewCliente.ItemSelected += ListViewCliente_ItemSelect;
        }

        public async void CarregarClientes()
        {
            ListaCliente = await ApiService.ObterCliente();
            ListViewCliente.ItemsSource = ListaCliente.OrderBy(x => x.Nome).ToList();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            CarregarClientes();
        }

        private async void ListViewCliente_ItemSelect(object sender, SelectedItemChangedEventArgs e)
        {
            await Navigation.PushAsync(new ClienteSelected());

        }

        private void PesquisaCliente_TextChanged(object sender, TextChangedEventArgs e)
        {
            string textopesquisa = pesquisaCliente.Text;
            ListViewCliente.ItemsSource = ListaCliente.Where(x => x.Nome.ToLower().Contains(textopesquisa.ToLower())).ToList();
        }

        private void btnAtualizar_Clicked(object sender, EventArgs e)
        {

        }
    }
}