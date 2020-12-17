<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Laborator_A2_3.Rivalda.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <asp:Label ID="Label1" runat="server" Text="Ngjyrat"></asp:Label>
            <br />


            <asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem Value="E kuqe"></asp:ListItem>
                <asp:ListItem Value="Jeshile"></asp:ListItem>
                <asp:ListItem Value="Blu"></asp:ListItem>
            </asp:DropDownList>
        </div>
    </form>
</body>
</html>
