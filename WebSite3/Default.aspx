<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {}
        .style2
        {}
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
<asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
<asp:Button ID="Button1" runat="server" Text="Button" onclick="Button1_Click" /><br />
<asp:Button ID="Button2" runat="server" Text="Button" onclick="Button2_Click" />

<asp:DropDownList ID="DropDownList1"
runat="server">
            <asp:ListItem Value="0">Sunday</asp:ListItem>
            <asp:ListItem Value="1">Monday</asp:ListItem>
            <asp:ListItem Value="2">Tuesday</asp:ListItem>
            <asp:ListItem Value="3">Wednesday</asp:ListItem>
            <asp:ListItem Value="4">Thursday</asp:ListItem>
            <asp:ListItem Value="5">Friday</asp:ListItem>
            <asp:ListItem Value="6">Saturday</asp:ListItem>
</asp:DropDownList>
    <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
        <br />
        <asp:ListBox ID="ListBox1" runat="server" CssClass="style1" Height="93px" 
            Width="189px"></asp:ListBox>
        <asp:Button ID="Button3" runat="server" CssClass="style2" 
            onclick="Button3_Click" Text="Button" Width="88px" />
&nbsp;
        <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
        <br />
        <asp:CheckBox ID="CheckBox1" runat="server" 
            oncheckedchanged="CheckBox1_CheckedChanged" Text="Select Me" />
        <asp:Label ID="Label4" runat="server"></asp:Label><br />
        <asp:RadioButton ID="RadioButton1" runat="server" GroupName="language" 
            Text="ASP.NET" />
        <asp:RadioButton ID="RadioButton2" runat="server" GroupName="language" 
            Text="VB.NET" />
        <asp:RadioButton ID="RadioButton3" runat="server" GroupName="language" 
            Text="C#" /><br />
        <asp:Label ID="Label5" runat="server" Text=""></asp:Label>
        <br />
<asp:Button ID="Button4" runat="server" Text="Button" onclick="Button4_Click" /><br />

<asp:LinkButton ID="LinkButton1" runat="server" onclick="LinkButton1_Click">Link</asp:LinkButton><br />
<asp:Label ID="Label6" runat="server" Text="Label"></asp:Label>
        <br />
        <asp:Image ID="Image1" runat="server" Height="100px" Width="100px" />
    </div>
    </form>
</body>
</html>
