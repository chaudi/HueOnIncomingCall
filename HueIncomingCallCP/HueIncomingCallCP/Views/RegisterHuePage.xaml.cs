using HueOnIncomingCall.Hue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HueIncomingCallCP.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegisterHuePage : ContentPage
    {
        public RegisterHuePage()
        {
            InitializeComponent();
        }

        private async Task Button_Clicked(object sender, EventArgs e)
        {
            HueCommunicator hc = new HueCommunicator(IPField.Text);
            var response = await hc.RegisterApp(new HueOnIncomingCall.Hue.Messages.RegisterUserRequest { DeviceType = "LUL" });
            Application.Current.Properties["Username"] = response.UserName;
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {

        }
    }
}
