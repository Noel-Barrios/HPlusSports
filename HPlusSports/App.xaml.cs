using System;
using HPlusSports.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace HPlusSports
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // REMEMBRER: the MainPage() constructor is referencing MainPage.xaml (which could be called anything)
            // but the MainPage property you see here, defines the root user interface element from the Xamarin.Forms application context.
            // We could use this property to change the core or main UI element thats being display.   
            //MainPage = new MainPage();
            MainPage = new NavigationPage( new MainPage() );

        }

        protected override void OnStart()
        {
            // Handle when your app starts
            ProductService.LoadWishList();
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
            ProductService.SaveWishList();
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
            ProductService.LoadWishList();

        }
    }
}
