<%@ Page Title="" Language="C#" MasterPageFile="~/Nav.Master" AutoEventWireup="true" CodeBehind="Contest.aspx.cs" Inherits="Web.WebForm4" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
      <link href="css/bootstrap.min.css" rel="stylesheet" />
      <link href="css/contest.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ListView ID ="LVContest" runat ="server" >
        <LayoutTemplate >
            <div id="itemPlaceholderContainer" runat="server">
              <div id="itemPlaceholder" runat="server">
              </div>
            </div>
        </LayoutTemplate>
        <ItemTemplate >
              <article class="post">
	            <header>
                    <div class="title">
         	            <h2 style="font-size:30px;"><a href="#"><%#Eval("con_title") %></a></h2>
          	            <p><%#Eval("con_place") %></p>
                    </div>
      	            <div class="meta">
                         <time class="published" style="font-size:12px;"><%#Eval("con_time") %></time>       		
      	            </div>
	            </header>
                <p style="font-size:20px;"><%#Eval("con_intro") %></p>
              </article>
         </ItemTemplate>
    </asp:ListView>
    <div class="pager">
      <asp:DataPager runat ="server" ID ="datapager" PageSize ="4" PagedControlID="LVContest" OnPreRender="contestpager_PreRender">
           <Fields>
                <asp:NextPreviousPagerField FirstPageText="首页" PreviousPageText="上一页" ButtonType="Button" ShowFirstPageButton="true" ShowNextPageButton="false"  ButtonCssClass="btn btn-primary btn-sm"/>
                <asp:NumericPagerField NextPreviousButtonCssClass="btn btn-primary btn-sm" NumericButtonCssClass="btn btn-primary btn-sm" ButtonCount="4" />
                <asp:NextPreviousPagerField NextPageText="下一页" LastPageText="末页" ShowPreviousPageButton="false" ButtonType="Button" ButtonCssClass="btn btn-primary btn-sm" ShowLastPageButton="true" />
          </Fields>
      </asp:DataPager>
    </div> 
</asp:Content>
