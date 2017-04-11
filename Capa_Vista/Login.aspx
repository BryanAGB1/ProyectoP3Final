<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Capa_Vista.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Inicio_Sesion - Universidad de las Antillas</title>
    <link href="Estilos.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
     <header>
            <nav>
                <ul>

                    <li><a href="Inicio.aspx">Inicio</a></li>
                    
                    <li><a href="Matricula.aspx">Informacion</a></li>

                     <li><a href="#">Contactenos</a>
                        <ul>
                            <li><a href="#">Numero1</a></li>
                            <li><a href="#">info@UA.ac.cr</a></li>
                            
                        </ul>
                    </li>
                </ul>
            </nav>
    </header>

        <div class="login">


            <asp:Label ID="LbEmail" runat="server" Text="Email"></asp:Label>
            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>

            <asp:Label ID="LbContraseña" runat="server" Text="Contraseña"></asp:Label>
            <asp:TextBox ID="txtContraseña" runat="server"></asp:TextBox>

            <asp:Button ID="BtnLogin" runat="server" Text="Ingresar" />
        </div>
    </form>
</body>
</html>
