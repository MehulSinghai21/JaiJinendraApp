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
            menu.Add(new MenuItems { SrNo="1",ImageSource = "db_chalisa_Black.png", ColorCodeHex= "#ff6101", TitleEn="Chalisa", TitleHi= "चालीसा संग्रह", AudioFileLink= "https://drive.google.com/uc?export=download&id=1ofeDNXEZz7MHDXj6ftKEBFduxqBOpG8e" });
            menu.Add(new MenuItems { SrNo = "2", ImageSource = "db_aarti_black.png", ColorCodeHex = "#fc7f2b", TitleEn = "Aarti", TitleHi = "आरती  संग्रह", AudioFileLink = "https://drive.google.com/uc?export=download&id=1ofeDNXEZz7MHDXj6ftKEBFduxqBOpG8e" });
            menu.Add(new MenuItems { SrNo = "3", ImageSource = "db_strotra_black.png", ColorCodeHex = "#fd9346", TitleEn = "Strotra", TitleHi = "स्त्रोत - हिन्दी " , AudioFileLink = "https://drive.google.com/uc?export=download&id=1ofeDNXEZz7MHDXj6ftKEBFduxqBOpG8e" });
            menu.Add(new MenuItems { SrNo = "4", ImageSource = "db_strotra_black.png", ColorCodeHex = "#fda766", TitleEn = "Strotra", TitleHi = "स्त्रोत - संस्कृति" , AudioFileLink = "https://drive.google.com/uc?export=download&id=1ofeDNXEZz7MHDXj6ftKEBFduxqBOpG8e" });
            menu.Add(new MenuItems { SrNo = "5", ImageSource = "db_aarghawali_black.png", ColorCodeHex = "#fcb777", TitleEn = "Chalisa", TitleHi = "अर्घावली", AudioFileLink = "https://drive.google.com/uc?export=download&id=1ofeDNXEZz7MHDXj6ftKEBFduxqBOpG8e" });
            menu.Add(new MenuItems { SrNo = "6", ImageSource = "db_bhakti_black.png", ColorCodeHex = "#ff6101", TitleEn = "Chalisa", TitleHi = "भक्ति", AudioFileLink = "https://drive.google.com/uc?export=download&id=1ofeDNXEZz7MHDXj6ftKEBFduxqBOpG8e" });
            menu.Add(new MenuItems { SrNo = "7", ImageSource = "db_bhakti2_black.png", ColorCodeHex = "#fd9346", TitleEn = "Chalisa", TitleHi = "स्तुति " , AudioFileLink = "https://drive.google.com/uc?export=download&id=1ofeDNXEZz7MHDXj6ftKEBFduxqBOpG8e" });
            //menu.Add(new MenuItems { SrNo = "8", ImageSource = "Browse Products", ColorCodeHex = "#fda766", TitleEn = "Chalisa", TitleHi = "भजन  संग्रहति " });
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
                if (selectedItem.SrNo == "2")
                {
                    SetAarti();
                }
                if (selectedItem.SrNo == "3")
                {
                    SetStrotraHindi();
                }
                if (selectedItem.SrNo == "4")
                {
                    SetStrotraSanskrit();
                }
                if (selectedItem.SrNo == "6")
                {
                    SetBhaktiHindi();
                }
                if (selectedItem.SrNo == "7")
                {
                    SetStuti();
                }
                



            }

             ((Xamarin.Forms.CollectionView)sender).SelectedItem = null;
        }

        void SetChalisaList()
        {
            list = new List<CommonListModel>();
            list.Add(new CommonListModel { SrNo = "1", ImageSource = "db_chalisa_Black.png", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "।।श्री आदिनाथ चालीसा।।", SubTitle="",SubTitleHi="",Body=ChalisaResources.AdinathChalisa , AudioFileLink = "https://drive.google.com/uc?export=download&id=1JHrQZ7Cr9Wtk4zVfZsSrsenBATMGv5FB" });
            list.Add(new CommonListModel { SrNo = "2", ImageSource = "db_chalisa_Black.png", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "।।श्री अजितनाथ चालीसा।।", SubTitle = "", SubTitleHi = "", Body = ChalisaResources.AjitnathChalisa, AudioFileLink = "https://drive.google.com/uc?export=download&id=1ofeDNXEZz7MHDXj6ftKEBFduxqBOpG8e" });
            list.Add(new CommonListModel { SrNo = "3", ImageSource = "db_chalisa_Black.png", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "।।श्री सम्भवनाथ चालीसा।।", SubTitle = "", SubTitleHi = "", Body = ChalisaResources.SambhavnathChalisa, AudioFileLink = "https://drive.google.com/uc?export=download&id=1ofeDNXEZz7MHDXj6ftKEBFduxqBOpG8e" });
            list.Add(new CommonListModel { SrNo = "4", ImageSource = "db_chalisa_Black.png", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "।।श्री अभिनन्दन नाथ चालीसा।।", SubTitle = "", SubTitleHi = "", Body = ChalisaResources.AbhinandannathChalisa, AudioFileLink = "https://drive.google.com/uc?export=download&id=1ofeDNXEZz7MHDXj6ftKEBFduxqBOpG8e" });
            list.Add(new CommonListModel { SrNo = "5", ImageSource = "db_chalisa_Black.png", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "।।श्री सुमतिनाथ चालीसा।।", SubTitle = "", SubTitleHi = "", Body = ChalisaResources.SumatinathChalisa, AudioFileLink = "https://drive.google.com/uc?export=download&id=1ofeDNXEZz7MHDXj6ftKEBFduxqBOpG8e" });
            list.Add(new CommonListModel { SrNo = "6", ImageSource = "db_chalisa_Black.png", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "।।श्री पद्मप्रभुजी चालीसा।।", SubTitle = "", SubTitleHi = "", Body = ChalisaResources.Padamprabhuji, AudioFileLink = "https://drive.google.com/uc?export=download&id=1ofeDNXEZz7MHDXj6ftKEBFduxqBOpG8e" });
            list.Add(new CommonListModel { SrNo = "7", ImageSource = "db_chalisa_Black.png", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "।।श्री सुपार्श्वनाथ चालीसा।।", SubTitle = "", SubTitleHi = "", Body = ChalisaResources.SuparasnathChalisa, AudioFileLink = "https://drive.google.com/uc?export=download&id=1ofeDNXEZz7MHDXj6ftKEBFduxqBOpG8e" });
            list.Add(new CommonListModel { SrNo = "8", ImageSource = "db_chalisa_Black.png", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "।।श्री चन्द्रप्रभु चालीसा।।", SubTitle = "", SubTitleHi = "", Body = ChalisaResources.ChandaprabhuChalisa, AudioFileLink = "https://drive.google.com/uc?export=download&id=1ofeDNXEZz7MHDXj6ftKEBFduxqBOpG8e" });
            list.Add(new CommonListModel { SrNo = "9", ImageSource = "db_chalisa_Black.png", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "।।श्री पुष्पदन्त चालीसा।।", SubTitle = "", SubTitleHi = "", Body = ChalisaResources.PushpdantChalisa, AudioFileLink = "https://drive.google.com/uc?export=download&id=1ofeDNXEZz7MHDXj6ftKEBFduxqBOpG8e" });
            list.Add(new CommonListModel { SrNo = "10", ImageSource = "db_chalisa_Black.png ", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "।।श्री शीतलनाथ चालीसा।।", SubTitle = "", SubTitleHi = "", Body = ChalisaResources.SheetalnathChalisa, AudioFileLink = "https://drive.google.com/uc?export=download&id=1ofeDNXEZz7MHDXj6ftKEBFduxqBOpG8e" });
            list.Add(new CommonListModel { SrNo = "11", ImageSource = "db_chalisa_Black.png", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "।।श्री श्रेयान्सनाथ चालीसा।।", SubTitle = "", SubTitleHi = "", Body = ChalisaResources.ShreyansnathChalisa, AudioFileLink = "https://drive.google.com/uc?export=download&id=1ofeDNXEZz7MHDXj6ftKEBFduxqBOpG8e" });
            list.Add(new CommonListModel { SrNo = "12", ImageSource = "db_chalisa_Black.png", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "।।श्री वासुपूज्य चालीसा।।", SubTitle = "", SubTitleHi = "", Body = ChalisaResources.VasupujyaChalisa, AudioFileLink = "https://drive.google.com/uc?export=download&id=1ofeDNXEZz7MHDXj6ftKEBFduxqBOpG8e" });
            list.Add(new CommonListModel { SrNo = "13", ImageSource = "db_chalisa_Black.png", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "।।श्री विमलनाथ चालीसा।।", SubTitle = "", SubTitleHi = "", Body = ChalisaResources.VimalnathChalisa, AudioFileLink = "https://drive.google.com/uc?export=download&id=1ofeDNXEZz7MHDXj6ftKEBFduxqBOpG8e" });
            list.Add(new CommonListModel { SrNo = "14", ImageSource = "db_chalisa_Black.png", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "।।श्री अनन्तनाथ चलीसा।।", SubTitle = "", SubTitleHi = "", Body = ChalisaResources.Anantnath, AudioFileLink = "https://drive.google.com/uc?export=download&id=1ofeDNXEZz7MHDXj6ftKEBFduxqBOpG8e" });
            list.Add(new CommonListModel { SrNo = "15", ImageSource = "db_chalisa_Black.png ", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "।।श्री धर्मनाथ चालीसा।।", SubTitle = "", SubTitleHi = "", Body = ChalisaResources.DharmanathaChalisa, AudioFileLink = "https://drive.google.com/uc?export=download&id=1ofeDNXEZz7MHDXj6ftKEBFduxqBOpG8e" });
            list.Add(new CommonListModel { SrNo = "16", ImageSource = "db_chalisa_Black.png", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "।।श्री शान्तिनाथ चालीसा।।", SubTitle = "", SubTitleHi = "", Body = ChalisaResources.ShantinathChalisa, AudioFileLink = "https://drive.google.com/uc?export=download&id=1ofeDNXEZz7MHDXj6ftKEBFduxqBOpG8e" });
            list.Add(new CommonListModel { SrNo = "17", ImageSource = "db_chalisa_Black.png", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "।।श्री कुन्थनाथ चालीसा।।", SubTitle = "", SubTitleHi = "", Body = ChalisaResources.KunthunathChalisa, AudioFileLink = "https://drive.google.com/uc?export=download&id=1ofeDNXEZz7MHDXj6ftKEBFduxqBOpG8e" });
            list.Add(new CommonListModel { SrNo = "18", ImageSource = "db_chalisa_Black.png", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "।।श्री अरहनाथ चालीसा।।", SubTitle = "", SubTitleHi = "", Body = ChalisaResources.ArahnathChalisa, AudioFileLink = "https://drive.google.com/uc?export=download&id=1ofeDNXEZz7MHDXj6ftKEBFduxqBOpG8e" });
            list.Add(new CommonListModel { SrNo = "19", ImageSource = "db_chalisa_Black.png", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "।।श्री मल्लिनाथ चालीसा।।", SubTitle = "", SubTitleHi = "", Body = ChalisaResources.MallinathChalisa, AudioFileLink = "https://drive.google.com/uc?export=download&id=1ofeDNXEZz7MHDXj6ftKEBFduxqBOpG8e" });
            list.Add(new CommonListModel { SrNo = "20", ImageSource = "db_chalisa_Black.png", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "।।श्री मुनिसुव्रतनाथ चालीसा।।", SubTitle = "", SubTitleHi = "", Body = ChalisaResources.MunisuvrathChalisa, AudioFileLink = "https://drive.google.com/uc?export=download&id=1ofeDNXEZz7MHDXj6ftKEBFduxqBOpG8e" });
            list.Add(new CommonListModel { SrNo = "21", ImageSource = "db_chalisa_Black.png", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "।।श्री नमिनाथ चालीसा।।", SubTitle = "", SubTitleHi = "", Body = ChalisaResources.NaminathChalisa, AudioFileLink = "https://drive.google.com/uc?export=download&id=1ofeDNXEZz7MHDXj6ftKEBFduxqBOpG8e" });
            list.Add(new CommonListModel { SrNo = "22", ImageSource = "db_chalisa_Black.png", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "।।श्री नेमिनाथ चालीसा।।", SubTitle = "", SubTitleHi = "", Body = ChalisaResources.NeminathChalisa, AudioFileLink = "https://drive.google.com/uc?export=download&id=1ofeDNXEZz7MHDXj6ftKEBFduxqBOpG8e" });
            list.Add(new CommonListModel { SrNo = "23", ImageSource = "db_chalisa_Black.png", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "।।श्री पार्श्वनाथ चालीसा।।", SubTitle = "", SubTitleHi = "", Body = ChalisaResources.ParshvnathChalisa, AudioFileLink = "https://drive.google.com/uc?export=download&id=1ofeDNXEZz7MHDXj6ftKEBFduxqBOpG8e" });
            list.Add(new CommonListModel { SrNo = "23", ImageSource = "db_chalisa_Black.png", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "।।श्री महावीर चालीसा।।", SubTitle = "", SubTitleHi = "", Body = ChalisaResources.MahaviraChalisa, AudioFileLink = "https://drive.google.com/uc?export=download&id=1IX3Q7Rz-wZMKbCq9nec_vv0O3oryjatr" });
            //KunthunathChalisa

            //SambhavnathChalisa
            Navigation.PushAsync(new CommonListPageView(list,    "चालीसा संग्रह"));
        }


        void SetAarti()
        {
            list = new List<CommonListModel>();
            list.Add(new CommonListModel { SrNo = "1", ImageSource = "db_aarti_black.png", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "-:  श्री आदिनाथ भगवान की आरती  :-", SubTitle = "", SubTitleHi = "", Body = AppResources.aarti_adinathswami, AudioFileLink = "https://drive.google.com/uc?export=download&id=1ofeDNXEZz7MHDXj6ftKEBFduxqBOpG8e" });
            list.Add(new CommonListModel { SrNo = "2", ImageSource = "db_aarti_black.png", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "-: श्री चंद्रप्रभु भगवान की आरती :-", SubTitle = "", SubTitleHi = "", Body = AppResources.aarti_chandraprabhu, AudioFileLink = "https://drive.google.com/uc?export=download&id=1ofeDNXEZz7MHDXj6ftKEBFduxqBOpG8e" });
            list.Add(new CommonListModel { SrNo = "3", ImageSource = "db_aarti_black.png", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "-: श्री चंद्रप्रभु भगवान की आरती :-", SubTitle = "", SubTitleHi = "", Body = AppResources.aarti_chandraprabhudeva, AudioFileLink = "https://drive.google.com/uc?export=download&id=1ofeDNXEZz7MHDXj6ftKEBFduxqBOpG8e" });
            list.Add(new CommonListModel { SrNo = "4", ImageSource = "db_aarti_black.png", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "-: श्री धर्मनाथ भगवान की आरती  :-", SubTitle = "", SubTitleHi = "", Body = AppResources.aarti_dharmanathbhagwan, AudioFileLink = "https://drive.google.com/uc?export=download&id=1ofeDNXEZz7MHDXj6ftKEBFduxqBOpG8e" });
            list.Add(new CommonListModel { SrNo = "5", ImageSource = "db_aarti_black.png", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "-: श्री जिनवाणी माता की आरती  :-", SubTitle = "", SubTitleHi = "", Body = AppResources.aarti_jinvanimata, AudioFileLink = "https://drive.google.com/uc?export=download&id=1ofeDNXEZz7MHDXj6ftKEBFduxqBOpG8e" });
            list.Add(new CommonListModel { SrNo = "6", ImageSource = "db_aarti_black.png", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "-: श्री महावीर स्वामी आरती :-", SubTitle = "", SubTitleHi = "", Body = AppResources.aarti_mahavir, AudioFileLink = "https://drive.google.com/uc?export=download&id=1ofeDNXEZz7MHDXj6ftKEBFduxqBOpG8e" });
            list.Add(new CommonListModel { SrNo = "7", ImageSource = "db_aarti_black.png", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "-:  श्री मुनिसुब्रत नाथ भगवान की आरती :-", SubTitle = "", SubTitleHi = "", Body = AppResources.aarti_munisuvratnath, AudioFileLink = "https://drive.google.com/uc?export=download&id=1ofeDNXEZz7MHDXj6ftKEBFduxqBOpG8e" });
            list.Add(new CommonListModel { SrNo = "8", ImageSource = "db_aarti_black.png", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "-: श्री नेमिनाथ भगवान की आरती :-", SubTitle = "", SubTitleHi = "", Body = AppResources.aarti_neminath_bhagwan, AudioFileLink = "https://drive.google.com/uc?export=download&id=1ofeDNXEZz7MHDXj6ftKEBFduxqBOpG8e" });
            list.Add(new CommonListModel { SrNo = "9", ImageSource = "db_aarti_black.png", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "-: श्री पारसनाथ भगवान आरती :-", SubTitle = "", SubTitleHi = "", Body = AppResources.aarti_parasnath, AudioFileLink = "https://drive.google.com/uc?export=download&id=1ofeDNXEZz7MHDXj6ftKEBFduxqBOpG8e" });
            list.Add(new CommonListModel { SrNo = "10", ImageSource = "db_aarti_black.png", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "-: श्री सन्मति प्रभु की आरती :-", SubTitle = "", SubTitleHi = "", Body = AppResources.aarti_sanmati_prabhu, AudioFileLink = "https://drive.google.com/uc?export=download&id=1ofeDNXEZz7MHDXj6ftKEBFduxqBOpG8e" });
            list.Add(new CommonListModel { SrNo = "11", ImageSource = "db_aarti_black.png", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "-: श्री शांतिनाथ भगवान की आरती :-", SubTitle = "", SubTitleHi = "", Body = AppResources.aarti_shantinath_bhagwan, AudioFileLink = "https://drive.google.com/uc?export=download&id=1ofeDNXEZz7MHDXj6ftKEBFduxqBOpG8e" });
            list.Add(new CommonListModel { SrNo = "12", ImageSource = "db_aarti_black.png", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "-: श्री शीतलनाथ भगवान की आरती :-", SubTitle = "", SubTitleHi = "", Body = AppResources.aarti_sheetalnath_bhagwan, AudioFileLink = "https://drive.google.com/uc?export=download&id=1ofeDNXEZz7MHDXj6ftKEBFduxqBOpG8e" });
            list.Add(new CommonListModel { SrNo = "13", ImageSource = "db_aarti_black.png", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "-: श्री पंच परमेष्ठी आरती  :-", SubTitle = "", SubTitleHi = "", Body = AppResources.aarti_shripanchparmeshthi, AudioFileLink = "https://drive.google.com/uc?export=download&id=1ofeDNXEZz7MHDXj6ftKEBFduxqBOpG8e" });
            list.Add(new CommonListModel { SrNo = "14", ImageSource = "db_aarti_black.png", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "-: श्री विद्यासागर महाराज आरती :-", SubTitle = "", SubTitleHi = "", Body = AppResources.aarti_trikaalchaubisi, AudioFileLink = "https://drive.google.com/uc?export=download&id=1ofeDNXEZz7MHDXj6ftKEBFduxqBOpG8e" });
            list.Add(new CommonListModel { SrNo = "15", ImageSource = "db_aarti_black.png", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "-: श्री विद्यासागर महाराज आरती :-", SubTitle = "", SubTitleHi = "", Body = AppResources.aarti_vardhman_swami, AudioFileLink = "https://drive.google.com/uc?export=download&id=1ofeDNXEZz7MHDXj6ftKEBFduxqBOpG8e" });
            list.Add(new CommonListModel { SrNo = "16", ImageSource = "db_aarti_black.png", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "-: श्री विद्यासागर महाराज आरती :-", SubTitle = "", SubTitleHi = "", Body = AppResources.aarti_vasupujya, AudioFileLink = "https://drive.google.com/uc?export=download&id=1ofeDNXEZz7MHDXj6ftKEBFduxqBOpG8e" });
            list.Add(new CommonListModel { SrNo = "17", ImageSource = "db_aarti_black.png", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "-: श्री विद्यासागर महाराज आरती :-", SubTitle = "", SubTitleHi = "", Body = AppResources.aarti_vidyasagar_maharaji, AudioFileLink = "https://drive.google.com/uc?export=download&id=1ofeDNXEZz7MHDXj6ftKEBFduxqBOpG8e" });
            Navigation.PushAsync(new CommonListPageView(list, "आरती संग्रह"));
        }

        void SetStrotraHindi()
        {
            list = new List<CommonListModel>();
            list.Add(new CommonListModel { SrNo = "1", ImageSource = "db_strotra_black", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "-: आलोचना पाठ :-", SubTitle = "", SubTitleHi = "", Body = AppResources.stotrahindi_AlochanaPath, AudioFileLink = "https://drive.google.com/uc?export=download&id=1ofeDNXEZz7MHDXj6ftKEBFduxqBOpG8e" });
            list.Add(new CommonListModel { SrNo = "2", ImageSource = "db_strotra_black", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "-: बारह भावना :-", SubTitle = "", SubTitleHi = "", Body = AppResources.stotrahindi_barahbhavna, AudioFileLink = "https://drive.google.com/uc?export=download&id=1ofeDNXEZz7MHDXj6ftKEBFduxqBOpG8e" });
            list.Add(new CommonListModel { SrNo = "3", ImageSource = "db_strotra_black", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "-: भक्तामर स्तोत्र -हिन्दी  :-", SubTitle = "", SubTitleHi = "", Body = AppResources.stotrahindi_bhaktamar, AudioFileLink = "https://drive.google.com/uc?export=download&id=1ofeDNXEZz7MHDXj6ftKEBFduxqBOpG8e" });
            list.Add(new CommonListModel { SrNo = "4", ImageSource = "db_strotra_black", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "-: दुःख हरण विनती :-", SubTitle = "", SubTitleHi = "", Body = AppResources.stotrahindi_dukhharanvinti, AudioFileLink = "https://drive.google.com/uc?export=download&id=1ofeDNXEZz7MHDXj6ftKEBFduxqBOpG8e" });
            list.Add(new CommonListModel { SrNo = "5", ImageSource = "db_strotra_black", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "-: मेरी भावना :-", SubTitle = "", SubTitleHi = "", Body = AppResources.stotrahindi_merebhawna, AudioFileLink = "https://drive.google.com/uc?export=download&id=1ofeDNXEZz7MHDXj6ftKEBFduxqBOpG8e" });
            list.Add(new CommonListModel { SrNo = "6", ImageSource = "db_strotra_black", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "-: सामायिक पाठ :-", SubTitle = "", SubTitleHi = "", Body = AppResources.stotrahindi_SamayikPath, AudioFileLink = "https://drive.google.com/uc?export=download&id=1ofeDNXEZz7MHDXj6ftKEBFduxqBOpG8e" });
            list.Add(new CommonListModel { SrNo = "7", ImageSource = "db_strotra_black", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "-: वैराग्य - भावना :-", SubTitle = "", SubTitleHi = "", Body = AppResources.stotrahindi_vairagyaBhavna, AudioFileLink = "https://drive.google.com/uc?export=download&id=1ofeDNXEZz7MHDXj6ftKEBFduxqBOpG8e" });
            
            Navigation.PushAsync(new CommonListPageView(list, "स्तोत्रह"));
        }

        void SetStrotraSanskrit()
        {
            list = new List<CommonListModel>();
            list.Add(new CommonListModel { SrNo = "1", ImageSource = "db_strotra_black", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "-: श्री भक्तामर स्त्रोत – संस्कृत :-", SubTitle = "", SubTitleHi = "", Body = AppResources.stotra_bhaktamar, AudioFileLink = "https://drive.google.com/uc?export=download&id=1ofeDNXEZz7MHDXj6ftKEBFduxqBOpG8e" });
            list.Add(new CommonListModel { SrNo = "2", ImageSource = "db_strotra_black", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "-: दर्शन पाठ - संस्कृत  :-", SubTitle = "", SubTitleHi = "", Body = AppResources.stotra_darshan_path, AudioFileLink = "https://drive.google.com/uc?export=download&id=1ofeDNXEZz7MHDXj6ftKEBFduxqBOpG8e" });
            list.Add(new CommonListModel { SrNo = "3", ImageSource = "db_strotra_black", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "-: एकीभाव स्तोत्र : संस्कृत :-", SubTitle = "", SubTitleHi = "", Body = AppResources.stotra_ekibhav, AudioFileLink = "https://drive.google.com/uc?export=download&id=1ofeDNXEZz7MHDXj6ftKEBFduxqBOpG8e" });
            list.Add(new CommonListModel { SrNo = "5", ImageSource = "db_strotra_black", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "-: कल्याण मंदिर स्तोत्र :-", SubTitle = "", SubTitleHi = "", Body = AppResources.stotra_kalyan_mandir, AudioFileLink = "https://drive.google.com/uc?export=download&id=1ofeDNXEZz7MHDXj6ftKEBFduxqBOpG8e" });
            list.Add(new CommonListModel { SrNo = "6", ImageSource = "db_strotra_black", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "-: महावीराष्टक-स्तोत्रम्  :-", SubTitle = "", SubTitleHi = "", Body = AppResources.stotra_mahavirastak, AudioFileLink = "https://drive.google.com/uc?export=download&id=1ofeDNXEZz7MHDXj6ftKEBFduxqBOpG8e" });
            list.Add(new CommonListModel { SrNo = "7", ImageSource = "db_strotra_black", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "-: पार्श्वनाथ स्तोत्र  :-", SubTitle = "", SubTitleHi = "", Body = AppResources.stotra_parasnath, AudioFileLink = "https://drive.google.com/uc?export=download&id=1ofeDNXEZz7MHDXj6ftKEBFduxqBOpG8e" });


            Navigation.PushAsync(new CommonListPageView(list, "स्तोत्रह"));
        }
        void SetBhaktiHindi()
        {
            list = new List<CommonListModel>();
            list.Add(new CommonListModel { SrNo = "1", ImageSource = "db_bhakti_black.png", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "-: आचार्य भक्ति :-", SubTitle = "", SubTitleHi = "", Body = AppResources.bhakti_acharyabhakti, AudioFileLink = "https://drive.google.com/uc?export=download&id=1ofeDNXEZz7MHDXj6ftKEBFduxqBOpG8e" });
            list.Add(new CommonListModel { SrNo = "2", ImageSource = "db_bhakti_black.png", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "-: आचार्य भक्ति संस्कृति :-", SubTitle = "", SubTitleHi = "", Body = AppResources.bhakti_acharyabhaktisanskrit, AudioFileLink = "https://drive.google.com/uc?export=download&id=1ofeDNXEZz7MHDXj6ftKEBFduxqBOpG8e" });
            list.Add(new CommonListModel { SrNo = "3", ImageSource = "db_bhakti_black.png", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "-: आचार्य वन्दना :-", SubTitle = "", SubTitleHi = "", Body = AppResources.bhakti_acharyavandana, AudioFileLink = "https://drive.google.com/uc?export=download&id=1ofeDNXEZz7MHDXj6ftKEBFduxqBOpG8e" });
            list.Add(new CommonListModel { SrNo = "4", ImageSource = "db_bhakti_black.png", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "-: भावना द्वात्रिशंतिका :-", SubTitle = "", SubTitleHi = "", Body = AppResources.bhakti_bhawnaDwatrishantika, AudioFileLink = "https://drive.google.com/uc?export=download&id=1ofeDNXEZz7MHDXj6ftKEBFduxqBOpG8e" });



            Navigation.PushAsync(new CommonListPageView(list, "भक्ति "));
        }


        void SetStuti()
        {
            list = new List<CommonListModel>();
            list.Add(new CommonListModel { SrNo = "1", ImageSource = "db_bhakti2_black.png", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "-: आलोचना पाठ  :-", SubTitle = "", SubTitleHi = "", Body = AppResources.stuti_alochanapath, AudioFileLink = "https://drive.google.com/uc?export=download&id=1ofeDNXEZz7MHDXj6ftKEBFduxqBOpG8e" });
            list.Add(new CommonListModel { SrNo = "2", ImageSource = "db_bhakti2_black.png", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "-: अमूल्य तत्व विचार :-", SubTitle = "", SubTitleHi = "", Body = AppResources.stuti_amulyatatvavichar, AudioFileLink = "https://drive.google.com/uc?export=download&id=1ofeDNXEZz7MHDXj6ftKEBFduxqBOpG8e" });
            list.Add(new CommonListModel { SrNo = "3", ImageSource = "db_bhakti2_black.png", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "-: आराधना पाठ :-", SubTitle = "", SubTitleHi = "", Body = AppResources.stuti_aradhanapath, AudioFileLink = "https://drive.google.com/uc?export=download&id=1ofeDNXEZz7MHDXj6ftKEBFduxqBOpG8e" });
            list.Add(new CommonListModel { SrNo = "4", ImageSource = "db_bhakti2_black.png", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "-: आआत्म - कीर्तन  :-", SubTitle = "", SubTitleHi = "", Body = AppResources.stuti_atamkirtan_, AudioFileLink = "https://drive.google.com/uc?export=download&id=1ofeDNXEZz7MHDXj6ftKEBFduxqBOpG8e" });
            list.Add(new CommonListModel { SrNo = "5", ImageSource = "db_bhakti2_black.png", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "-: भक्तामर-महिमा :-", SubTitle = "", SubTitleHi = "", Body = AppResources.stuti_bhaktamarmahima, AudioFileLink = "https://drive.google.com/uc?export=download&id=1ofeDNXEZz7MHDXj6ftKEBFduxqBOpG8e" });
            list.Add(new CommonListModel { SrNo = "6", ImageSource = "db_bhakti2_black.png", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "-: बाहुबली स्तुति :-", SubTitle = "", SubTitleHi = "", Body = AppResources.stuti_bhaubalistuti, AudioFileLink = "https://drive.google.com/uc?export=download&id=1ofeDNXEZz7MHDXj6ftKEBFduxqBOpG8e" });
            list.Add(new CommonListModel { SrNo = "7", ImageSource = "db_bhakti2_black.png", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "-: चौबसी तीर्थंकर वंदना :-", SubTitle = "", SubTitleHi = "", Body = AppResources.stuti_chubisiteerthankarvandana, AudioFileLink = "https://drive.google.com/uc?export=download&id=1ofeDNXEZz7MHDXj6ftKEBFduxqBOpG8e" });
            list.Add(new CommonListModel { SrNo = "8", ImageSource = "db_bhakti2_black.png", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "-: दर्शन पाठ :-", SubTitle = "", SubTitleHi = "", Body = AppResources.stuti_darshanpath, AudioFileLink = "https://drive.google.com/uc?export=download&id=1ofeDNXEZz7MHDXj6ftKEBFduxqBOpG8e" });
            list.Add(new CommonListModel { SrNo = "9", ImageSource = "db_bhakti2_black.png", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "-: आदर्शन स्तुति :-", SubTitle = "", SubTitleHi = "", Body = AppResources.stuti_darshanstuti, AudioFileLink = "https://drive.google.com/uc?export=download&id=1ofeDNXEZz7MHDXj6ftKEBFduxqBOpG8e" });
            list.Add(new CommonListModel { SrNo = "10", ImageSource = "db_bhakti2_black.png", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "-: प्रभु पतित पवन  :-", SubTitle = "", SubTitleHi = "", Body = AppResources.stuti_prabhupatitpavan, AudioFileLink = "https://drive.google.com/uc?export=download&id=1ofeDNXEZz7MHDXj6ftKEBFduxqBOpG8e" });
            list.Add(new CommonListModel { SrNo = "11", ImageSource = "db_bhakti2_black.png", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "-: समाधि भावना  :-", SubTitle = "", SubTitleHi = "", Body = AppResources.stuti_samadhibhwana, AudioFileLink = "https://drive.google.com/uc?export=download&id=1ofeDNXEZz7MHDXj6ftKEBFduxqBOpG8e" });
            list.Add(new CommonListModel { SrNo = "12", ImageSource = "db_bhakti2_black.png", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "-: समाधि भाव :-", SubTitle = "", SubTitleHi = "", Body = AppResources.stuti_samadhipath, AudioFileLink = "https://drive.google.com/uc?export=download&id=1ofeDNXEZz7MHDXj6ftKEBFduxqBOpG8e" });
            list.Add(new CommonListModel { SrNo = "13", ImageSource = "db_bhakti2_black.png", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "-: श्री सिद्धचक्र स्तुति :-", SubTitle = "", SubTitleHi = "", Body = AppResources.stuti_shrishiddhchakra, AudioFileLink = "https://drive.google.com/uc?export=download&id=1ofeDNXEZz7MHDXj6ftKEBFduxqBOpG8e" });
            list.Add(new CommonListModel { SrNo = "14", ImageSource = "db_bhakti2_black.png", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "-: तुमसे लगी लगन  :-", SubTitle = "", SubTitleHi = "", Body = AppResources.stuti_tumselagilagan, AudioFileLink = "https://drive.google.com/uc?export=download&id=1ofeDNXEZz7MHDXj6ftKEBFduxqBOpG8e" });
            

            Navigation.PushAsync(new CommonListPageView(list, "स्तुति"));
        }


    }







    public class MenuItems
    {
        public string SrNo { get; set; }
        public string ImageSource { get; set; }
        public string ColorCodeHex { get; set; }
        public string TitleEn { get; set; }
        public string TitleHi { get; set; }
        public string AudioFileLink { get; set; }
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
        public string AudioFileLink { get; set; }
    }
}
