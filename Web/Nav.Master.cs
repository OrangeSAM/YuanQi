using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web
{
    public partial class navi : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["user_name"] != null)
                {
                    PanelUser.Visible = true;
                    PanelLogin.Visible = false;
                    lblUser.Text = Session["user_name"].ToString();
                }
                else
                {
                    PanelLogin.Visible = true;
                    PanelUser.Visible = false;
                }
            }
        }
        protected void loginout_click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("Index.aspx");
        }
    }
}