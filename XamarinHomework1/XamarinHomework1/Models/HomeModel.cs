using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;
using XamarinHomework1.ViewModels;


namespace XamarinHomework1.Models
{
  public class HomeModel : INotifyPropertychanged
    {

        public event PropertyChangedEventHandler PropertyChanged;
        public string Icon { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public Xamarin.Forms.Color BoxColor { get; set; }



    }
}
