using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace web_khachsan
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            Application["products"] = new List<Product>();
            Application["cart"] = new List<Product>();
            Application["user"] = new List<User>();

            List<User> uarr = new List<User>();
            uarr.Add(new User() { name = "vu", email = "nguyenvu23hn@gmail.com", password = "123456" });

            List<Product> arr = new List<Product>();

            //
            arr.Add(new Product() { id = "1", img = "images/phong1.jpg", name = "Hue Hotel 1", price = "320000", type = "1" });
            arr.Add(new Product() { id = "2", img = "images/phong2.jpg", name = "Hue Hotel 2", price = "330000", type = "1" });
            arr.Add(new Product() { id = "3", img = "images/phong3.jpg", name = "Hue Hotel 3", price = "350000", type = "1" });
                                                                                
            arr.Add(new Product() { id = "4", img = "images/phong4.jpg", name = "Hue Hotel 4", price = "360000", type = "1" });
            arr.Add(new Product() { id = "5", img = "images/phong5.jpg", name = "Hue Hotel 5", price = "380000", type = "1" });
            arr.Add(new Product() { id = "6", img = "images/phong6.jpg", name = "Hue Hotel 6", price = "400000", type = "1" });
                                                            
            //                    
            arr.Add(new Product() { id = "7", img = "images/phong7.jpg", name = "Timothy Homestay Huế 1", price = "380000", type = "2" });
            arr.Add(new Product() { id = "8", img = "images/phong8.jpg", name = "Timothy Homestay Huế 2", price = "400000", type = "2" });
            arr.Add(new Product() { id = "9", img = "images/phong9.jpg", name = "Timothy Homestay Huế 3", price = "430000", type = "2" });

            arr.Add(new Product() { id = "10", img = "images/phong10.jpg", name = "Timothy Homestay Huế 4", price = "450000", type = "2" });
            arr.Add(new Product() { id = "11", img = "images/phong11.jpg", name = "Timothy Homestay Huế 5", price = "450000", type = "2" });
            arr.Add(new Product() { id = "12", img = "images/phong12.jpg", name = "Timothy Homestay Huế 6", price = "470000", type = "2" });
                                                             
            //                 
            arr.Add(new Product() { id = "13", img = "images/phong13.jpg", name = "Trường Tiền Hotel 1", price = "400000", type = "3" });
            arr.Add(new Product() { id = "14", img = "images/phong14.jpg", name = "Trường Tiền Hotel 2", price = "430000", type = "3" });
            arr.Add(new Product() { id = "15", img = "images/phong15.jpg", name = "Trường Tiền Hotel 3", price = "450000", type = "3" });
                                                                                                          
            arr.Add(new Product() { id = "16", img = "images/phong16.jpg", name = "Trường Tiền Hotel 4", price = "450000", type = "3" });
            arr.Add(new Product() { id = "17", img = "images/phong17.jpg", name = "Trường Tiền Hotel 5", price = "480000", type = "3" });
            arr.Add(new Product() { id = "18", img = "images/phong18.jpg", name = "Trường Tiền Hotel 6", price = "500000", type = "3" });

            //3                                                    
            arr.Add(new Product() { id = "19", img = "images/phong19.jpg", name = "Melia Vinpearl Hotel Huế 1", price = "2500000", type = "4" });
            arr.Add(new Product() { id = "20", img = "images/phong20.jpg", name = "Melia Vinpearl Hotel Huế 2", price = "2600000", type = "4" });
            arr.Add(new Product() { id = "21", img = "images/phong21.jpg", name = "Melia Vinpearl Hotel Huế 3", price = "2700000", type = "4" });
                                                                                                       
            arr.Add(new Product() { id = "22", img = "images/phong22.jpg", name = "Melia Vinpearl Hotel Huế 4", price = "2800000",type = "4" });
            arr.Add(new Product() { id = "23", img = "images/phong23.jpg", name = "Melia Vinpearl Hotel Huế 5", price = "2900000",type = "4" });
            arr.Add(new Product() { id = "24", img = "images/phong24.jpg", name = "Melia Vinpearl Hotel Huế 6", price = "3000000",type = "4" });

           


            Application["products"] = arr;
        }

        protected void Session_Start(object sender, EventArgs e)
        {
            Session["login"] = 0;
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    
    }
}