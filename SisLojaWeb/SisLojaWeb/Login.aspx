<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="SisLojaWeb.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    <link href="css/StylePage.css" rel="stylesheet" />

</head>
<body style="background-color:#1b1b1b;">



    <form id="form1" runat="server">
    <div class="BoxUsuario">
    
        Identifique-se
        
        <br />
        <br />
        <br />

        <asp:Label ID="Label1" runat="server" Text="Usuario"></asp:Label>
        <asp:TextBox ID="txtUsuario" runat="server" CssClass="TextBoxlogin"></asp:TextBox>

        <br>

        <asp:Label ID="Label2" runat="server" Text="Senha"></asp:Label>
        <asp:TextBox ID="txtSenha" runat="server" CssClass="textboxSenha TextBoxlogin" TextMode="Password"></asp:TextBox>
        <br />
        <asp:Button ID="btnlogin" runat="server" Text="Logar" CssClass="but" OnClick="btnlogin_Click" />
    </div>
    </form>
</body>
</html>
