<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="InsertValue.Default" %>

<!DOCTYPE html>
<meta charset="utf-8">  
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>  
    <link rel="stylesheet" href="//code.jquery.com/ui/1.12.1/themes/base/jquery-ui.css">
  <link rel="stylesheet" href="/resources/demos/style.css">
  <script src="https://code.jquery.com/jquery-1.12.4.js"></script>
  <script src="https://code.jquery.com/ui/1.12.1/jquery-ui.js"></script>
    <script>
       $(function () {
            $("#txtDOB").datepicker()

        });

    </script>
</head>
<body>
    <form id="form1" runat="server" >
    <div>
    <center>
        <table>
        <tr>
            <td>
                First Name:
            </td>
            <td>
                <asp:TextBox ID="txtFastName" runat="server"></asp:TextBox>
            </td>
        </tr>
         <tr>
            <td>
                Last Name:
            </td>
            <td>
                <asp:TextBox ID="txtLastName" runat="server" ></asp:TextBox>
            </td>
        </tr>
         <tr>
            <td>
                Age:
            </td>
            <td>
                <asp:TextBox ID="txtAge" runat="server"></asp:TextBox>
            </td>
        </tr>
         <tr>
            <td>
                Date of Birth:
            </td>
            <td>
                <asp:TextBox ID="txtDOB" runat="server" ClientIDMode="Static" autocomplete="off"></asp:TextBox>
                
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />

            </td>
        </tr>
    </table>
    </div>
    </form>
    </center>
</body>
</html>
