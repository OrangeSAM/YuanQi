using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using BLL;
using Models;

namespace Web
{
    public partial class Activity_detail : System.Web.UI.Page
    {
        static bool visibleflag;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                visibleflag = true;
                BindAct_de();
                Biz.TargetPath = Request.RawUrl;
            }


        }
        public void BindAct_de()
        {
            int id = Convert.ToInt32(Request.QueryString["id"]);
            DataTable dt = ActivityManager.SelectActivity(id);
            if (dt != null && dt.Rows.Count > 0)
            {
                LVact_de.DataSource = dt;
                LVact_de.DataBind();
            }


        }
        protected void lbtnjoin_click(object sender, EventArgs e)
        {
            LinkButton bt = (LinkButton)sender;
            Panel Paneljoin = bt.Parent.FindControl("joinpanel") as Panel;
            Paneljoin.Visible = true;
            visibleflag = !visibleflag;
        }
        protected void Btnjoin_click(object sender,EventArgs e)
        {
            if (Session["user_name"] != null)
            { 
               if (Page.IsValid)
                {
               
                    Button btn = (Button)sender;
                    string a = ((TextBox)btn.Parent.FindControl("txtname")).Text.Trim();
                    string b = ((TextBox)btn.Parent.FindControl("txtphone")).Text.Trim();
                    activity_sign us = new activity_sign();
                    us.user_id = int.Parse(Session["user_id"].ToString());
                    us.activity_id = Int32.Parse((btn.Parent.FindControl("HiddenFieldComID") as HiddenField).Value);
                    us.sign_time = DateTime.Now;
                    us.user_name = ((TextBox)btn.Parent.FindControl("txtname")).Text.Trim();
                    us.user_phone = ((TextBox)btn.Parent.FindControl("txtphone")).Text.Trim();
                    int result = Activity_signManager.InsertActSign(us);
                    if (result ==1)
                    {
                        ScriptManager.RegisterClientScriptBlock(updatejoin , this.GetType(), "click", "alert('报名成功！')", true);
                    }

                
                   else 
                   {
                    ScriptManager.RegisterClientScriptBlock(updatejoin, this.GetType(), "click", "alert('报名失败！')", true);
                   }
               }
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(updatejoin, this.GetType(), "click", "alert('您必须先登录才能报名！')", true);
                ScriptManager.RegisterStartupScript(updatejoin, updatejoin.GetType(), "updateScript", "window.location.href='login1.aspx'", true);
            }
        }
    }
}
