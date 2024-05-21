<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="studentdetails.aspx.cs" Inherits="drivetodestiny.studentdetails" %>

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
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem Value=".NET"></asp:ListItem>
            <asp:ListItem Value="PYTHON"></asp:ListItem>
            <asp:ListItem Value="JAVA"></asp:ListItem>
            <asp:ListItem Value="C"></asp:ListItem>
            <asp:ListItem Value="C++"></asp:ListItem>
            <asp:ListItem>Oracle</asp:ListItem>
            <asp:ListItem>Blockchain</asp:ListItem>
            <asp:ListItem></asp:ListItem>
            <asp:ListItem></asp:ListItem>
            <asp:ListItem></asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [studentregistration]"></asp:SqlDataSource>
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" BackColor="Yellow" BorderColor="#CC3300" ForeColor="Red" Font-Bold="true" Font-Size="Larger" Font-Italic="true" Text="Registered details" OnClick="Button1_Click" />
        &nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="Button3" runat="server" BackColor="Yellow" BorderColor="#CC3300" ForeColor="Red" Font-Bold="true" Font-Italic="true" Font-Size="Larger" Text="View Resume" OnClick="Button3_Click" />
        &nbsp;
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" BackColor="Yellow" BorderColor="#CC3300" ForeColor="Red" Font-Bold="true" Font-Italic="true" Font-Size="Larger" Text="Cancel" OnClick="Button2_Click" />
        <br />
        <br />



          
        <br />
        <asp:GridView ID="GridView2" runat="server" Font-Bold="true" ForeColor="White" Caption="Student details" BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" CellPadding="4" Height="16px" Width="890px">
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
        <br />
        <br />
        <asp:GridView ID="GridView1" runat="server" Font-Bold="true" ForeColor="White" Caption="Resume details"  

        CaptionAlign="Top" HorizontalAlign="Justify" 

         DataKeyNames="id" onselectedindexchanged="GridView1_SelectedIndexChanged" 

        ToolTip="resume FIle DownLoad Tool" CellPadding="4" BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" Height="16px" Width="891px">

        <RowStyle BackColor="White" ForeColor="#330099" />

        <Columns>

            <asp:CommandField ShowSelectButton="True" SelectText="Download" ControlStyle-ForeColor="Blue">

<ControlStyle ForeColor="Blue"></ControlStyle>
            </asp:CommandField>

        </Columns>

        <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />

        <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />

        <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />

        <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />

            <SortedAscendingCellStyle BackColor="#FEFCEB" />
            <SortedAscendingHeaderStyle BackColor="#AF0101" />
            <SortedDescendingCellStyle BackColor="#F6F0C0" />
            <SortedDescendingHeaderStyle BackColor="#7E0000" />

    </asp:GridView>



          
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
