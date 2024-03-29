using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace web_khachsan
{
    public class CartItem
    {
        public int Quantity { get; set; }
        public Product Pr { get; set; }

        /*public CartItem(int quantity, Product product)
        {
            Quantity = quantity;
            Product = product;
        }

        //ds sản phẩm trong giỏ hàng
        private List<CartItem> cartItems;

        //truy vấn csdl để lấy thông tin sản phẩm theo id
        private Product GetProductById(int id)
        {
            //kết nối csdl lấy thông tin sản phẩm
            Product product = new Product() { };
        }*/
    }
}