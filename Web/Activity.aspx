<%@ Page Title="" Language="C#" MasterPageFile="~/Nav.Master" AutoEventWireup="true" CodeBehind="Activity.aspx.cs" Inherits="Web.WebForm8" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/contest.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ListView ID ="LVActivity" runat ="server" GroupItemcount="3">
        <LayoutTemplate>
            <div>
                <asp:PlaceHolder ID="groupPlaceholder" runat="server"></asp:PlaceHolder>
            </div>
        </LayoutTemplate>
        <GroupTemplate>
            <div style=";width:735px;margin:20px auto;">
                <asp:PlaceHolder ID="itemplaceholder" runat="server" />
            </div>
        </GroupTemplate>
        <ItemTemplate >
            <div style="display:inline-block;text-align:center;width:30%;">
         	    <span style="font-size:30px;"><a href="#" style="color:black;"><%#Eval("act_name") %></a></span><br /><br />
                <time style=""><%#Eval("pub_time","{0:yyyy-MM-dd}") %></time><br /><br />
                <span style=""><%#Eval("activity_cont").ToString().Substring(0,8) + "..." %></span><br /><br />
                <a href="Activity_detail.aspx?id=<%#Eval("activity_id") %>" class="button big" style="width:100%">加入</a>
            </div>
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
