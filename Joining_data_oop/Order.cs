using System;
using System.Collections.Generic;
using System.Text;

namespace Joining_data_oop
{
    class Order
    {
        private string _customerName;
        private string _item;
        private decimal _price;
        private int _quanity;

        public string CustomerName
        {
            get { return this._customerName; }
            set { this._customerName = value; }
        }
        public string Item
        {
            get { return this._item; }
            set { this._item = value; }
        }
        public decimal Price
        {
            get { return this._price; }
            set { this._price = value; }
        }
        public int Quanity
        {
            get { return this._quanity; }
            set { this._quanity = value; }
        }
        public Order(string customerName, string item, decimal price, int quanity)
        {
            this._customerName = customerName;
            this._item = item;
            this._price = price;
            this._quanity = quanity;
        }
    }
}
