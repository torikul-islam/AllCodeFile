<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="TablePerType_TPT_Inheritance.home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="font-family:Arial">
     <asp:RadioButtonList ID="RadioButtonList1" runat="server"
    AutoPostBack="True"
    onselectedindexchanged="RadioButtonList1_SelectedIndexChanged">
    <asp:ListItem Text="All Employees" Value="All"></asp:ListItem>
    <asp:ListItem Text="Load Permanent Employees" Value="Permanent">
    </asp:ListItem>
    <asp:ListItem Text="Load Contract Employees" Value="Contract">
    </asp:ListItem>
        </asp:RadioButtonList>
        <br />
        <asp:GridView ID="GridView1" runat="server" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" ForeColor="Black" GridLines="Vertical">
            <AlternatingRowStyle BackColor="#CCCCCC" />
            <FooterStyle BackColor="#CCCCCC" />
            <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#808080" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#383838" />
        </asp:GridView>
        </div>
    </form>
</body>
</html>
