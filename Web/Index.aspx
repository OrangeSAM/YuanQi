<%@ Page Title="" Language="C#" MasterPageFile="~/Nav.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Web.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <link href="css/bootstrap.min.css" rel="stylesheet" />
    <link href="css/demo.css" rel="stylesheet" />
    <link href="css/font-awesome.min.css" rel="stylesheet" />
    <link href="css/Home.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <%-- 每日一图     --%>      
      <div id="container">
        <div class="sections">
          <asp:Repeater ID="Repeater1" runat="server">
             <ItemTemplate>
                <div class="section" id="section0">
                   <img src="<%#Eval("path")%>" style="width:100%;height:100%" />                    
                </div>
            </ItemTemplate>
         </asp:Repeater>
        </div>
      </div>
    <div class="container header-start text-center">
        <div class="heading-icon">
          <i class="fa fa-3x fa-heart"></i>
        </div>
      <h1 class="main-text">Show your Love for the Humanity</h1>
      <p class="text-center sub-text"><em class="first-line">Lorem ipsum dolor sit amet, consectetur adipisiciSng elit, sed do eiusmod tempor </em><em class="next-line"> incididunt ut labore et dolore magna aliqua.A sed do eiusmod tempor incididunt ut labore et dolore magna.</em></p>
    </div>
<div id="center">
    <%--游记--%>
    <div class="divider col-sm-8 col-xs-8 col-md-8">
        <div class="header-text">游记 <span>News</span></div>
        </div>
        <div class="divider col-sm-4 col-xs-4 col-md-4">
        <div class="header-text">赛事 <span>Contest</span></div>
    </div>
    <div id="exTab2" class="col-md-8 col-lg-7 ">
        <ul class="nav nav-tabs">
            <li class="active">
              <a  href="#1" data-toggle="tab">最新</a>
            </li>
            <li><a href="#2" data-toggle="tab">最热</a>
            </li>            
        </ul>
        <div class="tab-content ">
          <div class="tab-pane active" id="1">
            <asp:ListView id="LVtravel" runat ="server"  ItemPlaceholderID ="itemPlaceholder"> 
               <LayoutTemplate>
                    <div>
                        <asp:PlaceHolder ID="itemPlaceholder" runat="server" />
                    </div>                
                    <asp:DataPager ID="DataPager1" runat="server" PageSize="3"></asp:DataPager>
               </LayoutTemplate> 
                <ItemTemplate >
                    <div class="blog-event"> 
                     <div class ="  featured-img" >
                        <asp:Image ID="CoverLabel" runat="server" Width="250px" Height="130px" ImageUrl='<%#Eval("record_cover") %>'  />
                    </div>
                    <div class=" featured-blog">                    
                       <h3><a href="#"><%#Eval("record_title") %></h3></a>                    
                        <asp:Label ID="ContLabel" runat="server" Text='<%# Eval("record_cont") %>' />
                         <button class="button-info">Read More</button>

                   </div>
                    </div>
                </ItemTemplate>
            </asp:ListView>
            </div>
             
        <div class="tab-pane" id="2">
            <asp:ListView ID="LVHotTravel" runat="server" ItemPlaceholderID ="itemPlaceholder">
                <LayoutTemplate>
                    <div>
                    <asp:PlaceHolder ID="itemPlaceholder" runat="server" />
                    </div>
                    <asp:DataPager ID="DataPager1" runat="server" PageSize="3"></asp:DataPager>
                </LayoutTemplate>
            </asp:ListView>
            <div class="blog-event">
                 <div class ="  featured-img" >
                        <asp:Image ID="CoverLabel" runat="server" Width="250px" Height="130px" ImageUrl='<%#Eval("record_cover") %>'  />
                    </div>
                    <div class=" featured-blog">                    
                       <h3><a  href="#"><%#Eval("record_title") %></a></h3>                    
                        <asp:Label ID="ContLabel" runat="server" Text='<%# Eval("record_cont") %>' />
                         <button class="button-info">Read More</button>                     
                   </div>
                    </div>
            </div>
                </div>
            </div>
   <%-- 资讯--%>
    <div id="sidebar" class="col-md-3 col-lg-3 col-lg-offset-1 col-md-offset-1">
        
         <div id="news"> 
          <div class="nav-title">
               <span >最新资讯</span>
              <a href="ContestNews.aspx"><span>More>></span></a>
              <br /><br />              
           </div>
           <hr />
           <div class="title">
               <asp:ListView ID="ListView1" runat="server" ItemPlaceholderID="itemPlaceHoder">
                   <LayoutTemplate>

                       <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
                       <table runat="server" id="itemPlaceHoder"></table>
                        <asp:DataPager ID="DataPager1" runat="server" PageSize="10">
                             </asp:DataPager>
                   </LayoutTemplate>
                   <ItemTemplate>
                       <a href="ContestNews.aspx?id=<%#Eval("news_id") %>"><%#Eval("news_title") %></a>
                       <br>
                       </br>
                   </ItemTemplate>
               </asp:ListView>
           </div>
       </div>
        <div id="contest"> 
          <div class="nav-title">
               <span >赛事预告</span>
              <a href="Contest.aspx"><span>More>></span></a>
              <br /><br />
         </div>
            <hr />
            <div class="title">
                <asp:ListView ID="LVContest" runat="server" ItemPlaceholderID="itemPlaceHoder">
                    <LayoutTemplate>
                         <asp:PlaceHolder ID="PlaceHolder2" runat="server"></asp:PlaceHolder>
                       <table runat="server" id="itemPlaceHoder"></table>
                        <asp:DataPager ID="DataPager1" runat="server" PageSize="10">
                             </asp:DataPager>
                    </LayoutTemplate>
                    <ItemTemplate>
                        <%--<%#Eval("con_time") %>--%>
                        
                       <div class ="contest_time" style ="float :left ;width :50%">
                          <asp:Label ID="ConTimeLabel" runat="server" Text='<%# Eval("con_time") %>' /><br />
                     </div>
                       <div class ="contest_title" style ="float :right ;width :50%">
                         <a href="#"><asp:Label ID="ConTitleLabel" runat="server" Text='<%# Eval("con_title") %>' /><br /></a>
                      </div>
                      <%-- <div class ="contest_place" style ="float :right ;width :30%">
                          <asp:Label ID="ConPlaceLabel" runat="server" Text='<%# Eval("con_place") %>' /><br />
                      --%>
                       <br /><br />                      
                    </ItemTemplate>
                    </asp:ListView>
            </div>
            </div>
