﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="ChallengePostageCalculatorHelperMethods._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Postal Calculator<br />
        <br />
        Width:&nbsp;
        <asp:TextBox ID="widthTextBox" runat="server" AutoPostBack="True" OnTextChanged="handleChange"></asp:TextBox>
        <br />
        Height:&nbsp;
        <asp:TextBox ID="heightTextBox" runat="server" AutoPostBack="True" OnTextChanged="handleChange"></asp:TextBox>
        <br />
        Length:&nbsp;
        <asp:TextBox ID="lengthTextBox" runat="server" AutoPostBack="True" OnTextChanged="handleChange"></asp:TextBox>
        <br />
        <br />
        <asp:RadioButton ID="groundRadioButton" runat="server" GroupName="shippingMethods" Text="Ground" OnCheckedChanged="handleChange" AutoPostBack="True" />
        <br />
        <asp:RadioButton ID="airRadioButton" runat="server" GroupName="shippingMethods" Text="Air" OnCheckedChanged="handleChange" AutoPostBack="True" />
        <br />
        <asp:RadioButton ID="nextDayRadioButton" runat="server" GroupName="shippingMethods" Text="Next Day" OnCheckedChanged="handleChange" AutoPostBack="True" />
        <br />
        <br />
        <asp:Label ID="resultLabel" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>