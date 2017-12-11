using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using BLL;
using System.Data.SqlClient;

namespace Web
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          
            BindNews();
            BindNewsID();
        }
        public void BindNews()
        {
            DataTable dt = Contest_newsManager.SelectAll();
            if (dt != null && dt.Rows.Count != 0)
            {
                ElseNewsListView .DataSource = dt;
                ElseNewsListView .DataBind();
            }
        }
        public void BindNewsID()
        {
            int id = Convert.ToInt32(Request.QueryString["id"]);
            DataTable dt = Contest_newsManager.SelectNews(id);
            if (dt != null && dt.Rows.Count > 0)
            {
                NewsContentRepeater.DataSource = dt;
                NewsContentRepeater.DataBind();
            }
        }

    }
}