using System;
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


        public CommonDetailTextPageViewModel()
        {
        }

    }
}
