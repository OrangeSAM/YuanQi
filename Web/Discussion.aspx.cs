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
    public partial class WebForm16 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindDiscussion();
                BindUsers();
                Biz.TargetPath = Request.RawUrl;
            }
            
        }
        public void BindUsers()
        {
            DataTable dt = DiscussionManager.SelectPubNum();
            if (dt != null && dt.Rows.Count > 0)
            {
                ReUsers.DataSource = dt;
                ReUsers.DataBind();
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

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Session["user_name"] != null)
            {
                try
                {

                    discussion dis = new discussion();
                    dis.user_id = int.Parse(Session["user_id"].ToString());
                    dis.dis_cont = myEditor.InnerText;
                    dis.dis_title = title.Text.Trim();
                    dis.pub_time = DateTime.Now;
                    int result = DiscussionManager.InsertDiscussion(dis);
                    if (result >= 1)
                    {
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "true", "<script>alert('讨论贴发表成功！');</script>");
                    }
                }
                catch
                {

                    Page.ClientScript.RegisterStartupScript(this.GetType(), "true", "<script>alert('发布失败！请仔细检查');</script>");
                }
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "true", "<script>alert('请登录之后再发帖！'); </script>");
                Response.Redirect("login1.aspx");
               
            }
        }

        protected void LVDispager_PreRender(object sender, EventArgs e)
        {
            BindDiscussion();
        }
    }
}