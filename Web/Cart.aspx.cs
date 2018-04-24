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
    public partial class WebForm13 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindAllTotal();
                BindShoppingCart();
                Biz.TargetPath = Request.RawUrl;
            }
            int id = Convert.ToInt32(Session["user_id"]);
            DataTable dt = GoodsManager.JudgeShoppingCart(id);
            if (dt != null && dt.Rows.Count > 0)
            {
                Panel01.Visible = true;
                Panel02.Visible = false;
            }
            else
            {
                Panel01.Visible = false;
                Panel02.Visible = true;
            }
            BindUserMallCart();
        }
        public void BindAllTotal()
        {
            int user_id = Convert.ToInt32(Session["user_id"]);
            DataTable dt = GoodsManager.SelectAllTotalAmount(user_id);
            if (dt != null && dt.Rows.Count >= 0)
            {
                trShoppingCartBuy.DataSource = dt;
                trShoppingCartBuy.DataBind();
            }
            string a = dt.Rows[0][0].ToString();//获取总价
        }
        public void BindShoppingCart()
        {
            int id = Convert.ToInt32(Session["user_id"]);
            DataTable dt = GoodsManager.SelectShoppingCart(id);
            if (dt != null && dt.Rows.Count > 0)
            {
                Reshoppingcart.DataSource = dt;
                Reshoppingcart.DataBind();
            }
        }
        public int BindUserMallCart()
        {
            int UserMallCartNum;
            if (Session["user_id"] != null)
            {
                int user_id = Convert.ToInt32(Session["user_id"]);
                DataTable dt = GoodsManager.SelectUserMallCart(user_id);
                if (dt != null && dt.Rows.Count > 0)
                {
                    return UserMallCartNum = dt.Rows.Count;
                }
                else
                {
                    return UserMallCartNum = 0;
                }
            }
            else
            {
                return UserMallCartNum = 0;
            }
        }

        protected void Reshoppingcart_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            Label lbl = (Label)e.Item.FindControl("LabelShoppingCartID");
            Label lbl2 = (Label)e.Item.FindControl("LabelMallGoodsNum");
            Label lblprice = (Label)e.Item.FindControl("lblprice");
            TextBox textbox = (TextBox)e.Item.FindControl("sqlMallNumber");
            string Eventname = e.CommandName;
            switch (Eventname)
            {
                case "Delete":
                    {
                        int id = Convert.ToInt32(lbl.Text);
                        int result = GoodsManager.DeleteShoppingCart(id);
                        if (result >= 1)
                        {
                            int ID02 = Convert.ToInt32(Session["user_id"]);
                            DataTable dt = GoodsManager.JudgeShoppingCart(ID02);
                            if (dt != null && dt.Rows.Count != 0)
                            {
                                Panel01.Visible = true;
                                Panel02.Visible = false;

                            }
                            else
                            {
                                Panel01.Visible = false;
                                Panel02.Visible = true;
                            }
                            int user_id = Convert.ToInt32(Session["user_id"]);
                            DataTable dt1 = GoodsManager.SelectAllTotalAmount(user_id);
                            if (dt1 != null && dt1.Rows.Count != 0)
                            {
                                trShoppingCartBuy.DataSource = dt1;
                                trShoppingCartBuy.DataBind();
                            }
                            int user_id1 = Convert.ToInt32(Session["user_id"]);
                            DataTable dt2 = GoodsManager.SelectShoppingCart(user_id1);
                            if (dt2 != null && dt2.Rows.Count != 0)
                            {
                                Reshoppingcart.DataSource = dt2;
                                Reshoppingcart.DataBind();
                            }
                        }
                    }
                    break;
                case "ChageNum":
                    {
                        try
                        {
                            int lbl3 = Convert.ToInt32(lbl2.Text);
                            int a = Convert.ToInt32(textbox.Text);
                            if (a > lbl3) { a = lbl3; }
                            if (a <= 0) { a = 1; }
                            int ID = Convert.ToInt32(lbl.Text);
                            float Cartprice = float.Parse(lblprice.Text);
                            int number = a;
                            float total = Cartprice * number;
                            int result = GoodsManager.UpdateShoppingCartNum(ID, number, total);
                            if (result >= 1)
                            {
                                int user_id = Convert.ToInt32(Session["user_id"]);
                                DataTable dt1 = GoodsManager.SelectAllTotalAmount(user_id);
                                if (dt1 != null && dt1.Rows.Count != 0)
                                {
                                    trShoppingCartBuy.DataSource = dt1;
                                    trShoppingCartBuy.DataBind();
                                }
                                int user_id1 = Convert.ToInt32(Session["user_id"]);
                                DataTable dt2 = GoodsManager.SelectShoppingCart(user_id1);
                                if (dt2 != null && dt2.Rows.Count != 0)
                                {
                                    Reshoppingcart.DataSource = dt2;
                                    Reshoppingcart.DataBind();
                                }
                            }
                        }
                        catch
                        {
                            Page.ClientScript.RegisterStartupScript(this.GetType(), "true", "<script>alert('只能输入整数！');</script>");

                        }
                    }
                    break;
            }
        }

        protected void trShoppingCartBuy_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            string Eventname = e.CommandName;
            switch (Eventname)
            {
                case "BuyBuy":
                    {
                        try
                        {
                            TextBox textstart = e.Item.FindControl("start") as TextBox;
                            TextBox textend = e.Item.FindControl("end") as TextBox;

                            DateTime st = Convert.ToDateTime(textstart.Text);
                            DateTime ed = Convert.ToDateTime(textend.Text);
                            int id = Convert.ToInt32(Session["user_id"]);
                            int result = GoodsManager.InsertIndent(id,st,ed);
                            if (result >= 1)
                            {
                                Page.ClientScript.RegisterStartupScript(this.GetType(), "true", "<script>alert(‘下单成功！’)</script>");
                                BindAllTotal();
                                BindShoppingCart();
                                DataTable dt = GoodsManager.JudgeShoppingCart(id);
                                if (dt != null && dt.Rows.Count > 0)
                                {
                                    Panel01.Visible = true;
                                    Panel02.Visible = false;
                                }
                                else
                                {
                                    Panel01.Visible = false;
                                    Panel02.Visible = true;
                                }
                            }
                        }
                        catch
                        {
                            Page.ClientScript.RegisterStartupScript(this.GetType(), "true", "<script>alert(‘购物车什么也没有’)</script>");
                        }
                    }
                    break;
            }
        }
    }
}
