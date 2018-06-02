<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
<asp:DataList ID="DataList1" runat="server" oneditcommand="DataList1_EditCommand" 
        oncancelcommand="DataList1_CancelCommand" 
        onupdatecommand="DataList1_UpdateCommand">
    <ItemTemplate>
<%# Eval("eno") %><br />
<%# Eval("ename") %><br />
<%# Eval("eadd") %><br />
<%# Eval("esal") %><br />
<asp:LinkButton ID="LinkButton1" runat="server" CommandName="edit" Text="edit" /></ItemTemplate>
<EditItemTemplate>
<asp:TextBox ID="TextBox1" Text='<%#Eval("eno") %>' runat="server"></asp:TextBox><br />
<asp:TextBox ID="TextBox2" Text='<%#Eval("ename") %>' runat="server"></asp:TextBox><br />
<asp:TextBox ID="TextBox3" Text='<%#Eval("eadd") %>' runat="server"></asp:TextBox><br />
<asp:TextBox ID="TextBox4" Text='<%#Eval("esal") %>' runat="server"></asp:TextBox><br />
<asp:LinkButton ID="LinkButton1" runat="server" CommandName="cancel" Text="cancel" />
<asp:LinkButton ID="LinkButton2" runat="server" CommandName="update" Text="update" />
</EditItemTemplate>
</asp:DataList>
    </form>
</body>
</html>
