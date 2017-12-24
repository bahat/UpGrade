<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/NavBar.master" AutoEventWireup="true" CodeFile="AddStudents.aspx.cs" Inherits="AdminPages_AddStudents" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="../CSS/AddStudents.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
        <div id="textfields">
            <asp:textbox placeholder="DateOfBirth [MM/DD/YYYY] " id="DOB" runat="server"></asp:textbox><br />
            <asp:TextBox placeholder="First Name" ID="FirstName" runat="server"></asp:TextBox><br />
            <asp:TextBox placeholder="Last Name" ID="LastName" runat="server"></asp:TextBox><br />
            <asp:TextBox placeholder="SchoolID" ID="SchoolID" runat="server"></asp:TextBox><br />
            <asp:TextBox placeholder="PhoneNumber" ID="PhoneNumber" runat="server"></asp:TextBox><br />
            <asp:TextBox placeholder="Mail Address" ID="MailAddress" runat="server"></asp:TextBox><br />
            <asp:Button ID="Insert" runat="server" Text="Button" OnClick="Insert_Click"/>
        </div>
</asp:Content>


