using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JaiJinendra.Views;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace JaiJinendra
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterPage : MasterDetailPage
    {
        List<JaiJinendra.Views.MenuItems> menu;
        public MasterPage()
        {
            InitializeComponent();
            //menu = new List<MenuItems>();

            //menu.Add(new MenuItems { OptionName = "Browse Products" });
            //menu.Add(new MenuItems { OptionName = "Your orders" });
            //menu.Add(new MenuItems { OptionName = "Categories" });
            //menu.Add(new MenuItems { OptionName = "Profile" });
            //menu.Add(new MenuItems { OptionName = "Settings" });
            //menu.Add(new MenuItems { OptionName = "Logout" });

            menu = new List<JaiJinendra.Views.MenuItems>();
            menu.Add(new JaiJinendra.Views.MenuItems { SrNo = "1", ImageSource = "db_chalisa_Black.png", ColorCodeHex = "#ff6101", TitleEn = "Chalisa", TitleHi = "चालीसा संग्रह" });
            menu.Add(new JaiJinendra.Views.MenuItems { SrNo = "2", ImageSource = "db_aarti_black.png", ColorCodeHex = "#fc7f2b", TitleEn = "Aarti", TitleHi = "आरती  संग्रह" });
            menu.Add(new JaiJinendra.Views.MenuItems { SrNo = "3", ImageSource = "db_strotra_black.png", ColorCodeHex = "#fd9346", TitleEn = "Strotra", TitleHi = "स्त्रोत - हिन्दी " });
            menu.Add(new JaiJinendra.Views.MenuItems { SrNo = "4", ImageSource = "db_strotra_black.png", ColorCodeHex = "#fda766", TitleEn = "Strotra", TitleHi = "स्त्रोत" });
            menu.Add(new JaiJinendra.Views.MenuItems { SrNo = "5", ImageSource = "db_aarghawali_black.png", ColorCodeHex = "#fcb777", TitleEn = "Chalisa", TitleHi = "अर्घावली" });
            menu.Add(new JaiJinendra.Views.MenuItems { SrNo = "6", ImageSource = "db_bhakti_black.png", ColorCodeHex = "#ff6101", TitleEn = "Chalisa", TitleHi = "भक्ति" });
            menu.Add(new JaiJinendra.Views.MenuItems { SrNo = "7", ImageSource = "db_bhakti2_black.png", ColorCodeHex = "#fd9346", TitleEn = "Chalisa", TitleHi = "स्तुति " });

            navigationList.ItemsSource = menu;
            //Detail = new NavigationPage(new MainPage(JaiJinendra.StringResources.ChalisaResources.AdinathChalisa))
            //{
            //    BarBackgroundColor = (Color)App.Current.Resources["PrimaryColor"],
            //    BarTextColor = Color.White
            //};
            Detail = new NavigationPage(new DashboardPageView())
            {
                BarBackgroundColor = (Color)App.Current.Resources["PrimaryColor"],
                BarTextColor = Color.White
            };
            SpeakNowDefaultSettings();

        }

        public async Task SpeakNowDefaultSettings()
        {
            try {
                var locales = await TextToSpeech.GetLocalesAsync();

                // Grab the first locale
                var locale = locales.Where(x => x.Language == "hi").FirstOrDefault();

                var settings = new SpeechOptions()
                {
                    Volume = .75f,
                    Pitch = 0.7f,
                    Locale = locale
                };

                await TextToSpeech.SpeakAsync("जय जिनेन्द्र", settings);
            }
            catch
            {

            }


            // This method will block until utterance finishes.
        }

        private void Item_Tapped(object sender, ItemTappedEventArgs e)
        {
            try
            {
                
                //var item = e.Item as MenuItems;

                //switch (item.OptionName)
                //{
                //    case "Browse Products":
                //        {
                //            //Detail = new NavigationPage(new BrowseProducts());
                //            IsPresented = false;
                //        }
                //        break;
                //    case "Categories":
                //        {
                //           // Detail = new NavigationPage(new Categories());
                //            IsPresented = false;
                //        }
                //        break;
                //    case "Profile":
                //        {
                //         //   Detail.Navigation.PushAsync(new Profile());
                //            IsPresented = false;
                //        }
                //        break;
                //}
                IsPresented = false;
                ((CollectionView)sender).SelectedItem = null;
            }
            catch (Exception ex)
            {

            }
        }

        void SendFeedback_Tapped(System.Object sender, System.EventArgs e)
        {
            Detail.Navigation.PushAsync(new SendFeedbackPageView());
            IsPresented = false;
        }

        void Sponsors_Tapped(System.Object sender, System.EventArgs e)
        {
            Detail.Navigation.PushAsync(new SponsorDetailPageView());
            IsPresented = false;
        }


    }


    public class MenuItems
    {
        public string OptionName { get; set; }
    }
}
