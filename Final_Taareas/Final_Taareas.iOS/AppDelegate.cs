using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;
using Microsoft.WindowsAzure.MobileServices;
using System.Threading.Tasks;

namespace Final_Taareas.iOS
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the 
    // User Interface of the application, as well as listening (and optionally responding) to 
    // application events from iOS.
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate, loguin
    {
        //
        // This method is invoked when the application has loaded and is ready to run. In this 
        // method you should instantiate the window, load the UI into it and then make the window
        // visible.
        //
        // You have 17 seconds to return from this method, or iOS will terminate your application.
        //

        private MobileServiceUser user;

        public async Task<MobileServiceUser> Autentication()
        {
            var success = false;
            try
            {
                user = await Final_Taareas.Diseño.client.LoginAsync(UIApplication.SharedApplication.KeyWindow.RootViewController, MobileServiceAuthenticationProvider.Facebook);

                if (user != null)
                {
                    success = true;
                    UIAlertView alert = new UIAlertView("Welcome message", user.UserId, null, "ok", null);
                    alert.Show();
                }
            }

            catch (Exception ex)
            {
                UIAlertView alert = new UIAlertView("Error message", ex.Message, null, "ok", null);
                alert.Show();
            }
            return user;
        }
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            global::Xamarin.Forms.Forms.Init();
            LoadApplication(new App());

            return base.FinishedLaunching(app, options);
        }
    }
}
