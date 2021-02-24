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
        #endregion

        #region Properties
        public List<GroceryItem> GroceryItems { get { return groceryItems; } }
        #endregion

        #region Constructor

        #endregion
        public GroceryListViewModel() {
            Task.Run(LoadData);
        }
        #region Commands
        public ICommand SaveCommand {
            get { return new RelayCommand(Save); }
        }
        #endregion

        #region Methods
        public void Save(){
            App.DataBase.SaveAll(GroceryItems);
            Task.Run(LoadData);
        }

        private void LoadData() {
            try {
                List<GroceryItem> data = App.DataBase.ListGroceries();
                GroceryItems.Clear();
                data.ForEach(gro => GroceryItems.Add(gro));
            }
            catch (System.Exception e) {
                System.Diagnostics.Debug.WriteLine(e.Message);
            }
        }
        #endregion
    }
}
