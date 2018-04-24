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
    public partial class WebForm17 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Bindstores();
                Biz.TargetPath = Request.RawUrl;
            }
               
        }
        public void Bindstores()
        {
            DataTable dt = StoreManager.SelectAll();
            if (dt != null && dt.Rows.Count > 0)
            {
                LVstores.DataSource = dt;
                LVstores.DataBind();
            }

        }
    }
}