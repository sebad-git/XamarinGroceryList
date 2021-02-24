using GalaSoft.MvvmLight.Command;
using System.Collections.Generic;
using System.Windows.Input;
using Xamarin.Forms;
using XamarinGroceryList.Models;
using XamarinGroceryList.Services;

namespace XamarinGroceryList.ViewModel {
    class GroceryListViewModel : BaseViewModel {
        #region Attributes
        private List<GroceryItem> groceryItems = null;
        private GroceryItem selectedItem = null;
        #endregion

        #region Properties
        public List<GroceryItem> GroceryItems { 
            get { 
             if (groceryItems == null){ groceryItems = new List<GroceryItem>(); } 
             return groceryItems; 
            }
        }
        public GroceryItem SelectedItem {
            get { return selectedItem; }
            set { selectedItem= value;
            if (selectedItem == null) return;
               OnItemSelected(); 
               SelectedItem = null;
            }
        }
        #endregion

        #region Constructor

        #endregion
        public GroceryListViewModel() {
            GroceryItems.Add(new GroceryItem("Vegetables"));
            GroceryItems.Add(new GroceryItem("Fruits"));
        }
        #region Commands
        public ICommand AddItemCommand {
            get { return new RelayCommand(AddItem); }
        }
        #endregion

        #region Methods
        public void AddItem(){
            NavigationService.Instance.Navigate(AppPages.Add_Item);
        }
        private void OnItemSelected(){
            if (this.selectedItem == null) { return; }
            NavigationService.Instance.Alert("Selected", this.selectedItem.Name, "ok");
        }
        #endregion
    }
}
