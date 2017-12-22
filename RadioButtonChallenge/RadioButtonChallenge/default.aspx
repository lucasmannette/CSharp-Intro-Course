<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="RadioButtonChallenge._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Radio Button Challenge<br />
        <br />
        <asp:RadioButton ID="pencilRadio" runat="server" GroupName="writingPref" Text="Pencil" />
        <br />
        <asp:RadioButton ID="penRadio" runat="server" GroupName="writingPref" Text="Pen" />
        <br />
        <asp:RadioButton ID="phoneRadio" runat="server" GroupName="writingPref" Text="Phone" />
        <br />
        <asp:RadioButton ID="tabletRadio" runat="server" GroupName="writingPref" Text="Tablet" />
        <br />
        <br />
        <asp:Button ID="okButton" runat="server" OnClick="okButton_Click" Text="Click Here" />
        <br />
        <br />
        <br />
        <asp:Image ID="resultImage" runat="server" />
        <br />
        <br />
        <asp:Label ID="resultLabel" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
