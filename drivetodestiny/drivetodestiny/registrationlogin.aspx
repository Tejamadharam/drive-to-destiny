<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="registrationlogin.aspx.cs" Inherits="drivetodestiny.registrationlogin" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">

    <style type="text/css">
        .pad{
            padding-top: 50%;
        }
        .flip-container {
	perspective: 1000px;
}
	.flip-container:hover .flipper, .flip-container.hover .flipper {
		transform: rotateY(180deg);
	}

.flip-container, .front, .back {
	width: 320px;
	height: 480px;
}

.flipper {
	transition: 1.0s;
	transform-style: preserve-3d;

	position: relative;
}

.front, .back {
	backface-visibility: hidden;

	position: absolute;
	top: 0;
	left: 0;
}

.front {
	z-index: 2;
	transform: rotateY(0deg);
}

.back {
	transform: rotateY(180deg);
} 
body{
    background-size:cover;
    background-image:url("124690.jpg");
}
        .auto-style1 {
            width: 320px;
            height: 480px;
            backface-visibility: hidden;
            position: absolute;
            top: 2px;
            left: 0;
            z-index: 2;
            transform: rotateY(0deg);
        }
        .auto-style2 {
            margin-top: 14px;
        }
        .auto-style3 {
            height: 490px;
        }
        .auto-style4 {
            height: 490px;
            width: 350px;
        }
        .auto-style6 {
            width: 1511px;
        }
        .auto-style9 {
            width: 100%;
        }
        .auto-style10 {
            width: 1231px;
        }
    </style>
    
    <head id="Head1" runat="server">
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8"/>
        <link rel="stylesheet" href="css/c1.css"/>
        <title></title>
    </head>
    
    <body style="background-image:url(images1/12.jpg)" >

        <form id="Form1" runat="server" class="auto-style6" style="table-layout: auto; border-collapse: separate; border-spacing: inherit; empty-cells: hide; position: static">
           
               &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
               <table class="auto-style9">
                   <tr>
                       <td class="auto-style10" style="text-align: center; font-size: 62px; font-style: italic; color: #0000FF; font-weight: bolder;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; WELCOME TO SMART CAREERS</td>
                   </tr>
               </table>
           
               </form>
                    <font face="Castellar" color="black" size=6/>
        <table cellpadding="35" align="center" cellspacing="40" class="auto-style2" draggable="false">
                <tr>
                    <td class="auto-style4">
        <div class="flip-container" ontouchstart="this.classList.toggle('hover');">
	<div class="flipper">
            
		<div class="auto-style1">    
                    <img src="images1/15.jpg" height="350px" width="280px"/>
		</div>
		<div class="back">
            <form action="company registration.aspx">
                    <table class="pad">
                        <tr>
<td><font face="Century Gothic" color="#333" size="5"><b> REGISTRATION</b></font></td>

</tr>
<tr>
    <td> </td>
<td align="center">
    <button>Next</button>
</td>
</tr>
                        </table>
             </form>       
		</div>
        </div>
        </div>
                    </td>
                    
                    <td class="auto-style3">
                        <div class="flip-container" ontouchstart="this.classList.toggle('hover');">
	<div class="flipper">
                        <div class="front">    
                    <img src="images1/15.jpg" height="350px" width="280px">
		</div>
		<div class="back">
               <form action="login.aspx"> 
                        <table class="pad">
                                                <tr>
<td><font face="Century Gothic" color="#333" size="5"><b> LOGIN</b></font></td>

</tr>
<tr>
    <td> </td>
<td align="center">
    <button>Next</button>
</td>
</tr>
                            </table>
	</form>	</div>
        </div>
                        </div>
                    </td>
                
            </tr>
            </table>
        <div align="center">
         <asp:HyperLink ID="HyperLink1" runat="server" Font-Bold="true" Font-Size="X-Large" Text=" Home" NavigateUrl="~/homepage1.aspx" ForeColor="#CC3300"></asp:HyperLink>
    </div></body>
</html>
