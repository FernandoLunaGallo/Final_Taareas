using Microsoft.WindowsAzure.MobileServices;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace Final_Taareas.UWP
{
    public sealed partial class MainPage : loguin
    {
        private MobileServiceUser user;
        public async Task<MobileServiceUser> Autentication()
        {

            //var success = false;

            try
            {
                user = await Final_Taareas.Diseño.client.LoginAsync(MobileServiceAuthenticationProvider.WindowsAzureActiveDirectory);
                if (user != null)
                {
                    //success = true;
                    await new MessageDialog(user.UserId, "Bienvenido").ShowAsync();
                }
            }
            catch (Exception e)
            {
                await new MessageDialog(e.Message, "Error no has podido acceder").ShowAsync();
            }
            return user;
        }
        public MainPage()
        {
            this.InitializeComponent();
            Final_Taareas.Diseño.Init((loguin)this);
            LoadApplication(new Final_Taareas.App());
        }
    }
}
