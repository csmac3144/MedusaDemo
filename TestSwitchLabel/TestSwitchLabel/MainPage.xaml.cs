// ----- Visual Studio Magazine
//       Sample code for SwitchLabelControl project
//       by Tim Patrick

using System.ComponentModel;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MedusaDemo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            while (App.FunctionGroups == null)
                await Task.Delay(100);

            var btns = App.FunctionGroups.ButtonGroups.ToArray();

            buttonGroup1.SetButtons(captions: btns[0].Captions.ToArray(), radio: btns[0].RadioBehavior, triState: btns[0].TriState);
            buttonGroup2.SetButtons(captions: btns[1].Captions.ToArray(), radio: btns[1].RadioBehavior, triState: btns[1].TriState);
            buttonGroup3.SetButtons(captions: btns[2].Captions.ToArray(), radio: btns[2].RadioBehavior, triState: btns[2].TriState);
            buttonGroup4.SetButtons(captions: btns[3].Captions.ToArray(), radio: btns[3].RadioBehavior, triState: btns[3].TriState);
            buttonGroup5.SetButtons(captions: btns[4].Captions.ToArray(), radio: btns[4].RadioBehavior, triState: btns[4].TriState);
            buttonGroup6.SetButtons(captions: btns[5].Captions.ToArray(), radio: btns[5].RadioBehavior, triState: btns[5].TriState);



            //buttonGroup1.SetButtons(captions: new string[] { "Pulse", "Temperature" }, radio: false, triState: false);
            //buttonGroup2.SetButtons(captions: new string[] { "Infant", "Child","Adult","Elderly" }, radio: true, triState: false);
            //buttonGroup3.SetButtons(captions: new string[] { "Low", "Medium","High" }, radio: true, triState: false);
            //buttonGroup4.SetButtons(captions: new string[] { "Blood Type", "Height", "Weight", "Category X" }, radio: false, triState: false);
            //buttonGroup5.SetButtons(captions: new string[] { "Allergic", "Hypotensive","Shock","Ambulatory" }, radio: false, triState: true);
            //buttonGroup6.SetButtons(captions: new string[] { "Green","Yellow","Red" }, radio: true, triState: false);
            
        }

    }
}
