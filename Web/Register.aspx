<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Web.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="css/reg.css" rel="stylesheet" type="text/css"/> 
    <title>注册</title>
</head>
<body>
    <form id="form1" runat="server">
        <div id="div1">
            <div id="div2">注册YuanQi ID</div>
            <div id="div3">
                <asp:TextBox ID="phonenum" class="inputstyle" placeholder="请输入邮箱" runat="server"></asp:TextBox><br />
                <asp:TextBox ID="idcode" runat="server" placeholder="请输入验证码"></asp:TextBox>
                <asp:Button  ID="yanz" runat="server" Text="获取验证码" OnClick="yanz_Click" />
                <asp:TextBox ID="username" class="inputstyle" runat="server" placeholder="请输入用户名"></asp:TextBox><br />
                <asp:TextBox ID="pwd1" class="inputstyle" placeholder="请输入密码" runat="server"></asp:TextBox><br />
                <asp:TextBox ID="pwd2" class="inputstyle" placeholder="请再次输入密码" runat="server"></asp:TextBox><br />
                <p>我已阅读并同意遵守<a href="#">法律声明</a>和<a href="#">隐私条款</a></p>
                <%--<asp:Button ID="button2" runat="server" Text="注册" OnClick="Button2_click" />--%>
            </div>
            <div id="div4">
                <hr />
                <p>如果您已拥有Smartisan ID，则可在此<a href="#">登录</a></p>
            </div>
        </div>
    </form>
</body>
</html>
