<%@ Page Title="" Language="C#" MasterPageFile="~/Nav.Master" AutoEventWireup="true" CodeBehind="Album.aspx.cs" Inherits="Web.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
    <link href="css/bootstrap.min.css" rel="stylesheet" />
    <link href="css/demo.css" rel="stylesheet" />
    <link href="css/font-awesome.min.css" rel="stylesheet" />
    <link href="css/Home.css" rel="stylesheet" />
    <link href="css/styles.css" rel="stylesheet" />
    
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <div class="divider col-sm-12 col-xs-12 col-md-12">
      <div class="header-text">Album<span>相册</span></div>
      
  </div>
    <asp:DataList ID="DataList1" runat="server"  RepeatColumns="3">
        <ItemTemplate>
   <section id="blog-isotope" class="subpage bg-white">
         <div class="overlay-light">
             <div  class="container" style="margin-right:-830px;margin-left:40px;">
                 <div class="posts">
                      <div class="post item col-md-4 col-xs-10col-sm-4 ">
                          <div class="panel">
                                  <div class="panel-header">
                                      <a href="Album_photos.aspx?id=<%#Eval("album_id") %>"><img src="<%#Eval("photo") %>" class="img-responsive"  alt="image"/></a>
                                      </div>
                              <div class="panel-body">
                                   <h3 class="post-title"><a href="#"><%#Eval("album_name") %></a></h3>
                                         
                                        <p><%#Eval("album_intro") %></p>
                                   <div class="pull-left"><a class="btn btn-black btn-xs" href="#"><span class="read-more">Read More</span></a></div>                       
                                  </div>
                                  <div class="panel-footer">
                                    <div class="pull-right">
                                        <a href="#"><i class="fa fa-heart"></i></a>
                                        <small>425</small>
                                    </div>
                                    <div class="clearfix"></div>
                                  </div>
                            </div>
                    </div>
                    
                      </div>
               
                 </div>
             </div>
         
        </section>
           
            </ItemTemplate>
        </asp:DataList>

      <!-- pager -->
                  <ul class="col-md-12 pager wow animated fadeIn">
                    <li class="previous"><a href="#">&larr; Older</a></li>
                    <li class="next"><a href="#">Newer &rarr;</a></li>
                  </ul><!-- /end pager -->
</asp:Content>
