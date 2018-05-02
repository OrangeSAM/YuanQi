<%@ Page Title="" Language="C#" MasterPageFile="~/Nav.Master" AutoEventWireup="true" CodeBehind="usercenter.aspx.cs" Inherits="Web.usercenter" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
       .col-md-9 li{
           float:left;
           font-size:120%;
           font-weight:200;
           font-family:'Times New Roman', Times, serif;
       }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="margin:0 auto;width:1100px;min-height:575px;margin-top:40px;padding-bottom:18px;padding-top:35px;border-radius:10px;box-shadow:0px 0px 10px 0px;margin-bottom:40px;">
        <div class="col-md-3" style="text-align:center;">
            <asp:Image ID="headpor" runat="server" style="width:120px;height:150px;border-radius:3px;border:2px solid rgb(51,91,113);padding:3px;"/><br /><br />
            <asp:Label ID="user_name" runat="server" Text="Label"></asp:Label><br />
            <a href="usermodi.aspx" target="_blank">修改资料</a>
        </div> 
        <div class="col-md-9" style="display:flex;justify-content:space-around;">
            <ul id="myTab" class="nav nav-tabs" style="list-style:none;">
                <li class="active">
                    <a href="#trrecord" data-toggle="tab">租用的单车</a> 
                </li>
                <li>
                    <a href="#album_col" data-toggle="tab">收藏的相册</a>
                </li>
                <li>
                    <a href="#mall" data-toggle="tab">发表的游记</a>
                </li>
                <li>
                    <a href="#activity" data-toggle="tab">发布的活动</a>  
                </li>
                <li>
                    <a href="#estalbum" data-toggle="tab">创建的相册</a>
                </li>
                <li>
                    <a href="#recordcol" data-toggle="tab">收藏的游记</a> 
                </li>
            </ul>
        </div> 
        <div id="myTabContent" class="tab-content">
                <div class="tab-pane fade in active" id="trrecord">
                    <asp:ListView ID="indents" runat="server">
                        <LayoutTemplate>
                            <ul>
                                <asp:PlaceHolder runat="server" ID="itemplaceholder"></asp:PlaceHolder>
                            </ul>
                        </LayoutTemplate>
                        <ItemTemplate>
                            <li runat="server" id="st" >
                                <%#Eval("start_time") %>
                            </li>
                            <li runat="server" id="et">
                                <%#Eval("end_time") %>
                            </li>
                        </ItemTemplate>
                    </asp:ListView>
                </div>
                <div class="tab-pane fade" id="album_col">
                    <asp:ListView ID="albums" runat="server">
                        <LayoutTemplate>
                            <div>
                                <asp:PlaceHolder runat="server" ID="itemplaceholder"></asp:PlaceHolder>
                            </div>
                        </LayoutTemplate>
                        <ItemTemplate>
                            <asp:Image ID="Image2" runat="server" ImageUrl='<%#Eval("photo") %>' style="width:20%;margin-left:59px;margin-top:12px;border:3px solid #ccc;border-radius:3px;box-shadow:0px 0px 10px 0px;"/>
                            <asp:Label ID="Label2" runat="server" Text="" Style="margin-left:10px;"><%#Eval("album_name") %></asp:Label>
                        </ItemTemplate>
                    </asp:ListView>
                </div>
                <div class="tab-pane fade" id="mall">
                    <asp:ListView ID="trrecords" runat="server">
                        <LayoutTemplate>
                            <div>
                                <asp:PlaceHolder runat="server" ID="itemplaceholder"></asp:PlaceHolder>
                            </div>
                        </LayoutTemplate>
                        <ItemTemplate>
                            <asp:Image ID="Image1" runat="server" ImageUrl='<%#Eval("record_cover") %>' Style="width:17%;margin-left:58px;margin-top:20px;border:3px solid #ccc;border-radius:3px;box-shadow:0px 0px 10px 0px;"/><br />
                            <asp:Label ID="Label1" runat="server" Text='<%#Eval("record_title") %>' Style="margin-left:95px;"></asp:Label>
                        </ItemTemplate>
                    </asp:ListView>
                </div>
                <div class="tab-pane fade" id="activity">
                    <asp:ListView ID="actives" runat="server">
                        <LayoutTemplate>
                            <ul>
                                <asp:PlaceHolder runat="server" ID="itemplaceholder"></asp:PlaceHolder>
                            </ul>
                        </LayoutTemplate>
                        <ItemTemplate>
                            <li runat="server" id="act_name" style="text-align:center;"><%#Eval("act_name") %></li>
                        </ItemTemplate>
                    </asp:ListView>
                </div>
                <div class="tab-pane fade" id="estalbum">
                    <asp:ListView ID="esalbums" runat="server">
                        <LayoutTemplate>
                            <div>
                                <asp:PlaceHolder ID="itemplaceholder" runat="server"></asp:PlaceHolder>
                            </div>
                        </LayoutTemplate>
                        <ItemTemplate>
                            <asp:Image ID="cover" runat="server" ImageUrl='<%#Eval("photo") %>' style="width:20%;margin-left:59px;margin-top:12px;border:3px solid #ccc;border-radius:3px;box-shadow:0px 0px 10px 0px;"/>
                            <asp:Label ID="album_title" runat="server" Text='<%#Eval("album_name") %>' Style="margin-left:10px;"></asp:Label>
                        </ItemTemplate>
                    </asp:ListView>
                </div>
                <div class="tab-pane fade" id="recordcol">
                    <asp:ListView ID="record_col" runat="server">
                        <LayoutTemplate>
                            <div>
                                <asp:PlaceHolder runat="server" ID="itemplaceholder"></asp:PlaceHolder>
                            </div>
                        </LayoutTemplate>
                        <ItemTemplate>
                            <asp:Image ID="Image2" runat="server" ImageUrl='<%#Eval("record_cover") %>' Style="width:17%;margin-left:58px;margin-top:20px;border:3px solid #ccc;border-radius:3px;box-shadow:0px 0px 10px 0px;"/><br />
                            <asp:Label ID="Label2" runat="server" Text='<%#Eval("record_title") %>' Style="margin-left:95px;"></asp:Label>
                        </ItemTemplate>
                        </asp:ListView>
                </div>
            </div>
    </div>
    <script src="scripts/jquery-1.10.2.min.js"></script>
    <script src="scripts/bootstrap.min.js"></script>
</asp:Content>
