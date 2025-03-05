using sirocco.matmod.ViewModels;

namespace sirocco.matmod.Pages
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new ReadinessModelViewModel(); 
        }
    }
}





