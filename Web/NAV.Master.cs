using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Models;

namespace Web
{
    public partial class navi : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user_id"] != null)
            {
                touxiang.ImageUrl = Session["user_photo"].ToString();
                TX.HRef = "javascript:void(0)";
            }
        }
        protected void loginout_click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("Index.aspx");
        }
    }
}