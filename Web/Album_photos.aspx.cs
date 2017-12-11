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
    public partial class WebForm5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BindAlbumCover();
            BindPhoto();
        }
        public void BindAlbumCover()
        {
            int id = Convert.ToInt32(Request.QueryString["id"]);
            DataTable dt = AlbumManager.SelectAlbumCover(id);
            if(dt!=null &&dt.Rows.Count != 0)
            {
                LVPhoto.DataSource = dt;
                LVPhoto.DataBind();
            }
        }
        public void BindPhoto()
        {
            int id = Convert.ToInt32(Request.QueryString["id"]);
            DataTable dt = Album_photoManager.SelectAlbumId(id);
            if(dt!=null && dt.Rows.Count>0)
            {
                PhotoDetile.DataSource = dt;
                PhotoDetile.DataBind();
            }
        }
        
    }
}