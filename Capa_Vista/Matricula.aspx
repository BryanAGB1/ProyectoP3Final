<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Matricula.aspx.cs" Inherits="Capa_Vista.Informacion" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Matricula - Universidad de las Antillas</title>
    <link href="Estilos.css" rel="stylesheet" />
</head>
<body style="background-image:url(Imagenes/texturafondoazul.jpg) ; background-repeat: no-repeat; background-attachment: fixed;">
    <form id="form1" runat="server">
    <div>
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
        </div>
        <div class="TITULO"><h2>CURSOS PENDIENTES DE MATRICULA</h2></div>
        
    <div class="DVMatricula">
        <asp:GridView ID="GVMatricula" runat="server" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" ForeColor="Black" >
            <FooterStyle BackColor="#CCCCCC" />
            <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
            <RowStyle BackColor="White" />
            <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#808080" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#383838" />

        </asp:GridView>
    </div>
    </form>
        
    

</body>
</html>
