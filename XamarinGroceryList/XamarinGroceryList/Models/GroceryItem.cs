using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinGroceryList.Models {
    public class GroceryItem {

        #region Properties
        public string Name { get; set; }
        
        public bool Checked { get; set; }
        #endregion

        #region Constructor
        public GroceryItem(){}
        public GroceryItem(string _name, bool _ckecked) {
            this.Name = _name; this.Checked = _ckecked;
        }
        public GroceryItem(string _name) {
            this.Name = _name; this.Checked = false;
        }
        #endregion
    }
}
