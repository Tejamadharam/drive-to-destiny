<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="admin.aspx.cs" Inherits="drivetodestiny.admin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <style type="text/css">
        .autostyle1 {
            width: 125%;
            height: 45px;
            margin-bottom: 0px;
        }
        body {
            background-position:center center;
            background-image:url(2.jpg);
            background-repeat:no-repeat;
            padding:0px 0px 0px 0px;
            margin:0px 0px 0px 0px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <br />
        <br />
        <asp:Panel ID="Panel1" runat="server">
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Font-Bold="true" Font-Size="Larger" Text="Display student details" BackColor="White" BorderColor="#CC3300" ForeColor="#0000CC" />
&nbsp;
            <asp:Label ID="Label1" runat="server" Font-Bold="true" Font-Size="Larger" ForeColor="White" Text="Contact No"></asp:Label>
            &nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            &nbsp;
            <asp:Button ID="Delete" runat="server" OnClick="Delete_Click" Font-Bold="true" Font-Size="Larger" Text="Delete" BackColor="White" BorderColor="#CC3300" ForeColor="#0000CC" />
            <br />
            <br />
            <asp:GridView ID="GridView1" runat="server" Font-Bold ForeColor="White" Caption="Student details" BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" CellPadding="4" Height="19px" Width="542px" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
                <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
                <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
                <RowStyle BackColor="White" ForeColor="#330099" />
                <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
                <SortedAscendingCellStyle BackColor="#FEFCEB" />
                <SortedAscendingHeaderStyle BackColor="#AF0101" />
                <SortedDescendingCellStyle BackColor="#F6F0C0" />
                <SortedDescendingHeaderStyle BackColor="#7E0000" />
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [studentregistration]"></asp:SqlDataSource>
            <br />
            <br />
            <br />
            <br />
            <br />
        </asp:Panel>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
