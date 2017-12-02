using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using models;
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

        //public DataTable SelectShoppingCart(string UserName)
        //{
        //    throw new NotImplementedException();
        //}

        public DataTable SelectStoreID(string ID)
        {
            string sql = "select * from goods,store where goods.store_id=store.store_id and store_id like '" + @ID + "'";
            return DBHelper.GetFillData(sql);
        }
    }
}
