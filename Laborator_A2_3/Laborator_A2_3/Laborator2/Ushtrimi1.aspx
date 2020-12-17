<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ushtrimi1.aspx.cs" Inherits="Laborator_A2_3.Laborator2.Ushtrimi1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="label1" runat="server" Text="sonila allaraj"></asp:Label>
        <asp:TextBox ID="TextBox1" Text="20" TextMode="Number" runat="server"></asp:TextBox>
        <asp:TextBox ID="TextBox2" Text="2000-10-12" TextMode="Date" runat="server"></asp:TextBox>
        <asp:Panel ID="Panel1" runat="server">
            <asp:Image ID="Image1" ImageUrl="~/img/download.png" runat="server" />
        </asp:Panel>
        <asp:CheckBox ID="femer" Text="femer" runat="server" />
        <asp:CheckBox ID="mashkull" Text="mashkull" runat="server" />
    </form>
</body>
</html>
