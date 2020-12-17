<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DdlNgjyrat.aspx.cs" Inherits="Laborator_A2_3.Laborator2.DdlNgjyrat" %>

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

            <asp:DropDownList ID="ddlNgjyrat" runat="server">

                <asp:ListItem> E kuqe</asp:ListItem>
                <asp:ListItem> Jeshile</asp:ListItem>
                <asp:ListItem> Blu</asp:ListItem>
            </asp:DropDownList>
        </div>
    </form>
</body>
</html>
