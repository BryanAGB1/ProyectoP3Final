<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Capa_Vista.Inicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Inicio - Universidad de las Antillas</title>
    <link href="Estilos.css" rel="stylesheet" />
</head>
<body style="background-image:url(Imagenes/texturafondoazul.jpg) ; background-repeat: no-repeat; background-attachment: fixed;">
    <form id="form1" runat="server">
        <div>
            <header>
                <nav>
                    <ul>
                        <li>
                            <asp:Image ImageUrl="~/Imagenes/Udelasantillas.png" runat="server" class="Imagen" />
                        </li>
         
                        <li><a href="Default.aspx">Inicio</a></li>

                        <li><a href="Matricula.aspx">Matricula</a></li>

                        <li><a href="Login.aspx">Login</a></li>    
                    </ul>
                </nav>
            </header>
        </div>

        <div>
            <h1>Bienvenidos a la Universidad de las Antillas</h1>
        </div>
        <div>
            <img src="Imagenes/Udelasantillas.png" style="position:center;top: 500px; left: 0; width: 100%; height: 100% "/>
        </div>
    </form>
</body>
</html>
