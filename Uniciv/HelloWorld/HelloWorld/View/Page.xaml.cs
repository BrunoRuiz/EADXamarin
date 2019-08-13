
using HelloWorld.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page : ContentPage
    {
        public Page()
        {
            InitializeComponent();
            BindingContext = new CursosViewModel();
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            ((ListView)sender).SelectedItem = null;

        }
    }
}