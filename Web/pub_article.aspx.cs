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

namespace Web
{
    public partial class pub_article : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnTest_click(object sender, EventArgs e)
        {

            string edi = Server.HtmlDecode(myEditor.InnerHtml);
            this.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('" + edi + "');</script>");//这样的话会弹出编辑器中你输入的文本或者其他（带格式的，就是包含样式）

        }

        protected void pubbtn_Click(object sender, EventArgs e)
        {
            try
            {
                travel_record record = new travel_record();
                record.user_id = 3;
                record.record_author = "11";
                record.record_title = title.Text.Trim();
                record.record_cont = "11";
                record.pub_time = DateTime.Now.ToLocalTime();
                record.col_count = 0;
                record.comt_count = 0;
                record.like_count = 0;
                record.record_cover = "ww";
                int result=Travel_recordManager.InsertTravel_record(record);
                if(result>=1)
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "true", "<script>alert('游记发表成功！');</script>");
                }
            }
            catch (Exception)
            {

                Page.ClientScript.RegisterStartupScript(this.GetType(), "true", "<script>alert('发布失败！请仔细检查');</script>");
            }
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}