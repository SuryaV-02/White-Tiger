    <%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Web_forms.WebForm1" UnobtrusiveValidationMode="none" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>   
            <asp:Label runat="server" Text="Enter number 1 : " ><asp:TextBox runat="server" ID="TbNum1" /></asp:Label> 
        </div>
        <div>
            <asp:Label runat="server" Text="Enter number 1 : " ><asp:TextBox runat="server" ID="TbNum2" /></asp:Label> 
        </div>
        <div>
            <asp:CustomValidator runat="server" ControlToValidate="TbNum2" ErrorMessage ="Please enter a good single digit number (0-9)" OnServerValidate="ValidateGoodNumber" />
        </div>
        <asp:Button runat="server" Text="Compute Addition" ID="BtnAdd" OnClick="BtnAdd_Click" />
        <asp:Label runat="server" ID="LabRes" />
    </form>
</body>
</html>
