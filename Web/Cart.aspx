<%@ Page Title="" Language="C#" MasterPageFile="~/Mall.master" AutoEventWireup="true" CodeBehind="Cart.aspx.cs" Inherits="Web.WebForm13" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
      .cart{
          padding:2em 0;
      }
      .cart-top{
          background:white;
          width:86%;
          height:50px;
          margin-left:8%;
      }
      .temp{
          display:inline-block;
          float:right;
      }
    </style>
    <script src="scripts/jquery-1.10.2.min.js"></script>
    <link href="scripts/date/bootstrap-datetimepicker.min.css" rel="stylesheet" />
    <script src="scripts/date/bootstrap-datetimepicker.min.js"></script>
    <script src="scripts/bootstrap.min.js"></script>
    <link href="scripts/date/bootstrap-datetimepicker.css" rel="stylesheet" />  
    <script src="scripts/date/bootstrap-datetimepicker.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server" style="min-height:566px !important;">
    <%--<div class="cart-top"><h1>我的购物车</h1></div>--%>
    <asp:Panel ID="Panel01" runat="server">
       <div id="Panel01Box">
            <div class="cart" style="min-height:477px;">
                <div class="container" style="max-width:80%;">
                     <div class="row" style="border-bottom:1px solid;">
                        <div class="col-md-1">
                            <h4>物品图</h4>
                        </div>
                        <div class="col-md-4">
                            <h4>物品名</h4>
                        </div>
                        <div class="col-md-1">
                            <h4>库&nbsp;存</h4>
                        </div>
                        <div class="col-md-2">
                            <h4>数&nbsp;量</h4>
                        </div>
                        <div class="col-md-2">
                            <h4>单&nbsp;价</h4>
                        </div>
                        <div class="col-md-1">
                            <h4>总&nbsp;计</h4>
                        </div>
                    </div>
                        <asp:Repeater ID="Reshoppingcart" runat="server" OnItemCommand="Reshoppingcart_ItemCommand">
                            <ItemTemplate>
                                  <div class="row" style="margin-top:5px;">
                                    <div class="col-md-1">
                                       <img src="<%#Eval("photo") %>"  style="width:50px;height:50px;"/>
                                    </div>
                                    <div class="col-md-4">
                                        <h4><%#Eval("goods_name") %></h4>
                                         
                                     </div>
                                    <div class="col-md-1">
                                        <asp:Label ID="LabelMallGoodsNum" runat="server" style="font-size:18px;" Text='<%#Eval("stock")%>' />
                                       <asp:Label ID="LabelShoppingCartID" runat="server" Visible="false" Text='<%#Eval("shoppingcart_id")%>' />
                                    </div>
                                    <div class="col-md-2">
                                        <div class="input-group">
                                             <asp:TextBox ID="sqlMallNumber" runat="server" style="width:40%;" type="text" class="form-control" Text='<%#Eval("number")%>'>
                                             </asp:TextBox>
                                       </div>
                                    </div>
                                    <div class="col-md-2">
                                        <h5><asp:Label ID="lblPrice" runat="server" Text='<%#Eval("goods_price")%>' /></h5>
                                    </div>
                                    <div class="col-md-1">
                                        <h5 style="color: red">￥&nbsp<%#Eval("total_price")%></h5>
                                    </div>
                                    <div class="col-md-1">
                                        <asp:LinkButton ID="Mallclose" runat="server" Text="×" CommandName="Delete" />
                                    </div>
                                  </div>
                            </ItemTemplate>
                        </asp:Repeater>
                     <asp:Repeater ID="trShoppingCartBuy" runat="server" OnItemCommand="trShoppingCartBuy_ItemCommand">
                        <ItemTemplate>
                            <div class="row">
                                <div class="col-md-4">
                                    <div style="margin-top:5px;font-size:20px;"><small>共计</small>&nbsp<asp:Label ID="FinalTotalAmount" runat="server" Text='<%#Eval("FinalTotalAmount")%>'></asp:Label></div>
                                </div>
                                <div class="col-md-8" style="float:right">
                                    <div class="temp">
                                        <input type="button" class="btn btn-primary" value="继续逛逛" onclick="javascrtpt: window.location.href = 'TravelRent.aspx'"/>
                                    </div>
                                    <div class="temp" style="margin-right:10px;">
                                        <input type="button" class="btn btn-default" onClick="meg(1)" value="立即租用">
                                    </div>
                                </div>
                            </div>
                            <div id="inputbox" class="box" style="width:35%;margin-top:10%;margin:auto;padding:25px;z-index:3;border:1px solid #def1f1;display:none;position:fixed;left:30%;top:20%;background-color:aliceblue;border-radius:7px;box-shadow:0px 0px 10px 0px;">
        <a class="close" href="#" onclick="meg(0); return false;">关闭</a>
        <div class="available">
            <ul>
                <li>
                    租用日期：
                    <div class="input-group date" id='datetimepicker6' >  
                        <asp:TextBox ID="start" runat="server" CssClass="form-control"></asp:TextBox>                           
                        <%--<input id="start" type='text' class="form-control" runat="server"/>--%>
                        <span class="input-group-addon">
                        <span class="glyphicon glyphicon-calendar"></span>
                        </span>
                    </div>
                </li>
                <li>
                    结束日期：
                    <div class="input-group date" id='datetimepicker7' >
                        <asp:TextBox ID="end" runat="server" CssClass="form-control"></asp:TextBox>
                        <%--<input id="end" type='text' class="form-control" runat="server"/>--%>
                        <span class="input-group-addon">
                            <span class="glyphicon glyphicon-calendar"></span>
                        </span>
                    </div>
                </li>
                <%--<div class="clearfix"></div>--%>            
            </ul>
            <asp:LinkButton ID="BuyBuy" runat="server" class="btn btn-default" CommandName="BuyBuy">租用</asp:LinkButton>
        </div>
    </div>
                        </ItemTemplate>
                    </asp:Repeater>
                </div>
            </div>
       </div>
   </asp:Panel>
    <asp:Panel ID="Panel02" runat="server">
         <div id="imgBox" style="height:200px; margin-left:8%">
             租用成功
         </div>
    </asp:Panel>
    <script>
        function meg(n) {
            document.getElementById('inputbox').style.display = n ? 'block' : 'none';
        }
    </script>
    
    <script src="scripts/jquery-1.10.2.min.js"></script>
    <script src="scripts/bootstrap.min.js"></script>
</asp:Content>
