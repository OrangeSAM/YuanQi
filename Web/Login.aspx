<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Web.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>登录</title>
    <link href="css/log.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div id="div1">
        <div id="div2">
            <img src="Img/logimg.png"/>
            <div>more than bike</div>
            <div id="imgdiv">登录远骑网</div>
        </div>
        <div id="div3">
            <asp:TextBox id="account" CssClass="inputstyle" placeholder="请输入账号" runat="server"></asp:TextBox><br />
            <asp:TextBox id="pwd" type="password" class="inputstyle" placeholder="请输入密码" runat="server"></asp:TextBox><br />
            <%--<asp:Button ID="button2" runat="server" Text="登录" OnClick="Button2_Click" />--%>
        </div> 
        <div id="div4">
            <hr />
            <p>如果您未注册远骑网ID，则可在此<a href="register.aspx">注册</a></p>
        </div>
    </div>
    </form>
</body>
</html>
