<%@ Page Title="" Language="C#" MasterPageFile="~/Nav.Master" AutoEventWireup="true" CodeBehind="Activity.aspx.cs" Inherits="Web.WebForm8" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
	
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
    <main id="main">
	<div class="container">
       <div class="row section featured topspace">
			<h2 class="section-title" style="text-align :center ;"><span>Activities</span></h2>
           <asp:ListView ID="LVActivity" runat ="server" GroupItemCount ="3"  GroupPlaceholderID ="groupPlaceholder">
               <LayoutTemplate >
                   <div id="itemPlaceholderContainer" runat="server">
          <div id="itemPlaceholder" runat="server">
          </div>
        </div>
                   <div id="groupPlaceholderContainer" runat="server" border="0" style="">
                                           <div id="groupPlaceholder" runat="server">
                                           </div>
                                       </div>
                <div class="pager">
      <asp:DataPager runat ="server" ID ="datapager"  PageSize ="6" PagedControlID="LVActivity" OnPreRender="activitypager_PreRender">
           <Fields>
           
                        <asp:NextPreviousPagerField FirstPageText="首页" PreviousPageText="上一页" ButtonType="Button" ShowFirstPageButton="true" ShowNextPageButton="false"  ButtonCssClass="btn btn-primary btn-sm"/>
                        <asp:NumericPagerField NextPreviousButtonCssClass="btn btn-primary btn-sm" NumericButtonCssClass="btn btn-primary btn-sm" ButtonCount="4" />
                        <asp:NextPreviousPagerField NextPageText="下一页" LastPageText="末页" ShowPreviousPageButton="false" ButtonType="Button" ButtonCssClass="btn btn-primary btn-sm" ShowLastPageButton="true" />                   
          </Fields>
      </asp:DataPager>
            </div>     
               </LayoutTemplate>
               <GroupTemplate>
                   <div id="itemPlaceholderContainer" runat="server">
                                <td id="itemPlaceholder" runat="server"></td>
                            </div>
               </GroupTemplate>
               <ItemTemplate >
			<div class="row">
				<div class="col-sm-6 col-md-4">
					<h3 class="center"> <%#Eval("act_name") %></h3>
					<p><%#Eval("activity_cont") %></p>
					<p ><a href ="Activity_detail.aspx?id=<%#Eval("activity_id") %>" class="btn btn-action">点击详情>></a></p>
				</div>
				
			</div>
            </ItemTemplate>
            </asp:ListView>
          
		</div>
        </div> 
        </main> 

</asp:Content>
