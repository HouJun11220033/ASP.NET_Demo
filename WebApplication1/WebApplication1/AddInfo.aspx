<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddInfo.aspx.cs" Inherits="WebApplication1.EditInfo" %>
<%--<%@ Register Assembl="FredCK.FCKeditorV2" namespace="FredCK.FCKeditorV2" TagPrefix="FCKeditorV2"%>--%>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
            <table width="900" id="tedit" runat="server">
          <tr>
            <td class="tdLeft">姓名</td>
            <td class="tdRight">
                <asp:TextBox ID="Sname" runat="server"></asp:TextBox>
            </td>
            <td class="tdLeft">年龄</td>
            <td class="tdRight">
                <asp:TextBox ID="Sage" runat="server"></asp:TextBox>
            </td>
          </tr>
          <tr>
            <td class="tdLeft">学号</td>
            <td class="tdRight">
                <asp:TextBox ID="Snum" runat="server"></asp:TextBox>
            </td>
            <td class="tdLeft">性别</td>
            <td class="tdRight">
                <asp:DropDownList ID="Ssex" runat="server">
                  <asp:ListItem Text="男" Value="0"></asp:ListItem>
                  <asp:ListItem Text="女" Value="1"></asp:ListItem>
                </asp:DropDownList>
            </td>
          </tr>
          <tr>
            <td class="tdLeft">附件上传</td>
            <td colspan="3" class="tdRight">
                <asp:FileUpload ID="FileUpload1" runat="server" />
            </td>
          </tr>
          <tr>
            <td class="tdLeft">备注</td>
            <td colspan="3" class="tdRight">
<%--                <FCKeditorV2:FCKeditor ID="FCKeditor1" runat="server" BasePath="fckeditor/" 
                    Width="100%" Height="900">
                </FCKeditorV2:FCKeditor>--%>
            </td>
          </tr>
          <tr>
            <td colspan="4" class="tdCenter">
        
                <asp:Button ID="Button1" runat="server" Text="确认添加" onclick="Button1_Click" />
        
                <asp:Button ID="Button2" runat="server" style="margin-left: 88px" 
                    Text="返回列表" onclick="Button2_Click" Width="111px" />
        
            </td>
          </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
