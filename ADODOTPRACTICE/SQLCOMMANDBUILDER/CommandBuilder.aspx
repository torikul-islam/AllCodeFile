<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CommandBuilder.aspx.cs" Inherits="SQLCOMMANDBUILDER.CommandBuilder" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table>
            <tr>
                <td>
                   Enter Product Id:
                </td>
                <td>
                    <asp:TextBox ID="txtProductId" runat="server" AutoCompleteType="Disabled" ></asp:TextBox>
                    <asp:Button ID="btnLoad" runat="server" Text="Load" OnClick="btnLoad_Click" />
                </td>
            </tr>
            <tr>
                <td>
                     Product Name: 
                </td>
                <td>
                   <asp:TextBox ID="txtProductName" runat="server" AutoCompleteType="Disabled"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    Product Price:
                </td>
                <td>
                     <asp:TextBox ID="txtProductPrice" runat="server" AutoCompleteType="Disabled"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click" />
                    
                </td>
                <td>
                    <asp:Label ID="lblMessage" runat="server" ></asp:Label>
                </td>
            </tr>


        </table>
    
    </div>
    </form>
</body>
</html>
