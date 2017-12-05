<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login1.aspx.cs" Inherits="Web.login1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>远骑网</title>
    <script src="js/jquery-1.9.0.min.js"></script>
    <script src="js/login.js"></script>
    <link href="css/StyleSheet2.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <h1 style ="font-family :'Microsoft YaHei UI';font-size :55px;font-weight:bolder">远骑网</h1>

 <div class="login" style="margin-top:50px;">
    
    <div class="header">
        <div class="switch" id="switch"><a class="switch_btn_focus" id="switch_qlogin" href="javascript:void(0);" tabindex="7">快速登录</a>
			<a class="switch_btn" id="switch_login" href="javascript:void(0);" tabindex="8">快速注册</a>
            <div class="switch_bottom" id="switch_bottom" style="position: absolute; width: 64px; left: 0px;"></div>
        </div>
    </div>    
  
    
    <div class="web_qr_login" id="web_qr_login" style="display: block; height: 235px;">    

            <!--登录-->
            <div class="web_login" id="web_login">
                    <asp:ValidationSummary ID="ValidationSummary2" runat="server" ShowMessageBox="true"  ShowSummary ="false"  />
               
              
               <div class="login-box">
    
            <asp:Label ID="Label1" runat="server" Text="" CssClass ="lbl1"></asp:Label>
			<div class="login_form">
				<%--<form name="loginform" accept-charset="utf-8" id="login_form" class="loginForm" method="post"><input type="hidden" name="did" value="0"/>--%>
               <input type="hidden" name="to" value="log"/>
                <div class="uinArea" id="uinArea">                    
                <label class="input-tips" for="u">帐号：</label>
                <div class="inputOuter" id="uArea">

                    <asp:TextBox ID="u" runat="server" CssClass="inputstyle"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="用户名不能为空！" ControlToValidate="u" Display="Dynamic"  ValidationGroup ="submitGroup" ></asp:RequiredFieldValidator>
                    
                </div>
                </div>
                <div class="pwdArea" id="pwdArea">
               <label class="input-tips" for="p">密码：</label> 
               <div class="inputOuter" id="pArea">
                   <asp:TextBox ID="p" runat="server" CssClass="inputstyle" TextMode ="Password"></asp:TextBox>
                   <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="密码不能为空！" ControlToValidate ="p" Display ="Dynamic" ValidationGroup ="submitGroup"></asp:RequiredFieldValidator>
                </div>
                </div>
                    <asp:Button ID="submit" runat="server" Text="登 录" style="margin-top:1px;width:150px;text-align :center;margin-left :65px; " CssClass ="button_blue "  OnClick ="Submit_Click" ValidationGroup ="submitGroup"/>
                <br />
             
                 <label class="checkbox-inline">
                       <input type="checkbox" id="inlineCheckbox1" value="option1" runat="server" />记住我(7天)
                 </label>
               
              <%--</form>--%>
           </div>
           
            	</div>
               
            </div>
            
  </div>

  <!--注册-->
    <div class="qlogin" id="qlogin" style="display: none; ">
   
    <div class="web_login"><%--<form name="form2" id="regUser" accept-charset="utf-8" method="post">--%>
	      <input type="hidden" name="to" value="reg"/>
		      		       <input type="hidden" name="did" value="0"/>
        <ul class="reg_form" id="reg-ul">
            <asp:Label ID="lblrg" runat="server" Text="快速注册请注意格式" CssClass ="cue"></asp:Label>
                <li>
                    <asp:ValidationSummary ID="ValidationSummary1" runat="server" ShowMessageBox="true"  ShowSummary ="false"  />
                    <label for="user"  class="input-tips2">用户名：</label>
                    <div class="inputOuter2">
         
                    <asp:TextBox ID="user" runat="server" CssClass="inputstyle2"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="用户名不能为空！" ControlToValidate="user" Display="Dynamic"  ValidationGroup ="regGroup" ></asp:RequiredFieldValidator>
                    <asp:CustomValidator ID="CustomValidator1" runat="server" ErrorMessage="用户名不能超过16个字符" Display="None"  ControlToValidate="user" ValidationGroup ="regGroup"></asp:CustomValidator>
                    </div>
                    
                </li>
                
                <li>
                <label for="passwd" class="input-tips2">密码：</label>
                    <div class="inputOuter2">
                        
                        <asp:TextBox ID="passwd" runat="server" CssClass="inputstyle2 " TextMode ="Password"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="密码不能为空！" ControlToValidate ="passwd" Display="Dynamic"  ValidationGroup ="regGroup"></asp:RequiredFieldValidator>
                        <asp:CustomValidator ID="CustomValidator2" runat="server" ErrorMessage="密码不能超过16个字符" Display="Dynamic"  ControlToValidate="passwd" ValidationGroup ="regGroup"></asp:CustomValidator>

                    </div>
                    
                </li>
                <li>
                <label for="passwd2" class="input-tips2">确认密码：</label>
                    <div class="inputOuter2">
                        
                        <asp:TextBox ID="passwd2" runat="server" CssClass ="inputstyle2 " TextMode ="Password" ></asp:TextBox>
                         <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="重复密码不能为空！" ControlToValidate ="passwd2" Display ="Dynamic"  ValidationGroup ="regGroup"></asp:RequiredFieldValidator>
                        <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="密码不一致" ControlToCompare="passwd" ControlToValidate ="passwd2" Display ="Dynamic"  ValidationGroup ="regGroup"></asp:CompareValidator>

                    </div>
                    
                </li>
                
                <li>
                 <label for="email" class="input-tips2">Email：</label>
                    <div class="inputOuter2">
                       
                        <asp:TextBox ID="email" runat="server" CssClass ="inputstyle2" ></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="邮件不能为空！" ControlToValidate ="email" Display="Dynamic"  ValidationGroup ="regGroup"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="邮箱格式不正确" ControlToValidate ="email" Display ="Dynamic"  ValidationExpression ="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ValidationGroup ="regGroup"></asp:RegularExpressionValidator>

                    </div>
                   
                </li>
                
                <li>
                    <div class="inputArea">
                        <asp:Button ID="reg" runat="server" Text="同意协议并注册"  style="margin-top:10px;margin-left:85px;" CssClass ="button_blue " OnClick ="reg_Click" ValidationGroup="regGroup"/> <a href="#" class="zcxy" target="_blank">注册协议</a>
                        <br />
                      
                    </div>
                    
                </li>
            </ul><%--</form>--%>
           
    
    </div>
   
    
    </div>

    
    </div>
    </form>
</body>
</html>