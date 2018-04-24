<%@ Page Title="" Language="C#" MasterPageFile="~/Nav.Master" AutoEventWireup="true" CodeBehind="usermodi.aspx.cs" Inherits="Web.usermodi" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .input{
            display:block;
            margin-top:5px;
            border:none;
            background-color:#d1f1f1;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="border: 1px solid #2494A0;border-radius: 10px;width: 300px;margin: 0 auto;box-shadow: 0px 0px 10px 0px;">
        <div style="width:210px;margin:0 auto;text-align:center;">
            <asp:TextBox ID="uname" runat="server" class="input form-control"></asp:TextBox>
            <asp:TextBox ID="upwd" runat="server" class="input form-control"></asp:TextBox>
            <asp:TextBox ID="uemail" runat="server" class="input form-control"></asp:TextBox>
            <asp:TextBox ID="uphone" runat="server" class="input form-control"></asp:TextBox>
            <asp:TextBox ID="uaddr" runat="server" class="input form-control"></asp:TextBox>
            <asp:Button ID="modi" runat="server" Text="确认修改" onclick="modi_Click" CssClass="btn btn-default" Style="background-color:#def0f1;"/>
        </div>
    </div>
</asp:Content>
