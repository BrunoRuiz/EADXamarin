using Projeto3.Model;
using Projeto3.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Projeto3
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class PessoaView : ContentPage
    {
        public PessoaView(PessoaModel pessoa)
        {
            InitializeComponent();

            BindingContext = new PessoaViewModel(pessoa);
        }
    }
}
