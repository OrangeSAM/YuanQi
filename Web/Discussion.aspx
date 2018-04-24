<%@ Page Title="" Language="C#" MasterPageFile="~/Nav.Master" AutoEventWireup="true" CodeBehind="Discussion.aspx.cs" Inherits="Web.WebForm16" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <script src="scripts/jquery-1.10.2.min.js"></script>
    <script src="scripts/bootstrap.min.js"></script>
    <link href="css/bootstrap.min.css" rel="stylesheet" />
    <script type="text/javascript" src="utf8-net/ueditor.config.js"></script>
    <script type="text/javascript" src="utf8-net/ueditor.all.js"></script>
    <script type="text/javascript" charset="utf-8" src="utf8-net/lang/zh-cn/zh-cn.js"></script>
    <style>
     
    .nav-back{
        background-color:white;
        margin-top:30px;
    }
    .nav-con{
        padding:5px;
        padding-left:20px;
    }
    .nav-content{
        padding-top:10px;
    }
    .nav-back-left{
        background:white;
        padding-left:18px;

    }
    .nav-back-left hr{
        margin-bottom:8px;
        margin-top:8px;
    }
    .nav-title{
        background:white;
        padding:2px 0px 2px 10px;
        margin-top:30px;
    }
    .nav-pub{
        margin-top:20px;
    }
    .nav-title-pub{
        background:#354b5e;color:white;
        padding:2px 0px 2px 10px;
        margin-top:30px;
    }

    </style>
     <script>
        function setShowLength(obj, maxlength, id) {
            var rem = maxlength - obj.value.length;
            var wid = id;
            if (rem < 0) {
                rem = 0;
            }
            document.getElementById(wid).innerHTML = "还可以输入" + rem + "字数";
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 

    <div class="container">
   <div class="jumbotron" style="background:#354b5e;color:white;" >
        <h1>骑行论坛</h1>
    </div>
    <div class="row">
        <div class="col-xs-9">
          <asp:ScriptManager ID="scriptmanager" runat="server"></asp:ScriptManager>
            <asp:UpdatePanel ID="updatediscussion" runat="server">
                <ContentTemplate>
                    <asp:Listview ID="LVDiscussion" runat="server">
                        <LayoutTemplate >
                            <div id="itemPlaceholderContainer" runat="server">
          <div id="itemPlaceholder" runat="server">
          </div></div> 
                        </LayoutTemplate>
                   <ItemTemplate>
                       <div class="nav-back">
                          <div class="nav-con">
                              <div class="media">
                                  <div class="media-left" style="padding-top:23px;">
                                   <a href="#">
                                    <img class="media-object img-circle" src='<%#Eval("user_photo") %>' alt="" style="width:70px;height:70px;">
                                  </a>
                                 </div>
                               <div class="media-body">
                                   <div class="nav-tile">
                                     <h3><%#Eval("dis_title") %></h3>
                                   </div>
                                   <hr />
                                  <div class="nav-writer">
                                    By <a href="#" class="text-info"><%#Eval("user_name") %></a> Posted <a href="#" class="text-info"><%#Eval("pub_time","{0:yyyy-MM-dd}") %></a>
                                    <a href="#" class="text-info"><i class="fa fa-comment"></i><%#Eval("comt_count") %> Comments</a>
                                  </div>
                               <div class="nav-content">
                                    <p><%#Eval("dis_cont") %></p>
                                </div>
                                <div class="nav-button">
                                    <a href="Discussion_detail.aspx?id=<%#Eval("discussion_id") %>"class="f-more f-primary-b">Read more</a>
                                </div>
                              </div>
                         </div>
                       </div>
                    </div>
                   </ItemTemplate>
               </asp:Listview>
                     <div class="pager">
      <asp:DataPager runat ="server" ID ="LVDispager" PageSize ="6" PagedControlID="LVDiscussion" OnPreRender="LVDispager_PreRender">
           <Fields>
           
                        <asp:NextPreviousPagerField FirstPageText="首页" PreviousPageText="上一页" ButtonType="Button" ShowFirstPageButton="true" ShowNextPageButton="false"  ButtonCssClass="btn btn-primary btn-sm"/>
                        <asp:NumericPagerField NextPreviousButtonCssClass="btn btn-primary btn-sm" NumericButtonCssClass="btn btn-primary btn-sm" ButtonCount="4" />
                        <asp:NextPreviousPagerField NextPageText="下一页" LastPageText="末页" ShowPreviousPageButton="false" ButtonType="Button" ButtonCssClass="btn btn-primary btn-sm" ShowLastPageButton="true" />
                   
          </Fields>
      </asp:DataPager>
            </div> 
                </ContentTemplate>
            </asp:UpdatePanel>

            <%--<div class="nav-title"><h2>帖子</h2></div>--%>
               
            <div class="nav-title-pub"><h2>发帖</h2></div>
            <div class="row nav-pub">
               <div class="col-md-1">
                   <p class="text-left">标题</p>
               </div>
                <div class="col-md-11">									
                       <asp:TextBox ID="title" runat="server" maxlength="15" onkeyup="javascript:setShowLength(this, 15, 'cost_tpl_title_length');" CssClass="form-control" placeholder="请输入游记标题"></asp:TextBox>
                    </div>
               <div class="col-md-3">
                    <span class="red" id="cost_tpl_title_length">还可以输入15字数</span>
				</div>
                </div>
            <div class="row">
                <div class="col-md-1">
                   <p class="text-left">内容</p>
               </div>
                <div class="col-md-11">									
                  <textarea id="myEditor" name="myEditor" runat="server" onblur="setUeditor()"></textarea>
                
                </div>
            </div>
            <div class="row col-md-offset-11 " style="margin-top:5px;">
                <asp:Button ID="Button1" runat="server" Text="发表" CssClass="btn btn-primary" OnClick="Button1_Click"/>
            </div>
            <hr/>


            
        </div>
        <div class="col-md-3">
         <div class="row">
            <div class="nav-title"><h2>发帖达人</h2></div>
            <div class="nav-back-left">
                <hr />
                <asp:Repeater ID="ReUsers" runat="server">
                    <ItemTemplate>
                        <div class="row">
                            <div class="col-md-3"><img src="<%#Eval("user_photo") %>" class="img-circle" style="width:41px;border-radius:50%;padding-top:10px" /></div>
                            <div class="col-md-9">
                                <div class="nav-name"><%#Eval("user_name") %></div><br />
                                <div class="nav-num"><span>发帖数：</span><%#Eval("pub_num") %></div>
                            </div>
                        </div>
                        <hr />
                    </ItemTemplate>
                </asp:Repeater>
               
            </div>
        </div>
       </div>
    </div>
</div>

    <%--富文本编辑器--%>
       <script id="myEditors" type="text/plain"></script>                
            <script type="text/javascript">
                var editor = new baidu.editor.ui.Editor();
                editor.options.toolbars = [['undo', 'Redo', 'bold', 'fontfamily', 'fontsize', 'justifyleft', 'justifyright', 'justifycenter', 'justifyjustify', 'emotion', 'spechars', 'simpleupload', 'test']];
                editor.render("<%=myEditor.ClientID%>");                                     
           </script>
        <script type="text/javascript">
                    function setUeditor() {
                        var myEditor = document.getElementById("myEditor");
                        myEditor.value = editor.getContent();//把得到的值给textarea
                    }
        </script>
</asp:Content>
