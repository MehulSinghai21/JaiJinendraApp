using System;
using System.Collections.Generic;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace JaiJinendra.Views
{
    public partial class SponsorDetailPageView : ContentPage
    {
        public SponsorDetailPageView()
        {
            InitializeComponent();
        }

        async void WhatsApp_Tapped(System.Object sender, System.EventArgs e)
        {
      try
            {
                await Browser.OpenAsync("https://wa.me/qr/QSAOQGD4INRUN1", new BrowserLaunchOptions
                {
                    LaunchMode = BrowserLaunchMode.SystemPreferred,
                    TitleMode = BrowserTitleMode.Show,
                    PreferredToolbarColor = Color.Orange,
                    PreferredControlColor = Color.Orange
                });
            }
            catch
            {

            }
        }

        async void Email_Tapped(System.Object sender, System.EventArgs e)
        {
            await Clipboard.SetTextAsync("mehulsinghai21@gmail.com");
            var text = await Clipboard.GetTextAsync();
            DisplayAlert("Copied", text, "Ok");
        }
        async void Phone_Tapped(System.Object sender, System.EventArgs e)
        {
            await Clipboard.SetTextAsync("+91 9754509177");
            var text = await Clipboard.GetTextAsync();
            DisplayAlert("Copied", text, "Ok");
        }

    }
}
