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
            menu.Add(new MenuItems { SrNo="1",ImageSource = "db_chalisa_Black.png", ColorCodeHex= "#ff6101", TitleEn="Chalisa", TitleHi= "चालीसा संग्रह", AudioFileLink= "" });
            menu.Add(new MenuItems { SrNo = "2", ImageSource = "db_aarti_black.png", ColorCodeHex = "#fc7f2b", TitleEn = "Aarti", TitleHi = "आरती  संग्रह", AudioFileLink = "" });
            menu.Add(new MenuItems { SrNo = "3", ImageSource = "db_strotra_black.png", ColorCodeHex = "#fd9346", TitleEn = "Strotra", TitleHi = "स्त्रोत - हिन्दी " , AudioFileLink = "" });
            menu.Add(new MenuItems { SrNo = "4", ImageSource = "db_strotra_black.png", ColorCodeHex = "#fda766", TitleEn = "Strotra", TitleHi = "स्त्रोत - संस्कृति" , AudioFileLink = "" });
            menu.Add(new MenuItems { SrNo = "5", ImageSource = "db_aarghawali_black.png", ColorCodeHex = "#fcb777", TitleEn = "Chalisa", TitleHi = "अर्घावली", AudioFileLink = "" });
            menu.Add(new MenuItems { SrNo = "6", ImageSource = "db_bhakti_black.png", ColorCodeHex = "#ff6101", TitleEn = "Chalisa", TitleHi = "भक्ति", AudioFileLink = "" });
            menu.Add(new MenuItems { SrNo = "7", ImageSource = "db_bhakti2_black.png", ColorCodeHex = "#fd9346", TitleEn = "Chalisa", TitleHi = "स्तुति " , AudioFileLink = "" });
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
                if (selectedItem.SrNo == "5")
                {
                    SetAarghawali();
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
            list.Add(new CommonListModel { SrNo = "2", ImageSource = "db_chalisa_Black.png", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "।।श्री अजितनाथ चालीसा।।", SubTitle = "", SubTitleHi = "", Body = ChalisaResources.AjitnathChalisa, AudioFileLink = "" });
            list.Add(new CommonListModel { SrNo = "3", ImageSource = "db_chalisa_Black.png", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "।।श्री सम्भवनाथ चालीसा।।", SubTitle = "", SubTitleHi = "", Body = ChalisaResources.SambhavnathChalisa, AudioFileLink = "" });
            list.Add(new CommonListModel { SrNo = "4", ImageSource = "db_chalisa_Black.png", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "।।श्री अभिनन्दन नाथ चालीसा।।", SubTitle = "", SubTitleHi = "", Body = ChalisaResources.AbhinandannathChalisa, AudioFileLink = "" });
            list.Add(new CommonListModel { SrNo = "5", ImageSource = "db_chalisa_Black.png", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "।।श्री सुमतिनाथ चालीसा।।", SubTitle = "", SubTitleHi = "", Body = ChalisaResources.SumatinathChalisa, AudioFileLink = "" });
            list.Add(new CommonListModel { SrNo = "6", ImageSource = "db_chalisa_Black.png", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "।।श्री पद्मप्रभुजी चालीसा।।", SubTitle = "", SubTitleHi = "", Body = ChalisaResources.Padamprabhuji, AudioFileLink = "" });
            list.Add(new CommonListModel { SrNo = "7", ImageSource = "db_chalisa_Black.png", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "।।श्री सुपार्श्वनाथ चालीसा।।", SubTitle = "", SubTitleHi = "", Body = ChalisaResources.SuparasnathChalisa, AudioFileLink = "" });
            list.Add(new CommonListModel { SrNo = "8", ImageSource = "db_chalisa_Black.png", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "।।श्री चन्द्रप्रभु चालीसा।।", SubTitle = "", SubTitleHi = "", Body = ChalisaResources.ChandaprabhuChalisa, AudioFileLink = "https://drive.google.com/uc?export=download&id=1F3D9ZMSr3Zv5bMiqFg8jWMzaSLhdk6jf" });
            list.Add(new CommonListModel { SrNo = "9", ImageSource = "db_chalisa_Black.png", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "।।श्री पुष्पदन्त चालीसा।।", SubTitle = "", SubTitleHi = "", Body = ChalisaResources.PushpdantChalisa, AudioFileLink = "" });
            list.Add(new CommonListModel { SrNo = "10", ImageSource = "db_chalisa_Black.png ", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "।।श्री शीतलनाथ चालीसा।।", SubTitle = "", SubTitleHi = "", Body = ChalisaResources.SheetalnathChalisa, AudioFileLink = "" });
            list.Add(new CommonListModel { SrNo = "11", ImageSource = "db_chalisa_Black.png", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "।।श्री श्रेयान्सनाथ चालीसा।।", SubTitle = "", SubTitleHi = "", Body = ChalisaResources.ShreyansnathChalisa, AudioFileLink = "" });
            list.Add(new CommonListModel { SrNo = "12", ImageSource = "db_chalisa_Black.png", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "।।श्री वासुपूज्य चालीसा।।", SubTitle = "", SubTitleHi = "", Body = ChalisaResources.VasupujyaChalisa, AudioFileLink = "" });
            list.Add(new CommonListModel { SrNo = "13", ImageSource = "db_chalisa_Black.png", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "।।श्री विमलनाथ चालीसा।।", SubTitle = "", SubTitleHi = "", Body = ChalisaResources.VimalnathChalisa, AudioFileLink = "" });
            list.Add(new CommonListModel { SrNo = "14", ImageSource = "db_chalisa_Black.png", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "।।श्री अनन्तनाथ चलीसा।।", SubTitle = "", SubTitleHi = "", Body = ChalisaResources.Anantnath, AudioFileLink = "" });
            list.Add(new CommonListModel { SrNo = "15", ImageSource = "db_chalisa_Black.png ", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "।।श्री धर्मनाथ चालीसा।।", SubTitle = "", SubTitleHi = "", Body = ChalisaResources.DharmanathaChalisa, AudioFileLink = "" });
            list.Add(new CommonListModel { SrNo = "16", ImageSource = "db_chalisa_Black.png", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "।।श्री शान्तिनाथ चालीसा।।", SubTitle = "", SubTitleHi = "", Body = ChalisaResources.ShantinathChalisa, AudioFileLink = "" });
            list.Add(new CommonListModel { SrNo = "17", ImageSource = "db_chalisa_Black.png", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "।।श्री कुन्थनाथ चालीसा।।", SubTitle = "", SubTitleHi = "", Body = ChalisaResources.KunthunathChalisa, AudioFileLink = "" });
            list.Add(new CommonListModel { SrNo = "18", ImageSource = "db_chalisa_Black.png", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "।।श्री अरहनाथ चालीसा।।", SubTitle = "", SubTitleHi = "", Body = ChalisaResources.ArahnathChalisa, AudioFileLink = "" });
            list.Add(new CommonListModel { SrNo = "19", ImageSource = "db_chalisa_Black.png", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "।।श्री मल्लिनाथ चालीसा।।", SubTitle = "", SubTitleHi = "", Body = ChalisaResources.MallinathChalisa, AudioFileLink = "" });
            list.Add(new CommonListModel { SrNo = "20", ImageSource = "db_chalisa_Black.png", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "।।श्री मुनिसुव्रतनाथ चालीसा।।", SubTitle = "", SubTitleHi = "", Body = ChalisaResources.MunisuvrathChalisa, AudioFileLink = "" });
            list.Add(new CommonListModel { SrNo = "21", ImageSource = "db_chalisa_Black.png", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "।।श्री नमिनाथ चालीसा।।", SubTitle = "", SubTitleHi = "", Body = ChalisaResources.NaminathChalisa, AudioFileLink = "" });
            list.Add(new CommonListModel { SrNo = "22", ImageSource = "db_chalisa_Black.png", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "।।श्री नेमिनाथ चालीसा।।", SubTitle = "", SubTitleHi = "", Body = ChalisaResources.NeminathChalisa, AudioFileLink = "https://drive.google.com/uc?export=download&id=1DV_n3bXqlT3Yh7zm6DrOlHxysN2t-zCd" });
            list.Add(new CommonListModel { SrNo = "23", ImageSource = "db_chalisa_Black.png", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "।।श्री पार्श्वनाथ चालीसा।।", SubTitle = "", SubTitleHi = "", Body = ChalisaResources.ParshvnathChalisa, AudioFileLink = "https://drive.google.com/uc?export=download&id=1Z5rPWlPFLBV8PCWqSxdwa166DMYUwExH" });
            list.Add(new CommonListModel { SrNo = "23", ImageSource = "db_chalisa_Black.png", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "।।श्री महावीर चालीसा।।", SubTitle = "", SubTitleHi = "", Body = ChalisaResources.MahaviraChalisa, AudioFileLink = "https://drive.google.com/uc?export=download&id=1IX3Q7Rz-wZMKbCq9nec_vv0O3oryjatr" });
            //KunthunathChalisa

            //SambhavnathChalisa
            Navigation.PushAsync(new CommonListPageView(list,    "चालीसा संग्रह"));
        }


        void SetAarghawali()
        {
            list = new List<CommonListModel>();
            list.Add(new CommonListModel { SrNo = "1", ImageSource = "db_aarghawali_black.png", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "-:  श्री देव-शास्त्र-गुरु अर्घ्य  :-", SubTitle = "", SubTitleHi = "", Body = AppResources.arghavali_devshastraguru, AudioFileLink = string.Empty });
            list.Add(new CommonListModel { SrNo = "2", ImageSource = "db_aarghawali_black.png", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "-:  श्री विद्यमान-विंशति-तीर्थंकर अर्घ्य :-", SubTitle = "", SubTitleHi = "", Body = AppResources.arghavali_vidyamanabeesteethankar, AudioFileLink = string.Empty });
            list.Add(new CommonListModel { SrNo = "3", ImageSource = "db_aarghawali_black.png", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "-:  श्री कृत्रिम-अकृत्रिम चैत्यालयों का अर्घ्य :-", SubTitle = "", SubTitleHi = "", Body = AppResources.arghavali_kritrimaakritima, AudioFileLink = string.Empty });
            list.Add(new CommonListModel { SrNo = "4", ImageSource = "db_aarghawali_black.png", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "-:  श्री सिद्धपरमेष्ठी का अर्घ्य (संस्कृत):-", SubTitle = "", SubTitleHi = "", Body = AppResources.arghavali_siddhparmaesti, AudioFileLink = string.Empty });
            list.Add(new CommonListModel { SrNo = "5", ImageSource = "db_aarghawali_black.png", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "-:  श्री तीस-चौबीसी का अर्घ्य :-", SubTitle = "", SubTitleHi = "", Body = AppResources.arghavali_teeschaubisi, AudioFileLink = string.Empty });
            list.Add(new CommonListModel { SrNo = "6", ImageSource = "db_aarghawali_black.png", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "-:  श्री आदिनाथ-जिनेन्द्र का अर्घ्य :-", SubTitle = "", SubTitleHi = "", Body = AppResources.arghavali_shriaadinathji, AudioFileLink = string.Empty });
            list.Add(new CommonListModel { SrNo = "6", ImageSource = "db_aarghawali_black.png", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "-:  श्री अजितनाथ-जिनेन्द्र का अर्घ्य :-", SubTitle = "", SubTitleHi = "", Body = AppResources.arghavali_sriajitanathjinendra, AudioFileLink = string.Empty });
            list.Add(new CommonListModel { SrNo = "6", ImageSource = "db_aarghawali_black.png", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "-:  श्री संभवनाथ-जिनेन्द्र का अर्घ्य :-", SubTitle = "", SubTitleHi = "", Body = AppResources.arghavali_srisambhavanathajinendra, AudioFileLink = string.Empty });
            list.Add(new CommonListModel { SrNo = "6", ImageSource = "db_aarghawali_black.png", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "-:  श्री अभिनंदननाथ-जिनेन्द्र का अर्घ्य :-", SubTitle = "", SubTitleHi = "", Body = AppResources.arghavali_sriabhinandananatha, AudioFileLink = string.Empty });
            list.Add(new CommonListModel { SrNo = "6", ImageSource = "db_aarghawali_black.png", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "-:  श्री सुमतिनाथ-जिनेन्द्र का अर्घ्य :-", SubTitle = "", SubTitleHi = "", Body = AppResources.arghavali_srisumatinatha, AudioFileLink = string.Empty });
            list.Add(new CommonListModel { SrNo = "6", ImageSource = "db_aarghawali_black.png", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "-:  श्री पद्मप्रभ-जिनेन्द्र का अर्घ्य :-", SubTitle = "", SubTitleHi = "", Body = AppResources.arghavali_sripadmaprabhajinendra, AudioFileLink = string.Empty });
            list.Add(new CommonListModel { SrNo = "6", ImageSource = "db_aarghawali_black.png", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "-:  श्री सुपार्श्वनाथ जिनेन्द्र का अर्घ्य :-", SubTitle = "", SubTitleHi = "", Body = AppResources.arghavali_srisuparshvanatha, AudioFileLink = string.Empty });
            list.Add(new CommonListModel { SrNo = "6", ImageSource = "db_aarghawali_black.png", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "-:  श्री चंद्रप्रभ-जिनेन्द्र का अर्घ्य :-", SubTitle = "", SubTitleHi = "", Body = AppResources.arghavali_srichandraprahajinendra, AudioFileLink = string.Empty });
            list.Add(new CommonListModel { SrNo = "6", ImageSource = "db_aarghawali_black.png", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "-:  श्री पुष्पदंत-जिनेन्द्र का अर्घ्य :-", SubTitle = "", SubTitleHi = "", Body = AppResources.arghavali_sripuspadantajnendra, AudioFileLink = string.Empty });
            list.Add(new CommonListModel { SrNo = "6", ImageSource = "db_aarghawali_black.png", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "-:  श्री शीतलनाथ-जिनेन्द्र का अर्घ्य :-", SubTitle = "", SubTitleHi = "", Body = AppResources.arghavali_srisheetalnathajinendra, AudioFileLink = string.Empty });
            list.Add(new CommonListModel { SrNo = "6", ImageSource = "db_aarghawali_black.png", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "-:  श्री श्रेयांसनाथ-जिनेन्द्र का अर्घ्य :-", SubTitle = "", SubTitleHi = "", Body = AppResources.arghavali_srisreyansanatha, AudioFileLink = string.Empty });
            list.Add(new CommonListModel { SrNo = "6", ImageSource = "db_aarghawali_black.png", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "-:  श्री वासुपूज्य-जिनेन्द्र का अर्घ्य :-", SubTitle = "", SubTitleHi = "", Body = AppResources.arghavali_srivasupujyajinendra, AudioFileLink = string.Empty });
            list.Add(new CommonListModel { SrNo = "6", ImageSource = "db_aarghawali_black.png", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "-:  श्री विमलनाथ-जिनेन्द्र का अर्घ्य :-", SubTitle = "", SubTitleHi = "", Body = AppResources.arghavali_srivimalanatha, AudioFileLink = string.Empty });
            list.Add(new CommonListModel { SrNo = "6", ImageSource = "db_aarghawali_black.png", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "-:  श्री अनंतनाथ-जिनेन्द्र का अर्घ्य :-", SubTitle = "", SubTitleHi = "", Body = AppResources.arghavali_srinantanatha, AudioFileLink = string.Empty });
            list.Add(new CommonListModel { SrNo = "6", ImageSource = "db_aarghawali_black.png", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "-:  श्री धर्मनाथ-जिनेन्द्र का अर्घ्य :-", SubTitle = "", SubTitleHi = "", Body = AppResources.arghavali_sridharmanathajinendra, AudioFileLink = string.Empty });
            list.Add(new CommonListModel { SrNo = "6", ImageSource = "db_aarghawali_black.png", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "-:  श्री शांतिनाथ-जिनेन्द्र का अर्घ्य :-", SubTitle = "", SubTitleHi = "", Body = AppResources.arghavali_srishantinathajinendra, AudioFileLink = string.Empty });
            list.Add(new CommonListModel { SrNo = "6", ImageSource = "db_aarghawali_black.png", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "-:  श्री कुंथुनाथ-जिनेन्द्र का अर्घ्य :-", SubTitle = "", SubTitleHi = "", Body = AppResources.arghavali_srikunthunathajinendra, AudioFileLink = string.Empty });
            list.Add(new CommonListModel { SrNo = "6", ImageSource = "db_aarghawali_black.png", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "-:  श्री अरहनाथ-जिनेन्द्र का अर्घ्य :-", SubTitle = "", SubTitleHi = "", Body = AppResources.arghavali_sriarahnathajinendra, AudioFileLink = string.Empty });
            list.Add(new CommonListModel { SrNo = "6", ImageSource = "db_aarghawali_black.png", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "-:  श्री मल्लिनाथ-जिनेन्द्र का अर्घ्य :-", SubTitle = "", SubTitleHi = "", Body = AppResources.arghavali_srimallinathajinendra, AudioFileLink = string.Empty });
            list.Add(new CommonListModel { SrNo = "6", ImageSource = "db_aarghawali_black.png", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "-:  श्री मुनिसुव्रत-जिनेन्द्र का अर्घ्य :-", SubTitle = "", SubTitleHi = "", Body = AppResources.arghavali_srimunisuvratajinendra, AudioFileLink = string.Empty });
            list.Add(new CommonListModel { SrNo = "6", ImageSource = "db_aarghawali_black.png", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "-:  श्री नमिनाथ-जिनेन्द्र का अर्घ्य :-", SubTitle = "", SubTitleHi = "", Body = AppResources.arghavali_srinaminathajinendra, AudioFileLink = string.Empty });
            list.Add(new CommonListModel { SrNo = "6", ImageSource = "db_aarghawali_black.png", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "-:  श्री नेमिनाथ-जिनेन्द्र का अर्घ्य :-", SubTitle = "", SubTitleHi = "", Body = AppResources.arghavali_srineminathajinendra, AudioFileLink = string.Empty });
            list.Add(new CommonListModel { SrNo = "6", ImageSource = "db_aarghawali_black.png", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "-:  श्री पार्श्वनाथ-जिनेन्द्र का अर्घ्य :-", SubTitle = "", SubTitleHi = "", Body = AppResources.arghavali_sriparavanathajinendra, AudioFileLink = string.Empty });
            list.Add(new CommonListModel { SrNo = "6", ImageSource = "db_aarghawali_black.png", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "-:  श्री महावीर-जिनेन्द्र का अर्घ्य :-", SubTitle = "", SubTitleHi = "", Body = AppResources.arghavali_shimahavirajinendra, AudioFileLink = string.Empty });
            list.Add(new CommonListModel { SrNo = "6", ImageSource = "db_aarghawali_black.png", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "-:  श्री बाहुबली-स्वामी का अर्घ्य :-", SubTitle = "", SubTitleHi = "", Body = AppResources.arghavali_bhaubaliswami, AudioFileLink = string.Empty });
            list.Add(new CommonListModel { SrNo = "6", ImageSource = "db_aarghawali_black.png", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "-: पाँच बालयति अर्घ्य :-", SubTitle = "", SubTitleHi = "", Body = AppResources.arghavali_panchbalayati, AudioFileLink = string.Empty });
            list.Add(new CommonListModel { SrNo = "6", ImageSource = "db_aarghawali_black.png", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "-:  सोलहकारण-भावना का अर्घ्य :-", SubTitle = "", SubTitleHi = "", Body = AppResources.arghavali_solahakaranabhavana, AudioFileLink = string.Empty });
            list.Add(new CommonListModel { SrNo = "6", ImageSource = "db_aarghawali_black.png", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "-:  पंचमेरु-जिनालयों का अर्घ्य :-", SubTitle = "", SubTitleHi = "", Body = AppResources.arghavali_panchamerujinalayon, AudioFileLink = string.Empty });
            list.Add(new CommonListModel { SrNo = "6", ImageSource = "db_aarghawali_black.png", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "-:  नंदीश्वरद्वीप-जिनालयों का अर्घ्य :-", SubTitle = "", SubTitleHi = "", Body = AppResources.arghavali_nandisvaradvipajinalayon, AudioFileLink = string.Empty });
            list.Add(new CommonListModel { SrNo = "6", ImageSource = "db_aarghawali_black.png", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "-:  दशलक्षण-धर्म-अर्घ्यघ्य :-", SubTitle = "", SubTitleHi = "", Body = AppResources.arghavali_dasalaksanadharma, AudioFileLink = string.Empty });
            list.Add(new CommonListModel { SrNo = "6", ImageSource = "db_aarghawali_black.png", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "-:  श्री सम्यक् रत्नत्रय-अर्घ्य :-", SubTitle = "", SubTitleHi = "", Body = AppResources.arghavali_srisamyakratntraya, AudioFileLink = string.Empty });
            list.Add(new CommonListModel { SrNo = "6", ImageSource = "db_aarghawali_black.png", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "-:  सप्तर्षि-अर्घ्यघ्य :-", SubTitle = "", SubTitleHi = "", Body = AppResources.arghavali_saptarishi, AudioFileLink = string.Empty });
            list.Add(new CommonListModel { SrNo = "6", ImageSource = "db_aarghawali_black.png", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "-:  श्री चौबीस-तीर्थंकर निर्वाणक्षेत्र अर्घ्य :-", SubTitle = "", SubTitleHi = "", Body = AppResources.arghavali_srichaubisatirthankaranirvanaksetra, AudioFileLink = string.Empty });
            list.Add(new CommonListModel { SrNo = "6", ImageSource = "db_aarghawali_black.png", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "-:  सरस्वती-माता का अर्घ्यघ्य :-", SubTitle = "", SubTitleHi = "", Body = AppResources.arghavali_sarasvatimata, AudioFileLink = string.Empty });
            list.Add(new CommonListModel { SrNo = "6", ImageSource = "db_aarghawali_black.png", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "-:  सरस्वती-माता का अर्घ्यघ्य :-", SubTitle = "", SubTitleHi = "", Body = AppResources.arghavali_sarasvatimata, AudioFileLink = string.Empty });
            Navigation.PushAsync(new CommonListPageView(list, "अर्घावली"));
        }
            void SetAarti()
        {
            list = new List<CommonListModel>();
            list.Add(new CommonListModel { SrNo = "1", ImageSource = "db_aarti_black.png", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "-:  श्री आदिनाथ भगवान की आरती  :-", SubTitle = "", SubTitleHi = "", Body = AppResources.aarti_adinathswami, AudioFileLink = string.Empty });
            list.Add(new CommonListModel { SrNo = "2", ImageSource = "db_aarti_black.png", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "-: श्री चंद्रप्रभु भगवान की आरती :-", SubTitle = "", SubTitleHi = "", Body = AppResources.aarti_chandraprabhu, AudioFileLink = string.Empty });
            list.Add(new CommonListModel { SrNo = "3", ImageSource = "db_aarti_black.png", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "-: श्री चंद्रप्रभु भगवान की आरती :-", SubTitle = "", SubTitleHi = "", Body = AppResources.aarti_chandraprabhudeva, AudioFileLink = string.Empty });
            list.Add(new CommonListModel { SrNo = "4", ImageSource = "db_aarti_black.png", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "-: श्री धर्मनाथ भगवान की आरती  :-", SubTitle = "", SubTitleHi = "", Body = AppResources.aarti_dharmanathbhagwan, AudioFileLink = string.Empty });
            list.Add(new CommonListModel { SrNo = "5", ImageSource = "db_aarti_black.png", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "-: श्री जिनवाणी माता की आरती  :-", SubTitle = "", SubTitleHi = "", Body = AppResources.aarti_jinvanimata, AudioFileLink = string.Empty });
            list.Add(new CommonListModel { SrNo = "6", ImageSource = "db_aarti_black.png", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "-: श्री महावीर स्वामी आरती :-", SubTitle = "", SubTitleHi = "", Body = AppResources.aarti_mahavir, AudioFileLink = string.Empty });
            list.Add(new CommonListModel { SrNo = "7", ImageSource = "db_aarti_black.png", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "-:  श्री मुनिसुब्रत नाथ भगवान की आरती :-", SubTitle = "", SubTitleHi = "", Body = AppResources.aarti_munisuvratnath, AudioFileLink = string.Empty });
            list.Add(new CommonListModel { SrNo = "8", ImageSource = "db_aarti_black.png", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "-: श्री नेमिनाथ भगवान की आरती :-", SubTitle = "", SubTitleHi = "", Body = AppResources.aarti_neminath_bhagwan, AudioFileLink = string.Empty });
            list.Add(new CommonListModel { SrNo = "9", ImageSource = "db_aarti_black.png", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "-: श्री पारसनाथ भगवान आरती :-", SubTitle = "", SubTitleHi = "", Body = AppResources.aarti_parasnath, AudioFileLink = string.Empty });
            list.Add(new CommonListModel { SrNo = "10", ImageSource = "db_aarti_black.png", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "-: श्री सन्मति प्रभु की आरती :-", SubTitle = "", SubTitleHi = "", Body = AppResources.aarti_sanmati_prabhu, AudioFileLink = string.Empty });
            list.Add(new CommonListModel { SrNo = "11", ImageSource = "db_aarti_black.png", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "-: श्री शांतिनाथ भगवान की आरती :-", SubTitle = "", SubTitleHi = "", Body = AppResources.aarti_shantinath_bhagwan, AudioFileLink = string.Empty });
            list.Add(new CommonListModel { SrNo = "12", ImageSource = "db_aarti_black.png", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "-: श्री शीतलनाथ भगवान की आरती :-", SubTitle = "", SubTitleHi = "", Body = AppResources.aarti_sheetalnath_bhagwan, AudioFileLink = string.Empty });
            list.Add(new CommonListModel { SrNo = "13", ImageSource = "db_aarti_black.png", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "-: श्री पंच परमेष्ठी आरती  :-", SubTitle = "", SubTitleHi = "", Body = AppResources.aarti_shripanchparmeshthi, AudioFileLink = string.Empty });
            list.Add(new CommonListModel { SrNo = "14", ImageSource = "db_aarti_black.png", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "-: श्री विद्यासागर महाराज आरती :-", SubTitle = "", SubTitleHi = "", Body = AppResources.aarti_trikaalchaubisi, AudioFileLink = string.Empty });
            list.Add(new CommonListModel { SrNo = "15", ImageSource = "db_aarti_black.png", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "-: श्री विद्यासागर महाराज आरती :-", SubTitle = "", SubTitleHi = "", Body = AppResources.aarti_vardhman_swami, AudioFileLink = string.Empty });
            list.Add(new CommonListModel { SrNo = "16", ImageSource = "db_aarti_black.png", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "-: श्री विद्यासागर महाराज आरती :-", SubTitle = "", SubTitleHi = "", Body = AppResources.aarti_vasupujya, AudioFileLink = string.Empty });
            list.Add(new CommonListModel { SrNo = "17", ImageSource = "db_aarti_black.png", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "-: श्री विद्यासागर महाराज आरती :-", SubTitle = "", SubTitleHi = "", Body = AppResources.aarti_vidyasagar_maharaji, AudioFileLink = string.Empty });
            Navigation.PushAsync(new CommonListPageView(list, "आरती संग्रह"));
        }

        void SetStrotraHindi()
        {
        
            list = new List<CommonListModel>();
            list.Add(new CommonListModel { SrNo = "1", ImageSource = "db_strotra_black", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "-: आलोचना पाठ :-", SubTitle = "", SubTitleHi = "", Body = AppResources.stotrahindi_AlochanaPath, AudioFileLink = "https://drive.google.com/uc?export=download&id=1FPyMsiOMsBRkhFi9rqqHxXwNNKnJkE9y" });
            list.Add(new CommonListModel { SrNo = "2", ImageSource = "db_strotra_black", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "-: बारह भावना :-", SubTitle = "", SubTitleHi = "", Body = AppResources.stotrahindi_barahbhavna, AudioFileLink = "https://drive.google.com/uc?export=download&id=1i7WilyeCNmo5xTbw5pI4HzIYPdV55TEV" });
            list.Add(new CommonListModel { SrNo = "3", ImageSource = "db_strotra_black", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "-: भक्तामर स्तोत्र -हिन्दी  :-", SubTitle = "", SubTitleHi = "", Body = AppResources.stotrahindi_bhaktamar, AudioFileLink = "https://drive.google.com/uc?export=download&id=1IeBvJ7Zp8IbSkA-fVdvupGVlHBgpnSU2" });
            list.Add(new CommonListModel { SrNo = "4", ImageSource = "db_strotra_black", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "-: दुःख हरण विनती :-", SubTitle = "", SubTitleHi = "", Body = AppResources.stotrahindi_dukhharanvinti, AudioFileLink = "https://drive.google.com/uc?export=download&id=1t7oOYxymVGXiFBQjNpy9CjJlN6FxNb8S" });
            list.Add(new CommonListModel { SrNo = "5", ImageSource = "db_strotra_black", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "-: मेरी भावना :-", SubTitle = "", SubTitleHi = "", Body = AppResources.stotrahindi_merebhawna, AudioFileLink = "https://drive.google.com/uc?export=download&id=1jhXIR4e3rWt_S4ZxAuoCis0kaiymGZwJ" });
            list.Add(new CommonListModel { SrNo = "6", ImageSource = "db_strotra_black", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "-: सामायिक पाठ :-", SubTitle = "", SubTitleHi = "", Body = AppResources.stotrahindi_SamayikPath, AudioFileLink = "https://drive.google.com/uc?export=download&id=1Uuozqu6ex9Bx1rfolwpM5sBF2-eoicMt" });
            list.Add(new CommonListModel { SrNo = "7", ImageSource = "db_strotra_black", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "-: वैराग्य - भावना :-", SubTitle = "", SubTitleHi = "", Body = AppResources.stotrahindi_vairagyaBhavna, AudioFileLink = "https://drive.google.com/uc?export=download&id=1W0RsyUqDhehrtneFGUrzFslknx-ytTD0" });
            
            Navigation.PushAsync(new CommonListPageView(list, "स्तोत्रह"));
        }

        void SetStrotraSanskrit()
        {
            list = new List<CommonListModel>();
            list.Add(new CommonListModel { SrNo = "1", ImageSource = "db_strotra_black", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "-: श्री भक्तामर स्त्रोत – संस्कृत :-", SubTitle = "", SubTitleHi = "", Body = AppResources.stotra_bhaktamar, AudioFileLink = "https://drive.google.com/uc?export=download&id=1QMSbkeKyl9VXTgPFPhwsC9PnbvCSXxO4" });
            list.Add(new CommonListModel { SrNo = "2", ImageSource = "db_strotra_black", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "-: दर्शन पाठ - संस्कृत  :-", SubTitle = "", SubTitleHi = "", Body = AppResources.stotra_darshan_path, AudioFileLink = "https://drive.google.com/uc?export=download&id=1WaMZrfJSyQsCDL9wytmRFAoyf9r9OTHk" });
            list.Add(new CommonListModel { SrNo = "3", ImageSource = "db_strotra_black", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "-: एकीभाव स्तोत्र : संस्कृत :-", SubTitle = "", SubTitleHi = "", Body = AppResources.stotra_ekibhav, AudioFileLink = "https://drive.google.com/uc?export=download&id=1BjSOErd2DiUirycMDqr5kyip4P_zP4et" });
            list.Add(new CommonListModel { SrNo = "5", ImageSource = "db_strotra_black", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "-: कल्याण मंदिर स्तोत्र :-", SubTitle = "", SubTitleHi = "", Body = AppResources.stotra_kalyan_mandir, AudioFileLink = "https://drive.google.com/uc?export=download&id=1OQ1w3IfoyM4t0mvdaL2ndtWNIXy9kifG" });
            list.Add(new CommonListModel { SrNo = "6", ImageSource = "db_strotra_black", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "-: महावीराष्टक-स्तोत्रम्  :-", SubTitle = "", SubTitleHi = "", Body = AppResources.stotra_mahavirastak, AudioFileLink = "https://drive.google.com/uc?export=download&id=1dWOQuTbEdZ_PZ-EpNU5FBNvR2LNfNSzc" });
            list.Add(new CommonListModel { SrNo = "7", ImageSource = "db_strotra_black", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "-: पार्श्वनाथ स्तोत्र  :-", SubTitle = "", SubTitleHi = "", Body = AppResources.stotra_parasnath, AudioFileLink = "https://drive.google.com/uc?export=download&id=1Wb4gOOL3OgW-nrlVfdg2yQP0845BlDV9" });


            Navigation.PushAsync(new CommonListPageView(list, "स्तोत्रह"));
        }
        void SetBhaktiHindi()
        {
            list = new List<CommonListModel>();
            list.Add(new CommonListModel { SrNo = "1", ImageSource = "db_bhakti_black.png", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "-: आचार्य भक्ति :-", SubTitle = "", SubTitleHi = "", Body = AppResources.bhakti_acharyabhakti, AudioFileLink = "" });
            list.Add(new CommonListModel { SrNo = "2", ImageSource = "db_bhakti_black.png", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "-: आचार्य भक्ति संस्कृति :-", SubTitle = "", SubTitleHi = "", Body = AppResources.bhakti_acharyabhaktisanskrit, AudioFileLink = "" });
            list.Add(new CommonListModel { SrNo = "3", ImageSource = "db_bhakti_black.png", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "-: आचार्य वन्दना :-", SubTitle = "", SubTitleHi = "", Body = AppResources.bhakti_acharyavandana, AudioFileLink = "" });
            list.Add(new CommonListModel { SrNo = "4", ImageSource = "db_bhakti_black.png", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "-: भावना द्वात्रिशंतिका :-", SubTitle = "", SubTitleHi = "", Body = AppResources.bhakti_bhawnaDwatrishantika, AudioFileLink = "" });



            Navigation.PushAsync(new CommonListPageView(list, "भक्ति "));
        }


        void SetStuti()
        {
            list = new List<CommonListModel>();
            list.Add(new CommonListModel { SrNo = "1", ImageSource = "db_bhakti2_black.png", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "-: आलोचना पाठ  :-", SubTitle = "", SubTitleHi = "", Body = AppResources.stuti_alochanapath, AudioFileLink = "" });
            list.Add(new CommonListModel { SrNo = "2", ImageSource = "db_bhakti2_black.png", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "-: अमूल्य तत्व विचार :-", SubTitle = "", SubTitleHi = "", Body = AppResources.stuti_amulyatatvavichar, AudioFileLink = "" });
            list.Add(new CommonListModel { SrNo = "3", ImageSource = "db_bhakti2_black.png", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "-: आराधना पाठ :-", SubTitle = "", SubTitleHi = "", Body = AppResources.stuti_aradhanapath, AudioFileLink = "" });
            list.Add(new CommonListModel { SrNo = "4", ImageSource = "db_bhakti2_black.png", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "-: आआत्म - कीर्तन  :-", SubTitle = "", SubTitleHi = "", Body = AppResources.stuti_atamkirtan_, AudioFileLink = "" });
            list.Add(new CommonListModel { SrNo = "5", ImageSource = "db_bhakti2_black.png", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "-: भक्तामर-महिमा :-", SubTitle = "", SubTitleHi = "", Body = AppResources.stuti_bhaktamarmahima, AudioFileLink = "" });
            list.Add(new CommonListModel { SrNo = "6", ImageSource = "db_bhakti2_black.png", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "-: बाहुबली स्तुति :-", SubTitle = "", SubTitleHi = "", Body = AppResources.stuti_bhaubalistuti, AudioFileLink = "" });
            list.Add(new CommonListModel { SrNo = "7", ImageSource = "db_bhakti2_black.png", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "-: चौबसी तीर्थंकर वंदना :-", SubTitle = "", SubTitleHi = "", Body = AppResources.stuti_chubisiteerthankarvandana, AudioFileLink = "" });
            list.Add(new CommonListModel { SrNo = "8", ImageSource = "db_bhakti2_black.png", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "-: दर्शन पाठ :-", SubTitle = "", SubTitleHi = "", Body = AppResources.stuti_darshanpath, AudioFileLink = "" });
            list.Add(new CommonListModel { SrNo = "9", ImageSource = "db_bhakti2_black.png", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "-: आदर्शन स्तुति :-", SubTitle = "", SubTitleHi = "", Body = AppResources.stuti_darshanstuti, AudioFileLink = "" });
            list.Add(new CommonListModel { SrNo = "10", ImageSource = "db_bhakti2_black.png", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "-: प्रभु पतित पवन  :-", SubTitle = "", SubTitleHi = "", Body = AppResources.stuti_prabhupatitpavan, AudioFileLink = "" });
            list.Add(new CommonListModel { SrNo = "11", ImageSource = "db_bhakti2_black.png", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "-: समाधि भावना  :-", SubTitle = "", SubTitleHi = "", Body = AppResources.stuti_samadhibhwana, AudioFileLink = "" });
            list.Add(new CommonListModel { SrNo = "12", ImageSource = "db_bhakti2_black.png", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "-: समाधि भाव :-", SubTitle = "", SubTitleHi = "", Body = AppResources.stuti_samadhipath, AudioFileLink = "" });
            list.Add(new CommonListModel { SrNo = "13", ImageSource = "db_bhakti2_black.png", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "-: श्री सिद्धचक्र स्तुति :-", SubTitle = "", SubTitleHi = "", Body = AppResources.stuti_shrishiddhchakra, AudioFileLink = "" });
            list.Add(new CommonListModel { SrNo = "14", ImageSource = "db_bhakti2_black.png", ColorCodeHex = "#ff6101", Title = "Chalisa", TitleHi = "-: तुमसे लगी लगन  :-", SubTitle = "", SubTitleHi = "", Body = AppResources.stuti_tumselagilagan, AudioFileLink = "" });
            

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
