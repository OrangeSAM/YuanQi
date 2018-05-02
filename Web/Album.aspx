<%@ Page Title="" Language="C#" MasterPageFile="~/Nav.Master" AutoEventWireup="true" CodeBehind="Album.aspx.cs" Inherits="Web.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
    <link href="css/bootstrap.min.css" rel="stylesheet" />
    <link href="css/demo.css" rel="stylesheet" />
    <link href="css/font-awesome.min.css" rel="stylesheet" />
    <link href="css/Home.css" rel="stylesheet" />
<%--    <link href="css/styles.css" rel="stylesheet" />--%>
    
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <div class="divider col-sm-12 col-xs-12 col-md-12">
      <div class="header-text"></div>      
  </div>
    <div style="height:900px;">
    <asp:ListView ID="LVAlbum1" runat="server">
        <LayoutTemplate>
            <div>
               <asp:PlaceHolder ID="itemPlaceHolder" runat="server" />
            </div>
        </LayoutTemplate>
        <ItemTemplate>
                 <div class="posts" style="width:80%;margin-left:150px;">
                      <div class="post item col-md-3 col-xs-10 col-sm-3 ">
                          <div class="panel">
                                  <div class="panel-header">
                                      <a href="Album_photos.aspx?id=<%#Eval("album_id") %>">
                                          <img src="<%#Eval("photo") %>" class="img-responsive"   alt="image" style="width:238px;height:158px;"/>
                                      </a>
                                      </div>
                              <div class="panel-body">
                                   <h3 class="post-title" style="height:27px;overflow:hidden;"><a href="#" ><%#Eval("album_name") %></a></h3>
                                        <p><%#Eval("album_intro") %></p>
                                   <div class="pull-left"><a class="btn btn-black btn-xs" href="Album_photos.aspx?id=<%#Eval("album_id") %>"><span class="read-more">Read More</span></a></div>                       
                                  </div>
                                  <div class="panel-footer">
                                    <div class="pull-right">
                                        <a href="#"><i class="fa fa-heart"></i></a>
                                        <small><%#Eval("col_num") %></small>
                                    </div>
                                    <div class="clearfix"></div>
                                  </div>
                            </div>
                    </div>
                      </div>
               
                <%-- </div>--%>
        <%--     </div>--%>
         
      <%--  </section>--%>           
            </ItemTemplate>  
        </asp:ListView>
    </div>
    <div class="pager">
                     <asp:DataPager ID="albumpager" runat="server"  PagedControlID="LVAlbum1"  PageSize="8" OnPreRender="albumpager_PreRender">
                         <Fields>   
                        <asp:NextPreviousPagerField FirstPageText="首页" PreviousPageText="上一页" ButtonType="Button" ShowFirstPageButton="true" ShowNextPageButton="false"  ButtonCssClass="btn btn-primary btn-sm"/>
                        <asp:NumericPagerField NextPreviousButtonCssClass="btn btn-primary btn-sm" NumericButtonCssClass="btn btn-primary btn-sm" ButtonCount="4" />
                        <asp:NextPreviousPagerField NextPageText="下一页" LastPageText="末页" ShowPreviousPageButton="false" ButtonType="Button" ButtonCssClass="btn btn-primary btn-sm" ShowLastPageButton="true" />
                    </Fields>                
                     </asp:DataPager>
        </div>
</asp:Content>
