<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Capa_Vista.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Inicio_Sesion - Universidad de las Antillas</title>
    <link href="Estilos.css" rel="stylesheet" />
    <style type="text/css">
        .auto-style1 {
            width: 294px;
        }
    </style>
</head>
<body style="background-image:url(Imagenes/texturafondoazul.jpg) ; background-repeat: no-repeat; background-attachment: fixed;" > 
    <form id="form1" runat="server">
    <div>
        <header>
            <nav>
                <ul>
                    <li>
                        <Img src="~/Imagenes/Udelasantillas.png" runat="server" class="Imagen" /></li>
                    
                    <li><a href="Default.aspx">Inicio</a></li>

                    <li><a href="Matricula.aspx">Matricula</a></li>

                    <li><a href="Login.aspx">Login</a></li>
                </ul>
            </nav>
        </header>
    </div>


  <table class="Login">

  <tr>

    <td>Cedula:</td>

    <td class="auto-style1"><asp:TextBox ID="txtCarnet" runat="server" Height="30px" Width="164px" ></asp:TextBox></td>


  </tr>

    <tr>
        <td>Constraseña:</td>
        <td class="auto-style1"><asp:TextBox ID="txtContraseña" runat="server" TextMode="Password" Height="29px" style="margin-left: 0px" Width="163px" ></asp:TextBox></td>
    </tr>  
</table>

        <div class="Boton">
            <asp:Button ID="BtnIngresar" runat="server" Text="Ingresar" OnClick="BtnIngresar_Click" Height="49px" Width="109px" />
        </div>
        <%--<asp:Button ID="BtnIngresar" runat="server" Text="Ingresar" OnClick="BtnIngresar_Click" />--%>
        </form>


   </body>
</html>
