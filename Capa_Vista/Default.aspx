<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Capa_Vista.Inicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Inicio - Universidad de las Antillas</title>
    <link href="/Estilos.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <header>
                <nav>
                    <ul>
                        <li><a href="Default.aspx">
                            <asp:Image ImageUrl="~/Imagenes/Udelasantillas.png" runat="server" class="Imagen" />
                        </a></li>

                        <li><a href="Default.aspx">Inicio</a></li>

                        <li><a href="Matricula.aspx">Informacion</a></li>

                        <li><a href="Login.aspx">Login</a></li>    
                    </ul>
                </nav>
            </header>
        </div>
    </form>
</body>
</html>
