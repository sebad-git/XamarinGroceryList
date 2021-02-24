using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinGroceryList.Models {
    class GroceryItem {

        #region Properties
        public string Name { get; set; }
        public bool Ckecked { get; set; }

        #endregion

        #region Constructor
        public GroceryItem(){}
        public GroceryItem(string _name, bool _ckecked) {
            this.Name = _name; this.Ckecked = _ckecked;
        }
        public GroceryItem(string _name) {
            this.Name = _name; this.Ckecked = false;
        }
        #endregion

        #region Methods

        #endregion
    }
}
