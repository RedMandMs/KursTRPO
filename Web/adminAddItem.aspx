<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="adminAddItem.aspx.cs" Inherits="Web.adminAddItem" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:DropDownList ID="elementList" runat="server" Height="20px" AutoPostBack="True"
            onselectedindexchanged="elementList_SelectedIndexChanged" Width="242px">
            <asp:ListItem Value="0">Резисторы</asp:ListItem>
            <asp:ListItem Value="1">Конденсаторы</asp:ListItem>
            <asp:ListItem Value="2">Индуктивности</asp:ListItem>
        </asp:DropDownList>
    
    </div>

    <asp:Table runat="server" ID="tableElem">
        <asp:TableRow>
            <asp:TableCell><asp:Label ID="Label1" runat="server">Id элемента:</asp:Label></asp:TableCell>
            <asp:TableCell><asp:TextBox ID="tbId" runat="server"></asp:TextBox></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell><asp:Label ID="lName" runat="server">Название элемента:</asp:Label></asp:TableCell>
            <asp:TableCell><asp:TextBox ID="tbName" runat="server"></asp:TextBox></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell><asp:Label ID="lValue" runat="server">Величина:</asp:Label></asp:TableCell>
            <asp:TableCell><asp:TextBox ID="tbValue" runat="server"></asp:TextBox></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell><asp:Label ID="lPrice" runat="server">Цена:</asp:Label></asp:TableCell>
            <asp:TableCell><asp:TextBox ID="tbPrice" runat="server"></asp:TextBox></asp:TableCell>
        </asp:TableRow>
    </asp:Table>
    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
        Text="Add element" />
    <asp:Button ID="btnGetData" runat="server" onclick="btnGetData_Click" 
        Text="Get data" />
    <asp:GridView ID="gridView" runat="server">
    </asp:GridView>
    </form>
</body>
</html>
