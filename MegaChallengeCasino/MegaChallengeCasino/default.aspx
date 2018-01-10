<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="MegaChallengeCasino._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Image ID="slotOne" runat="server" Height="220px" />
        <asp:Image ID="slotTwo" runat="server" Height="220px" />
        <asp:Image ID="slotThree" runat="server" Height="220px" />
        <br />
        <br />
        Your Bet:&nbsp;
        <asp:TextBox ID="betTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="pullLeverButton" runat="server" OnClick="pullLeverButton_Click" Text="Pull The Lever!" />
        <br />
        <br />
        <asp:Label ID="resultLabel" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Label ID="moneyLabel" runat="server"></asp:Label>
        <br />
        <br />
        1 Cherry - x2 Your Bet<br />
        2 Cherry - x3 Your Bet<br />
        3 Cherry - x4 Your Bet<br />
        <br />
        3 7&#39;s - Jackpot - x100 Your Bet<br />
        <br />
        HOWEVER<br />
        <br />
        If there&#39;s even one BAR you win nothing</div>
    </form>
</body>
</html>
