
using Badge.Plugin;
using Plugin.Notifications;
using System;
using Xamarin.Forms;

namespace LDNotificationBadge
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            int cantidad = 0;
            try
            {
                cantidad = Convert.ToInt32(entrycantidad.Text);
            }
            catch (Exception)
            {
            }
            switch (Device.RuntimePlatform)
            {
                case Device.Android:
                    CrossBadge.Current.SetBadge( cantidad, "Notificaciones");
                    break;
                case Device.iOS:
                    CrossNotifications.Current.SetBadge(cantidad);
                    break;
            }
        }
    }
}
