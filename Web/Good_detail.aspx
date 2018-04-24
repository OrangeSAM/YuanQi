<%@ Page Title="" Language="C#" MasterPageFile="~/Mall.master" AutoEventWireup="true" CodeBehind="Good_detail.aspx.cs" Inherits="Web.WebForm11" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="scripts/jquery-1.10.2.min.js"></script>
    <script src="scripts/bootstrap.min.js"></script>
    <link href="font-awesome-4.7.0/css/font-awesome.min.css" rel="stylesheet" />
    <link href="scripts/date/bootstrap-datetimepicker.css" rel="stylesheet" />
    <link href="scripts/date/bootstrap-datetimepicker.min.css" rel="stylesheet" />
    <script src="scripts/date/bootstrap-datetimepicker.js"></script>
    <script src="scripts/date/bootstrap-datetimepicker.min.js"></script>
    <style>
        h1, h2, h3, h4, h5, h6 {
          padding: 12px 0;
          margin:0;
        }
        .single-para h4 {
            color: #444444;
          font-size: 1.7em;
            padding: 0;
        }
        .single-para p {
          font-size: 1em;
          color: #2c3e50;
          line-height: 1.8em;
            margin: 1em 0;
        }
        .single-para h5 {
          color: #ff5d56;
          font-size: 2em;
          border-bottom: 1px solid #C4C3C3;
          padding: 0.3em 0;
        }
        .star-on {
          padding: .6em 0;
        }
        .review{
	        float:left;
        }
        ul{
            padding:0;
            list-style:none;
        }
        .available {
          padding:  1em 0;
        }
        .available ul li{
	        list-style:none;
	        padding:0 0.5em 0 0;
	        color:#4c4c4c;
	        font-size:1.1em;
	        float:left;
	        width:100%;
	           margin: 0.5em 0;
        }
        .available ul li select{
          outline: none;
          padding: 12px;
          border: none;
          background: #eeeeee;
          width: 77%;
          margin-left: 13%;
          cursor:pointer;
        }
        .available ul li.size-in select {
	          margin-left: 16%;
        }
        .tag{
    
	        padding:0.3em 0;
	         border-top: 1px solid #C4C3C3;
	          /*border-bottom: 1px solid #C4C3C3;*/
              margin-top:5px;
        }
        .tag p {
            color:#797979;
	        font-size:1.5em;
	        line-height:2em;
	        padding:0 0 1em;
        }
        .date{
            width:60%;
        }
        .addcart{
            margin:10px 0px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <asp:ListView ID="LVgoods" runat="server" OnItemCommand="LVgoods_ItemCommand">
            <LayoutTemplate>
                <div id="itemPlaceholderContainer" runat="server">
                    <div id="itemPlaceholder" runat="server"></div>
                </div>
            </LayoutTemplate>
            <ItemTemplate>
                <div class="col-lg-6">
                    <%-- 绑定商品图片--%>
                    <img src="<%#Eval("photo") %>" style="width:600px;" />
                </div>
                <div class="col-lg-5  single-top col-lg-offset-1">
                    <div class="single-para">
                        <h4><%#Eval("goods_name") %></h4>
                        <div class="star-on">
                            <div class="review">
                                <a href="#"><%#Eval("store_name") %></a>
                            </div>
                            <div class="clearfix"></div>
                        </div>
                        <h5 class="item_price">
                            <asp:Label ID="RTprice" Text='<%#Eval("goods_price") %>' runat="server"></asp:Label>
                        </h5>
                        <div class="tag">
                            <div class="row">
                                <div class="col-md-2">
                                    <h4>数量</h4>
                                </div>
                                <div class="col-md-6">
                                    <div class="input-group">
                                        <span class="input-group-btn">
                                            <asp:LinkButton ID="NumMinus" runat="server" class="btn btn-default" CommandName="Minus"><em><span class="glyphicon glyphicon-minus"></span></em></asp:LinkButton>
                                        </span>
                                        <asp:TextBox ID="TextNum" runat="server" class="form-control text-center" Text='<%#ViewState["ShoppingCartNumber"]%>'></asp:TextBox>
                                        <span class="input-group-btn">
                                            <asp:LinkButton ID="NumAdd" runat="server" class="btn btn-default" CommandName="Add"><em><span class="glyphicon glyphicon-plus"></span></em></asp:LinkButton>
                                        </span>
                                    </div>
                                </div>
                                <div class="col-md-3">
                                    <h4>库存&nbsp<%#Eval("stock") %></h4>
                                </div>
                            </div>
                        </div>
                        <div class="tag">
                            <p><%#Eval("goods_intro") %></p>
                        </div>
                        <div class="col-md-12 addcart">
                            <asp:LinkButton ID="AddShoppingCart" runat="server" class="btn btn-primary" CommandName="AddShoppingCart">加入购物车</asp:LinkButton>
                        </div>
                    </div>
                    <div class="clearfix"></div>
                </div>
            </ItemTemplate>
        </asp:ListView>
    </div>
    <script type="text/javascript">
    $(function () {
        $('#datetimepicker6').datetimepicker();
        $('#datetimepicker7').datetimepicker({
            useCurrent: false //Important! See issue #1075
        });
        $("#datetimepicker6").on("dp.change", function (e) {
            $('#datetimepicker7').data("DateTimePicker").minDate(e.date);
        });
        $("#datetimepicker7").on("dp.change", function (e) {
            $('#datetimepicker6').data("DateTimePicker").maxDate(e.date);
        });
    });
</script>
</asp:Content>
