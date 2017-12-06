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
                BindDayPhoto();
                BindNews();
                BindTravel_record();
                BindContest();
                BindAlbum();
            }

        }
        public void BindDayPhoto()
        {
            DataTable dt = DayphotoManager.Selecttopphoto(4);
            if (dt != null && dt.Rows.Count != 0)
            {
                Repeater1.DataSource = dt;
                Repeater1.DataBind();
            }
        }
        public void BindNews()
        {
            DataTable dt = Contest_newsManager.SelectAll();
            if (dt != null && dt.Rows.Count != 0)
            {
                ListView1.DataSource = dt;
                ListView1.DataBind();
            }
        }
        public void BindTravel_record()
        {
            DataTable dt = Travel_recordManager.SelectAll();
            if (dt != null && dt.Rows.Count != 0)
            {
                LVtravel.DataSource = dt;
                LVtravel.DataBind();
            }
        }
        public void BindContest()
        {
            DataTable dt = ContestManager.SelectAll();
            if (dt != null && dt.Rows.Count != 0)
            {
                LVContest.DataSource = dt;
                LVContest.DataBind();
            }
        }
        public void BindAlbum()
        {
            DataTable dt = AlbumManager.SelectAll();
            if (dt != null && dt.Rows.Count != 0)
            {
                DataList1.DataSource = dt;
                DataList1.DataBind();
            }
        }

    }
}
