using Xamarin.Forms;

namespace TwoPageSwitch
{
    public partial class PageTwo : ContentPage
    {
        public PageTwo()
        {
            InitializeComponent();
        }

        public PageTwo(bool toggled)
        {
            InitializeComponent();
            imgToggled.Source = toggled ? "image1" : "image2";
        }
    }
}
