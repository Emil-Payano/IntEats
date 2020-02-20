using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinHomework1.ViewModels;

namespace XamarinHomework1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SignUpPage : ContentPage
    {
        public SignUpPage(string emailparametroP)
        {
            InitializeComponent();
            emailParametro2.Text = emailparametroP;
            BindingContext = new SignUpPageViewModel();

        }

       
    }
}