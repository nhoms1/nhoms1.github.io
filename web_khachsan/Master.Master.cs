using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace web_khachsan
{
    public partial class Master : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["login"].ToString() == "1")
            {
                loregisterlogin.InnerHtml = "<a href=\"userinformation.aspx\">Cá Nhân</a>";
                Session["url"] = Page.Request.Url.ToString();
            }
            else
            {
                loregisterlogin.InnerHtml = "<a href=\"account.aspx\">Tài khoản</a> ";
            }
        }
    }
}