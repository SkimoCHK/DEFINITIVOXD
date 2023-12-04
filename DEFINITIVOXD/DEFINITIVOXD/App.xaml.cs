using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using DEFINITIVOXD.Vistas;

namespace DEFINITIVOXD
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new CalcularView();
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
