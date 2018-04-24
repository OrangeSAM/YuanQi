using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using System.Data;

namespace Web
{
    public partial class WebForm6 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                BindTravel();
                BindTravel1();
                Biz.TargetPath = Request.RawUrl;
            }
        }
        public void BindTravel()
        {
            DataTable dt = Travel_recordManager.SelectAll();
            if(dt!=null && dt.Rows.Count!=0)
            {
                LVTravel.DataSource = dt;
                LVTravel.DataBind();
            }
        }
        public void BindTravel1()
        {
            DataTable dt = Travel_recordManager.SelectTop(5);
            if (dt != null && dt.Rows.Count != 0)
            {
                LVTravel1.DataSource = dt;
                LVTravel1.DataBind();
            }
        }
    }
}