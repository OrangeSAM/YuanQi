<%@ Page Title="" Language="C#" MasterPageFile="~/Nav.Master" AutoEventWireup="true" CodeBehind="Activity.aspx.cs" Inherits="Web.WebForm8" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
	
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="css/contest.css" rel="stylesheet" />
  <div class="divider col-sm-12 col-xs-12 col-md-12">
      <div class="header-text">Activity<span>活动</span></div>      
  </div><br /><br /><br /><br /><br />
    <asp:ListView ID ="LVActivity" runat ="server" >
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
         	<h2 style="font-size:30px;"><a href="#"><%#Eval("act_name") %></a></h2>
          		
        </div>
      	<div class="meta">
             <time class="published" style="font-size:12px;"><%#Eval("pub_time") %></time>       		
      	</div>
	</header>
   
    <p style="font-size:20px;"><%#Eval("activity_cont") %></p>
   
      <ul class="actions">
	     <li><a href="Activity_detail.aspx?id=<%#Eval("activity_id") %>" class="button big">Continue Reading</a></li>
      </ul>
     

  </article>
        </ItemTemplate>
</asp:ListView>
<div class="pager">
      <asp:DataPager runat ="server" ID ="datapager" PageSize ="3" PagedControlID="LVActivity" OnPreRender="activitypager_PreRender">
           <Fields>
           
                        <asp:NextPreviousPagerField FirstPageText="首页" PreviousPageText="上一页" ButtonType="Button" ShowFirstPageButton="true" ShowNextPageButton="false"  ButtonCssClass="btn btn-primary btn-sm"/>
                        <asp:NumericPagerField NextPreviousButtonCssClass="btn btn-primary btn-sm" NumericButtonCssClass="btn btn-primary btn-sm" ButtonCount="4" />
                        <asp:NextPreviousPagerField NextPageText="下一页" LastPageText="末页" ShowPreviousPageButton="false" ButtonType="Button" ButtonCssClass="btn btn-primary btn-sm" ShowLastPageButton="true" />
                   
          </Fields>
      </asp:DataPager>
            </div> 




</asp:Content>
