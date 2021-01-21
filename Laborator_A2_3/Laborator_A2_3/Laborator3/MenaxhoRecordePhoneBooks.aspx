<%@ Page Language="C#" AutoEventWireup="true" UnobtrusiveValidationMode="None" CodeBehind="MenaxhoRecordePhoneBooks.aspx.cs" Inherits="Laborator_A2_3.Laborator3.MenaxhoRecordePhoneBooks" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:Label runat="server" ID="lbl1"> Elementet</asp:Label>
            <br />
            <asp:DropDownList   runat="server" ID="ddl">

            </asp:DropDownList>
            <br />
            <asp:Panel runat="server" ID="pnlShto">
                <asp:Label runat="server" ID="Label1"> PhoneBookPersonName:</asp:Label>
                <asp:TextBox ID="txtpersonName" runat="server"> </asp:TextBox>
                <asp:RequiredFieldValidator ID="rqfld1" runat="server"
                    ControlToValidate="txtpersonName" ValidationGroup="shtoRecord" ErrorMessage="Plotesoni phonebookpersoname" Display="Dynamic" ForeColor="Red"></asp:RequiredFieldValidator>
                <br />
                 <asp:Label runat="server" ID="Label2"> PhoneNumber:</asp:Label>
                <asp:TextBox ID="txtphoneNumber" runat="server"> </asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"
                    ControlToValidate="txtphoneNumber" ValidationGroup="shtoRecord" ErrorMessage="Plotesoni PhoneNumber" Display="Dynamic" ForeColor="Red"></asp:RequiredFieldValidator>
          
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" 
                    runat="server" ErrorMessage="Ju lutem plotesoni nr ne formatin e duhur" Display="Dynamic" 
                     ControlToValidate="txtphoneNumber" ValidationGroup="shtoRecord" ValidationExpression="^[+]{1}[0-9]{10}$" ForeColor="Red">
                   
                </asp:RegularExpressionValidator>
                
                <%-- 
                    ^ --> thote qe shprehja e rregullt duhet te filloje me patjeter
                    [] --> percaktojne nje karakter te caktuar
                    {} --> percaktojn nr e hereve qe perseritet elementi ne kllapat katrore
                    [0-9] --> percaktojne nje bashkesi karakteresh , 0,1,2,3,4,5,6,7,8,9,
                    {10}--> nr i hereve qe perseritet elementi ne kllapa katrore
                    $ --> tregon perfundimin e shprehjes se rregullt
                    --%>
                
                
                <br />
                <asp:Label runat="server" ID="Label3"> PhoneType:</asp:Label>
                <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                    <asp:ListItem Value=""> Zgjidhni phonetype</asp:ListItem>
                    <asp:ListItem Value="1"> Celular</asp:ListItem>
                    <asp:ListItem Value="2"> Work</asp:ListItem>
                    <asp:ListItem Value="3"> Home</asp:ListItem>
                </asp:RadioButtonList>
                  <asp:RequiredFieldValidator ValidationGroup="shtoRecord" ID="RequiredFieldValidator2" runat="server"
                    ControlToValidate="RadioButtonList1" InitialValue="" ErrorMessage="Zgjidhni PhoneTypen" Display="Dynamic" ForeColor="Red"></asp:RequiredFieldValidator>
           <br />
                <asp:Button ID="btnShto" runat="server" Text="Shto record"  ValidationGroup="shtoRecord" OnClick="btnShto_Click" />


            </asp:Panel>
            <br />
            <br />

            <asp:Panel runat="server" ID="pnldelete">
                  <asp:Button ID="btnfshi" runat="server" Text="Fshi record"  OnClick="btnfshi_Click" />



            </asp:Panel> <br />

            <asp:Panel runat="server" ID="pnlTransferDatas">
                  <asp:Button ID="btnTransfero" runat="server" Text="Transfero te dhena"  OnClick="btnTransfero_Click" />



            </asp:Panel>

        </div>
    </form>
</body>
</html>
