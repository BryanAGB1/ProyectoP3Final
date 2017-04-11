<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Capa_Vista.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Inicio_Sesion - Universidad de las Antillas</title>
    <link href="Estilos.css" rel="stylesheet" />
</head>
<body>
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


    <form class="form-horizontal">
        <div class="form-group">
            <label for="inputEmail3" class="col-sm-2 control-label">Email</label>
            <div class="col-sm-10">
                <input type="email" class="form-control" id="inputEmail3" placeholder="Email">
            </div>
        </div>
        <div class="form-group">
            <label for="inputPassword3" class="col-sm-2 control-label">Password</label>
            <div class="col-sm-10">
                <input type="password" class="form-control" id="inputPassword3" placeholder="Password">
            </div>
        </div>
        <div class="form-group">
            <div class="col-sm-offset-2 col-sm-10">
                <div class="checkbox">
                    <label>
                        <input type="checkbox">
                        Remember me
                    </label>
                </div>
            </div>
        </div>
        <div class="form-group">
            <div class="col-sm-offset-2 col-sm-10">
                <button type="submit" class="btn btn-default">Sign in</button>
            </div>
        </div>
    </form>
</body>
</html>
