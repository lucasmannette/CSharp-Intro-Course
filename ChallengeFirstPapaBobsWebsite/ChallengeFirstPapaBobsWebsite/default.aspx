<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="ChallengeFirstPapaBobsWebsite._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            color: #FF3300;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <h1>
            <asp:Image ID="Image1" runat="server" ImageUrl="PapaBob.png" />
&nbsp;&nbsp;&nbsp; Papa Bob&#39;s Pizza and Software</h1>
        <p>
            <asp:RadioButton ID="babySize" runat="server" GroupName="size" Text="Baby Bob Size (10&quot;) - $10" /><br />
            <asp:RadioButton ID="mamaSize" runat="server" GroupName="size" Text="Mama Bob Size (13&quot;) - $13" /><br />
            <asp:RadioButton ID="papaSize" runat="server" GroupName="size" Text="Papa Bob Size (16&quot;) - $16" /><br /><br />
            <asp:RadioButton ID="thinCrust" GroupName="crust" Text="Thin Crust" runat="server" /><br />
            <asp:RadioButton ID="deepCrust" GroupName="crust" Text="Deep Dish (+$2)" runat="server" /><br /><br /><br />

            
            <asp:CheckBox ID="pepperoni" Text="Pepperoni (+$1.50)" runat="server" /><br />
            <asp:CheckBox ID="onions" Text="Onions (+$0.75)" runat="server" /><br />
            <asp:CheckBox ID="greenPeppers" Text="Green Peppers (+$0.50)" runat="server" /><br />
            <asp:CheckBox ID="redPeppers" Text="Red Peppers (+$0.75)" runat="server" /><br />
            <asp:CheckBox ID="anchovies" Text="Anchovies (+$2)" runat="server" />


            
        </p>
        <h2>
            Papa Bob&#39;s <span class="auto-style1">Special Deal</span></h2>
        Save $2.00 when you add Pepperoni, Green Peppers and Anchovies OR Pepperoni, Red Peppers, and Onions to your Pizza.<br />
        <br />
        <asp:Button ID="okButton" runat="server" OnClick="okButton_Click" Text="Purchase" />
        <br />
        <br />
        <asp:Label ID="resultLabel" runat="server"></asp:Label>
        <br />
        <br />
        Sorry at this time you can only order one pizza online, and pick-up only. We will have a better website shortly!<br />


            
    </div>
    </form>
</body>
</html>
