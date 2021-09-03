using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using JaiJinendra.ViewModel;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace JaiJinendra.Views
{
    public partial class CommonDetailTextPageView : ContentPage
    {
        CancellationTokenSource cts;
        CommonDetailTextPageViewModel viewModel;
        public CommonDetailTextPageView(string text,string title)
        {
            
            InitializeComponent();
            this.BindingContext = viewModel = new CommonDetailTextPageViewModel();
            viewModel.ContentBody = text;
            viewModel.PageTitle = title;
            
            
        }

        async void TapGestureRecognizer_Tapped(System.Object sender, System.EventArgs e)
        {
            var locales = await TextToSpeech.GetLocalesAsync();

            // Grab the first locale
            var locale = locales.Where(x=>x.Language=="hi").FirstOrDefault();

            var settings = new SpeechOptions()
            {
                Volume = .75f,
                Pitch = 1.0f,
                Locale = locale
            };
            cts = new CancellationTokenSource();
            await TextToSpeech.SpeakAsync(viewModel.ContentBody, cancelToken: cts.Token);
        }
    }
}
