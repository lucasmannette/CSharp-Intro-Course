<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="ChallengeEpicSpiesAssetTracker._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Image ID="Image1" runat="server" Height="150px" ImageUrl="epic-spies-logo.jpg" />
        <br />
        <h1>Asset Performance Tracker</h1>
        Asset Name:&nbsp;
        <asp:TextBox ID="assetNameTextBox" runat="server" Height="22px"></asp:TextBox>
&nbsp;<br /><br />
        Elections Rigged:&nbsp; <asp:TextBox ID="electionsRiggedTextBox" runat="server"></asp:TextBox>
&nbsp;<br /><br />
        Acts of Subterfuge Performed:&nbsp;
        <asp:TextBox ID="subterfugePerformedTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="addAssetButton" runat="server" OnClick="addAssetButton_Click" Text="Add Asset" />
        <br />
        <br />
        <asp:Label ID="resultLabel" runat="server"></asp:Label>
        <br />

    </div>
    </form>
</body>
</html>
