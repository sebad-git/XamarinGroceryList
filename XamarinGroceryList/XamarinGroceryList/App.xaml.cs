using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinGroceryList.Views;

namespace XamarinGroceryList {
    public partial class App : Application {
        public App() {
            InitializeComponent();
            MainPage = new NavigationPage(new GroceryListPage());
        }

        protected override void OnStart() { }

        protected override void OnSleep() {}

        protected override void OnResume() {}
    }
}
