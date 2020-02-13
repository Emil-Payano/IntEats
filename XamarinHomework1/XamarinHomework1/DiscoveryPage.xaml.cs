using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinHomework1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DiscoveryPage : ContentPage
    {
        public DiscoveryPage()
        {
            InitializeComponent();
        }

        public void CambiarColor(BoxView boxView)
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
            CambiarColor(Boxview11);

        }
        private void Click2(object sender, EventArgs e)
        {
            CambiarColor(Boxview2);

        }
        private void Click3(object sender, EventArgs e)
        {
            CambiarColor(Boxview3);



        }
        private void Click4(object sender, EventArgs e)
        {
            CambiarColor(Boxview4);



        }
        private void Click5(object sender, EventArgs e)
        {
            CambiarColor(Boxview5);


        }
        private void Click6(object sender, EventArgs e)
        {
            CambiarColor(Boxview6);

        }
    }
}