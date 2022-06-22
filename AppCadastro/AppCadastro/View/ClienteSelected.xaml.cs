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
        public ClienteSelected()
        {
            InitializeComponent();
        }
        public async void ExibirInfo()
        {
            Cliente cliente = await ApiService.ObterClienteById(1);
            //OnPropertyChanged(nameof());
        }
    }
}