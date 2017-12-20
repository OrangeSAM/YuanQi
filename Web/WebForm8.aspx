<%@ Page Title="" Language="C#" MasterPageFile="~/Nav.Master" AutoEventWireup="true" CodeBehind="WebForm8.aspx.cs" Inherits="Web.WebForm8" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="scripts/jquery-1.10.2.min.js"></script>
    <script src="scripts/bootstrap.min.js"></script>
    <link href="css/bootstrap.min.css" rel="stylesheet" />
    <style>
        .nav-comt li{
            float:left;
        }
        .nav-comt{
            display:flex;
            justify-content:space-around;
        }
         li a {
            text-decoration:none;
            color:black;
        }
        a:hover{
            color:#337ab7;
            text-decoration:none;
        }
        #thediv{
             background-color:#f2f2f5;
             height:800px;
        }
        .bgc{
            background-color:#ffffff;
            border-bottom:thin;
            border-bottom-color:#d9d9d9;
        }
        .btn-float{
            float:right;
            margin-top:3px;
        }
        #contentid{
            width:55%;
            margin-top:5px;
            margin-left:80px;
        }
        .reply-txtbox{
            background-color:#ffffff;
        }

    </style>
 <%--   <script type="text/javascript">
        function Show_Hidden(obj) {
            if (obj.style.display == "block") {
                obj.style.display = 'none';
            }
            else {
                obj.style.display = 'block';
            }
        }
        window.onload = function () {
            var olink = document.getElementById("link");
            var odiv = document.getElementById("thediv");
            olink.onclick = function () {
                Show_Hidden(odiv);
                return false;
            }
        }

    </script>--%>
        <script  type="text/JavaScript">
//function showdiv(targetid,objN){
   
//    var target=document.getElementById(targetid);
//    var clicktext=document.getElementById(objN)

//    if (target.style.display=="block"){
//        target.style.display="none";
//        clicktext.innerText="点击查看详细信息";
  

//    } else {
//        target.style.display="block";
//        clicktext.innerText='关闭详细信息信息';
//    }
   
//}
            
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <%--<div class="row">--%>
        <div class="col-lg-1 col-lg-offset-2"></div>
       <asp:ListView ID="LVDiscussion" runat="server">
           <LayoutTemplate>
               <div>
               <asp:PlaceHolder ID="itemPlaceHolder" runat="server" /></div>
           </LayoutTemplate>
    <ItemTemplate>
       <div class="center" style="margin-left:22%;width:55%;">
            <div class="bgc">               
                <div class="media-left">
                   <a href="#">
                       <img class="media-object" src="..." />
                   </a>
            </div>
            <div class="media-body">
                <h4 class="media-heading"><%#Eval("dis_title") %></h4>
                <h5><%#Eval("pub_time") %></h5>
                <p><%#Eval("dis_cont") %></p>
                </div>
              <ul class="nav-comt">
                <%--<li><a id="showtext" onclick="showdiv('contentid','showtext')">评论</a></li>     --%>  
                  <li><a href="WebForm8.aspx"?id="<%#Eval("discussion_id") %>">评论</a></li>             
                <li><a href="#">点赞</a></li>
                <li><a href="#">收藏</a></li>
             </ul>
            </div>
            </div>
      
                </ItemTemplate>
           </asp:ListView>
            <div id="contentid" >
             <asp:UpdatePanel ID="updatecomment" runat="server">
                 <ContentTemplate>
                <div class="nav-width">
                    <asp:TextBox ID="txtComments" runat="server" CssClass="form-control"></asp:TextBox>
                    <asp:Button ID="btnComments" runat="server" Text="评论" CssClass="btn btn-primary btn-float" OnClick="btnComments_Click1"/>
                </div>
                     </ContentTemplate>
                 </asp:UpdatePanel>
                <hr />
            <asp:UpdatePanel ID="updatereply" runat="server">
               <ContentTemplate>
                <asp:ListView ID="LVDisReply" runat="server" OnItemDataBound="LVReply_ItemDataBound">
                    <LayoutTemplate>
                        <asp:PlaceHolder ID="itemPlaceHolder" runat="server" />
                    </LayoutTemplate>
                    <ItemTemplate>
                       <div class="media bgc">
                           <div class="media-left">
                                <a href="#">
                                   <img class="media-object" src="<%#Eval("user_photo") %>" />
                                </a>
                           </div>
                             <div class="media-body">
                                <h4 class="media-heading"><%#Eval("user_name") %></h4>:<%#Eval("comt_cont") %><div class="row">
                                     <div class="col-lg-8 col-lg-offset-1">
                                        <h5><%#Eval("comt_time") %></h5></div>
                                     <div class="col-lg-3">
                                        <asp:LinkButton ID="lbtnReply" runat="server" OnClick="btnreply_Click">回复</asp:LinkButton></div>                                        
                                     </div>                                
                             </div>
                       </div>
                        <asp:Panel ID="panelreply" runat="server" Visible="false">
                             <div class="reply_textbox">
                                 <asp:HiddenField ID="HiddenFieldComID" runat="server" Value='<%#Eval("discomt_id") %>' Visible="false" />
                                 <asp:TextBox ID="txtreply" CssClass="form-control " TextMode="MultiLine" runat="server"></asp:TextBox>
                                 <asp:Button ID="btnreply" runat="server" Text="发表" OnClick="btnreply_Click" CssClass="btn btn-primary btn-float"  />
                             </div>
                             <div>
                                 <%--验证控件--%>
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
                    </ItemTemplate>
                 </asp:ListView>
             </ContentTemplate>
    </asp:UpdatePanel>
            </div>

          
        </div>
        
        <div class="col-lg-1"></div>
    </div>
</asp:Content>
