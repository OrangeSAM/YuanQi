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
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {   if (!IsPostBack) { 
            BindContest();
                Biz.TargetPath = Request.RawUrl;
            }
        }
        public void BindContest()
        {
            DataTable dt = ContestManager.SelectAll();
            if (dt != null && dt.Rows.Count > 0)
            {
                LVContest .DataSource = dt;
                LVContest .DataBind();
            }
        }
        protected void contestpager_PreRender(object sender, EventArgs e)
        {

            BindContest();

        }
    }
    
}