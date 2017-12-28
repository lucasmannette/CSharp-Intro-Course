<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="ChallengeEpicSpies._default" MaintainScrollPositionOnPostback="true" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
         <asp:Image ID="spyImage" runat="server" ImageUrl="images/epic-spies-logo.jpg" Height="190px" />
        <br />
        <br />
        <h1> Spy New Assignment Form</h1>
        
        Spy Code Name:
         <asp:TextBox ID="spyCodeName" runat="server"></asp:TextBox>
        <br /><br />
        New Assignment Name:
         <asp:TextBox ID="assignmentNewName" runat="server"></asp:TextBox>
        <br /><br />
        End Date of Previous Assignment
         <br />
         <asp:Calendar ID="endDatePrevious" runat="server"></asp:Calendar>
         <br />
         Start Date of New Assignment<br />
         <asp:Calendar ID="startDateNew" runat="server"></asp:Calendar>
         <br />
         Projected End Date of New Assignment<br />
         <asp:Calendar ID="endDateNew" runat="server"></asp:Calendar>
         <br />
         <asp:Button ID="assignButton" runat="server" OnClick="assignButton_Click" Text="Assign Spy" />
         <br />
         <br />
         <asp:Label ID="resultLabel" runat="server"></asp:Label>
        <br />
    </div>
    </form>
</body>
</html>
