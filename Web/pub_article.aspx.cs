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
                record.record_author = "强东东";
                record.record_title = title.Text.Trim();
                record.record_cont = myEditor.InnerText;
                record.pub_time = DateTime.Now.ToLocalTime();
                record.col_count = 0;
                record.comt_count = 0;
                record.like_count = 0;
                record.record_cover = Label2.Text.Trim();
                int result=Travel_recordManager.InsertTravel_record(record);
                if(result>=1)
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "true", "<script>alert('游记发表成功！');</script>");
                }
            }
            catch (Exception ex)
            {

                Page.ClientScript.RegisterStartupScript(this.GetType(), "true", "<script>alert('发布失败！请仔细检查');</script>");
            }
            
        }

        protected void cover_Click(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile)//判断上传框是否有文件
            {
                bool FileOK = false;//初始化文件格式是否正确
                string FileExtension = System.IO.Path.GetExtension(FileUpload1.FileName.ToLower());
                string[] allowedExtension = { ".jpg", ".jpge", ".png", ".bmp", ".gif" };//设置允许上传的文件类型
                for (int i = 0; i < allowedExtension.Length; i++)
                {
                    if (FileExtension == allowedExtension[i])
                    {
                        FileOK = true;
                    }
                }
                if (FileOK)//文件类型正确
                {
                    try
                    {
                        string SavePath = Server.MapPath("~/img/trrecord_cover/");//指定上传文件在服务器上的保存路径
                        if (!System.IO.Directory.Exists(SavePath))//检查服务器上是否存在这个物理路径，如果不存在则创建
                        {
                            System.IO.Directory.CreateDirectory(SavePath);
                        }
                        SavePath = SavePath + "\\" + FileUpload1.FileName;
                        FileUpload1.SaveAs(SavePath);
                        Session["DocAddr"] = "UploadFiles\\Documents\\" + Session["UserName"] + "\\" + FileUpload1.FileName;
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "true", "<script>alert('上传成功！');</script>");
                        Label1.Text = "已上传文件：" + FileUpload1.FileName;
                        Label2.Text = "img\\trrecord\\" + FileUpload1.FileName;
                        ViewState["UploadMallPhoto"] = "img\\trrecord\\" + FileUpload1.FileName;
                        Image1.ImageUrl = ViewState["UploadMallPhoto"].ToString();
                        this.cover.Enabled = false;
                    }
                    catch
                    {
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "true", "<script>alert('上传失败！');</script>");
                    }
                }
                else
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "true", "<script>alert('上传的文件格式不正确，请重新选择！');</script>");
                }
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "true", "<script>alert('请选择需要上传的文件！');</script>");
            }
        }
    }
}