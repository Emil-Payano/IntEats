using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using XamarinHomework1.Models;

namespace XamarinHomework1.ViewModels
{
    public class DiscoveryPageViewModel : INotifyPropertychanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public HomeModel FirstElement { get; set; } = new HomeModel();

        public HomeModel SecondElement { get; set; } = new HomeModel();

        public HomeModel ThirdElement { get; set; } = new HomeModel();

        public HomeModel FourthElement { get; set; } = new HomeModel();

        public HomeModel FithElement { get; set; } = new HomeModel();

        public HomeModel SixElement { get; set; } = new HomeModel();

        public ICommand ChangeColorCommand { get; set; }
        public ICommand ChangeColorCommand1 { get; set; }
        public ICommand ChangeColorCommand2 { get; set; }
        public ICommand ChangeColorCommand3 { get; set; }
        public ICommand ChangeColorCommand4 { get; set; }
        public ICommand ChangeColorCommand5 { get; set; }
        public DiscoveryPageViewModel() {

            FirstElement.Icon = "BeerIcon";
            FirstElement.Title = "Bars Hotels";
            FirstElement.SubTitle = "42 Place";
            FirstElement.BoxColor = Color.White;

            SecondElement.Icon = "CafesIcon";
            SecondElement.Title = "Cafes";
            SecondElement.SubTitle = "26 Place";
            SecondElement.BoxColor = Color.White;

            ThirdElement.Icon = "FastFoodIcon";
            ThirdElement.Title = "Fast Food";
            ThirdElement.SubTitle = "29 Place";
            ThirdElement.BoxColor = Color.White;

            FourthElement.Icon = "DiningIcon";
            FourthElement.Title = "Dining";
            FourthElement.SubTitle = "16 Place";
            FourthElement.BoxColor = Color.White;

            FithElement.Icon = "NearbyIcon";
            FithElement.Title = "Nearby";
            FithElement.SubTitle = "34 Place";
            FithElement.BoxColor = Color.White;

            SixElement.Icon = "FeaturedFoodsIcon";
            SixElement.Title = "Featured Foods";
            SixElement.SubTitle = "21 Place";
            SixElement.BoxColor = Color.White;

            ChangeColorCommand = new Command(() =>
            {

                FirstElement.BoxColor = Color.Yellow;
                SecondElement.BoxColor = Color.White;
                ThirdElement.BoxColor = Color.White;
                FourthElement.BoxColor = Color.White;
                FithElement.BoxColor = Color.White;
                SixElement.BoxColor = Color.White;

            });

            ChangeColorCommand1 = new Command(() =>
            {

                FirstElement.BoxColor = Color.White;
                SecondElement.BoxColor = Color.Yellow;
                ThirdElement.BoxColor = Color.White;
                FourthElement.BoxColor = Color.White;
                FithElement.BoxColor = Color.White;
                SixElement.BoxColor = Color.White;

            });

            ChangeColorCommand2 = new Command(() =>
            {

                FirstElement.BoxColor = Color.White;
                SecondElement.BoxColor = Color.White;
                ThirdElement.BoxColor = Color.Yellow;
                FourthElement.BoxColor = Color.White;
                FithElement.BoxColor = Color.White;
                SixElement.BoxColor = Color.White;

            });

            ChangeColorCommand3 = new Command(() =>
            {

                FirstElement.BoxColor = Color.White;
                SecondElement.BoxColor = Color.White;
                ThirdElement.BoxColor = Color.White;
                FourthElement.BoxColor = Color.Yellow;
                FithElement.BoxColor = Color.White;
                SixElement.BoxColor = Color.White;
            });

            ChangeColorCommand4 = new Command(() =>
            {

                FirstElement.BoxColor = Color.White;
                SecondElement.BoxColor = Color.White;
                ThirdElement.BoxColor = Color.White;
                FourthElement.BoxColor = Color.White;
                FithElement.BoxColor = Color.Yellow;
                SixElement.BoxColor = Color.White;
            });

            ChangeColorCommand5 = new Command(() =>
            {
                FirstElement.BoxColor = Color.White;
                SecondElement.BoxColor = Color.White;
                ThirdElement.BoxColor = Color.White;
                FourthElement.BoxColor = Color.White;
                FithElement.BoxColor = Color.White;
                SixElement.BoxColor = Color.Yellow;
            });    
        }
        
    }
}
