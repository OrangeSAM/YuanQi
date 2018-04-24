<%@ Page Title="" Language="C#" MasterPageFile="~/Mall.master" AutoEventWireup="true" CodeBehind="Mall.aspx.cs" Inherits="Web.WebForm17" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/bootstrap.css" rel="stylesheet" type="text/css" media="all" />
    <link href="css/Rent_style.css" rel="stylesheet" />
    <script src="scripts/jquery-1.10.2.min.js"></script>
    <script src="scripts/bootstrap.min.js"></script>
    <style>
        .egg:hover{
            border-color:#d81e06;
            transition:1s;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container" style="width:80%;">
        <%-- 店铺--%>
         <asp:ScriptManager ID="scriptManager" runat="server"></asp:ScriptManager>
         <asp:UpdatePanel ID="Updatestore" runat="server">
             <ContentTemplate>
	             <div class="content-sit">
	                 <div class="">
                            <asp:ListView ID="LVstores" runat="server" GroupItemCount="3">
                                <LayoutTemplate>
                                    <div id="itemPlaceholderContainer" runat="server">
                                        <div id="groupPlaceholder" runat="server"></div>
                                    </div>
                                </LayoutTemplate>
                                <GroupTemplate>
                                    <div>
                                        <placeholder id="itemPlaceholder" runat="server"></placeholder>
                                    </div>
                                </GroupTemplate>
                                <ItemTemplate>
		                            <div class="egg" style="width:27%;display:inline-block;margin-right:30px;">
                                        <div class="photo">
		                                    <img src="<%#Eval("store_photo") %>"  class ="img-responsive" alt="" style="width:259px;border:2px double #ccc;padding:1px;"/>
                                        </div>
                                        <div class="intro" style="padding-top:4px;">
                                            <a href="stores.aspx?id=<%#Eval("store_id") %>" style="font-size:18px;color:black;text-decoration:none;"><%#Eval("store_name") %></a>
                                        </div>
	                                </div>
                                </ItemTemplate>
                            </asp:ListView>
                      </div>
                 </div>
             </ContentTemplate> 
         </asp:UpdatePanel> 
     </div>
</asp:Content>
