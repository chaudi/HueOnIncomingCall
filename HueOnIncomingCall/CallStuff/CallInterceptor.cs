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
using Android.Telephony;

namespace HueOnIncomingCall.CallStuff
{
    public class CallInterceptor : PhoneStateListener
    {

        Context context;

        public CallInterceptor(Context context_)
        {
            this.context = context_;
        }

        public override void OnCallStateChanged(CallState state, string incomingNumber)
        {
            if (state == CallState.Ringing)
            {
                
                base.OnCallStateChanged(state, incomingNumber);
            }
        }
    }
}