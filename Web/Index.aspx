<%@ Page Title="" Language="C#" MasterPageFile="~/Nav.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Web.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/bootstrap.min.css" rel="stylesheet" />
    <link href="css/demo.css" rel="stylesheet" />
    <link href="css/font-awesome.min.css" rel="stylesheet" />
    <link href="css/Home.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <%-- 轮播 --%>
        <div id="carousel-example-generic" class="carousel slide" data-ride="carousel" style="position:relative;">
              <!-- Indicators -->
              <ol class="carousel-indicators">
                    <li data-target="#carousel-example-generic" data-slide-to="0" class="active"></li>
                    <li data-target="#carousel-example-generic" data-slide-to="1"></li>
                    <li data-target="#carousel-example-generic" data-slide-to="2"></li>
              </ol>
              <!-- Wrapper for slides -->
              <div class="carousel-inner" role="listbox">
                    <div class="item active">
                      <img src="img/31.jpg" alt="..." style="width:100%;" />
                    </div>
                    <div class="item">
                      <img src="img/21.jpg" alt="..." style="width:100%;"/>
                    </div>
                    <div class="item">
                      <img src="img/22.jpg" alt="..." style="width:100%;"/>
                    </div>
              </div>
        </div>
        <%-- 租车 --%>
        <div style="position:absolute;top:25%;left:12%;background-color:white;width:30%;padding-left:3%;opacity:0.95;">
            <div>取车城市<asp:DropDownList ID="DropDowncity1" class="hire" runat="server" style="height:34px;"></asp:DropDownList></div>
            <div>还车城市<asp:DropDownList ID="DropDowncity" class="hire" runat="server" style="height:34px;"></asp:DropDownList></div>
            <div>租车日期<input type="date" class="hire" runat="server" id="datebegin" style="padding:0;"/></div>
            <div>还车日期<input type="date" class="hire" runat="server" id="dateend" style="padding:0;"/></div>
            <asp:Button ID="Button1" style="width:89%;height:50px;margin-top:3%;margin-bottom:3%;background-color:#d81e06;border:none;color:white;font-weight:600;font-size:1.4em;" runat="server" onclick="hire" Text="立即租车" />
        </div>
        <%-- 游记 --%>
        <div class="divider col-sm-8 col-xs-8 col-md-8" style="width:55%;margin-left:5%;margin-top:2%;">
                <div class="header-text">游记 <span>News</span></div>
                <div class="tab-content " style="margin-bottom:20px;">
                    <div class="tab-pane active" id="1">
                         <asp:ListView id="LVtravel" runat ="server"  ItemPlaceholderID ="itemPlaceholder"> 
                            <LayoutTemplate>
                                <div>
                                    <asp:PlaceHolder ID="itemPlaceholder" runat="server" />
                                </div>                
                                <asp:DataPager ID="DataPager1" runat="server" PageSize="4"></asp:DataPager>
                            </LayoutTemplate> 
                            <ItemTemplate >
                                <div class="blog-event" style="transition:all 0.5s ease-in;padding:20px;border-radius:3px;"> 
                                    <div class =" featured-img" >
                                        <asp:Image ID="CoverLabel" runat="server" Width="250px" Height="150px" ImageUrl='<%#Eval("record_cover") %>'  />
                                    </div>
                                    <div class=" featured-blog">                    
                                        <h3><a href="TravelCommentReply.aspx?id=<%#Eval("trrecord_id") %>" style="color:rgb(51,51,51);text-decoration:none;"><%#Eval("record_title") %></h3></a>                    
                                        <asp:Label ID="ContLabel" runat="server" Text='<%# Eval("record_cont").ToString().Substring(0,70)+ "..." %>' /><br />
                                        <h5 style="color:#d81e06"><%#Eval ("record_author") %></h5>                                         
                                    </div>
                                </div>
                            </ItemTemplate>
                         </asp:ListView>
                    </div>
                 </div>
            </div>
        <%-- 赛事 --%>
        <div class="divider col-sm-4 col-xs-4 col-md-4" style="width:25%;margin-left:5%;margin-top:2%;">
                <div class="header-text">赛事 <span>Contest</span></div>
                <%-- 赛事资讯 --%>
                <div id="news"> 
                    <div class="nav-title">
                       <span >最新资讯</span>
                       <a href="ContestNews.aspx"><span style="color:#d81e06">More>></span></a>          
                    </div>
                    <hr />
                    <div class="title">
                        <asp:ListView ID="ListView1" runat="server" ItemPlaceholderID="itemPlaceHoder">
                            <LayoutTemplate>
                                <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
                                <table runat="server" id="itemPlaceHoder"></table>
                                <asp:DataPager ID="DataPager1" runat="server" PageSize="10">
                                </asp:DataPager>
                            </LayoutTemplate>
                            <ItemTemplate>
                                <a href="ContestNews.aspx?id=<%#Eval("news_id") %>" style="color:#000000;"><%#Eval("news_title") %></a><br></br>
                            </ItemTemplate>
                        </asp:ListView>
                    </div>
                </div>
                <%-- 赛事预告 --%>
                <div id="contest"> 
                    <div class="nav-title">
                        <span >赛事预告</span>
                        <a href="Contest.aspx"><span style="color:#d81e06">More>></span></a>
                    </div>
                    <hr />
                    <div class="title">
                        <asp:ListView ID="LVContest" runat="server" ItemPlaceholderID="itemPlaceHoder">
                            <LayoutTemplate>
                                 <asp:PlaceHolder ID="PlaceHolder2" runat="server"></asp:PlaceHolder>
                                 <table runat="server" id="itemPlaceHoder"></table>
                                 <%--<asp:DataPager ID="DataPager1" runat="server" PageSize="10">
                                 </asp:DataPager>--%>
                            </LayoutTemplate>
                            <ItemTemplate>
                               <div class ="contest_time" style ="float :left ;width :37%;border-right:1px solid #ccc">
                                  <asp:Label ID="ConTimeLabel" runat="server" Text='<%# Eval("con_time","{0:yyyy-MM-dd}") %>' /><br />
                               </div>
                               <div class ="contest_title" style ="float :right ;width :50%">
                                  <a href="#"><asp:Label ID="ConTitleLabel" style="color:black;" runat="server" Text='<%# Eval("con_title") %>' /><br /></a>
                               </div>
                               <br /><br />                      
                            </ItemTemplate>
                        </asp:ListView>
                    </div>
                </div>
            </div>  
        <script src="scripts/jquery-1.10.2.min.js"></script>
        <script src="scripts/bootstrap.min.js"></script>
        <%--<script src="scripts/script.js"></script>--%>
        <script src="scripts/pageSwitch.min.js"></script>
        <script src="scripts/jquery.pwstabs-1.2.1.js"></script>
        <script src="scripts/jQuery-face-cursor.js"></script>
        <script src="scripts/pgwslider.min.js"></script>
</asp:Content>
