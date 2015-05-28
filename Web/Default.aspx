<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Web.Default" %>

<!DOCTYPE html>

<head runat="server">
    <link rel="stylesheet" type="text/css" href="css/style.css"/>
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
        <asp:Table runat="server" HorizontalAlign='Center' CellPadding="20" > 
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
		<br>
		<br>
		<br>
		<br>
		<br>
		<br>
		<br>
		<br>
		<br>
		<br>
		<br>
		<br>

	    <img alt="Здесь должна быть информация о нас" height="150" src="img/foot.jpg" style="float: left; margin: 0px; border-width: 0px; border-style: solid;" width="100%">
    </div>
    </form>
</body>
</html>
