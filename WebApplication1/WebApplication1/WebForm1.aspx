<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
<%-- <form id="form1" runat="server">
    <div style="height: 31px">
    <asp:Label ID="lblmessage" runat="server"></asp:Label>
    <br />
    <br />
    <br />
    <asp:Button ID="btnclick" runat="server" Text="Click" OnClick="btnclick_Click" />
    </div>
    </form>--%>
    <form id="form1" runat="server">
    <div>Enter your name:</div>
    <asp:TextBox ID="TextBox1" runat="server" style="width: 148px"></asp:TextBox>
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit"/>
    <asp:Label ID="Label1" runat="server" />
    </form>
</body>
</html>
