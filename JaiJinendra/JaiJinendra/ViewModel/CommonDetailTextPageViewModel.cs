using System;
using MediaManager;
using MediaManager.Library;

namespace JaiJinendra.ViewModel
{
    public class CommonDetailTextPageViewModel: BaseViewModel   
    {
        private string _ContentBody = String.Empty;
        public string ContentBody
        {
            get
            {
                return
                _ContentBody;
            }
            set
            {
                _ContentBody = value;
                OnPropertyChanged("ContentBody");

            }
        }

        private string _pageTitle = String.Empty;
        public string PageTitle
        {
            get
            {
                return
                _pageTitle;
            }
            set
            {
                _pageTitle = value;
                OnPropertyChanged("PageTitle");

            }
        }

        private bool _isAudioPlaying = false;
        public bool AudioPlaying
        {
            get
            {
                return
                _isAudioPlaying;
            }
            set
            {
                _isAudioPlaying = value;
                OnPropertyChanged("AudioPlaying");

            }
        }


        private string _PageImageSrc = String.Empty;
        public string PageImageSrc
        {
            get
            {
                return
                _PageImageSrc;
            }
            set
            {
                _PageImageSrc = value;
                OnPropertyChanged("PageImageSrc");

            }
        }
        private string _audioLink = String.Empty;
        public string AudioLink
        {
            get
            {
                return
                _audioLink;
            }
            set
            {
                _audioLink = value;
                OnPropertyChanged("AudioLink");

            }
        }
        IMediaItem mediaFile = null;

        public CommonDetailTextPageViewModel()
        {
        }

        async void Button_Play_Clicked(System.Object sender, System.EventArgs e)
        {
            var mediaInfo = CrossMediaManager.Current;
            await mediaInfo.Play("https://drive.google.com/uc?export=download&id=1ofeDNXEZz7MHDXj6ftKEBFduxqBOpG8e");
            //var mediaInfo1 = CrossMediaManager.Current;
            //if (mediaFile1 == null)
            //{
            //    await mediaInfo.Play(audioLink);
            //}
            //else
            //{
            //    await mediaInfo.Play();
            //}
        }



    }
}
