using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using BLL;

namespace Web
{
    public partial class Mall : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

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
    }
}