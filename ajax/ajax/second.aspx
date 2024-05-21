<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="second.aspx.cs" Inherits="ajax.second" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <br />
        <br />
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
            <asp:ListItem Value="green"></asp:ListItem>
            <asp:ListItem Value="red"></asp:ListItem>
            <asp:ListItem Value="orange"></asp:ListItem>
            <asp:ListItem Value="brown"></asp:ListItem>
            <asp:ListItem Value="yellow"></asp:ListItem>
            <asp:ListItem></asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <br />
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="NSIC"></asp:Label>
        <br />
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
