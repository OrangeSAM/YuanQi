using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using Models;
using System.Data;
namespace Web
{
    public partial class WebForm11 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                ViewState["ShoppingCartNumber"] = 1;
                ViewState["goods_id"] = Convert.ToInt32(Request.QueryString["id"]);
                Bindgoods();
                BindUserMallCart();
                Biz.TargetPath = Request.RawUrl;
            }
        }
        public void Bindgoods()//绑定商品
        {
            int id = int.Parse(Request.QueryString["id"]);
            DataTable dt = GoodsManager.SelectID(id);
            if (dt != null && dt.Rows.Count > 0)
            {
                LVgoods.DataSource = dt;
                LVgoods.DataBind();
                ViewState["stock"] = dt.Rows[0]["stock"].ToString();
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


        protected void LVgoods_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            int num = int.Parse(ViewState["stock"].ToString());
            string Eventname = e.CommandName;
            switch (Eventname)
            {
                case "Minus":
                    {
                        int i = Convert.ToInt32(ViewState["ShoppingCartNumber"]);
                        if (i > 0)
                        {
                            i--;
                            ViewState["ShoppingCartNumber"] = i;
                            Bindgoods();
                        }
                    }
                    break;
                case "Add":
                    {
                        int i = Convert.ToInt32(ViewState["ShoppingCartNumber"]);
                        if (i < num)
                        {
                            i++;
                            ViewState["ShoppingCartNumber"] = i;
                            Bindgoods();
                        }
                    }
                    break;
                //加入购物车
                case "AddShoppingCart":
                    {
                        if (Session["user_name"] != null)
                        {
                            int number = Convert.ToInt32(ViewState["ShoppingCartNumber"]);
                            if (number > 0)
                            {
                                int user_id = Convert.ToInt32(Session["user_id"]);
                                int goods_id = Convert.ToInt32(ViewState["goods_id"]);
                                DataTable goods = GoodsManager.JudgeMallYorN(user_id, goods_id);
                                if (goods != null && goods.Rows.Count != 0)
                                {
                                    float total_price = (float.Parse(((Label)e.Item.FindControl("RTprice")).Text)) * (Convert.ToInt32(ViewState["ShoppingCartNumber"]));
                                    int result = GoodsManager.UpdateShoppingCart(user_id, goods_id, number, total_price);
                                    if (result >= 1)
                                    {
                                        Page.ClientScript.RegisterStartupScript(this.GetType(), "true", "<script>alert('加入购物车成功！');</script>");
                                        BindUserMallCart();
                                    }
                                }
                                else
                                {
                                    shoppingcart Shoppingcart = new shoppingcart();
                                    Shoppingcart.user_id = Convert.ToInt32(Session["user_id"]);
                                    Shoppingcart.goods_id = Convert.ToInt32(ViewState["goods_id"]);
                                    Shoppingcart.unit_price = float.Parse(((Label)e.Item.FindControl("RTprice")).Text);
                                    Shoppingcart.number = Convert.ToInt32(ViewState["ShoppingCartNumber"]);
                                    Shoppingcart.total_price = (float.Parse(((Label)e.Item.FindControl("RTprice")).Text)) * (Convert.ToInt32(ViewState["ShoppingCartNumber"]));
                                    int result = GoodsManager.InsertShoppingCart(Shoppingcart);
                                    if (result >= 1)
                                    {
                                        Page.ClientScript.RegisterStartupScript(this.GetType(), "true", "<script>alert('加入购物车成功！');</script>");
                                        BindUserMallCart();
                                    }
                                    else
                                    {
                                        Page.ClientScript.RegisterStartupScript(this.GetType(), "true", "<script>alert('请确定购买数量');</script>");
                                    }
                                }
                            }
                            else
                            {
                                Page.ClientScript.RegisterStartupScript(this.GetType(), "true", "<script>alert('已经卖光了。。。');</script>");
                            }
                        }
                        else
                        {
                            Page.ClientScript.RegisterStartupScript(this.GetType(), "true", "<script>alert('请先登录');</script>");
                            Response.Redirect("login1.aspx");
                        }
                        }
                        break;
            }
        }
    }
}

        

