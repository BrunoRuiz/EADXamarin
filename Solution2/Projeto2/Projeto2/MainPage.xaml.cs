using Projeto2.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Projeto2
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void BtnSomar_Clicked(object sender, EventArgs e)
        {
            int numero1 = int.Parse(edtNumero1.Text);
            int numero2 = int.Parse(edtNumero2.Text);

            int result = MyClass.Somar(numero1, numero2);

            lblResultado.Text = "O Resultado é: " + result.ToString();
        }
    }
}
