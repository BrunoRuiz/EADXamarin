using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Projeto5.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WebViewPage : ContentPage
    {
        public WebViewPage()
        {
            InitializeComponent();

            var paginaHTML = new HtmlWebViewSource();
            paginaHTML.Html = @"<html><body>
                Esta Tela é um WebView Executando nosso HTML local.
                </body></html>";

            webView.Source = paginaHTML;
        }
    }
}