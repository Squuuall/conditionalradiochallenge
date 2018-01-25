<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="conditionalradiochallenge.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Your note taking preferences<br />
        <br />
        <asp:RadioButton ID="pencilRadio" runat="server" GroupName="noteGroup" Text="Pencil" />
        <br />
        <asp:RadioButton ID="penRadio" runat="server" GroupName="noteGroup" Text="Pen" />
        <br />
        <asp:RadioButton ID="phoneRadio" runat="server" GroupName="noteGroup" Text="Phone" />
        <br />
        <asp:RadioButton ID="tabletRadio" runat="server" GroupName="noteGroup" Text="Tablet" />
        <br />
        <br />
        <asp:Button ID="okButton" runat="server" OnClick="okButton_Click" Text="ok" />
        <br />
        <br />
        <asp:Image ID="showImage" runat="server" Height="100px" Width="100px" />
        <br />
        <br />
        <asp:Label ID="resultLabel" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
