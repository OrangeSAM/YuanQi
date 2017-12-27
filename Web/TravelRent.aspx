<%@ Page Title="" Language="C#" MasterPageFile="~/Nav.Master" AutoEventWireup="true" CodeBehind="TravelRent.aspx.cs" Inherits="Web.WebForm10" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/bootstrap.css" rel="stylesheet" type="text/css" media="all" />
    <link href="css/Rent_style.css" rel="stylesheet" />

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <%--图片--%>
    <div class="banner">
		<div class="banner-in">		
			</div>	
	</div>

    <div class="content-grid">
    <%--左边排行榜--%>
    
			<div class="col-md-4 grid-food">
                 
				<div class="popular">
				<h3>租车热榜</h3>
				<p>Popular Products</p>
             <asp:ListView  ID="LVhot" runat ="server" >
                 <LayoutTemplate >
                     <div id="itemPlaceholderContainer" runat="server">
          <div id="itemPlaceholder" runat="server">
          </div>
        </div>
                 </LayoutTemplate>
                    <ItemTemplate >
				<ul class="popular-in">
					<li><a href="#"><i></i><%#Eval("goods_name") %> </a></li>											
				</ul>
                    </ItemTemplate> 
                   </asp:ListView>
                    <asp:DataPager ID="pager" runat ="server" PageSize ="4" PagedControlID ="LVhot"></asp:DataPager>
				</div>
                 
				<div class="popular phone">
					<h3>订购热线</h3>
					<p>时间：9：00-18：00</p>
					<ul class="number">
						<li><span><i> </i>(000) 888 88888</span ></li>
						<li><a href="#"><i class="mail"> </i>yuanqi@163.com </a></li>					
					</ul>
				</div>
				
			</div>
        <div class ="col-md-1 food-grid "></div>
         <div class="col-md-7 food-grid">            
            <asp:listview ID ="LVgoods" runat ="server" >
                <LayoutTemplate >
                    <div id="itemPlaceholderContainer" runat="server">
          <div id="itemPlaceholder" runat="server">
          </div>
        </div>
                </LayoutTemplate>
                <ItemTemplate >
				<div class="cup">
					<div class="col-md-5 cup-in">
						<a href="single.html"><img src="<%#Eval("photo") %>" class="img-responsive" alt="" style ="width :100%;height :150px;"></a>
						<p><%#Eval("goods_name") %></p>
						<span class="dollar">
                            <%#Eval("goods_price") %>
						</span>
						<div class="details-in">
							<a href="#" class="details">商品详情</a>
						</div>
						<div class="clearfix"> </div>
					</div>									
				 </div>
                </ItemTemplate>
            </asp:listview>  
             </div>
             <br />
                <div class="pager">
      <asp:DataPager runat ="server" ID ="datapager" PageSize ="4" PagedControlID="LVgoods" OnPreRender="datapager_PreRender">
           <Fields>
           
                        <asp:NextPreviousPagerField FirstPageText="首页" PreviousPageText="上一页" ButtonType="Button" ShowFirstPageButton="true" ShowNextPageButton="false"  ButtonCssClass="btn btn-primary btn-sm"/>
                        <asp:NumericPagerField NextPreviousButtonCssClass="btn btn-primary btn-sm" NumericButtonCssClass="btn btn-primary btn-sm" ButtonCount="4" />
                        <asp:NextPreviousPagerField NextPageText="下一页" LastPageText="末页" ShowPreviousPageButton="false" ButtonType="Button" ButtonCssClass="btn btn-primary btn-sm" ShowLastPageButton="true" />
                   
          </Fields>
      </asp:DataPager>
            </div> 
			
           
</div> 
</asp:Content>
