using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.Net.Mail;


namespace Web
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string title = "Test mail";
            string content = "欢迎您注册本网站，你的验证码是 8990";//邮件内容

            System.Net.Mail.SmtpClient client = new System.Net.Mail.SmtpClient();
            client.UseDefaultCredentials = true;
            client.Port = 25;
            client.Host = "smtp.qq.com";//使用163的SMTP服务器发送邮件

            client.EnableSsl = true;
            client.UseDefaultCredentials = false;

            client.DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network;
            client.Credentials = new System.Net.NetworkCredential("发送人邮箱", "开启SMTP时的动态码");
            System.Net.Mail.MailMessage message = new System.Net.Mail.MailMessage();
            message.From = new System.Net.Mail.MailAddress("收件人邮箱");

            message.To.Add("收件人邮箱");
            message.CC.Add("收件人邮箱");

            message.Subject = title;
            message.Body = content;

            message.BodyEncoding = System.Text.Encoding.GetEncoding("UTF-8");
            message.SubjectEncoding = System.Text.Encoding.GetEncoding("UTF-8");
            //获取或设置一个值，该值指示电子邮件正文是否为HTML。
            message.IsBodyHtml = false;
            //指定邮件优先级
            message.Priority = System.Net.Mail.MailPriority.High;

            try
            {
                client.Send(message);
                Response.Write("[" + title + "]邮件发送成功！");
            }
            catch(System.Net.Mail.SmtpException ex)
            {
                Response.Write("邮件发送错误，错误信息：" + ex.Message);
            }

           
        }

        protected void yanz_Click(object sender, EventArgs e)
        {

        }
    }
}