using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace JaiJinendra
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterPage : MasterDetailPage
    {
        List<MenuItems> menu;
        public MasterPage()
        {
            InitializeComponent();
            menu = new List<MenuItems>();

            menu.Add(new MenuItems { OptionName = "Browse Products" });
            menu.Add(new MenuItems { OptionName = "Your orders" });
            menu.Add(new MenuItems { OptionName = "Categories" });
            menu.Add(new MenuItems { OptionName = "Profile" });
            menu.Add(new MenuItems { OptionName = "Settings" });
            menu.Add(new MenuItems { OptionName = "Logout" });
            navigationList.ItemsSource = menu;
            Detail = new NavigationPage(new MainPage(AppResources.Language))
            {
                BarBackgroundColor = (Color)App.Current.Resources["PrimaryColor"],
                BarTextColor = Color.White
            }; ;
        }

        private void Item_Tapped(object sender, ItemTappedEventArgs e)
        {
            try
            {
                var item = e.Item as MenuItems;

                switch (item.OptionName)
                {
                    case "Browse Products":
                        {
                            //Detail = new NavigationPage(new BrowseProducts());
                            IsPresented = false;
                        }
                        break;
                    case "Categories":
                        {
                           // Detail = new NavigationPage(new Categories());
                            IsPresented = false;
                        }
                        break;
                    case "Profile":
                        {
                         //   Detail.Navigation.PushAsync(new Profile());
                            IsPresented = false;
                        }
                        break;
                }
            }
            catch (Exception ex)
            {

            }
        }
    }


    public class MenuItems
    {
        public string OptionName { get; set; }
    }
}
