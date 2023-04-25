using System;
using System.Collections.Generic;
using System.Text;

namespace OrdersApplication
{
    class Order
    {
        // Instance variables for the order.
        private int _id;
        private int _totalItems;

         public Order(int id)
        {
            _id = id;
            _totalItems = 0;
        }

        /// <summary>
        /// Gets and sets the id of the order.
        /// </summary>
        public int id
        {
            get { return _id; }
            set { _id = value; }
        }

        /// <summary>
        /// Adds an item to the order.
        /// </summary>
        /// <param name="itemName">The name of the item.</param>
        public void AddItem(string itemName)
        {
            _totalItems += 1;
        }

        /// <summary>
        /// Gets the total items for the order.
        /// </summary>
        public int TotalItems
        {
            get { return _totalItems; }
        }
    }
}
