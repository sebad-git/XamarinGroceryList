using System;
using System.Collections.Generic;
using System.Text;
using XamarinGroceryList.Models;

namespace XamarinGroceryList.Services {
    public interface IDataBaseService {

        List<GroceryItem> ListGroceries();
        void SaveAll(List<GroceryItem> list);

    }
}
