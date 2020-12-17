<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ushtrimi8.aspx.cs" Inherits="Laborator_A2_3.Ushtrimi8" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:TextBox ID="TextBox1" runat="server" AutoPostBack="true"  OnTextChanged="AfishoniText"></asp:TextBox>

            <asp:Label runat="server" ID="lbl1" ></asp:Label>
        </div>
    </form>
</body>
</html>
