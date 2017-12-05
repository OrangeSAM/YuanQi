using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Web.Security;
using System.Configuration;
using BLL;
using Models;

public partial class login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
    }
    protected void Server_Validate(object source,ServerValidateEventArgs args)
    {
        if (args.Value.Length > 16)
            args.IsValid = false;
        else
            args.IsValid = true;
    }
    protected void reg_Click(object sender, EventArgs e)
    {
        if (IsValid)
        {
            try
            {
                users  us = new users ();
                us.user_name  = user.Text;
                us.user_pwd  = passwd.Text;
                us.user_email = email.Text;

                int i = UsersManager.Insert (us);
                if (i == 1)
                {
                    Page.ClientScript.RegisterClientScriptBlock(typeof(Object), "alert", "<script>alert('注册成功！');</script>");
                    Response.Redirect("~/WebForm1.aspx");
                }

            }
            catch
            {
                Page.ClientScript.RegisterClientScriptBlock(typeof(Object), "alert", "<script>alert('注册失败！');</script>");
            }

        }
    }


    protected void Submit_Click(object sender, EventArgs e)
    {
        string username =u.Text.Trim();
        string pwd =p.Text.Trim();


        try
        {

            SqlDataReader dr = UsersManager.Login(username, pwd);
            if (dr.Read())
            {
                Session["user_name"] = dr[0].ToString();
                Response.Cookies["user_name"].Value = dr[0].ToString();
                Label1.Text = "欢迎登录远骑网！";
                Response.Redirect("WebForm1.aspx");

            }
            else
            {
                Label1.Text = "用户名或密码错误！";
            }
       

       
        }
        catch (Exception ex)
        {
            Response.Write("错误原因：" + ex.Message);
        }


    }
}
