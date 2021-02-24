using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using XamarinGroceryList.ViewModel;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinGroceryList.Services;

namespace XamarinGroceryList.Views {
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GroceryListPage : ContentPage {
        public INavigationService NavigationService { get; set; }
        public GroceryListPage() {
            InitializeComponent();
            BindingContext = new GroceryListViewModel();
            NavigationService = new NavigationService();
        }
    }
}