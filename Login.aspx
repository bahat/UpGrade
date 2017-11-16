<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Welcome to UpGrade</h1>
        <h2>our mission is to bring schools into the 21st century</h2>
        <h3>login:</h3>
        <asp:TextBox ID="SchoolName" runat="server" placeholder="SchoolName"></asp:TextBox><br />
        <asp:TextBox ID="UserName" runat="server" placeholder="UserName"></asp:TextBox><br />
        <asp:TextBox ID="Password" runat="server" placeholder="Password" type="password"></asp:TextBox>
        <asp:RadioButtonList ID="TeacherOrStudent" runat="server">
            <asp:ListItem ID="Teacher" runat="server">Teacher</asp:ListItem>
            <asp:ListItem ID="Student" runat="server">Student</asp:ListItem>
            <asp:ListItem ID="Admin" runat="server">Admin</asp:ListItem>
        </asp:RadioButtonList>
        <asp:Button ID="Submit" runat="server" Text="Login" />
        <div>
            
        </div>
    </form>
</body>
</html>
