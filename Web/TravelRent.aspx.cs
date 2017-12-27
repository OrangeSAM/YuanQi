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
    public partial class WebForm10 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                BindHot();
                Bindgoods();
          
            }
        }
        public void BindHot()
        {
            //int stock = Convert.ToInt32(Request.QueryString["id"]);
            DataTable dt = GoodsManager.SelectHotgoods();
            LVhot.DataSource = dt;
            LVhot.DataBind();
        }
        public void Bindgoods()
        {
            DataTable dt = GoodsManager.SelectAll();
            LVgoods .DataSource = dt;
            LVgoods.DataBind();
        }

        protected void datapager_PreRender(object sender, EventArgs e)
        {
            Bindgoods();
        }
    }
}