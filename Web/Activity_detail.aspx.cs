using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using BLL;

namespace Web
{
    public partial class WebForm9 : System.Web.UI.Page
    {
        static bool visibleflag;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                visibleflag = true;
                BindAct_de();
            }


        }
        public void BindAct_de()
        {
            int id = Convert.ToInt32(Request.QueryString["id"]);
            DataTable dt = ActivityManager.SelectActivity(id);
            if (dt != null && dt.Rows.Count > 0)
            {
                LVact_de.DataSource = dt;
                LVact_de.DataBind();
            }


        }
        protected void lbtnjoin_click(object sender, EventArgs e)
        {
            LinkButton bt = (LinkButton)sender;
            Panel Paneljoin = bt.Parent.FindControl("joinpanel") as Panel;
            Paneljoin.Visible = true;
            visibleflag = !visibleflag;
        }
    }
}
