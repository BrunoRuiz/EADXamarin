using Projeto3.Model;
using Projeto3.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Projeto3.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListagemPessoaView : ContentPage
    {
        public ListagemPessoaView()
        {
            InitializeComponent();

            BindingContext = new ListagemPessoaViewModel();
        }

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            PessoaModel pessoa = e.Item as PessoaModel;

            Navigation.PushAsync(new PessoaView(pessoa));
        }
    }
}