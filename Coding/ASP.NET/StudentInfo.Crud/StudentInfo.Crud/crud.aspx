<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="crud.aspx.cs" Inherits="StudentInfo.Crud.crud" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            
            
            
            
            <div style="font-size:x-large"align ="center" >
            RegistrationForm</div>
            <br />
           

            <asp:Label ID="studentName" runat="server" Text="StudentName"></asp:Label>
            <asp:TextBox runat="server" ID="name" ></asp:TextBox><br />
            
            
            <asp:Label ID="address" runat="server" Text="Address"></asp:Label>
            <asp:TextBox runat="server" ID="name2"></asp:TextBox><br />
          
            

            <asp:Label ID="age" runat="server" Text="Age"></asp:Label>
            <asp:TextBox runat="server" ID="name3"></asp:TextBox><br />
            
            <asp:Label ID="contact" runat="server" Text="Contact"></asp:Label>
            <asp:TextBox runat="server" ID = "name4"></asp:TextBox><br />

            <asp:Button runat="server" Text="Insert" OnClick="Unnamed1_Click" ForeColor="#FF66FF"></asp:Button>
             <asp:Button runat="server" Text="Update" OnClick="Unnamed2_Click" ForeColor="#FF66FF"></asp:Button>
             <asp:Button runat="server" Text="Delete" OnClick="Unnamed3_Click" ForeColor="#FF66FF"></asp:Button>
             <asp:Button runat="server" Text="Search" OnClick="Unnamed4_Click" ForeColor="#FF66FF"></asp:Button>
        </div>
    </form>
</body>
</html>

        
