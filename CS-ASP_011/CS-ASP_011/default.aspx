<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="CS_ASP_011._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Is&nbsp;
        <asp:TextBox ID="firstText" runat="server"></asp:TextBox>
&nbsp; equal to&nbsp;
        <asp:TextBox ID="secondText" runat="server"></asp:TextBox>
&nbsp; ?<br />
        <br />
        <br />
        <asp:CheckBox ID="coolCheckBox" runat="server" Text="Are you cool?" />
        <br />
        <br />
        If you could only eat one food for the rest of your life, what would you choose?<br />
        <br />
        <asp:RadioButton ID="pizzaButton" runat="server" GroupName="foodGroup" Text="Pizza" />
        <br />
        <asp:RadioButton ID="pbjButton" runat="server" GroupName="foodGroup" Text="Peanut Butter and Jelly" />
&nbsp;<br />
        <asp:RadioButton ID="noodlesButton" runat="server" GroupName="foodGroup" Text="Noodles" />
        <br />
        <br />
        <asp:Button ID="okButton" runat="server" OnClick="okButton_Click" Text="OK" />
        <br />
        <br />
        <asp:Label ID="resultLabel" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
