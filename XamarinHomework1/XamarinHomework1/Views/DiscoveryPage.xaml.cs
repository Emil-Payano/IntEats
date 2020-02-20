using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinHomework1.Models;
using XamarinHomework1.ViewModels;

namespace XamarinHomework1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DiscoveryPage : ContentPage
    {
        public DiscoveryPage()
        {
            InitializeComponent();
            BindingContext = new DiscoveryPageViewModel();
        }

        public void ChangeColor(BoxView boxView)
        {

            Device.StartTimer(TimeSpan.FromSeconds(1), () =>
            {
                if (boxView.BackgroundColor == Color.White)
                {
                    boxView.BackgroundColor = Color.LightGoldenrodYellow;
                    return true;
                }
                else
                {
                    boxView.BackgroundColor = Color.White;
                    return false;
                }

            });


        }
        private void Click1(object sender, EventArgs e)
        {
            ChangeColor(Boxview11);

        }
        private void Click2(object sender, EventArgs e)
        {
            ChangeColor(Boxview2);

        }
        private void Click3(object sender, EventArgs e)
        {
            ChangeColor(Boxview3);



        }
        private void Click4(object sender, EventArgs e)
        {
            ChangeColor(Boxview4);



        }
        private void Click5(object sender, EventArgs e)
        {
            ChangeColor(Boxview5);


        }
        private void Click6(object sender, EventArgs e)
        {
            ChangeColor(Boxview6);

        }
    }
}