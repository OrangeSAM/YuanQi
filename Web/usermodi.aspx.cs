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
    public partial class usermodi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                getdetail();
                Biz.TargetPath = Request.RawUrl;
            }
            
        }
        protected void getdetail()
        {
            string user_id = "3";
                //(string)Session["user_id"];
            DataTable dt = BLL.UsersManager.getsingleuser(user_id);
            if (dt != null & dt.Rows.Count == 1)
            {
                uname.Text = dt.Rows[0][1].ToString();
                upwd.Text = dt.Rows[0][2].ToString();
                uemail.Text = dt.Rows[0][5].ToString();
                uphone.Text = dt.Rows[0][6].ToString();
                uaddr.Text = dt.Rows[0][7].ToString();
            }
        }

        protected void modi_Click(object sender, EventArgs e)
        {
            string Una    = uname.Text;
            string Upwd   = upwd.Text;
            string Uemail = uemail.Text;
            string Uphone = uphone.Text;
            string Uaddr  = uaddr.Text;
            users modi = new users();
            {
                modi.user_name  = Una;
                modi.user_pwd   = Upwd;
                modi.user_email = Uemail;
                modi.user_phone = Uphone;
                modi.user_addr  = Uaddr;
                modi.user_id    = 3;
                    //Session["user_id"]
            }
            int result = UsersManager.Update(modi);
            if (result > 1)
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "true", "<script>alert('个人信息修改成功！');</script>");
            }
        }
    }
   
}