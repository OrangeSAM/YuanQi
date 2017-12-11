<%@ Page Title="" Language="C#" MasterPageFile="~/Nav.Master" AutoEventWireup="true" CodeBehind="Contest.aspx.cs" Inherits="Web.WebForm4" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<%--    <link href="css/main.css" rel="stylesheet" />--%>
    <link href="css/contest.css" rel="stylesheet" />
    <asp:ListView ID ="LVContest" runat ="server" >
    <LayoutTemplate >
        <div id="itemPlaceholderContainer" runat="server">
          <div id="itemPlaceholder" runat="server">
          </div>
        </div>
      <asp:DataPager runat ="server" ID ="datapager" PageSize ="6"></asp:DataPager>
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
   	<%--<a href="#" class="image featured"><img src="images/pic01.jpg" alt="" /></a>--%>
    <p style="font-size:20px;"><%#Eval("con_intro") %></p>
   
      <ul class="actions">
	     <li><a href="#" class="button big">Continue Reading</a></li>
      </ul>
     

  </article>
        </ItemTemplate>
</asp:ListView>

</asp:Content>
