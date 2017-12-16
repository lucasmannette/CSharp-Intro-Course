<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="CS_006._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-family: Arial, Helvetica, sans-serif;
        }
        .auto-style2 {
            color: #006600;
        }
        .auto-style3 {
            width: 100%;
        }
        .auto-style4 {
            background-color: #FFFF00;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <h1>Head Line 1</h1>
        <h2>Head Line 2</h2>
        <h3>Head Line 3</h3>
        <h4>Head Line 4</h4>
        <h5>Head Line 5</h5>
        <h6>Head Line 6</h6>
        <p class="auto-style1">
            This is some text I want to <span class="auto-style2">apply</span> styling to.</p>
        <p class="auto-style1">
            <a href="http://www.learnvisualstudio.net">Add a hyperlink</a></p>
        <p class="auto-style1">
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="https://microsoft.com" Target="_blank">This is another hyperlink</asp:HyperLink>
        </p>
    
    </div>
        <asp:Image ID="Image1" runat="server" Height="200px" ImageUrl="~/destiny2wp.jpg" />
        <br />
        <br />
        <table class="auto-style3">
            <tr>
                <td>Player</td>
                <td>Year</td>
                <td>HomeRuns</td>
            </tr>
            <tr>
                <td>Sammy Sosa</td>
                <td>2005</td>
                <td>100</td>
            </tr>
            <tr>
                <td>Mark McGuire</td>
                <td>2005</td>
                <td>102</td>
            </tr>
        </table>
    </form>
    <ol>
        <li>First Item</li>
        <li>Second Item</li>
        <li>Third Item</li>
    </ol>
    <ul>
        <li class="auto-style4">This is an idea</li>
        <li class="auto-style4">This is a better idea</li>
        <li class="auto-style4">This is some other idea</li>
    </ul>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
</body>
</html>
