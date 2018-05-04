using System;
using System.Web.UI.WebControls;
using BLL;
using Models;
using System.Data;

namespace Web
{
    public partial class WebForm14 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ViewState["ShoppingCartNumber"] = 1;
                Bindstores();
                BindGoods();
                getparts();
                BindUserMallCart();
                Biz.TargetPath = Request.RawUrl;
            }

        }
        public void Bindstores()
        {
            int id = int.Parse(Request.QueryString["id"]);
            DataTable dt = StoreManager.SelectStoreID(id);
            if (dt != null && dt.Rows.Count > 0)
            {
                LVstores.DataSource = dt;
                LVstores.DataBind();
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
        //获取车辆商品
        public void BindGoods()
        {
            int id = int.Parse(Request.QueryString["id"]);
            DataTable dt = GoodsManager.SelectStoreID(id,1);
            if (dt != null && dt.Rows.Count > 0)
            {
                LVgoods.DataSource = dt;
                LVgoods.DataBind();
            }
        }
        //获取配件商品
        public void getparts()
        {
            int id = int.Parse(Request.QueryString["id"]);
            DataTable dt = GoodsManager.SelectStoreID(id, 2);
            if(dt !=null && dt.Rows.Count > 0)
            {
                partgoods.DataSource = dt;
                partgoods.DataBind();
                ViewState["stock"] = dt.Rows[0]["stock"].ToString();
            }
        }

        
        public void rent(object sender,EventArgs e)
        {
            if (Session["user_id"] != null)
            {
                string st = Session["datebegin"].ToString();
                string ed = Session["dateend"].ToString();
                if (st == "" || ed == "")
                {
                    Response.Write("<script>alert('请输入开始结束日期')</script>");
                }
                else
                {
                    Button btn = (Button)sender;
                    Label gprice = btn.Parent.FindControl("gprice") as Label;
                    string str = gprice.Attributes["data-value"].ToString();
                    indent ind = new indent();
                    ind.user_id = (int)Session["user_id"];
                    DateTime start = Convert.ToDateTime(Session["datebegin"].ToString());
                    ind.start_time = start;
                    DateTime end = Convert.ToDateTime(Session["dateend"].ToString());
                    ind.end_time = end;
                    ind.indent_date = DateTime.Now;
                    ind.indent_state = "已租用";
                    ind.indent_price = float.Parse(str);
                    int i = IndentManager.InsertIndent(ind);
                    if (i == 1)
                    {
                        Response.Write("<script>alert('租车成功，可到个人中心页面查看')</script>");
                    }
                }
                
            }
            else
            {
                Response.Write("<script>alert('请先登录网站')</script>");
            }  
        }
        public void addcar(object sender,EventArgs e)
        {
            int num = int.Parse(ViewState["stock"].ToString());
            if (num > 0)
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
                            Button btn = (Button)sender;
                            Label RTprice = btn.Parent.FindControl("RTprice") as Label;
                            string str = RTprice.Attributes["data-value"];
                            float total_price = float.Parse(str) * (Convert.ToInt32(ViewState["ShoppingCartNumber"]));
                            int result = GoodsManager.UpdateShoppingCart(user_id, goods_id, number, total_price);
                            if (result >= 1)
                            {
                                Page.ClientScript.RegisterStartupScript(this.GetType(), "true", "<script>alert('加入购物车成功！');</script>");
                                BindUserMallCart();
                            }
                        }
                        else
                        {
                            Button btn = (Button)sender;
                            Label gprices = btn.Parent.FindControl("RTprice") as Label;
                            float str = float.Parse(gprices.Attributes["data-value"]);

                            shoppingcart Shoppingcart = new shoppingcart();
                            Shoppingcart.user_id = Convert.ToInt32(Session["user_id"]);
                            Shoppingcart.goods_id = 1033;
                                Convert.ToInt32(ViewState["goods_id"]);
                            Shoppingcart.unit_price = str;
                                //float.Parse(((Label)e.Item.FindControl("RTprice")).Text);
                            Shoppingcart.number = Convert.ToInt32(ViewState["ShoppingCartNumber"]);
                            Shoppingcart.total_price = str * (Convert.ToInt32(ViewState["ShoppingCartNumber"]));
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
        }

    }
}