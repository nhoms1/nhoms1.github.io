using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace web_khachsan
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) // Kiểm tra trang không ở chế độ PostBack
            {
                if (Application["products"] != null)
                {
                    List<Product> arr = (List<Product>)Application["products"];
                    List<Product> arrFeaturedProducts = new List<Product>();
                    List<Product> arrLastestProducts = new List<Product>();

                    foreach (Product pr in arr)
                    {
                        int id;
                        if (int.TryParse(pr.id, out id))
                        {
                            if (id == 5 || id == 11 || id == 18 || id == 21)
                            {
                                arrFeaturedProducts.Add(pr);
                            }
                            if (id == 4 || id == 24 || id == 13 || id == 16 || id == 7 || id == 8)
                            {
                                arrLastestProducts.Add(pr);
                            }
                        }
                        else
                        {
                            // Handle invalid id here, maybe log it or skip the product
                            // Example: Console.WriteLine("Invalid id for product: " + pr.id);
                        }
                    }

                    ListViewFearturedProducts.DataSource = arrFeaturedProducts;
                    ListViewFearturedProducts.DataBind();
/*
                    ListViewLastestProducts.DataSource = arrLastestProducts;
                    ListViewLastestProducts.DataBind();*/
                }
                else
                {
                    // Handle case when "products" in Application state is not initialized
                    // Example: Console.WriteLine("No products available");
                }
            }
        }


    }
}