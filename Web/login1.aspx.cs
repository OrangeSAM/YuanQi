using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using BLL;
using Models;
using DAL;

namespace Web
{
    public partial class login1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }
        protected void Server_Validate(object source, ServerValidateEventArgs args)
        {
            if (args.Value.Length > 16)
                args.IsValid = false;
            else
                args.IsValid = true;
        }
        protected void reg_Click(object sender, EventArgs e)
        {
            string sql = "select * from users where user_name=@user_name";
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@user_name",user.Text.Trim())
            };
            SqlDataReader dr = DBHelper.GetDataReader(sql, para);
            if (dr.Read())
            {
                ClientScript.RegisterStartupScript(typeof(Object), "alert", "<script>alert('用户名已被注册！');</script>");
            }
            else
            {
               if (IsValid)
                {
                 try
                 { 
                    users us = new users();
                    us.user_name = user.Text;
                    us.user_pwd = passwd.Text;
                    us.user_email = email.Text;

                    int i = UsersManager.Insert(us);
                    if (i == 1)
                    {
                        
                        lblrg.Text = "用户注册成功！";
                    }

                 }
                 catch (Exception ex)
                 {
                    
                    lblrg.Text = "用户注册失败，错误原因：" + ex.Message;
                 }

               }
            }
        }


        protected void Submit_Click(object sender, EventArgs e)
        {
            string name = u.Text.Trim();
            string pwd = p.Text.Trim();
            try
            {
                SqlDataReader dr = UsersManager.Login(name, pwd);
                if (dr.Read())
                {
                    Session["user_name"] = dr[1].ToString();
                    Session["user_id"] = dr[0];
                    Session["user_photo"] = dr[3];
                    if (inlineCheckbox1.Checked)
                    {
                        Response.Cookies["users"]["user_name"] = HttpUtility.UrlEncode(u.Text.Trim());
                        Response.Cookies["users"]["user_pwd"] = HttpUtility.UrlEncode(p.Text.Trim());
                        Response.Cookies["users"].Expires = DateTime.Now.AddDays(7);
                    }
                    //Response.Redirect("Index.aspx");
                    Biz.LoginOk = true;  //登录成功设为True.
                    Biz.Account = "user_id";  //记录登录成功的帐号
                    Response.Redirect(Biz.TargetPath);  //转向目标页面

                }
                else
                {
                    Label1.Text = "用户名或密码错误！";
                }
            }
            catch (Exception ex)
            {
                Label1 .Text ="登录失败，错误原因：" + ex.Message;
            }


        }
    }
}
