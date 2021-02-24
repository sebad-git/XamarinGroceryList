using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using XamarinGroceryList.Models;

namespace XamarinGroceryList.Services {
    public class DataBaseService : IDataBaseService {

        private List<GroceryItem> groceryItems = new List<GroceryItem>();

        public List<GroceryItem> ListGroceries() {
            if (groceryItems.Count == 0) {
                groceryItems.Add(new GroceryItem("Eggs"));
                groceryItems.Add(new GroceryItem("Apples"));
                groceryItems.Add(new GroceryItem("Milk"));
                groceryItems.Add(new GroceryItem("Ice Cream"));
                groceryItems.Add(new GroceryItem("Soda"));
            }
            return groceryItems;
        }

        public void SaveAll(List<GroceryItem> list) {
            groceryItems.Clear();
            groceryItems.AddRange(list);
        }
    }
}
