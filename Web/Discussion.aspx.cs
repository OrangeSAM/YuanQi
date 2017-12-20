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
    public partial class WebForm12 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindDiscussion();
                BindHotDiscussion();
                BindLikeDiscussion();
            }
            
        }
        public void BindDiscussion()
        {
            //int discussion = int.Parse(Request.QueryString["id"]);
            DataTable dt = DiscussionManager.SelectAll();
            if (dt != null && dt.Rows.Count > 0)
            {
                LVDiscussion.DataSource = dt;
                LVDiscussion.DataBind();
            }
        }
        public void BindHotDiscussion()
        {
            //int discussion = int.Parse(Request.QueryString["id"]);
            DataTable dt = DiscussionManager.SelectAll();
            if (dt != null && dt.Rows.Count > 0)
            {
                ReHotDiscussion.DataSource = dt;
                ReHotDiscussion.DataBind();
            }
        }

        public void BindLikeDiscussion()
        {
            //int discussion = int.Parse(Request.QueryString["id"]);
            DataTable dt = DiscussionManager.SelectAll();
            if (dt != null && dt.Rows.Count > 0)
            {
                ReLikeDiscussion.DataSource = dt;
                ReLikeDiscussion.DataBind();
            }
        }

        protected void discussion_PreRender(object sender, EventArgs e)
        {
            BindDiscussion();
        }
    }
}