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

namespace HueOnIncomingCall.Service
{
    [Service]
    public class PhoneCallService : IntentService
    {
        public override void OnCreate()
        {
            base.OnCreate();
        }

        //this will not be called, however it is require to override
        public override IBinder OnBind(Intent intent)
        {
            return null;
        }

        public override StartCommandResult OnStartCommand(Intent intent, StartCommandFlags flags, int startId)
        {
            base.OnStartCommand(intent, flags, startId);
            /*
            var callDetactor = new PhoneCallDetector(this);
            var tm = (TelephonyManager)base.GetSystemService(TelephonyService);
            tm.Listen(callDetactor, PhoneStateListenerFlags.CallState);
        */
            return StartCommandResult.Sticky;
        }

        protected override void OnHandleIntent(Intent intent)
        {
            throw new NotImplementedException();
        }
    }
}