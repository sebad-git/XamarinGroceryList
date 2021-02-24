using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace XamarinGroceryList.Services {

    public enum AppPages {
        Main,
        Add_Item
    }
    public interface INavigationService {

        void Navigate(AppPages nextPage);

        void Alert(string title,string message,string button);

    }
}
