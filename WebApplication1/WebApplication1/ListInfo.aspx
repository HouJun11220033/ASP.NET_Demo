<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListInfo.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:GridView ID="GridView_Stu" runat="server" Width="488px" AllowPaging="True" OnRowDeleting="GridView_Stu_RowDeleting">
            <Columns>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:CheckBox ID="checkbox1" runat="server" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="Sname" HeaderText="姓名" />
                <asp:BoundField DataField="Snum" HeaderText="学号" />
                <asp:BoundField DataField="Sage" HeaderText="年龄" />
                <asp:BoundField DataField="Ssex" HeaderText="性别" />
                <asp:CommandField HeaderText="Edit" ShowEditButton="true" />
                <asp:CommandField HeaderText="Delete" ShowDeleteButton="true" />
            </Columns>
        </asp:GridView>
        <asp:CheckBox ID="CheckBox2" runat="server" AutoPostBack="True" Font-Size="9pt" Text="全选"
            OnCheckedChanged="CheckBox2_CheckedChanged" />
    </div>
    <asp:Button ID="Button1" runat="server" Text="添加" OnClick="Button1_Click" />
    <asp:Button ID="Button2" runat="server" Text="批量删除" OnClick="Button2_Click" />
    </form>
</body>
</html>
