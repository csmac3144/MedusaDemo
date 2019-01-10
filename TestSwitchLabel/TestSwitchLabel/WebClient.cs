using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MedusaDemo
{
    class WebClient
    {
        public static async Task<string> GetButtonData()
        {
            using (var client = new System.Net.Http.HttpClient())
            {
                return await client.GetStringAsync(App.MainUrl);
            }
        }
        public static async Task<HttpResponseMessage> PostButtonData(string json)
        {
            using (var client = new System.Net.Http.HttpClient())
            {
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                return await client.PostAsync(App.MainUrl, content);
            }
        }
    }
}