</div>   
    </div>
    <%--相册--%>
 <div class="buttom">
        <div class="divider col-sm-8 col-xs-8 col-md-8">
          <div class="header-text"><span>相册</span> Album</div> 

        </div>
          <div class ="divider col-sm-4 col-xs-4 col-md-4" style ="font-size: 35px;"><div class="header-text"><a href ="Album.aspx">More>></a> </div> </div>

 </div>
       
     <asp:DataList ID="DataList1" runat="server" RepeatColumns="3"  RepeatDirection="Horizontal">
         <ItemTemplate>
     <section id="clients">
         <div class="inner team">
             <div class="team-members inner-details">
                 <div class="col-xs-12 member animated" data-animation="fadeInUp" data-animation-delay="0">
          <div class="member-inner">
              <a class="team-image">
                  <img src="<%#Eval("photo") %>" style="width:390px;height:280px"/></a>
                   <div class="member-details">
              <div class="member-details-inner">
                  <%#Eval("album_name") %>
            
              <div class="socials" >
                  <!-- Link -->
                  <a href ="Album_photos.aspx?id=<%#Eval("album_id") %>"><i class="fa fa-link"></i></a>
                </div><!-- End Socials -->
              </div> <!-- End Detail Inner -->
            </div><!-- End Details -->
          </div> <!-- End Member Inner -->
        </div><!-- End Member -->

</div>
             </div>
 </section>
             </ItemTemplate>
         </asp:DataList>
</div>


<script src="scripts/jquery-1.10.2.min.js"></script><script src="scripts/bootstrap.min.js"></script><script src="scripts/script.js"></script><script src="scripts/pageSwitch.min.js"></script><script src="scripts/jquery.pwstabs-1.2.1.js"></script><script src="scripts/jQuery-face-cursor.js"></script><script src="scripts/pgwslider.min.js"></script>

<script>                //轮播动画        $("#container").PageSwitch({
            direction: 'horizontal',
            easing: 'ease-in',
            duration: 1000,
            autoPlay: true,
            loop: 'false'
        });
        $(document).ready(function () {
            $(document).ready(function () {
                $('.pgwSlider').pgwSlider();
            });
        });</script>
    
</asp:Content>
