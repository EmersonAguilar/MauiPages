using MauiPages.Views;

namespace MauiPages
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

           MainPage= new HomeContenPage();
        }
    }
}