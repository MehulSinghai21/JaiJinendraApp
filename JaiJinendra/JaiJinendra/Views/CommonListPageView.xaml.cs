using System;
using System.Collections.Generic;
using System.Linq;
using JaiJinendra.ViewModel;
using Xamarin.Forms;

namespace JaiJinendra.Views
{
    public partial class CommonListPageView : ContentPage
    {
        //List<CommonListModel> incomingList;
        CommonListPageViewModel viewModel;
        public CommonListPageView(List<CommonListModel> _incomingList,string title)
        {

            InitializeComponent();
            this.BindingContext = viewModel = new CommonListPageViewModel();
            CommonListPage.Title = string.Empty;
            viewModel.IncomingList = _incomingList;
            CommonListPage.Title = title;
           // CollectionView_CommonList.ItemsSource = incomingList;
        }

        void CollectionView_CommonList_SelectionChanged(System.Object sender, Xamarin.Forms.SelectionChangedEventArgs e)
        {
            CommonListModel selectedItem = e.CurrentSelection.FirstOrDefault() as CommonListModel;
            if(selectedItem!=null)
            {
                Navigation.PushAsync(new CommonDetailTextPageView(selectedItem.Body,selectedItem.TitleHi,selectedItem.ImageSource,selectedItem.AudioFileLink));
                if (sender is CollectionView lv) lv.SelectedItem = null;
            }
            
        }
    }
}
