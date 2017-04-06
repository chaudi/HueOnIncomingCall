using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System.Net.Http;
using Newtonsoft.Json;
using System.Threading.Tasks;
using HueOnIncomingCall.Hue.Messages;

namespace HueOnIncomingCall.Hue
{
    public class HueCommunicator
    {
        private HttpClient client;

        public HueCommunicator(string ip)
        {
            client = new HttpClient();
            client.BaseAddress = new Uri(ip);
        }

        public async Task<bool> SetLights(IEnumerable<Light> lights)
        {
            var json = JsonConvert.SerializeObject(lights);
            var content = new StringContent(json);

            var response = await client.PostAsync("/api/lights", content);
            var responseMessage = await response.Content.ReadAsStringAsync();


            return responseMessage.Contains("error");
        }

        public async Task<RegisteredResponse> RegisterApp()
        {
            var content = new StringContent("");
            var response = await client.PostAsync("/api/register/", content);
            var responseObject = JsonConvert.DeserializeObject<RegisteredResponse>(await response.Content.ReadAsStringAsync());
            return responseObject;
        }

    }
}