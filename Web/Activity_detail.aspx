<%@ Page Title="" Language="C#" MasterPageFile="~/Nav.Master" AutoEventWireup="true" CodeBehind="Activity_detail.aspx.cs" Inherits="Web.Activity_detail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="scripts/jquery-1.10.2.min.js"></script>
    <script src="scripts/bootstrap.min.js"></script>
    <link href="css/bootstrap.min.css" rel="stylesheet" />
    <link href="css/comment.css" rel="stylesheet" />
    <link href="css/contest.css" rel="stylesheet" />
    <style>
        a:hover{
            text-decoration:none;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <asp:UpdatePanel ID ="updatejoin" runat ="server" >
        <ContentTemplate>
            <asp:ListView ID ="LVact_de" runat ="server" >
                        <LayoutTemplate > 
                            <div id="itemPlaceholderContainer" runat="server">
                                    <div id="itemPlaceholder" runat="server"></div>
                            </div>
                        </LayoutTemplate>
                        <ItemTemplate >         
                            <article class="post" style="min-height:585px;">
	                            <header>
                                    <div class="title">
         	                            <h2 style="font-size:30px;"><a href="#"><%#Eval("act_name") %></a></h2>
                                    </div>
      	                            <div class="meta">
                                        <time class="published" style="font-size:12px;"><%#Eval("pub_time") %></time>       		
      	                            </div>
	                            </header>
                                <p style="font-size:20px;"><%#Eval("activity_cont") %></p>
                                <ul class="actions" style="padding:0;">
	                                <li><asp:linkbutton ID ="lbtnjoin" runat="server" class="button big" OnClick ="lbtnjoin_click">报名参与</asp:linkbutton></li>
                                </ul>
                                <asp:Panel ID="joinpanel" runat ="server" Visible ="false"  >
                                    <div class ="jointxtbox">
                                        <asp:HiddenField ID="HiddenFieldComID" runat="server" Value='<%#Eval("activity_id") %>' Visible="false" />
                                        <div class="joinname" style="text-align :center "> 用户名：<asp:TextBox ID="txtname" CssClass="form txtbox " runat="server"></asp:TextBox></div><br />
                                        <div class ="joinphone" style ="text-align :center "> 手机号：<asp:TextBox ID ="txtphone" CssClass ="form txtbox " runat ="server" ></asp:TextBox></div><br />
                                        <asp:Button ID="btnjoin" runat="server" Text="报名"  CssClass="form-btn"  OnClick ="Btnjoin_click" /> <br />
                                    </div>
                                </asp:Panel>
                                <button class="btn btn-primary" type="button" data-toggle="collapse" data-target="#collapseExample" aria-expanded="false" aria-controls="collapseExample" style ="height :50px;width :150px;margin-top:15px;">查看报名名单</button>
                            </article>
                        </ItemTemplate>
            </asp:ListView>
            <div class="collapse" id="collapseExample">
                  <div class="well" style="width:90%;margin:0 auto;">
                    <asp:ListView ID ="LVlist" runat ="server"  >
                        <LayoutTemplate >
                            <div id="itemPlaceholderContainer" runat="server">
                                 <div id="itemPlaceholder" runat="server"></div>
                            </div>
                        </LayoutTemplate>
                        <ItemTemplate >
                            <%#Eval ("user_name") %>
                        </ItemTemplate>
                    </asp:ListView>
                  </div>
            </div>
        </ContentTemplate> 
    </asp:UpdatePanel>
</asp:Content>
