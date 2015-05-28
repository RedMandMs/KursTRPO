<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="admin.aspx.cs" Inherits="Web.admin" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Table runat="server">
            <asp:TableRow>
                <asp:TableCell><asp:Label>Login</asp:Label></asp:TableCell>
                <asp:TableCell><asp:TextBox runat="server" ID="tbLogin" Visible="true"></asp:TextBox></asp:TableCell>    
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell><asp:Label>Password</asp:Label></asp:TableCell>
                <asp:TableCell><asp:TextBox TextMode="Password" runat="server" ID="tbPassword"/></asp:TableCell>    
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell><asp:Button ID="btnEntryAdmin" OnClick="entryAsAdmin" runat="server"  Text="Submit"/></asp:TableCell>
                <asp:TableCell></asp:TableCell>    
            </asp:TableRow>
        </asp:Table>
        <asp:DropDownList ID="elementList" runat="server" Height="26px" AutoPostBack="True"
            onselectedindexchanged="elementList_SelectedIndexChanged" Width="281px">
            <asp:ListItem Value="0">Выберите нужную схему</asp:ListItem>
            <asp:ListItem Value="1">Схема 1</asp:ListItem>
            <asp:ListItem Value="2">Схема 1</asp:ListItem>
            <asp:ListItem Value="3">Схема 3</asp:ListItem>
            <asp:ListItem Value="9999">Элементы</asp:ListItem>
        </asp:DropDownList>
        
		<asp:GridView ID="GridView1" runat="server">
        </asp:GridView>

    </div>
    </form>
</body>
</html>
