using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace web_khachsan
{
    public partial class cart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            float totalprice = 0;
            //int quantity = Convert.ToInt32(Session["quantity"].ToString()); 
            List<Product> arr = (List<Product>)Application["cart"];
            foreach (Product pr in arr)
            {
                totalprice += float.Parse(pr.price) /** quantity*/;
            }
            cartList.DataSource = arr;
            cartList.DataBind();
            TotalProduct.Text = arr.Count.ToString();
            TotalPriceProduct.Text = totalprice.ToString();


        }

        protected void btnRemove_Click(object sender, EventArgs e)
        {
            string id = ((Button)sender).CommandArgument.ToString();
            List<Product> arr = (List<Product>)Application["cart"];
            foreach (Product pr in arr)
            {
                if (pr.id == id)
                {
                    arr.Remove(pr);
                    break;
                }
            }

            Application["cart"] = arr;
            cartList.DataSource = arr;
            cartList.DataBind();
            TotalProduct.Text = arr.Count.ToString();
            Page.Response.Redirect(Page.Request.Url.ToString(), true);
        }

        protected void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            TextBox txtQuantity = (TextBox)sender;
            ListViewItem item = (ListViewItem)txtQuantity.NamingContainer;
            Label lblPrice = (Label)item.FindControl("lblPrice");
            Label lblTotalPrice = (Label)item.FindControl("lblTotalPrice");
            int quantity = Convert.ToInt32(txtQuantity.Text);
            int price = Convert.ToInt32(lblPrice.Text);
            int total = quantity * price;
            lblTotalPrice.Text = total.ToString();
            UpdateCart();
        }

        private void UpdateCart()
        {
            int totalProduct = 0;
            int totalPrice = 0;
            foreach (ListViewItem item in cartList.Items)
            {
                Label lblQuantity = (Label)item.FindControl("lblQuantity");
                TextBox txtQuantity = (TextBox)item.FindControl("txtQuantity");
                Label lblPrice = (Label)item.FindControl("lblPrice");
                Label lblTotalPrice = (Label)item.FindControl("lblTotalPrice");
                int quantity = Convert.ToInt32(txtQuantity.Text);
                int price = Convert.ToInt32(lblPrice.Text);
                int total = quantity * price;
                lblTotalPrice.Text = total.ToString();
                lblQuantity.Text = quantity.ToString();
                totalProduct += quantity;
                totalPrice += total;
                int i = 1;
                Label lblSTT = (Label)item.FindControl("lblSTT");
                lblSTT.Text = i.ToString();
                i++;
            }
            TotalProduct.Text = totalProduct.ToString();
            TotalPriceProduct.Text = totalPrice.ToString();
        }

        protected void btnCheckout_Click(object sender, EventArgs e)
        {
            List<Product> arr = (List<Product>)Application["cart"];
            if (arr.Count == 0)
            {
                Response.Write("<script>confirm('Your cart dont have any product!')</script>");
            }
            else
            {
                if (Session["login"].ToString() == "1") { }
                else
                {
                    Response.Write("<script> var k=confirm('You have to Sign in');" +
                        "if(k==true)window.location='https://localhost:44323/account.aspx';</script>");
                }
            }
        }
    }
}