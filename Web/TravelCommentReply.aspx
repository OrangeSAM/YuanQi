<%@ Page Title="" Language="C#" MasterPageFile="~/Nav.Master" AutoEventWireup="true" CodeBehind="TravelCommentReply.aspx.cs" Inherits="Web.WebForm7" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/bootstrap.min.css" rel="stylesheet" />
    <link href="css/demo.css" rel="stylesheet" />
    <link href="font-awesome-4.7.0/css/font-awesome.min.css" rel="stylesheet" />
    <link href="css/comment.css" rel="stylesheet" />
    <link href="css/Travel.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
<div class="nav-main" style="width:60%;margin-left:20%;">
    <asp:UpdatePanel ID="UpdateLike" runat="server">
            <ContentTemplate>
     <asp:ListView ID="LVTravel1" runat="server">
            <LayoutTemplate>
                <asp:PlaceHolder ID="itemPlaceHolder" runat="server" />
            </LayoutTemplate>
            <ItemTemplate>
                <article class="mini-post" >
                    <header>
                        <h2><%#Eval("record_title") %></h2>
                        <p><%#Eval("record_cont") %></p>
                        <%-- wdith:90%;text-indent:20px;padding-top:20px; --%>
                        <time class="published"><%#Eval("pub_time") %></time>
                        <a href="#" class="author" ><img src="<%#Eval("user_photo") %>" /></a>
                        <ul class="stats" style="    display: flex; justify-content: space-around;">
                            <li style="float:right;"><a href="#" class="fa fa-comment-o"><%#Eval("comt_count") %></a></li>                            
                            <li><asp:LinkButton ID="btnCol" runat="server" class="fa fa-star-o btnDL" style="text-decoration:none;" OnClick="btnCol_Click"></asp:LinkButton>
                            <span><%#Eval("col_count") %></span></li>
                            <li><asp:LinkButton ID="btnLike" runat="server" class="fa fa-heart-o btnDL" style="text-decoration:none;" OnClick="btnLike_Click"></asp:LinkButton>
                            <span><%#Eval("like_count") %></span></li>                             
                        </ul>
                    </header>
                    <a href="#"><img src="<%#Eval("record_cover") %>" class="image featured" style="height:600px;"/></a>
                </article>
            </ItemTemplate>
        </asp:ListView>
   </ContentTemplate>
        </asp:UpdatePanel>
    <%--评论--%>
   <asp:UpdatePanel ID="updatecomment" runat="server">
       <ContentTemplate>
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

    <%--回复--%>
    <asp:UpdatePanel ID="updatereply" runat="server">
        <ContentTemplate>
            <asp:ListView ID="LVReply" runat="server" OnItemDataBound="LVReply_ItemDataBound">
                <LayoutTemplate>
                    <asp:PlaceHolder ID="itemPlaceHolder" runat="server" />
                </LayoutTemplate>
                <ItemTemplate>
                    <%--<section class="testimonial">--%>
                <%--       <div class="col-md-7 testimonial-blog">
                            <div id="wrapper">                             
                    <div class="testimonials-slider" style="margin-left:150px;">--%>
                      <%--<div class="testimonials-carousel-thumbnail">
                         <img src="<%#Eval("user_photo") %>" width="120"/>
                     </div>--%>
                   <%--  <div "testimonials-carousel-context">
                         <span class="testimonials-carousel-thumbnail"><img src="<%#Eval("user_photo") %>" width="120" />
                         </span>
                         <div class="testimonials-name"><%#Eval("user_name") %>&nbsp;&nbsp;
                             <span><%# string.Format("{0:yyyy-MM-dd}", Eval("comt_time")) %>
                             </span>
                         </div>
                          <div class="testimonials-carousel-content">
                             <p><%#Eval("comt_cont") %></p>
                         </div>
                     </div>
                        </div>
                         <div class="reply_comment">
                         <asp:LinkButton ID="lbtnReply" runat="server"  OnClick="lbtnReply_Click">回复</asp:LinkButton>
                         </div>                    
                    </div>--%>
                    <div class="row" style="margin-left:20px;margin-top:-20px;">
                       <div class="media">
                         <div class="media-left">
                           <a href="#">
                           <img src="<%#Eval("user_photo") %>" width="90" />
                            </a>
                        </div>
                     <div class="media-body">
                        <h4 class="media-heading"><%#Eval("user_name") %></h4><span><%# string.Format("{0:yyyy-MM-dd}", Eval("comt_time")) %>
                            <div class="row">
                                <div class="col-md-8"><p><%#Eval("comt_cont") %></p></div>
                                <div class="col-md-4"><asp:LinkButton ID="lbtnReply" runat="server"  OnClick="lbtnReply_Click">回复</asp:LinkButton></div>
                            </div>
                           
                       </div>
                     </div>
                    </div>
                            <asp:Panel ID="panelreply" runat="server" Visible="false">
                             <div class="reply_textbox">
                                 <asp:HiddenField ID="HiddenFieldComID" runat="server" Value='<%#Eval("trcomt_id") %>' Visible="false" />
                                 <asp:TextBox ID="txtreply" CssClass="form textarea" TextMode="MultiLine" runat="server"></asp:TextBox>
                                 <asp:Button ID="btnreply" runat="server" Text="发表" OnClick="btnreply_Click" CssClass="form-btn semibold"  />
                             </div>
                             <div>
                                 <%--验证控件--%>
                             </div>
                         </asp:Panel>
                          
                   <div class="repeter"  style="margin-top:15%;">
                         <asp:Repeater ID="Rereplycomment" runat="server">
                             <ItemTemplate>
                                 <div class="reply">
                                     <div class="reply_contents">
                                         <div class="col-md-8">
                                 <a href="#"><%#Eval("回复人") %></a>回复<a href="#"><%#Eval("被回复人") %></a>：<%#Eval("reply_cont") %>
                                             </div>
                                         <div class="col-md-4"><%# string.Format("{0:yyyy-MM-dd}",Eval("reply_time")) %></div>

                                     </div>
                                </div>
                             </ItemTemplate>
                         </asp:Repeater>

                           </div>
                          
                  <%--  </section>--%>
                        

                </ItemTemplate>
            </asp:ListView>
        </ContentTemplate>
    </asp:UpdatePanel>
</div>
</asp:Content>
