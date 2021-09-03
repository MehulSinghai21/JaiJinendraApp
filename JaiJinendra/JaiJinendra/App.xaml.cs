using System;
using System.Globalization;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace JaiJinendra
{
    public partial class App : Application
    {
        public App()
        {
            String langName = "hi-IN";//"en-US";// "ar-AE";
            CultureInfo ci = new CultureInfo(langName);
            AppResources.Culture = ci;
            JaiJinendra.StringResources.ChalisaResources.Culture = ci;
            InitializeComponent();

            MainPage = new MasterPage() ;
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
