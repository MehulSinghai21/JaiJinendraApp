using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace JaiJinendra.ViewModel
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public BaseViewModel()
        {
            // _PopupCloseCommand = new Command(OnPopupCloseTap);
        }

        private bool _isBusy;
        public bool IsBusy
        {
            get { return _isBusy; }
            set
            {
                _isBusy = value;
                OnPropertyChanged();
            }
        }


        //ICommand _PopupCloseCommand { get; set; }
        //public ICommand PopupCloseCommand
        //{
        //    get { return _PopupCloseCommand; }
        //}
        //private void OnPopupCloseTap(object obj)
        //{
        //    try
        //    {
        //        var popup = obj as ContentView;
        //        popup.IsVisible = !popup.IsVisible;
        //    }
        //    catch (Exception ex)
        //    {
        //        Utils.ExceptionHandler(ex);
        //    }
        //    //throw new NotImplementedException();
        //}
        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            var changed = PropertyChanged;
            if (changed == null)
                return;

            changed.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

        //public async void RedirectErrorPage(string Message)
        //{
        //    if (Message == Constant.MsgTimeout || Message == Constant.MsgInternalServerError && PopupNavigation.Instance.PopupStack.Count == 0)
        //        await PopupNavigation.Instance.PushAsync(new ServerErrorPopup(true));
        //    else if (Message == Constant.MsgSocketException && PopupNavigation.Instance.PopupStack.Count == 0)
        //        await PopupNavigation.Instance.PushAsync(new ServerErrorPopup(true));
        //}


        /*push Notification*/
        //async void LocalNotification(int notificationCounter)
        //{
        //    try
        //    {
        //        await Task.Run(() =>
        //        {
        //            if (notificationCounter > 0)
        //            {
        //                if (notificationCounter != App.oldNotificationCounter)
        //                {
        //                    App.oldNotificationCounter = notificationCounter;
        //                    var notification = new NotificationRequest
        //                    {
        //                        NotificationId = 1,
        //                        Title = "Notification",
        //                        BadgeNumber = notificationCounter,
        //                        Description = "Pending Notification :" + notificationCounter.ToString(),
        //                        ReturningData = "", // Returning data when tapped on notification.
        //                        NotifyTime = DateTime.Now// Used for Scheduling local notification.
        //                    };
        //                    NotificationCenter.Current.Show(notification);
        //                    new DashboardViewModel().SetReceivedReminderData();
        //                }
        //            }
        //            else
        //            {
        //                NotificationCenter.Current.CancelAll();
        //            }
        //        });
        //    }
        //    catch (Exception ex)
        //    {
        //        Utils.ExceptionHandler(ex);
        //    }
        //}
    }
}
