using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Models;
using BLL;
using System.Data;
using System.Data.SqlClient;
using DAL;

namespace Web
{
    public partial class WebForm7 : System.Web.UI.Page
    {
        static bool visibleflag;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                visibleflag = true;
                BindTravel();
                BindTravelComment();
                Biz.TargetPath = Request.RawUrl;
            }
        }
        public void BindTravel()
        {
            int trrecord_id = int.Parse(Request.QueryString["id"]);
            DataTable dt = Travel_recordManager.SelectTravel_record(trrecord_id);
            if (dt != null && dt.Rows.Count > 0)
            {
                LVTravel1.DataSource = dt;
                LVTravel1.DataBind();
            }
        }
        public void BindTravelComment()
        {
            int trrecord_id= int.Parse(Request.QueryString["id"]);
            DataTable dt = Travel_record_comtManager.SelectTravel_record_comt(trrecord_id);
            if(dt!=null && dt.Rows.Count > 0)
            {
                LVReply.DataSource = dt;
                LVReply.DataBind();
            }
        }

        protected void btnComments_Click(object sender, EventArgs e)
        {
            if(Session["user_name"]!=null)
            {
                if(Page.IsValid)
                {
                    travel_record_comt comt = new travel_record_comt();//新建查询对象
                    comt.user_id = int.Parse(Session["user_id"].ToString());
                    comt.trrecord_id = int.Parse(Request.QueryString["id"]);
                    comt.comt_cont = txtComments.Text;
                    comt.comt_time = DateTime.Now;
                    int result = Travel_record_comtManager.InsertTravel_record_comt(comt);
                    if(result>=1)
                    {
                        ScriptManager.RegisterClientScriptBlock(updatecomment, this.GetType(), "click", "alert('评论成功！')",true);
                        BindTravelComment();
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
                    travel_comt_reply reply = new travel_comt_reply();
                    reply.trcomt_id = Int32.Parse((btn.Parent.FindControl("HiddenFieldComID") as HiddenField).Value);
                    reply.user_id = int.Parse(Session["user_id"].ToString());
                    reply.reply_cont = ((TextBox)btn.Parent.FindControl("txtreply")).Text.Trim();
                    reply.reply_time = DateTime.Now;
                    int result = Travel_comt_replyManager.InsertTravel_re(reply);
                    if (result >= 1)
                    {
                        ScriptManager.RegisterClientScriptBlock(updatereply, this.GetType(), "click", "alert('回复成功！')", true);
                        BindTravelComment();
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
            if(e.Item.ItemType==ListViewItemType.DataItem)
            {
                HiddenField hiddencomid = e.Item.FindControl("HiddenFieldComID") as HiddenField;
                int trcomt_id = int.Parse(hiddencomid.Value);
                Repeater rpt = e.Item.FindControl("Rereplycomment") as Repeater;
                DataTable dt = Travel_comt_replyManager.SelectTravelReply_comt(trcomt_id);
                if(dt!=null && dt.Rows.Count > 0)
                {
                    rpt.DataSource = dt;
                    rpt.DataBind();
                }
            }
        }

        protected void btnLike_Click(object sender, EventArgs e)
        {
            if (Session["user_name"] != null)
            {
                if (ViewState["like_count"] == null)
                {
                    int trrecord_id = int.Parse(Request.QueryString["id"]);
                    Travel_recordManager.UpdateLike(trrecord_id);
                    //ScriptManager.RegisterClientScriptBlock(UpdateLike, this.GetType(), "click", "alert('点赞成功！')", true);
                    BindTravel();
                    ViewState["like_count"] = true;
                }

                else
                {
                    int trrecord_id = int.Parse(Request.QueryString["id"]);
                    int dt = Travel_recordManager.getLikecount(trrecord_id);
                    if (dt > 0)
                    {
                        Travel_recordManager.UpdateDislike(trrecord_id);
                        //ScriptManager.RegisterClientScriptBlock(UpdateLike, this.GetType(), "click", "alert('取消点赞！')", true);
                        BindTravel();
                        ViewState["like_count"] = null;
                    }


                    //}

                }

            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(UpdateLike, this.GetType(), "click", "alert('请先登录');location='Login1.aspx'", true);
            }

        }

        protected void btnCol_Click(object sender, EventArgs e)
        {
            if (Session["user_name"] != null)
            {
                trrecord_col trcol = new trrecord_col();//创建表对象
                int id = int.Parse(Request.QueryString["id"]);
                string sql = "select * from trrecord_col where trrecord_id=@trrecord_id and user_id=@user_id";
                SqlParameter[] sp = { new SqlParameter("@trrecord_id", id),
                                      new SqlParameter("@user_id",Session["user_id"]),};
                SqlDataReader dr = DBHelper.GetDataReader(sql, sp);
                if (dr.Read())
                {
                    ScriptManager.RegisterClientScriptBlock(UpdateLike, this.GetType(), "click", "alert('您已收藏过该游记！')", true);
                }
                else
                {
                    trcol.user_id = int.Parse(Session["user_id"].ToString());
                    trcol.trrecord_id = id;
                    trcol.col_time = DateTime.Now;
                    int result = Trrecord_colManager.InsertTrrecord(trcol);
                    if (result >= 1)
                    {
                        ScriptManager.RegisterClientScriptBlock(UpdateLike, this.GetType(), "click", "alert('收藏成功！')", true);
                        Travel_recordManager.UpdateCol(id);
                        BindTravel();
                    }

                }
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(UpdateLike, this.GetType(), "click", "alert('请先登录');location='Login1.aspx'", true);
            }
        }
    }
    }

 

