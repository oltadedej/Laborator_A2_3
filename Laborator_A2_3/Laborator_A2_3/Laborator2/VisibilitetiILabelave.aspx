<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VisibilitetiILabelave.aspx.cs" Inherits="Laborator_A2_3.Laborator2.VisibilitetiILabelave" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Jam e dukshme" Visible="true"></asp:Label>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Jam e padukshme" Visible="false"></asp:Label>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Afisho ose Fsheh" OnClick="Afisho_Fsheh" />
        </div>
    </form>
</body>
</html>
