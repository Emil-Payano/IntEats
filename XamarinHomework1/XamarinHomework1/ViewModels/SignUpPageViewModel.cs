using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using XamarinHomework1.Models;

namespace XamarinHomework1.ViewModels
{
    class SignUpPageViewModel : INotifyPropertychanged
    {
        public User User { get; set; } = new User();
        public ICommand GoLoginCommand { get; set; }
        public ICommand ShowPassCommand { get; set; }
        public ICommand ShowPassCommand1 { get; set; }
        public SignUpPageViewModel() 
        {
            User.Condition = true;

            ShowPassCommand = new Command(async () =>
            {
                User.Condition = !User.Condition;

            });

            ShowPassCommand1 = new Command(async () =>
            {
                User.Condition = !User.Condition;

            });

            GoLoginCommand = new Command(async () =>
            {
                await App.Current.MainPage.Navigation.PopModalAsync();

            });
        }

    }
}
