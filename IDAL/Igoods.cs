using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using models;
using System.Data;

namespace IDAL
{
   public  interface Igoods
    {
        DataTable SelectGoods(int top);
        DataTable SelectMallGoods(string A, string B); //绑定商品
        DataTable SelectKeys(string Keys);
        DataTable SelectMallByKeys(string Keys, string UB);
        DataTable SelectID(int ID);
        int InsertGoods(goods  goods);
        DataTable SelectStoreID(string ID);
        //DataTable SelectShoppingCart(string UserName);
        //int InsertShoppingCart(MallItemCart MallItemCart);
        //int DeleteShoppingCart(int ShoppingCartID);
        //DataTable SelectAllTotalAmount(string UserName);
        //int UpdateShoppingCartNum(int CartID, int num, float total);
        //DataTable JudgeShoppingCart(int UserID);
        //DataTable JudgeMallYorN(int UserID, int GoodsID);//判断某用户购物车是否有某商品的方法
        //int UpdateShoppingCart(int UserID, int GoodsID, int Number, float TotalAmount);//购物车有商品时做更新操作
        //int InsertIndent(int UserID); //从购物车表插入订单表
        DataTable SelectIndent(int UserID); //从订单表查询某用户的订单信息
        DataTable SelectIndentIntro(int OrderID); //从订单表查询某订单的订单信息
        DataTable SelectIndentDetail(int OrderID); //从订单详细表查询订单详细信息
        DataTable SelectAll();
        int DeleteGoods(int GoodsID);
        //DataTable SelectUserMallCart(int UserID); //查询用户购物车数量
    }
}
