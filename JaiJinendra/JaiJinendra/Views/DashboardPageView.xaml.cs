using System;
using System.Collections.Generic;
using System.Linq;
using JaiJinendra.StringResources;
using Xamarin.Forms;

namespace JaiJinendra.Views
{
    public partial class DashboardPageView : ContentPage
    {
        List<MenuItems> menu;
        List<CommonListModel> list;
        public DashboardPageView()
        {
            InitializeComponent();
            menu = new List<MenuItems>();
            menu.Add(new MenuItems { SrNo="1",ImageSource = "Browse Products", ColorCodeHex= "#ff6101", TitleEn="Chalisa", TitleHi= "चालीसा संग्रह" });
            menu.Add(new MenuItems { SrNo = "2", ImageSource = "Browse Products", ColorCodeHex = "#fc7f2b", TitleEn = "Chalisa", TitleHi = "आरती  संग्रह" });
            menu.Add(new MenuItems { SrNo = "3", ImageSource = "Browse Products", ColorCodeHex = "#fd9346", TitleEn = "Chalisa", TitleHi = "स्त्रोत" });
            menu.Add(new MenuItems { SrNo = "4", ImageSource = "Browse Products", ColorCodeHex = "#fda766", TitleEn = "Chalisa", TitleHi = "स्त्रोत" });
            menu.Add(new MenuItems { SrNo = "5", ImageSource = "Browse Products", ColorCodeHex = "#fcb777", TitleEn = "Chalisa", TitleHi = "अर्घावली" });
            menu.Add(new MenuItems { SrNo = "6", ImageSource = "Browse Products", ColorCodeHex = "#ff6101", TitleEn = "Chalisa", TitleHi = "भक्ति" });
            menu.Add(new MenuItems { SrNo = "6", ImageSource = "Browse Products", ColorCodeHex = "#fc7f2b", TitleEn = "Chalisa", TitleHi = "ChalisaHindi" });
            menu.Add(new MenuItems { SrNo = "7", ImageSource = "Browse Products", ColorCodeHex = "#fd9346", TitleEn = "Chalisa", TitleHi = "स्तुति " });
            menu.Add(new MenuItems { SrNo = "8", ImageSource = "Browse Products", ColorCodeHex = "#fda766", TitleEn = "Chalisa", TitleHi = "भजन  संग्रहति " });
            Collectionview_Dashboard.ItemsSource = menu;
            //#ff6101
            //#fc7f2b
            //#fd9346
            //#fda766
            //#fcb777
        }

        void Collectionview_Dashboard_SelectionChanged(System.Object sender, Xamarin.Forms.SelectionChangedEventArgs e)
        {
            MenuItems selectedItem = e.CurrentSelection.FirstOrDefault() as MenuItems;
            if(selectedItem != null)
            {
                if (selectedItem.SrNo == "1")
                {
                    SetChalisaList();
                }
            }

             ((Xamarin.Forms.CollectionView)sender).SelectedItem = null;
        }

        void SetChalisaList()
        {
            list = new List<CommonListModel>();
            list.Add(new CommonListModel { SrNo = "1", ImageSource = "Browse Products", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "।।श्री आदिनाथ चालीसा।।", SubTitle="",SubTitleHi="",Body=ChalisaResources.AdinathChalisa });
            list.Add(new CommonListModel { SrNo = "2", ImageSource = "Browse Products", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "।।श्री अजितनाथ चालीसा।।", SubTitle = "", SubTitleHi = "", Body = ChalisaResources.AjitnathChalisa });
            list.Add(new CommonListModel { SrNo = "3", ImageSource = "Browse Products", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "।।श्री सम्भवनाथ चालीसा।।", SubTitle = "", SubTitleHi = "", Body = ChalisaResources.SambhavnathChalisa });
            list.Add(new CommonListModel { SrNo = "4", ImageSource = "Browse Products", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "।।श्री अभिनन्दन नाथ चालीसा।।", SubTitle = "", SubTitleHi = "", Body = ChalisaResources.AbhinandannathChalisa });
            list.Add(new CommonListModel { SrNo = "5", ImageSource = "Browse Products", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "।।श्री सुमतिनाथ चालीसा।।", SubTitle = "", SubTitleHi = "", Body = ChalisaResources.SumatinathChalisa });
            list.Add(new CommonListModel { SrNo = "6", ImageSource = "Browse Products", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "।।श्री पद्मप्रभुजी चालीसा।।", SubTitle = "", SubTitleHi = "", Body = ChalisaResources.Padamprabhuji });
            list.Add(new CommonListModel { SrNo = "7", ImageSource = "Browse Products", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "।।श्री सुपार्श्वनाथ चालीसा।।", SubTitle = "", SubTitleHi = "", Body = ChalisaResources.SuparasnathChalisa });
            list.Add(new CommonListModel { SrNo = "8", ImageSource = "Browse Products", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "।।श्री चन्द्रप्रभु चालीसा।।", SubTitle = "", SubTitleHi = "", Body = ChalisaResources.ChandaprabhuChalisa });
            list.Add(new CommonListModel { SrNo = "9", ImageSource = "Browse Products", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "श्री पुष्पदन्त चालीसा", SubTitle = "", SubTitleHi = "", Body = ChalisaResources.PushpdantChalisa });

            //SambhavnathChalisa
            Navigation.PushAsync(new CommonListPageView(list, "चालीसा संग्रह"));
        }
    }







    public class MenuItems
    {
        public string SrNo { get; set; }
        public string ImageSource { get; set; }
        public string ColorCodeHex { get; set; }
        public string TitleEn { get; set; }
        public string TitleHi { get; set; }
    }

    public class CommonListModel
    {
        public string SrNo { get; set; }
        public string ImageSource { get; set; }
        public string ColorCodeHex { get; set; }
        public string Title { get; set; }
        public string TitleHi { get; set; }
        public string SubTitle { get; set; }
        public string SubTitleHi { get; set; }
        public string Body { get; set; }
        
    }
}
