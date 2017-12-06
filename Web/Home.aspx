<%@ Page Title="" Language="C#" MasterPageFile="~/NAV.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Web.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
  
    
    <link href="css/Home.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div id="container1">
    <%--每日一图--%>
         <div id ="top">
         <div id="container">
        <div class="sections">
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <div class="section" id="section0">
                <img src="<%#Eval("path")%>" style="width:100%;height:100%;" />
                    
            </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>
              </div>
              <div id="news"> 
          <div class="nav-title" style ="background-color :crimson;height :50px;">
               <span >最新资讯</span>
              <a href="#"><span>More>></span></a>
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
                       <a href="#"><%#Eval("news_title") %></a>
                       <br>
                       </br>
                   </ItemTemplate>
               </asp:ListView>
           </div>
       </div>
   
            </div>
             

        <%--赛事新闻--%>
   
  <div id="center">        
        <%--游记--%>
        <div id="travel">
            <asp:ListView id="LVtravel" runat ="server"  ItemPlaceholderID ="itemPlaceholder"> 
               <LayoutTemplate>
                    <div>
                        <asp:PlaceHolder ID="itemPlaceholder" runat="server" />
                    </div> 
               
                    <asp:DataPager ID="DataPager1" runat="server" PageSize="3"></asp:DataPager>
               </LayoutTemplate> 
                <ItemTemplate >
                    <div class="travel_de">
 
                     <div class ="  travel_cover" >
                        <asp:Image ID="CoverLabel" runat="server" Width="250px" Height="130px" ImageUrl='<%#Eval("record_cover") %>'  />
                    </div>
                    <div class=" travel_content">
                    
                       <h3><a href="#"><b style="color:crimson;"><%#Eval("record_title") %></b></h3></a>
                    
                        <asp:Label ID="ContLabel" runat="server" Text='<%# Eval("record_cont") %>' />
                   </div>
                    </div>
                    
                </ItemTemplate>


            </asp:ListView>
             
        </div>
      <div id="center-right">
   

        <%--赛事预告--%>
       
        <div id="contest">
            <div class="nav-title" style ="background-color :crimson;height :50px;">
               <span >赛事预告</span>
              <a href="#"><span <%--style="float:right;margin-right:20px;"--%>>More>></span></a>
              <br /><br />
                </div>
            
            <asp:ListView ID="LVContest" runat="server" ItemPlaceholderID="itemPlaceHoder2">
                   <LayoutTemplate>

                       <asp:PlaceHolder ID="PlaceHolder2" runat="server"></asp:PlaceHolder>
                       <table runat="server" id="itemPlaceHoder2"></table>
                        <asp:DataPager ID="DataPager1" runat="server" PageSize="10">
                             </asp:DataPager>
                   </LayoutTemplate>
                   <ItemTemplate>
                       <div class="con" style ="margin-left :20px;margin-top :20px;">
                       <div class ="contest_time" style ="float :left ;width :30%">
                           <asp:Label ID="ConTimeLabel" runat="server" Text='<%# Eval("con_time") %>' /><br />
                       </div>
                       <div class ="contest_title" style ="float :left ;width :30%">
                           <asp:Label ID="ConTitleLabel" runat="server" Text='<%# Eval("con_title") %>' /><br />
                       </div>
                       <div class ="contest_place" style ="float :right ;width :30%">
                           <asp:Label ID="ConPlaceLabel" runat="server" Text='<%# Eval("con_place") %>' /><br />
                       </div>
                       <br />
                      </div>
                   </ItemTemplate>
               </asp:ListView>
                
        </div>
          </div>
        </div>
         <br />
    <%--相册--%>
    <div id="album">
        <asp:DataList ID="DataList1" runat="server" RepeatColumns="3"  RepeatDirection="Horizontal">
           <ItemTemplate >
        
               <div class ="album_left" >
                   <a href ="#"><img src="<%#Eval("photo")%>"  style="width:100px;height :80px;float :left " /></a><br />
               </div>
               <div class ="album_right"  >
            <%# Eval("album_intro") %> <br />
               </div>
               <br />
           </ItemTemplate>
       </asp:DataList>
    </div>
</div>


    <script src="scripts/jquery-1.10.2.min.js"></script><script src="scripts/bootstrap.min.js"></script><script src="scripts/script.js"></script><script src="scripts/pageSwitch.min.js"></script><script src="scripts/jquery.pwstabs-1.2.1.js"></script><script src="scripts/jQuery-face-cursor.js"></script><script src="scripts/pgwslider.min.js"></script>    <script>                //轮播动画        $("#container").PageSwitch({
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
