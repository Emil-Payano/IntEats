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
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void ShowPass(object sender, EventArgs e)
        {

            PasswordEntry.IsPassword = !PasswordEntry.IsPassword;
           
        }

        async void Button_Clicked(object sender, EventArgs e)
        {
          
           await Navigation.PushModalAsync(new SignUpPage(EmailEntry.Text));
             
      
        }

        async void Button_Clicked_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(EmailEntry.Text))
            {
                
                    if (!string.IsNullOrEmpty(PasswordEntry.Text))
                    {
                    await Navigation.PushAsync(new AppPage());
                    }
                    else
                    { 
                    await Navigation.PushModalAsync(new SignUpPage(EmailEntry.Text));
                    }

                
            }
            else
            {
                await DisplayAlert("Alert", "One of the boxes is not filled in", "OK");
            }
        }
    }
}
