using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using JaiJinendra.ViewModel;
using MediaManager;
using MediaManager.Library;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace JaiJinendra.Views
{
    public partial class CommonDetailTextPageView : ContentPage
    {
        IMediaItem mediaFile = null;
        CancellationTokenSource cts;
        CommonDetailTextPageViewModel viewModel;
        public CommonDetailTextPageView(string text,string title,string imgSrc,string _audioLink)
        {
            
            InitializeComponent();
            this.BindingContext = viewModel = new CommonDetailTextPageViewModel();
            viewModel.ContentBody = text;
            viewModel.PageTitle = title;
            viewModel.PageImageSrc = imgSrc;
            viewModel.AudioLink = _audioLink;
            var current = Connectivity.NetworkAccess;

            if (_audioLink==string.Empty)
            {
                Layout_AudioButton.IsVisible = false;
            }
            else
            {
                if (current == NetworkAccess.Internet)
                {
                    Layout_AudioButton.IsVisible = true;
                }
               
            }
            




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

        async void Play_Tapped(System.Object sender, System.EventArgs e)
        {
            try
            {

            
            viewModel.AudioPlaying = false;
            viewModel.IsBusy = true;
            //viewModel.getPdfStream();
            var mediaInfo = CrossMediaManager.Current;
            if (mediaFile == null)
            {
                await mediaInfo.Play(viewModel.AudioLink);
            }
            else
            {
                await mediaInfo.Play();
            }
            viewModel.AudioPlaying=true;
            viewModel.IsBusy = false;
            mediaInfo.MediaItemChanged += (sender1, args) =>
            {
                mediaFile = args.MediaItem;
            };
            mediaInfo.MediaItemFinished
                 += (sender1, args) =>
                 {

                     viewModel.AudioPlaying = false;
                     mediaFile = args.MediaItem;
                 };
            }
            catch
            {
                viewModel.IsBusy = false;
                DisplayAlert("", "Can't play audio ", "Done");
            }


        }
        void Pause_Tapped(System.Object sender, System.EventArgs e)
        {
            CrossMediaManager.Current.Pause();
            viewModel.AudioPlaying = false;
        }
    }
}
