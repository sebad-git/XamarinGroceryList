using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using XamarinGroceryList.Views;

namespace XamarinGroceryList.Services {
    public class NavigationService : INavigationService {

        private Dictionary<AppPages, Page> stack;
        public Page CurrentPage { get; private set; }

        public NavigationService() { stack = new Dictionary<AppPages, Page>(); this.RoutePages(); }

        public void RoutePages() {
            stack.Add(AppPages.Main, Application.Current.MainPage);
            stack.Add(AppPages.Add_Item, new AddItemPage());
        }

        public async void Navigate(AppPages nextPage) {
            try {
                CurrentPage = stack[nextPage];
                await Application.Current.MainPage.Navigation.PushAsync(stack[nextPage]);
            }
            catch (System.Exception e) {
                await Application.Current.MainPage.DisplayAlert("Error", e.Message, "Ok");
            }
        }

        public async void Alert(string title, string message, string button) {
            await Application.Current.MainPage.DisplayAlert(title,message,button);
        }
    }
}
