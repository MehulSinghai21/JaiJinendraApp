using System;
using System.Collections.Generic;
using JaiJinendra.Views;

namespace JaiJinendra.ViewModel
{
    public class CommonListPageViewModel: BaseViewModel
    {
        private List<CommonListModel> _incomingList;
        public List<CommonListModel> IncomingList
        {
            get
            {
                return
                _incomingList;
            }
            set
            {
                _incomingList = value;
                OnPropertyChanged("IncomingList");

            }
        }
        public CommonListPageViewModel()
        {
        }
    }
}
