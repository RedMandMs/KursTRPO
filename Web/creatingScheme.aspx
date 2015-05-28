<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="creatingScheme.aspx.cs" Inherits="Web.creatingScheme" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Схемотехническое моделирование</title>
		<style>
			body {
			background: #5F667C; /* Цвет фона */
			color: #fc0; /* Цвет текста */
			}
		</style>
</head>
<body>
    <form id="form1" runat="server">
		<div>
			<p><img alt="Здесь должна быть красивая картинка со схемой" height="150" src="img/hat.jpg" style="float: left; margin: 0px; border-width: 0px; border-style: solid;" width="100%"></p>
		    <br/>
            <asp:Table ID="Table1" runat="server" HorizontalAlign='Center' CellPadding="20" > 
            <asp:TableRow >
                <asp:TableCell ColumnSpan="3">
		            <h2>Наш сайт посвящён схемотехнической разработке. 
                    На нашем сайте вы сможете с лёгкостью отыскать все 
                    необходимые схематехнические компоненты для смешанного 
                    моделирования и даже просмотреть уже готовые надёжные решения!</h2>
		        </asp:TableCell> 
            </asp:TableRow>
            <asp:TableRow VerticalAlign='Middle' HorizontalAlign='Center'>
                <asp:TableCell><a href="Default.aspx"><img alt="На главную" height="170" src="img/ToMain.jpg" style="margin: 0px;"/></a></asp:TableCell>
                <asp:TableCell><a href="creatingScheme.aspx"><img alt="Сделать самому" height="170" src="img/ToMake.jpg" style="margin: 0px;"/></a></asp:TableCell>
                <asp:TableCell><a href="workingScheme.aspx"><img alt="Взять готовую схему" height="170" src="img/ToGet.jpg" style="margin: 0px;"/></a></asp:TableCell>
            </asp:TableRow>
        </asp:Table>
		</div>

        <div>

        <asp:DropDownList ID="elementList" runat="server" Height="22px" AutoPostBack="True"
            onselectedindexchanged="elementList_SelectedIndexChanged" Width="186px">
            <asp:ListItem Selected=True>Выберите Компонент</asp:ListItem>
            <asp:ListItem Value="0">Резисторы</asp:ListItem>
            <asp:ListItem Value="1">Конденсаторы</asp:ListItem>
            <asp:ListItem Value="2">Индуктивности</asp:ListItem>
        </asp:DropDownList>
        <p></p>
        <asp:GridView ID="gridView" runat="server">
        </asp:GridView>

					<p><input name="addComponent" type="button" value="Добавить компонент" 
                            style="height: 26px; width: 184px"></p>
            <p>Ваш набор компонентов:</p>
					<p><select name="selectedElements" size="5" style="width: 181px"></select>&nbsp;</p>
					<p><input name="deleteElement" type="button" value="Удалить из набора" 
                            style="width: 181px"></p>
		</div>
		<br>
		<br>
		<br>
		<br>
		<img alt="Здесь должна быть информация о нас" height="150" src="img/foot.jpg" 
            style="float: left; margin: 0px; border-width: 0px; border-style: solid;" 
            width="100%">

	</form>
	</body>
</html>