<%@ Page Title="" Language="C#" MasterPageFile="~/Mall.master" AutoEventWireup="true" CodeBehind="stores.aspx.cs" Inherits="Web.WebForm14" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="scripts/jquery-1.10.2.min.js"></script>
    <script src="scripts/bootstrap.min.js"></script>
    <link href="css/Rent_style.css" rel="stylesheet" />
    <link href="font-awesome-4.7.0/css/font-awesome.min.css" rel="stylesheet" />
    <style type="text/css">
        .iw_poi_title {color:#CC5522;font-size:14px;font-weight:bold;overflow:hidden;padding-right:13px;white-space:nowrap}
        .iw_poi_content {font:12px arial,sans-serif;overflow:visible;padding-top:4px;white-space:-moz-pre-wrap;word-wrap:break-word}
        .single:hover{
            box-shadow:0px 0px 20px #888888 inset;
        }
        .button {
            -webkit-border-radius: 4px;
            -moz-border-radius: 4px;
            border-radius: 4px;
            text-shadow: 0px 1px 0px #c3dae9;
            -webkit-box-shadow: 0px 10px 14px -7px #c3dae9;
            -moz-box-shadow: 0px 10px 14px -7px #c3dae9;
            box-shadow: 0px 10px 14px -7px #c3dae9;
            font-family: Arial;
            color: #ffffff;
            font-size: 16px;
            background: #c3dae9;
            padding: 3px 6px 4px 6px;
            border: solid #c3dae9 1px;
            text-decoration: none;
        }
        .button:hover {
          color: #ffffff;
          background: #adc2d0;
          text-decoration: none;
        }
    </style>
    <script type="text/javascript" src="http://api.map.baidu.com/api?key=&v=1.1&services=true"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container" style="margin-top:30px;">
            <div class="col-md-3">
                <asp:ListView ID="LVstores" runat="server">
                    <LayoutTemplate>
                        <div id="itemPlaceholderContainer" runat="server">
                            <asp:PlaceHolder ID="itemPlaceholder" runat="server" />
                        </div>
                    </LayoutTemplate>
                    <ItemTemplate>
                        <div class="">
                            <img class="img-responsive" src="<%#Eval("store_photo") %>" alt="" />
                        </div>
                        <div class="">
                            <span style="font-size:20px;display:block;"><%#Eval("store_name") %></span><br />
                            <span style=""><i class="fa fa-phone" style="padding-right:10px;"></i>电 &nbsp &nbsp &nbsp 话：<%#Eval("store_phone") %></span><br />
                            <span style=""><i class="fa fa-clock-o" style="padding-right:10px;"></i>运营时间：<%#Eval("runtime") %></span><br />
                            <span style=""><i class="fa fa-location-arrow" style="padding-right:10px;"></i>店铺地址：</span><br />
                            <div style="width:255px;height:270px;border:#ccc solid 1px;" id="dituContent"></div>
                            <span style="display:block;padding-top:10px;">店铺介绍：<%#Eval("store_intro") %></span>
                        </div>
                    </ItemTemplate>
                </asp:ListView>
            </div>
            <div class="col-md-9">
                <%-- 这里做出选择商品类别 --%>
                <div class=" " style="margin-left:-1px;">
                    <ul id="mytab" class="nav nav-tabs">
                        <li role="presentation" class="active"><a href="#bicycle" data-toggle="tab">自行车</a></li>
                        <li role="presentation"><asp:LinkButton ID="part" runat="server" OnClientClick="getparts()" href="#parts" data-toggle="tab">配件</asp:LinkButton></li>
                    </ul>
                </div>
                <div id="mytabContent" class="tab-content">
                    <div class="tab-pane fade in  active" id="bicycle">
                        <asp:ListView ID="LVgoods" runat="server" GroupItemCount="3">
                            <LayoutTemplate>
                                <div>
                                    <asp:PlaceHolder ID="groupPlaceholder" runat="server"></asp:PlaceHolder>
                                </div>
                            </LayoutTemplate>
                            <GroupTemplate>
                                <div>
                                    <asp:PlaceHolder ID="itemplaceholder" runat="server" />
                                </div>
                            </GroupTemplate>
                            <ItemTemplate>
                                <div style="display:inline-block;width:260px;padding:20px;transition:.5s ease;background-color:white;text-align:center;" class="single">
                                    <img src='<%#Eval ("photo") %>' style="width:220px;height:165px;" /><br />
                                    <span><%#Eval ("goods_name") %></span><br />
                                    <asp:label id="gprice" runat="server" data-value='<%#Eval ("goods_price") %>'><%#Eval ("goods_price") %></asp:label><br />
                                    <asp:Button ID="rent" runat="server" Text="立即租用" class="button" onclick="rent"/>
                                </div>
                            </ItemTemplate>
                        </asp:ListView>
                    </div>
                    <div class="tab-pane fade" id="parts">
                        <asp:ListView ID="partgoods" runat="server" GroupItemCount="3">
                            <LayoutTemplate>
                                <div>
                                    <asp:PlaceHolder ID="groupPlaceholder" runat="server"></asp:PlaceHolder>
                                </div>
                            </LayoutTemplate>
                            <GroupTemplate>
                                <div>
                                    <asp:PlaceHolder ID="itemplaceholder" runat="server" />
                                </div>
                            </GroupTemplate>
                            <ItemTemplate>
                                <div style="display:inline-block;width:260px;padding:20px;transition:.5s ease;background-color:white;text-align:center;" class="single">
                                    <img src='<%#Eval ("photo") %>' style="width:220px;height:190px;"/><br />
                                    <span><%#Eval ("goods_name") %></span><br />
                                    <asp:label id="RTprice" runat="server" data-value='<%#Eval ("goods_price") %>'><%#Eval ("goods_price") %></asp:label><br />
                                    <asp:Button ID="car" runat="server" Text="加购物车" OnClick="addcar" class="button"/>
                                </div>
                            </ItemTemplate>
                        </asp:ListView>
                    </div>
                </div>
            </div>
    </div>
    <script type="text/javascript">
    //创建和初始化地图函数：
    function initMap(){
        createMap();//创建地图
        setMapEvent();//设置地图事件
        addMapControl();//向地图添加控件
    }
    
    //创建地图函数：
    function createMap(){
        var map = new BMap.Map("dituContent");//在百度地图容器中创建一个地图
        var point = new BMap.Point(116.037358,28.684842);//定义一个中心点坐标
        map.centerAndZoom(point,15);//设定地图的中心点和坐标并将地图显示在地图容器中
        window.map = map;//将map变量存储在全局
    }
    
    //地图事件设置函数：
    function setMapEvent(){
        map.enableDragging();//启用地图拖拽事件，默认启用(可不写)
        map.enableScrollWheelZoom();//启用地图滚轮放大缩小
        map.enableDoubleClickZoom();//启用鼠标双击放大，默认启用(可不写)
        map.enableKeyboard();//启用键盘上下左右键移动地图
    }
    
    //地图控件添加函数：
    function addMapControl(){
        //向地图中添加缩放控件
	var ctrl_nav = new BMap.NavigationControl({anchor:BMAP_ANCHOR_TOP_LEFT,type:BMAP_NAVIGATION_CONTROL_ZOOM});
	map.addControl(ctrl_nav);
        //向地图中添加缩略图控件
	var ctrl_ove = new BMap.OverviewMapControl({anchor:BMAP_ANCHOR_BOTTOM_RIGHT,isOpen:0});
	map.addControl(ctrl_ove);
        //向地图中添加比例尺控件
	var ctrl_sca = new BMap.ScaleControl({anchor:BMAP_ANCHOR_BOTTOM_LEFT});
	map.addControl(ctrl_sca);
    }
    
    
    initMap();//创建和初始化地图
    </script>
</asp:Content>
