using TODOList.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TODOList.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TarefaPageView : ContentPage
    {
        public TarefaPageView()
        {
            InitializeComponent();
            BindingContext = new TarefaViewModel();
        }

    }
}