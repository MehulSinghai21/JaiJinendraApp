using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace JaiJinendra
{
    public partial class MainPage : ContentPage
    {
        public MainPage(string text)
        {
            InitializeComponent();
            Label_Text.Text = text;

        }
    }
}
