<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Master.aspx.cs" Inherits="Chap4_5Practice.Master" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        	<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [Products]"></asp:SqlDataSource>
        </div>
    	<asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource1" DataTextField="Name" DataValueField="ProductID">
		</asp:DropDownList>
		<p>
			<asp:Label ID="Label1" runat="server" Text="Hellur"></asp:Label>
		</p>
		<asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
		<p>
			<asp:Image ID="Image1" runat="server" />
		</p>
		<asp:Button ID="Add" runat="server" OnClick="Add_Click" Text="Add" />
		<asp:Button ID="Checkout" runat="server" OnClick="Checkout_Click" PostBackUrl="~/Cart.aspx" Text="Checkout" />
    </form>
</body>
</html>
