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
    public partial class WebForm8 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                BindActivity();
                Biz.TargetPath = Request.RawUrl;
            }
        }
        public void BindActivity()
        {
            DataTable dt = ActivityManager.SelectAll();
            if(dt!=null && dt.Rows .Count > 0)
            {
                LVActivity.DataSource = dt;
                LVActivity.DataBind();
            }
        }
        protected void activitypager_PreRender(object sender, EventArgs e)
        {

            BindActivity();

        }
    }
}