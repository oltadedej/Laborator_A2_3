<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ushtrimi7.aspx.cs" Inherits="Laborator_A2_3.Laborator2.Ushtrimi7" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lbl1" Text="Ngjyrat" runat="server"></asp:Label>
            <br />

            <asp:DropDownList ID="Ngjyrat" AutoPostBack="true" OnSelectedIndexChanged="Ngjyrat_SelectedIndexChanged" runat="server">
                <asp:ListItem> Selektoni</asp:ListItem>
                <asp:ListItem>e kuqe</asp:ListItem>
                <asp:ListItem>Jeshile</asp:ListItem>
                <asp:ListItem>Blue</asp:ListItem>
            </asp:DropDownList>

            <asp:Label ID="lblAfishimi" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
