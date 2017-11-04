using System;
using Android.App;
using Android.Runtime;
using Plugin.PushNotification;

namespace PushNotify.Droid
{
    [Application]
   public class MainApplication:Application
    {
        protected MainApplication(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
        {
        }

        public override void OnCreate()
        {
            base.OnCreate();

            //If debug you should reset the token each time.
#if DEBUG
            PushNotificationManager.Initialize(this, true);
#else
              PushNotificationManager.Initialize(this,false);
#endif

            //Handle notification when app is closed here
            CrossPushNotification.Current.OnNotificationReceived += (s, p) =>
            {


            };
        }
        }
}