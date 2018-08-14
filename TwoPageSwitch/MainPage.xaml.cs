using System;
using Xamarin.Forms;

namespace TwoPageSwitch
{
    public partial class MainPage : ContentPage
    {
        bool Toggled { get; set; }

        public MainPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        void Handle_Toggled(object sender, ToggledEventArgs e)
        {
            Toggled = e.Value;
        }

        void Handle_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PageTwo(Toggled));
        }
    }
}
