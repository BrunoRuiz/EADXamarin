using ConsultaCEP.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ConsultaCEP
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

        private async void Button_Clicked(object sender, EventArgs e)
        {
            if (edtCEP.Text != null && edtCEP.Text.Length == 8)
            {
                lblResultado.TextColor = Color.Blue;
                lblResultado.Text = await ServiceCEP.BuscaCEP(edtCEP.Text);
            }
            else
            {
                lblResultado.TextColor = Color.Red;
                lblResultado.Text = "Cep informado não encontrado ou inválido.";

                //bool result = await DisplayAlert("ERRO", "Cep informado não encontrado ou inválido, Deseja buscar novamente?", "Sim", "Não");
                
                var result = await DisplayActionSheet("Teste do ActionSheet ?", "Cancelar", "Fechar", "Opção A", "Opção B", "Opção C");

                lblResultado.Text = result.ToString();

            }
        }
    }
}
