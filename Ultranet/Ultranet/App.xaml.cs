using System;
using Ultranet.Screens;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
[assembly: ExportFont("Montserrat-Bold.ttf", Alias = "MontserratBold")]
[assembly: ExportFont("Montserrat-SemiBold.ttf", Alias = "MontserratSemiBold")]
[assembly: ExportFont("Montserrat-Medium.ttf", Alias = "MontserratMedium")]
[assembly: ExportFont("Montserrat-Regular.ttf", Alias = "MontserratRegular")]
[assembly: ExportFont("Montserrat-Light.ttf", Alias = "MontserratLight")]
namespace Ultranet
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new ManageAccounts();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
