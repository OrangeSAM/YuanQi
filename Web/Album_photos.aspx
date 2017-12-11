<%@ Page Title="" Language="C#" MasterPageFile="~/Nav.Master" AutoEventWireup="true" CodeBehind="Album_photos.aspx.cs" Inherits="Web.WebForm5" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/photo.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="main">
         <div class="main-inner body-width">
            <%-- 相册信息--%>
             <asp:ListView ID="LVPhoto" runat="server">
                 <LayoutTemplate>
                     <div id="itemPlaceholderContainer" runat="server">
                            <div id="itemPlaceholder" runat="server">
                            </div>
                        </div>
                 </LayoutTemplate>
                 <ItemTemplate>
                     <div class="banner clearfix">
                            <div class="slider" id="slider">
                                <div class="slider-wrapper">
                                    <img src="<%#Eval("photo") %>"/> 
                                </div>
                        <div class="slider-title" >
                            <h2><%#Eval("album_name") %></h2>
                            <span></span>
                        </div>
                    </div>
          <div class="banner-info">
              <div class="news body-border">
                  <ul>
                     <li class="title">相册详情</li>
                     <li class="choose">                
                        介绍：<span ><%#Eval("album_intro") %></span>
                     </li>
                     <li class="assistant">
                        <p>相片数：<%#Eval("photo_amount ") %></p>
                     </li>
                 </ul>
             </div>
         </div>
      <div class="app body-border"><a href="#"></a></div>
      </div>
           </ItemTemplate>
      </asp:ListView>


             <%--相片--%>
  <div class="main-cont main-album">
      <div class="main-cont__title" style ="margin-left :20px;margin-bottom :25px;margin-top :25px;">
          <h3>相片详情</h3>
        </div>
      <asp:DataList ID="PhotoDetile" runat="server" RepeatColumns="5"  RepeatDirection="Horizontal">
         <ItemTemplate>
           <ul class="main-cont__list clearfix">
          <li class="item">
            <img src="<%#Eval("photo") %>"  style ="width:250px;height:300px;margin-left :25px;"/>
            <div class="info" style ="margin-left :50px;margin-top :15px;font-size :18px;">
              <p>收藏数：<%#Eval("col_count") %> &nbsp;&nbsp;·&nbsp;&nbsp; 点赞数：<%#Eval("like_count") %></p>
           
            </div>
          </li>
               </ul>
             </ItemTemplate>
      </asp:DataList>
      </div>
    </div>
</div>
</asp:Content>
