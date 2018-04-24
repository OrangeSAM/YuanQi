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
            if (!IsPostBack)
            {
            BindAlbumPhoto();
            Biz.TargetPath = Request.RawUrl;
            }
        }
        public void BindAlbumPhoto()
        {
            DataTable dt = AlbumManager.SelectAll();
            if(dt!=null && dt.Rows.Count!=0)
            {
                LVAlbum1.DataSource = dt;
                LVAlbum1.DataBind();
            }
        }
        protected void albumpager_PreRender(object sender, EventArgs e)
        {

            BindAlbumPhoto();

        }

    }
}