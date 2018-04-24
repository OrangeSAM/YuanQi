using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using Models;
using System.Data;

namespace Web
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Bindcity();
                //BindDayPhoto();
                BindTravel_record();
                BindNews();
                BindContest();
            };
            Biz.TargetPath = Request.RawUrl;
        }
        //public void BindDayPhoto()
        //{
        //    DataTable dt = DayphotoManager.Selecttopphoto(4);
        //    if (dt != null && dt.Rows.Count != 0)
        //    {
        //        Repeater1.DataSource = dt;
        //        Repeater1.DataBind();
        //    }
        //}
        public void BindTravel_record()
        {
            DataTable dt = Travel_recordManager.SelectAll();
            if (dt != null && dt.Rows.Count != 0)
            {
                LVtravel.DataSource = dt;
                LVtravel.DataBind();
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
        public void BindContest()
        {
            DataTable dt = ContestManager.SelectAll();
            if (dt != null && dt.Rows.Count != 0)
            {
                LVContest.DataSource = dt;
                LVContest.DataBind();
            }
        }
        public void BindNewsID()
        {
            int id = Convert.ToInt32(Request.QueryString["id"]);
            DataTable dt = Contest_newsManager.SelectNews(id);
            if (dt!=null && dt.Rows .Count > 0)
            {
                ListView1.DataSource = dt;
                ListView1.DataBind();
            }
        }
        public void Bindcity()
        {
            DataTable dt = StoreManager.SelectAll();
            if (dt != null && dt.Rows.Count != 0)
            {
                DropDowncity.DataSource = dt;
                DropDowncity.DataValueField = "store_id";
                DropDowncity.DataTextField = "city";
                DropDowncity.DataBind();
                DropDowncity1.DataSource = dt;
                DropDowncity1.DataValueField = "store_id";
                DropDowncity1.DataTextField = "city";
                DropDowncity1.DataBind();
            }
        }
        public void hire(object sender,EventArgs e)
        {
            if (Session["user_id"] ==null)
            {
                Response.Write("<script>alert('请先登录网站')</script>");
            }
            else
            {
                if (datebegin.Value=="" || dateend.Value == "")
                {
                    Response.Write("<script>alert('请输入开始结束日期')</script>");
                }
                else
                {
                    Session["datebegin"] = datebegin.Value;
                    Session["dateend"] = dateend.Value;
                    string st = DropDowncity1.SelectedValue;
                    Response.Redirect("stores.aspx?id=" + st);
                }
            }
            
        }
    }
}