using System;
using Models;
using IDAL;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class SqlServerGoods : Igoods
    {
        public int DeleteGoods(int GoodsID)
        {
            SqlParameter[] sp = { new SqlParameter("@goods_id", GoodsID) };
            return DBHelper.GetExcuteNonQuery("Deletegoods", System.Data.CommandType.StoredProcedure, sp);
        }

        public int InsertGoods(goods goods)
        {
            string sql = "insert into goods(store_id, goods_name,goods_price,goods_intro,stock)values(@store_id, @goods_name,@goods_price,@goods_intro,@stock)";
            SqlParameter[] sp =
            {
                new SqlParameter("@store_id",goods.goods_id),
                new SqlParameter("@goods_name",goods.goods_name),
                new SqlParameter("@goods_price",goods.goods_price),
                new SqlParameter("@good_intro",goods.goods_intro),
                new SqlParameter("@stock",goods.stock),
            };
            return DBHelper.GetExcuteNonQuery(sql, sp);
        }

        public DataTable SelectAll()//查询商品信息和店铺名
        {
            string sql = "select a.*,b.store_name from goods a,store b where a.store_id=b.store_id";
            return DBHelper.GetFillData(sql);
        }
        public DataTable SelectUserMallCart(int UserID)
        {
            string sql = "select * from ShoppingCart where user_id='" + @UserID + "'";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@UserID",UserID)
            };
            DataTable dt = DBHelper.GetFillData(sql, sp);
            return dt;
        }

        public DataTable SelectGoods(int top)
        {
            string sql = "select TOP " + top + " *,store_name from goods,store where goods.store_id=store.store_id order by goods_id";
            return DBHelper.GetFillData(sql);
        }

        public DataTable SelectID(int ID)//通过传入的ID显示商品
        {
            string sql = "select * from goods,store where goods.store_id=store.store_id and goods_id like '" + @ID + "'";
            return DBHelper.GetFillData(sql);
        }

        public DataTable SelectIndent(int UserID)//查询某用户的订单
        {
            string sql = "select * from indent where user_id='" + UserID + "'";
            return DBHelper.GetFillData(sql);
        }

        public DataTable SelectIndentDetail(int IndentID)//通过订单明细查询订单详细信息
        {
            string sql = "select * from indent_detail,goods where indent_detail.goods_id=goods.goods_id and indent_id='" + IndentID + "'";
            return DBHelper.GetFillData(sql);
        }

        public DataTable SelectIndentIntro(int IndentID)//通过订单编号查询订单
        {
            string sql = "select * from indent where indent_id='" + @IndentID + "'";
            return DBHelper.GetFillData(sql);
        }

        public DataTable SelectKeys(string Keys)//通过商品名模糊查找商品
        {
            string sql = "select *,from goods,store where goods.store_id=store.store_id and goods_name like '%" + @Keys + "%'";
            SqlParameter[] sp =
            {
                new SqlParameter("@Keys",Keys),
            };
            DataTable dt = DBHelper.GetFillData(sql, sp);
            return dt;
        }
       
        public DataTable SelectMallByKeys(string Keys, string UB)
        {
            string sql = "select * ,store_name,goods." + Keys + " from goods,store where goods.store_id=store.store_id order by goods." + Keys + "" + null + "" + UB + " ";
            return DBHelper.GetFillData(sql);
        }

        public DataTable SelectMallGoods(string A, string B)//绑定商品（排序用）
        {
            string sql = "select *,store_name from goods,store where goods.store_id=store.store_id order by " + @A + " " + @B + "";
            return DBHelper.GetFillData(sql);
        }
        //选项卡
        public DataTable selectMallBike(int type_id )
        {
            string sql = "select * from goods,goods_type where goods.type_id=goods_type.type_id and goods.type_id=@type_id";
            SqlParameter[] sp =
            {
                new SqlParameter("@type_id",type_id),
            };
            return DBHelper.GetFillData(sql, sp);
        }

        //public DataTable SelectShoppingCart(string UserName)
        //{
        //    throw new NotImplementedException();
        //}
        public DataTable JudgeMallYorN(int UserID, int GoodsID) //判断某用户购物车是否有某商品的方法
        {
            string sql = "select * from shoppingcart where user_id ='" + @UserID + "'and goods_id='" + @GoodsID + "'";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@UserID",UserID),
                new SqlParameter("@GoodsID",GoodsID)
            };
            DataTable dt = DBHelper.GetFillData(sql, sp);
            return dt;
        }
        public int UpdateShoppingCartNum(int CartID, int num, float total)
        {
            string sql = "update shoppingcart set number=@number,total_price=@total_price where shoppingcart_id=@shoppingcart_id";
            SqlParameter[] sp =
            {
                new SqlParameter("@number",num),
                new SqlParameter("@total_price",total),
                new SqlParameter("@shoppingcart_id",CartID),
            };
            return DBHelper.GetExcuteNonQuery(sql, sp);
        }

        public int InsertIndent(int UserID, DateTime startt, DateTime endt)
        {
            SqlParameter[] sp =
            {
                new SqlParameter("@user_id",UserID),
                new SqlParameter("@start_t",startt),
                new SqlParameter("@end_t",endt)
            };
            return DBHelper.GetExcuteNonQuery("shoppingcart_indent", System.Data.CommandType.StoredProcedure, sp);
        }

        public int UpdateShoppingCart(int UserID, int GoodsID, int Number, float TotalAmount) //购物车有商品时做更新操作
        {
            string sql = "update shoppingcart set number=number+'" + @Number + "',total_price=total_price+'" + @TotalAmount + "' where user_id='" + @UserID + "' and goods_id='" + @GoodsID + "'";
            SqlParameter[] para =
            {
                new SqlParameter("@Number",Number),
                new SqlParameter("@TotalAmount",TotalAmount),
                new SqlParameter("@UserID",UserID),
                new SqlParameter("@GoodsID",GoodsID)
            };
            return DBHelper.GetExcuteNonQuery(sql, para);
        }

        public DataTable JudgeShoppingCart(int UserID)
        {
            string sql = "select * from shoppingcart where user_id ='" + @UserID + "'";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@UserID",UserID)
            };
            DataTable dt = DBHelper.GetFillData(sql, sp);
            return dt;
        }
        public DataTable SelectShoppingCart(int user_id)
        {
            string sql = "select * from users a,shoppingcart b,goods c where a.user_id=b.user_id and b.goods_id=c.goods_id and a.user_id=@user_id";
            SqlParameter[] sp =
            {
                new SqlParameter("@user_id",user_id),
            };
            return DBHelper.GetFillData(sql, sp);
        }
        public DataTable SelectAllTotalAmount(int user_id)
        {
            string sql = "select SUM(total_price) FinalTotalAmount from users a,shoppingcart b,goods c where a.user_id=b.user_id and b.goods_id=c.goods_id and a.user_id=@user_id";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@user_id",user_id)
            };
            DataTable dt = DBHelper.GetFillData(sql, sp);
            return dt;
        }
        public int DeleteShoppingCart(int ShoppingCartID)
        {
            string sql = "delete from shoppingcart where shoppingcart_id=@ShoppingCartID";
            SqlParameter[] para =
            {
                new SqlParameter("@ShoppingCartID",ShoppingCartID)
            };
            return DBHelper.GetExcuteNonQuery(sql, para);
        }
        public int InsertShoppingCart(shoppingcart Shoppingcart)
        {
            string sql = "insert into shoppingcart(user_id,goods_id,unit_price,number,total_price)values(@UserID,@GoodsID,@UnitPrice,@Number,@TotalAmount)";
            SqlParameter[] para =
            {
                new SqlParameter ("@UserID",Shoppingcart.user_id),
                new SqlParameter ("@GoodsID",Shoppingcart.goods_id),
                new SqlParameter ("@UnitPrice",Shoppingcart.unit_price),
                new SqlParameter ("@Number",Shoppingcart.number),
                new SqlParameter ("@TotalAmount",Shoppingcart.total_price)
            };
            return DBHelper.GetExcuteNonQuery(sql, para);
        }

        public DataTable SelectStoreID(int ID,int type_id)
        {
            string sql = "select * from goods,store where goods.store_id=store.store_id and store.store_id like '" + @ID + "' and goods.type_id='"+ @type_id +"'" ;
            //即展示属于这家店的所有商品
            //后期应改为分类展示
            return DBHelper.GetFillData(sql);
        }
        public DataTable SelectHotgoods()
        {
            string sql = "select *,store_name from goods,store where goods.store_id=store.store_id order by stock asc";
            //SqlParameter[] sp =
            //{
            //    new SqlParameter("@stock",stock)
            //};
            return DBHelper.GetFillData (sql);
        }
    }
}
