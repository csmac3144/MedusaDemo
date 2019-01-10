using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using Xamarin.Forms;

namespace MedusaDemo
{
    public partial class App : Application
    {
        public const string MainUrl = "http://t4g-medusa.azurewebsites.net/api/values";

        public static FunctionGroup FunctionGroups { get; private set; }

        public App()
        {
            InitializeComponent();

            MainPage = new MedusaDemo.MainPage();

            Device.BeginInvokeOnMainThread(async () =>
            {

                var grps = TestData.GenerateFake();

                var json = JsonConvert.SerializeObject(grps);

                try
                {
                    var result = await WebClient.PostButtonData(json);
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                }


                try
                {
                    json = await WebClient.GetButtonData();
                    grps = JsonConvert.DeserializeObject<FunctionGroup>(json);
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                }
                FunctionGroups = grps;
            });

        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
