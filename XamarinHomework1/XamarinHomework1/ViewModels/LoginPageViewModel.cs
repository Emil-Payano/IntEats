using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using XamarinHomework1.Models;

namespace XamarinHomework1.ViewModels
{
    class LoginPageViewModel : INotifyPropertychanged
    {
        public User User { get; set; } = new User();
        public ICommand LoginCommand { get; set; }
        public ICommand GoToSignUpCommand { get; set; }
        public ICommand ShowPassCommand { get; set; }
        public LoginPageViewModel() {

            User.Condition = true;

           LoginCommand = new Command(async() =>
            {
                if (!string.IsNullOrEmpty(User.UserName))
                {

                    if (!string.IsNullOrEmpty(User.PassWord))
                    {
                        await App.Current.MainPage.Navigation.PushAsync(new AppPage());
                    }
                    else
                    {
                        await App.Current.MainPage.Navigation.PushModalAsync(new SignUpPage(User.UserName));
                    }


                }
                else
                {
                    await App.Current.MainPage.DisplayAlert("Alert", "One of the boxes is not filled in", "OK");
                }

            });

            ShowPassCommand = new Command(async () =>
            {
                User.Condition = !User.Condition;

            });

            GoToSignUpCommand = new Command(async () =>
            {
                await App.Current.MainPage.Navigation.PushModalAsync(new SignUpPage(User.UserName));

            });


        }
    }
}
