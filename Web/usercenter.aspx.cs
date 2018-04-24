using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Models;
using BLL;

namespace Web
{
    public partial class usercenter : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BindUserDetails();
            gettrrecord();
            getalbum();
            getact();
            getesalbums();
            getreocrd_col();
            getindent();
            Biz.TargetPath = Request.RawUrl;
        }
        
        /// <summary>
        /// 三层皆有更新，对于getsingleuser方法
        /// </summary>
        protected void BindUserDetails()
        {
            string userid = Session["user_id"].ToString();
            DataTable userdetail = BLL.UsersManager.getsingleuser(userid);
            if (userdetail !=null & userdetail.Rows.Count == 1)
            {
                headpor.ImageUrl = userdetail.Rows[0][3].ToString();
                user_name.Text ="欢迎你" + userdetail.Rows[0][1].ToString();
            }
        }
        protected void gettrrecord()
        {
            string userid = Session["user_id"].ToString();
            DataTable dt = Travel_recordManager.SelectUserTravel_record(userid);
            if(dt !=null && dt.Rows.Count != 0)
            {
                trrecords.DataSource = dt;
                trrecords.DataBind();
            }
        }
        /// <summary>
        /// 三层皆有更新
        /// </summary>
        protected void getalbum()
        {
            string userid = Session["user_id"].ToString();
            DataTable dts = Album_colManager.getusercol(userid);
            if(dts != null && dts.Rows.Count !=0)
            {
                albums.DataSource = dts;
                albums.DataBind();
            }
        }
        
        protected void getact()
        {
            string username =Session["user_name"].ToString(); ;
            DataTable dts = ActivityManager.Selectusers(username);
            if(dts !=null && dts.Rows.Count != 0)
            {
                actives.DataSource = dts;
                actives.DataBind();
            }
        }
        protected void getesalbums()
        {
            int userid = (int)Session["user_id"];
            DataTable dts = AlbumManager.Selectusers(userid);
            if(dts !=null && dts.Rows.Count != 0)
            {
                esalbums.DataSource = dts;
                esalbums.DataBind();
            }
        }
        protected void getindent()
        {
            int userid = (int)Session["user_id"];
            DataTable dts = GoodsManager.SelectIndent(userid);
            if(dts != null && dts.Rows.Count != 0)
            {
                indents.DataSource = dts;
                indents.DataBind();
            }
        }
        protected void getreocrd_col()
        {
            int userid = (int)Session["user_id"];
            DataTable dts = Travel_recordManager.SelectUserrecord_col(userid);
            if (dts != null && dts.Rows.Count != 0)
            {
                record_col.DataSource = dts;
                record_col.DataBind();
            }
        }

    }
}