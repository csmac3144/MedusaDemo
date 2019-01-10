// ----- Visual Studio Magazine
//       Sample code for SwitchLabelControl project
//       by Tim Patrick

using System.ComponentModel;
using Xamarin.Forms;

namespace MedusaDemo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            buttonGroup1.SetButtons(captions: new string[] { "Pulse", "Temperature" }, radio: false, triState: false);
            buttonGroup2.SetButtons(captions: new string[] { "Infant", "Child","Adult","Elderly" }, radio: true, triState: false);
            buttonGroup3.SetButtons(captions: new string[] { "Low", "Medium","High" }, radio: true, triState: false);
            buttonGroup4.SetButtons(captions: new string[] { "Blood Type", "Height", "Weight", "Category X" }, radio: false, triState: false);
            buttonGroup5.SetButtons(captions: new string[] { "Allergic", "Hypotensive","Shock","Ambulatory" }, radio: false, triState: true);
            buttonGroup6.SetButtons(captions: new string[] { "Green","Yellow","Red" }, radio: true, triState: false);
            
        }

    }
}
