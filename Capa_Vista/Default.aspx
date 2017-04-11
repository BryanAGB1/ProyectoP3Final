<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Capa_Vista.Inicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Inicio - Universidad de las Antillas</title>
    <link href="Estilos.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
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

                    <%--<li><a href"#"></a></li>--%>
                
                </ul>
            </nav>
    </header>
    </div>
    </form>
</body>
</html>
