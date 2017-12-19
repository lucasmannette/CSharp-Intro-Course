<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="SimpleCalculatorChallenge._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <h1>Simple Calculator</h1>
            <div>First Value:&nbsp;
                <asp:TextBox ID="firstValue" runat="server"></asp:TextBox>
        </div>
            <div>Second Value:&nbsp;
                <asp:TextBox ID="secondValue" runat="server"></asp:TextBox>
        </div>
        <div>
            <br />
            <asp:Button ID="addButton" runat="server" Height="20px" OnClick="addButton_Click" Text="+" Width="20px" />
&nbsp;
            <asp:Button ID="subtractButton" runat="server" Height="20px" OnClick="subtractButton_Click" Text="-" Width="20px" />
&nbsp;
            <asp:Button ID="multiplyButton" runat="server" Height="20px" OnClick="multiplyButton_Click" Text="*" Width="20px" />
&nbsp;
            <asp:Button ID="divideButton" runat="server" Height="20px" OnClick="divideButton_Click" Text="/" Width="20px" />
            <br />
            <br />
            <asp:Label ID="resultLabel" runat="server" style="font-weight: 700; font-size: large; color: #00CCFF; background-color: #3333FF"></asp:Label>
        </div>
    
    </div>
    </form>
</body>
</html>
