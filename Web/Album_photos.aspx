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
                     <div class="banner clearfix" style="margin-left:10%;margin-right:30px;">
                            <div class="slider" id="slider" style="box-shadow:0px 0px 10px 2px;border-radius:4px;">
                                <div class="slider-wrapper">
                                    <img src="<%#Eval("photo") %>"/> 
                                </div>
                        <div class="slider-title" >
                            <h2><%#Eval("album_name") %></h2>
                            <span></span>
                        </div>
                    </div>
          <div class="banner-info" style="float:left;">
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
  <div class="main-cont main-album" style="margin:10%;">
      <div class="main-cont__title" >
          <h3>相片详情</h3>
        </div>
     <asp:ListView ID="LVAlbumPhoto" runat="server" GroupItemCount="5">         
             <LayoutTemplate>
            <div>
               <asp:PlaceHolder ID="groupPlaceHolder" runat="server" />
            </div>
        </LayoutTemplate>
    <GroupTemplate>
         <asp:PlaceHolder ID="itemPlaceHolder" runat="server" />
</GroupTemplate>         
         <ItemTemplate>
           <ul class="main-cont__list clearfix" style="display:inline-block;">
          <li class="item">
            <img src="<%#Eval("photo") %>"  style ="width:250px;height:300px;margin-left :25px;"/>
            <div class="info" style ="margin-left :50px;margin-top :15px;font-size :18px;">
              <p>收藏数：<%#Eval("col_count") %> &nbsp;&nbsp;·&nbsp;&nbsp; 点赞数：<%#Eval("like_count") %></p>           
            </div>
          </li>
               </ul>
             </ItemTemplate>
      </asp:ListView>

       <div class="pager">
                     <asp:DataPager ID="albumpager" runat="server"  PagedControlID="LVAlbumPhoto"  PageSize="8" >
                         <Fields>   
                        <asp:NextPreviousPagerField FirstPageText="首页" PreviousPageText="上一页" ButtonType="Button" ShowFirstPageButton="true" ShowNextPageButton="false" ButtonCssClass="btn btn-primary btn-sm"/>
                        <asp:NumericPagerField NextPreviousButtonCssClass="btn btn-primary btn-sm" NumericButtonCssClass="btn btn-primary btn-sm" ButtonCount="4" />
                        <asp:NextPreviousPagerField NextPageText="下一页" LastPageText="末页" ShowPreviousPageButton="false" ButtonType="Button" ButtonCssClass="btn btn-primary btn-sm" ShowLastPageButton="true" />
                    </Fields>                         
                     </asp:DataPager>
        </div>

      </div>
    </div>
</div>
</asp:Content>
