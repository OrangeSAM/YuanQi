<%@ Page Title="" Language="C#" MasterPageFile="~/Nav.Master" AutoEventWireup="true" CodeBehind="Discussion.aspx.cs" Inherits="Web.WebForm12" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/bootstrap.min.css" rel="stylesheet" />
    <link href="css/font-awesome.min.css" rel="stylesheet" />
    <link type="text/css" rel='stylesheet' href="js/fancybox/jquery.fancybox.css"/>
    <link href="css/main-default.css" rel="stylesheet" />
    <link type="text/css" rel='stylesheet' href="fonts/fonts.css"/>
    <link href='http://fonts.googleapis.com/css?family=Open+Sans:300italic,400italic,600italic,700italic,800italic,400,300,600,700,800&amp;subset=latin,cyrillic-ext' rel='stylesheet' type='text/css'/>
    <link href='http://fonts.googleapis.com/css?family=Merriweather:400,300,300italic,400italic,700,700italic,900,900italic' rel='stylesheet' type='text/css'/>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  <div class="container">    
      <div class="row">
          <asp:ListView ID="LVDiscussion" runat="server">
              <LayoutTemplate>
                  <asp:PlaceHolder ID="itemPlaceHolder" runat="server" />
              </LayoutTemplate>
              <ItemTemplate>
                   <div class="col-md-9 ">
                       <div class="b-blog-listing__block">
                        <div class="b-infoblock-with-icon b-blog-listing__infoblock">
                            <a href="#" class="b-infoblock-with-icon__icon f-infoblock-with-icon__icon fade-in-animate hidden-xs">
                                <i class="fa fa-pencil"></i>
                            </a>
                            <div class="b-infoblock-with-icon__info f-infoblock-with-icon__info">
                                <a href="#" class="f-infoblock-with-icon__info_title b-infoblock-with-icon__info_title f-primary-l b-title-b-hr f-title-b-hr">
                                    <%#Eval("dis_title") %>
                                </a>
                                <div class="f-infoblock-with-icon__info_text b-infoblock-with-icon__info_text f-primary-b b-blog-listing__pretitle">
                                    By <a href="#" class="f-more"><%#Eval("user_name") %></a> Posted <a href="#" class="f-more"><%#Eval("pub_time") %></a>
                                    <a href="#" class="f-more b-blog-listing__additional-text f-primary"><i class="fa fa-comment"></i><%#Eval("comt_count") %> Comments</a>
                                </div>
                                <div class="f-infoblock-with-icon__info_text b-infoblock-with-icon__info_text c-primary b-blog-listing__text">
                                    <%#Eval("dis_cont") %>
                                </div>
                                <div class="f-infoblock-with-icon__info_text b-infoblock-with-icon__info_text">
                                    <a href="#" class="f-more f-primary-b">Read more</a>
                                </div>
                            </div>
                        </div> 
                       </div>                         
                  </div>
             </ItemTemplate>
      </asp:ListView>
          <div class="col-md-3">
               <div class="row">
                     <div class="col-md-12">
                        <div class="b-form-row b-input-search">
                            <input class="form-control" type="text" placeholder="Enter your keywords"/>
                            <span class="b-btn b-btn-search f-btn-search fa fa-search fa-2x"></span>
                        </div>
                    </div>
               </div>
              <div class="row b-col-default-indent">
                  <div class="col-md-12">
                      <div class="b-categories-filter">
                          <h4 class="f-primary-b b-h4-special f-h4-special--gray f-h4-special">blog categories</h4>
                          <%--绑定最热--%>
                          <asp:Repeater ID="ReHotDiscussion" runat="server">
                              <ItemTemplate>
                        <ul>
                            <li>
                          <a class="f-categories-filter_name" href="#"><i class="fa fa-plus"></i> <%#Eval("dis_title") %></a>
                          <span class="b-categories-filter_count f-categories-filter_count"><%#Eval("comt_count") %> </span>
                                </li>
                        </ul>
                                  </ItemTemplate>
                         </asp:Repeater>
                      </div>
                  </div>
                  <div class="col-md-12">
                    <div class="b-categories-filter">
                        <h4 class="f-primary-b b-h4-special f-h4-special--gray f-h4-special">blog categories</h4>
                    </div>
                    <asp:Repeater ID="ReLikeDiscussion" runat="server">
                        <ItemTemplate>
                      <div class="b-blog-short-post--popular col-md-12  col-xs-12 f-primary-b">
                            <div class="b-blog-short-post__item_img">
                               <a href="#"><%#Eval("user_photo") %></a>
                            </div>
                            <div class="b-remaining">
                             <div class="b-blog-short-post__item_text f-blog-short-post__item_text">
                               <a href="#"><%#Eval("dis_title") %></a>
                             </div>
                            <div class="b-blog-short-post__item_date f-blog-short-post__item_date f-primary-it">
                             <%#Eval("pub_time") %>
                             </div>
                    </div>
                  </div>
                            </ItemTemplate>
                        </asp:Repeater>                      
                  </div> 
                   <div class="col-md-12">
        <h4 class="f-primary-b b-h4-special f-h4-special--gray f-h4-special">tags cloud</h4>
        <div>
    <a class="f-tag b-tag" href="#">Dress</a>
    <a class="f-tag b-tag" href="#">Mini</a>
    <a class="f-tag b-tag" href="#">Skate animal</a>
    <a class="f-tag b-tag" href="#">Lorem ipsum</a>
    <a class="f-tag b-tag" href="#">literature</a>
    <a class="f-tag b-tag" href="#">Baroque</a>
    <a class="f-tag b-tag" href="#">Dress</a>
    <a class="f-tag b-tag" href="#">Mini</a>
    <a class="f-tag b-tag" href="#">Skate animal</a>
    <a class="f-tag b-tag" href="#">Lorem ipsum</a>
    <a class="f-tag b-tag" href="#">literature</a>
    <a class="f-tag b-tag" href="#">Baroque</a>
</div>
    </div>

              </div>
          </div>
      </div>
  </div>

<%--<script>--%>
    <script src="scripts/jquery-1.10.2.min.js"></script>
    <script src="scripts/bootstrap.min.js"></script>
    <script src="scripts/discussion/color-themes.js"></script>
    <script src="js/fancybox/jquery.fancybox.pack.js"></script>
    <script src="js/fancybox/jquery.mousewheel.pack.js"></script>
    <script src="js/fancybox/jquery.fancybox.custom.js"></script>
</asp:Content>
