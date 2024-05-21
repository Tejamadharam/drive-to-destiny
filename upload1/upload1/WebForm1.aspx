<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="upload1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 420px">
          <asp:GridView ID="GridView1" runat="server" 

        CaptionAlign="Top" HorizontalAlign="Justify" 

         DataKeyNames="id" onselectedindexchanged="GridView1_SelectedIndexChanged" 

        ToolTip="resume FIle DownLoad Tool" CellPadding="4" ForeColor="#333333" 

        GridLines="None">

        <RowStyle BackColor="#E3EAEB" />

        <Columns>

            <asp:CommandField ShowSelectButton="True" SelectText="Download" ControlStyle-ForeColor="Blue"/>

        </Columns>

        <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />

        <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />

        <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />

        <HeaderStyle BackColor="Gray" Font-Bold="True" ForeColor="White" />

        <EditRowStyle BackColor="#7C6F57" />

        <AlternatingRowStyle BackColor="White" />

    </asp:GridView> 
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="viewresume" />
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [resume]"></asp:SqlDataSource>
            <asp:Button ID="Button2" runat="server" Text="show" OnClick="Button2_Click" />
            <asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem Value=".net"></asp:ListItem>
                <asp:ListItem Value="c"></asp:ListItem>
                <asp:ListItem Value="c++"></asp:ListItem>
                <asp:ListItem></asp:ListItem>
            </asp:DropDownList>
    </div>
    </form>
</body>
</html>
