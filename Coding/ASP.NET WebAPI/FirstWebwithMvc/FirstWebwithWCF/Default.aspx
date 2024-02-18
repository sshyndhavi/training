<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="FirstWebwithWCF._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>

<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <div style="width:50%">
        <div style="background-color: Blue; color: white; font-size: large; font-weight: bolder">
            Calculator using WCF
        </div>
        <br />
        <div style="background-color: Gray; color: Blue; font-size: medium; font-weight: bolder">
            Number1 :<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            Number2 :<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </div>
        <asp:Button ID="Button1" runat="server" Text="ADD" />
        <asp:Button ID="Button2" runat="server" Text="SUB" />
        <asp:Button ID="Button3" runat="server" Text="MUL" />
        <asp:Button ID="Button4" runat="server" Text="DIV" />
    </div>
</asp:Content>
