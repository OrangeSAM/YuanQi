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
    public partial class WebForm8 : System.Web.UI.Page
    {
        static bool visibleflag;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                visibleflag = true;
                BindDiscussion();
                BindDiscussionComment();
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
        public void BindDiscussionComment()
        {
            int discussion = Convert.ToInt32(Request.QueryString["id"]);
            DataTable dt = Discussion_comtManager.SelectDiscussion_comt(discussion);
            if (dt != null && dt.Rows.Count > 0)
            {
                LVDisReply.DataSource = dt;
                LVDisReply.DataBind();
            }
        }



        protected void lbtnReply_Click(object sender, EventArgs e)
        {
            LinkButton bt = (LinkButton)sender;
            Panel Panelreply = bt.Parent.FindControl("panelreply") as Panel;
            Panelreply.Visible = true;
            visibleflag = !visibleflag;
        }


        protected void btnreply_Click(object sender, EventArgs e)
        {
            if (Session["user_name"] != null)
            {
                if (Page.IsValid)
                {
                    Button btn = (Button)sender;
                    string a = ((TextBox)btn.Parent.FindControl("txtreply")).Text.Trim();
                    discussion_reply reply = new discussion_reply();
                    reply.discomt_id = Int32.Parse((btn.Parent.FindControl("HiddenFieldComID") as HiddenField).Value);
                    reply.user_id = int.Parse(Session["user_id"].ToString());
                    reply.reply_cont = ((TextBox)btn.Parent.FindControl("txtreply")).Text.Trim();
                    reply.reply_time = DateTime.Now;
                    int result = Discussion_replyManager.Insert(reply);
                    if (result > 1)
                    {
                        ScriptManager.RegisterClientScriptBlock(updatereply, this.GetType(), "click", "alert('回复成功！')", true);
                        BindDiscussionComment();
                        txtComments.Text = "";
                    }
                    else
                    {
                        ScriptManager.RegisterClientScriptBlock(updatereply, this.GetType(), "click", "alert('回复失败！')", true);
                    }
                }
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(updatereply, this.GetType(), "click", "alert('您必须先登录才能回复！')", true);
                ScriptManager.RegisterStartupScript(updatereply, updatereply.GetType(), "updateScript", "window.location.href='login1.aspx'", true);
            }
        }

        protected void LVReply_ItemDataBound(object sender, ListViewItemEventArgs e)//绑定数据后触发的事件
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {
                HiddenField hiddencomid = e.Item.FindControl("HiddenFieldComID") as HiddenField;
                int discomt_id = int.Parse(hiddencomid.Value);
                Repeater rpt = e.Item.FindControl("Rereplycomment") as Repeater;
                DataTable dt = Discussion_replyManager.SelectDiscussion_re(discomt_id);
                if (dt != null && dt.Rows.Count > 0)
                {
                    rpt.DataSource = dt;
                    rpt.DataBind();
                }
            }


        }

        protected void btnComments_Click1(object sender, EventArgs e)
        {
            if (Session["user_name"] != null)
            {
                if (Page.IsValid)
                {
                    discussion_comt comt = new discussion_comt();//新建查询对象
                    comt.user_id = int.Parse(Session["user_id"].ToString());
                    comt.discussion_id = int.Parse(Request.QueryString["id"]);
                    comt.comt_cont = txtComments.Text;
                    comt.comt_time = DateTime.Now;
                    int result = Discussion_comtManager.InsertDiscussion_comt(comt);
                    if (result > 1)
                    {
                        ScriptManager.RegisterClientScriptBlock(updatecomment, this.GetType(), "click", "alert('评论成功！')", true);
                        BindDiscussionComment();
                        txtComments.Text = "";
                    }
                    else
                    {
                        ScriptManager.RegisterClientScriptBlock(updatecomment, this.GetType(), "click", "alert('评论失败！')", true);
                    }
                }
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(updatecomment, this.GetType(), "click", "alert('您必须先登录才能评论！')", true);
                ScriptManager.RegisterStartupScript(updatecomment, updatecomment.GetType(), "updateScript", "window.location.href='login1.aspx'", true);
            }
        }



        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            LinkButton bt = (LinkButton)sender;
            Panel PanelComment = bt.Parent.FindControl("Panelcomment") as Panel;
            PanelComment.Visible = true;
            visibleflag = !visibleflag;
        }
    }
}