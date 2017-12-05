using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Models;
using IDAL;
using DALFactory;

namespace BLL
{
   public class GoodsManager
    {
        private static Igoods igoods = DataAccess.Creategoods();
        public static DataTable SelectGoods(int top)
        {
            return igoods.SelectGoods(top);
        }
        public static DataTable SelectMallGoods(string A, string B)
        {
            return igoods.SelectMallGoods(A, B);
        }
        public static DataTable SelectKeys(string Keys)
        {
            return igoods.SelectKeys(Keys);
        }
        public static DataTable SelectMallByKeys(string Keys, string UB)
        {
            return igoods.SelectMallByKeys(Keys, UB);
            
        }
        public static DataTable SelectID(int ID)
        {
            return igoods.SelectID(ID);
        }
        public static int InsertGoods(goods goods)
        {
            return igoods.InsertGoods(goods);
        }
        public static DataTable SelectStoreID(string ID)
        {
            return igoods.SelectStoreID(ID);
        }
        //public static DataTable SelectShoppingCart(string UserName)
        //{
        //    return igoods.SelectShoppingCart(UserName);
        //}
        //public static int InsertShoppingCart(ShoppingCart shoppingCart)
        //{
        //    return igoods.InsertShoppingCart(shoppingCart);
        //}
        //public static int DeleteShoppingCart(int ShoppingCartID)
        //{
        //    return igoods.DeleteShoppingCart(ShoppingCartID);
        //}
        //public static DataTable JudgeCartYorN(int UserID, int GoodsID)
        //{
        //    return igoods.JudgeCartYorN(UserID, GoodsID);
        //}
        //public static int UpdateShoppingCart(int UserID, int GoodsID, int Number, float TotalAmount)
        //{
        //    return igoods.UpdateShoppingCart(UserID, GoodsID, Number, TotalAmount);
        //}
        //public static int InsertIndent(int UserID)
        //{
        //    return igoods.InsertIndent(UserID);
        //}
        public static DataTable SelectIndent(int UserID)
        {
            return igoods.SelectIndent(UserID);
        }
        public static DataTable SelectIndentIntro(int IndentID)
        {
            return igoods.SelectIndentIntro(IndentID);

        }
        public static DataTable SelectIndentDetail(int IndentID)
        {
            return igoods.SelectIndentDetail(IndentID);
        }
        public static DataTable SelectAll()
        {
            return igoods.SelectAll();
        }
        public static int DeleteGoods(int GoodsID)
        {
            return igoods.DeleteGoods(GoodsID);
        }
   }
}
