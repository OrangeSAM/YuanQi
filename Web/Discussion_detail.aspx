<%@ Page Title="" Language="C#" MasterPageFile="~/Nav.Master" AutoEventWireup="true" CodeBehind="Discussion_detail.aspx.cs" Inherits="Web.WebForm9" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
        <link href="css/bootstrap.min.css" rel="stylesheet" />
       <link href="css/comment.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <link href="css/contest.css" rel="stylesheet" />
     <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <asp:UpdatePanel ID ="updatejoin" runat ="server" >
         <ContentTemplate>
                <asp:ListView ID ="LVdis_de" runat ="server" >
                            <LayoutTemplate > 
                                <div id="itemPlaceholderContainer" runat="server">
                                        <div id="itemPlaceholder" runat="server">                                        </div>
                                 </div>
                            </LayoutTemplate>
                            <ItemTemplate >         
                                <article class="post">
	                                <header>
                                        <div class="title">
         	                                <h2 style="font-size:30px;"><a href="#"><%#Eval("dis_title") %></a></h2>
                                        </div>
      	                                <div class="meta">
                                            <time class="published" style="font-size:12px;"><%#Eval("pub_time") %></time>       		
      	                                </div>
	                                </header>
                                    <p style="font-size:20px;"><%#Eval("dis_cont") %></p>
                                </article>
                            </ItemTemplate>
                </asp:ListView>
            <%--评论--%>
                <asp:UpdatePanel ID="updatecomment" runat ="server" >
                            <ContentTemplate >
                                <div class="inner-com">
                                  <div class="col-xs-12 wow animated slideInRight" data-wow-delay=".5s">
                                      <asp:TextBox ID="txtComments" CssClass="form textarea" runat="server" TextMode="MultiLine" placeholder="说点什么吧..."></asp:TextBox>
                                      <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="评论不能为空" Display="Dynamic" ControlToValidate="txtComments"></asp:RequiredFieldValidator>--%>
                                  </div>
                                  <div class="relative fullwidth col-xs-12">
                                      <asp:Button ID="btnComments" CssClass="form-btn semibold" runat="server" Text="评论" OnClick="btnComments_Click" ValidationGroup="comments" />
                                  </div>
                                  <div class="clear"></div>
                                </div>
                            </ContentTemplate>
                  </asp:UpdatePanel>
         </ContentTemplate> 
    </asp:UpdatePanel>
<%--回复--%>
    <asp:UpdatePanel ID="updatereply" runat ="server" >
        <ContentTemplate >
            <asp:ListView ID="LVreply" runat ="server"  OnItemDataBound ="LVreply_ItemDataBound">
                <LayoutTemplate>
                    <asp:PlaceHolder ID="itemPlaceHolder" runat="server" />
                </LayoutTemplate>
                <ItemTemplate>
                    <div class="col-md-7 testimonial-blog">
                        <div id="wrapper">                             
                           <div class="testimonials-slider" style="margin-left:150px;">
                                 <div class="testimonials-carousel-thumbnail">
                                     <img src="<%#Eval("user_photo") %>" width="120"/>
                                 </div>
                                 <div "testimonials-carousel-context">
                                     <div class="testimonials-name"><%#Eval("user_name") %>&nbsp;&nbsp;<span><%# string.Format("{0:yyyy-MM-dd}", Eval("comt_time")) %></span></div>
                                      <div class="testimonials-carousel-content">
                                         <p><%#Eval("comt_cont") %></p>
                                     </div>
                                 </div>
                            </div>
                            <div class="reply_comment">
                            <asp:LinkButton ID="lbtnReply" runat="server"  OnClick="lbtnReply_Click">回复</asp:LinkButton>
                            </div>
                        </div>
                        <asp:Panel ID="panelreply" runat="server" Visible="false">
                            <div class="reply_textbox">
                                <asp:HiddenField ID="HiddenFieldComID" runat="server" Value='<%#Eval("discomt_id") %>' Visible="false" />
                                <asp:TextBox ID="txtreply" CssClass="form textarea" TextMode="MultiLine" runat="server"></asp:TextBox>
                                <asp:Button ID="btnreply" runat="server" Text="发表" OnClick="btnreply_Click" CssClass="form-btn semibold"  />
                            </div>
                        </asp:Panel>
                        <div class="repeter"  style="margin-top:10%;">
                             <asp:Repeater ID="Rereplycomment" runat="server">
                                 <ItemTemplate>
                                     <div class="reply">
                                         <div class="reply_contents">
                                         <a href="#"><%#Eval("回复人") %></a>回复<a href="#"><%#Eval("被回复人") %></a>：<%#Eval("reply_cont") %><%# string.Format("{0:yyyy-MM-dd}",Eval("reply_time")) %></div>
                                     </div>
                                 </ItemTemplate>
                             </asp:Repeater>
                        </div>
                    </div>
                </ItemTemplate>
            </asp:ListView>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>

