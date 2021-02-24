using GalaSoft.MvvmLight.Command;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using XamarinGroceryList.Models;
using XamarinGroceryList.Services;

namespace XamarinGroceryList.ViewModel {
    class GroceryListViewModel : BaseViewModel {
        #region Attributes
        private List<GroceryItem> groceryItems = new List<GroceryItem>();
        //private GroceryItem selectedItem = null;
        #endregion

        #region Properties
        public List<GroceryItem> GroceryItems { get { return groceryItems; } }
        
        /*
        public GroceryItem SelectedItem {
            get { return selectedItem; }
            set { selectedItem = value;
            if (selectedItem == null) return;
               OnItemSelected();
               SelectedItem = null;
            }
        }
        */
        #endregion

        #region Constructor

        #endregion
        public GroceryListViewModel() {
            Task.Run(AddDummyData);
        }
        #region Commands
        public ICommand AddItemCommand {
            get { return new RelayCommand(AddItem); }
        }
        #endregion

        #region Methods
        public void AddItem(){
            App.NavigationService.Navigate(AppPages.Add_Item);
        }
        /*
        private void OnItemSelected(){
            if (selectedItem == null) { return; }
        }
        */

        private void AddDummyData() {
            GroceryItems.Add(new GroceryItem("Eggs"));
            GroceryItems.Add(new GroceryItem("Apples"));
            GroceryItems.Add(new GroceryItem("Milk"));
            GroceryItems.Add(new GroceryItem("Ice Cream"));
            GroceryItems.Add(new GroceryItem("Soda"));
        }
        #endregion
    }
}
