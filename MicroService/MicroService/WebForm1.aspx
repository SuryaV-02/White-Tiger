<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="MicroService.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div><asp:Label runat="server">Enter the Value of A</asp:Label><asp:TextBox runat="server" ID="txt1"></asp:TextBox></div>
            <div><asp:Label runat="server">Enter the value of B</asp:Label><asp:TextBox runat="server" ID="txt2"></asp:TextBox></div>
            <asp:Button runat="server" ID="submitbtn" OnClick="SubmitButton" Text="Submit"/>

            <div>
                <asp:Label>Result : </asp:Label><asp:Label runat="server" ID="result"></asp:Label>
            </div>

        </div>
    </form>
</body>
</html>
