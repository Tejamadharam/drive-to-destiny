<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="displaytable.aspx.cs" Inherits="aspconnection.displaytable" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView ID="GridView1" runat="server" Height="171px" Width="430px">
        </asp:GridView>
    
        <br />
        <br />
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ></asp:SqlDataSource>
    
    </div>
    </form>
</body>
</html>
