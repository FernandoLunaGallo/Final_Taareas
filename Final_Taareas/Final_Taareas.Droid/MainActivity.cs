using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Microsoft.WindowsAzure.MobileServices;
using System.Threading.Tasks;

namespace Final_Taareas.Droid
{
    [Activity(Label = "Final_Taareas", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global:: Xamarin.Forms.Platform.Android.FormsApplicationActivity, loguin
    {
        private MobileServiceUser user;
        public async Task<MobileServiceUser> Autentication()
        {
            var success = false;
            try
            {
                user = await Final_Taareas.Diseño.client.LoginAsync(this, MobileServiceAuthenticationProvider.WindowsAzureActiveDirectory);
                if (user != null)
                {
                    success = true;
                }
            }
            catch (Exception ex)
            {
                AlertDialog.Builder buider = new AlertDialog.Builder(this);
                buider.SetMessage(ex.Message);
                buider.SetTitle("Error Message");
                buider.Create().Show();
            }
            return user;
        }

     

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            Microsoft.WindowsAzure.MobileServices.CurrentPlatform.Init();
            global::Xamarin.Forms.Forms.Init(this, bundle);
            Diseño.Init((loguin)this);
            LoadApplication(new App());
        }
    }
}

