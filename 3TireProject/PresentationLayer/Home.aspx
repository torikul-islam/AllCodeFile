<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="PresentationLayer.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <%--<script type="text/javascript" src="http://code.jquery.com/jquery-1.8.2.js"></script>
    <script type="text/javascript">
        $('#btnSubmit').click(function () {
            var BusinessObject = {};
            BusinessObject._Name = $('#txtName').val();
            BusinessObject._Address = $('#txtAddress').val();
            BusinessObject._Email = $('#txtEmailid').val();
            BusinessObject._MObileNo = $('#txtMobile').val();

            if ($('#txtEmailid') == "") {
                ale("Fill  emailid");
            }
        });

        $.ajax({
            type: 'post',
            url: 'Home.aspx/BusinessObject',
            contentType: "application/json; charset=utf-8",
            data: 'BusinessObject' + JSON.stringify(BusinessObject),
            dataType: 'json',
            success: function () {
                alert("Inserted Successfully.");
            },
            error: function () {
                alert("error");
            },

            });
        





    </script>--%>
</head>
<body>
    <form id="form1" runat="server" >
    <div>
    <table>
        <tr>
            <td>
                Name:
            </td>
            <td>
                <asp:TextBox ID="txtName" runat="server" ClientIDMode="Static" ></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                Address:
            </td>
            <td>
                <asp:TextBox ID="txtAddress" runat="server" ClientIDMode="Static"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                Email ID:
            </td>
            <td>
                <asp:TextBox ID="txtEmailid" runat="server" ClientIDMode="Static"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                Mobile No:
            </td>
            <td>
                <asp:TextBox ID="txtMobile" runat="server" ClientIDMode="Static" ></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                
            </td>
            <td>
                <asp:Button ID="btnSubmit" runat="server" Text="Registered" ClientIDMode="Static" OnClick="btnSubmit_Click" />
            </td>
        </tr>
    </table>
    </div>
    </form>
</body>
</html>
