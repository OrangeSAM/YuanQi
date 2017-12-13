<%@ Page Title="" Language="C#" MasterPageFile="~/Nav.Master" AutoEventWireup="true" CodeBehind="TravelRecord.aspx.cs" Inherits="Web.WebForm6" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/bootstrap.min.css" rel="stylesheet" />
    <link href="css/font-awesome.min.css" rel="stylesheet" />
    <link href="css/Travel.css" rel="stylesheet" />
   <%-- <link href="css/main.css" rel="stylesheet" />--%>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="left">
        <section id="intro">
			<a href="#" class="logo">
                <img src="img/logo.png" /></a>
				<header>
					<h2>骑行游记</h2>
						<p>Travel Record</p>
				</header>
		</section>
        <asp:ListView ID="LVTravel1" runat="server">
            <LayoutTemplate>
                <asp:PlaceHolder ID="itemPlaceHolder" runat="server" />
            </LayoutTemplate>
            <ItemTemplate>
                <article class="mini-post">
                    <header>
                        <h3><a href="TravelCommentReply.aspx?id=<%#Eval("trrecord_id") %>"><%#Eval("record_title") %></a></h3>
                        <time class="published"><%# string.Format("{0:yyyy-MM-dd}",Eval("pub_time")) %></time>
                        <a href="#" class="author"><img src="<%#Eval("user_photo") %>" /></a>
                    </header>
                    <a href="#"><img src="<%#Eval("record_cover") %>" class="image featured"/></a>
                </article>
            </ItemTemplate>
        </asp:ListView>
    </div>
    <div id="right">
    <asp:ListView ID="LVTravel" runat="server">
        <LayoutTemplate>
            <asp:PlaceHolder ID="itemPlaceHolder" runat="server" />
        </LayoutTemplate>
        <ItemTemplate>
            <div class="main">
                <%--游记详情--%>
                <article class="post">
                    <header>
                        <div class="title">
                            <h2><%#Eval("record_title") %></h2>
                        </div>
                        <div class="meta">
                            <time class="published"><%# string.Format("{0:yyyy-MM-dd}",Eval("pub_time"))%></time>
                            <a href="#" class="author"><span class="name"><%#Eval("record_author") %></span><img src="<%#Eval("user_photo") %>" /></a>
                        </div>
                    </header>
                    <img src="<%#Eval("record_cover") %>" class="image featured"/>
                    <p><%#Eval("record_cont") %></p>
                   <%-- <footer>--%>
                        <ul class="actions">
                            
                        </ul>
                        <ul class="stats">
                            <li><a href="TravelCommentReply.aspx?id=<%#Eval("trrecord_id") %>" class="button-main big">continue reding</a></li>
                            <li style="float:right;"><a href="#" class="icon-bar fa-heart"><%#Eval("col_count") %></a></li>
                            <li style="float:right;"><a href="#" class="icon-bar fa-comment"><%#Eval("comt_count") %></a></li>
                            <li style="float:right;"><a href="#" class="icon-bar fa-heart-o"><%#Eval("like_count") %></a></li>
                        </ul>
                   <%-- </footer>--%>
                </article>
            </div>
        </ItemTemplate>
    </asp:ListView>
         <div class="pager">
                     <asp:DataPager ID="travelpager" runat="server"  PagedControlID="LVTravel"  PageSize="4" >
                         <Fields>   
                        <asp:NextPreviousPagerField FirstPageText="首页" PreviousPageText="上一页" ButtonType="Button" ShowFirstPageButton="true" ShowNextPageButton="false" ButtonCssClass="btn btn-primary btn-sm"/>
                        <asp:NumericPagerField NextPreviousButtonCssClass="btn btn-primary btn-sm" NumericButtonCssClass="btn btn-primary btn-sm" ButtonCount="4" />
                        <asp:NextPreviousPagerField NextPageText="下一页" LastPageText="末页" ShowPreviousPageButton="false" ButtonType="Button" ButtonCssClass="btn btn-primary btn-sm" ShowLastPageButton="true" />
                    </Fields>                         
                     </asp:DataPager>
        </div>
        </div>
</asp:Content>
