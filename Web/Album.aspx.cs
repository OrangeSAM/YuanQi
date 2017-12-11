using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using System.Data;
using Models;

namespace Web
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BindAlbumPhoto();
        }
        public void BindAlbumPhoto()
        {
            DataTable dt = AlbumManager.SelectAll();
            if(dt!=null && dt.Rows.Count!=0)
            {
                DataList1.DataSource = dt;
                DataList1.DataBind();
            }
        }
    }
}