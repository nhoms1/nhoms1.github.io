using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace web_khachsan
{
    public class Product
    {
        public string id { get; set; }
        public string img { get; set; }
        public string name { get; set; }
        public string price { get; set; }
        public string quantity { get; set; }
        public string type { get; set; }

    

        public Product(string id, string name, string price, string quantity,  string type)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.quantity = quantity;
            this.type = type;
        }

        public Product()
        {
        }
    }
}