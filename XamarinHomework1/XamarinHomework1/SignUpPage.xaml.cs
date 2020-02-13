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
    public partial class SignUpPage : ContentPage
    {
        public SignUpPage(string emailparametroP)
        {
            InitializeComponent();
            emailParametro2.Text = emailparametroP;

        }

        private void ShowPass(object sender, EventArgs e)
        {
            Password.IsPassword = !Password.IsPassword;
          
        }

        private void ShowPass1(object sender, EventArgs e)
        {
            RepeatPassword.IsPassword = !RepeatPassword.IsPassword;
           
        }

        private void VolverLogin(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }

        private void Register(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }
    }
}