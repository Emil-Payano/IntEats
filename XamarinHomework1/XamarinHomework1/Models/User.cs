using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using XamarinHomework1.ViewModels;

namespace XamarinHomework1.Models
{
  public class User : INotifyPropertychanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public string Email { get; set; }
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public string PassWord1 { get; set; }
        public bool Condition { get; set; }

    }
}
