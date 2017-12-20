<%@ Page Title="" Language="C#" MasterPageFile="~/Nav.Master" AutoEventWireup="true" CodeBehind="ContestNews.aspx.cs" Inherits="Web.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
   
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="css/ContestNews.css" rel="stylesheet" />
     <div class="main">
        <%--左侧新闻标题--%>
        <div class="MoreNews">
            <div class="NewIcon">
                
                <p>最近资讯</p>
            </div>
            <div class="MoreNewsTitle">

                <asp:ListView ID="ElseNewsListView" runat="server">
                    <LayoutTemplate>
                        <div id="itemPlaceholderContainer" runat="server">
                            <div id="itemPlaceholder" runat="server">
                            </div>
                        </div>
                      
                    </LayoutTemplate>
                    <ItemTemplate>

                        <ul class="box">
                            <li><a href="ContestNews.aspx?id=<%#Eval("news_id") %>"><%#Eval("news_title") %> </a><hr /></li>
                            
                        </ul>
                    </ItemTemplate>
                </asp:ListView>
                <div class="pager">
      <asp:DataPager runat ="server" ID ="datapager" PageSize ="5" PagedControlID="ElseNewsListView" OnPreRender="news_PreRender">
           <Fields>
           
                        <asp:NextPreviousPagerField FirstPageText="首页" PreviousPageText="上一页" ButtonType="Button" ShowFirstPageButton="true" ShowNextPageButton="false"  ButtonCssClass="btn btn-primary btn-sm"/>
                        <asp:NumericPagerField NextPreviousButtonCssClass="btn btn-primary btn-sm" NumericButtonCssClass="btn btn-primary btn-sm" ButtonCount="4" />
                        <asp:NextPreviousPagerField NextPageText="下一页" LastPageText="末页" ShowPreviousPageButton="false" ButtonType="Button" ButtonCssClass="btn btn-primary btn-sm" ShowLastPageButton="true" />
                   
          </Fields>
      </asp:DataPager>
            </div> 
            </div>
           </div>  
        <%--右侧新闻内容--%>
        <div class="NewsContent">
            <asp:Repeater ID="NewsContentRepeater" runat="server">
                <ItemTemplate>              
            <div class="first-main">
                <h3><%#Eval("news_title") %></h3>
                <h5>发布时间:<%#Eval("pub_time") %>&nbsp&nbsp&nbsp&nbsp 来源: 远骑网</h5>
            </div>
            <hr />
            <div class="second-main">
               
                <div class="text">
                    <h6 style="  line-height:25px; margin-top: 15px; color: #555555; margin-left: 5px; margin-top: 5px;padding:15px; font-size:15px; ">&nbsp&nbsp&nbsp&nbsp <%#Eval("news_cont") %></h6>
                </div>
                
            </div>
                      </ItemTemplate>
            </asp:Repeater>
        </div>

    </div>
         
</asp:Content>
