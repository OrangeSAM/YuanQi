<%@ Page Title="" Language="C#" MasterPageFile="~/Nav.Master" AutoEventWireup="true" CodeBehind="pub_article.aspx.cs" Inherits="Web.pub_article" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script type="text/javascript" src="utf8-net/ueditor.config.js"></script>
    <script type="text/javascript" src="utf8-net/ueditor.all.js"></script>
    <script type="text/javascript" charset="utf-8" src="utf8-net/lang/zh-cn/zh-cn.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="width:85%;margin:0 auto;">
        <asp:TextBox ID="title" runat="server" CssClass="form-control" placeholder="请输入游记标题"></asp:TextBox>
        <asp:FileUpload ID="FileUpload1" runat="server" class="btn btn-default"/>
        <asp:Image ID="Image1" runat="server" />
        <asp:Button ID="Button1" runat="server" Text="上传封面" class="btn btn-primary" OnClick="Button1_Click"/>
            <div>内容：<br />
                <script id="myEditors" type="text/plain"></script>
                <textarea id="myEditor" name="myEditor" runat="server" onblur="setUeditor()" style="width: 1030px;
                    height: 250px;"></textarea>
                <%-- 上面这个style这里是实例化的时候给实例化的这个容器设置宽和高，不设置的话，或默认为auto可能会造成部分显示的情况--%>
                <script type="text/javascript">
                    var editor = new baidu.editor.ui.Editor();
                
                    editor.render("<%=myEditor.ClientID%>");
                </script>
                <asp:Button ID="pubbtn" runat="server" Text="发表游记" class="btn btn-primary" OnClick="pubbtn_Click"/>
            </div>
    </div>
        <script type="text/javascript">
        function setUeditor() {
            var myEditor = document.getElementById("myEditor");
            myEditor.value = editor.getContent();//把得到的值给textarea
        }
        </script>
</asp:Content>
