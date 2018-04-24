using System;
using System.Data;
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
        public static DataTable SelectStoreID(int ID,int type_id)
        {
            return igoods.SelectStoreID(ID,type_id);
        }
        public static  DataTable SelectHotgoods()
        {
            return igoods.SelectHotgoods();
        }
        public static DataTable selectMallBike(int type_id)
        {
            return igoods.selectMallBike(type_id);
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
        public static DataTable SelectUserMallCart(int UserID)
        {
            return igoods.SelectUserMallCart(UserID);
        }
        public static DataTable JudgeMallYorN(int UserID, int GoodsID) //判断某用户购物车是否有某商品的方法
        {
            return igoods.JudgeMallYorN(UserID, GoodsID);
        }
        public static int UpdateShoppingCart(int UserID, int GoodsID, int Number, float TotalAmount) //购物车有商品时做更新操作
        {
            return igoods.UpdateShoppingCart(UserID, GoodsID, Number, TotalAmount);
        }
        public static int InsertShoppingCart(shoppingcart Shoppingcart)
        {
            return igoods.InsertShoppingCart(Shoppingcart);
        }
        public static DataTable JudgeShoppingCart(int UserID)
        {
            return igoods.JudgeShoppingCart(UserID);
        }
        public static DataTable SelectShoppingCart(int user_id)
        {
            return igoods.SelectShoppingCart(user_id);
        }
        public static DataTable SelectAllTotalAmount(int user_id)
        {
            return igoods.SelectAllTotalAmount(user_id);
        }
        public static  int DeleteShoppingCart(int ShoppingCartID)
        {
            return igoods.DeleteShoppingCart(ShoppingCartID);
        }
        public static  int UpdateShoppingCartNum(int CartID, int num, float total)
        {
            return igoods.UpdateShoppingCartNum(CartID, num, total);
        }
        public static int InsertIndent(int UserID, DateTime startt, DateTime endtt)
        {
            return igoods.InsertIndent(UserID, startt, endtt);
        }

    }
}
