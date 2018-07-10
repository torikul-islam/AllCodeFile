<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="InserDataUsingAjax.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
        <link href="http://ajax.googleapis.com/ajax/libs/jqueryui/1.8.1/themes/base/jquery-ui.css" rel="stylesheet" type="text/css" />  
        <script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.4.2/jquery.min.js"></script>  
        <script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jqueryui/1.8.1/jquery-ui.min.js"></script>
         <script type="text/javascript">

             $('#btnSubmit').click(function () {
                 
                 var name = $('#txtUserName').val();
                 var email = $('#txtEmail').val();
                 
             });
             
             //var msg = "";
             if(name == ""){
                 alert("Please, Fill UserName Field.");
             }


             //$.ajax({
             //    type: 'post',
             //    dataType: 'json',
             //    contentType: "application/json; charset=utf-8",
             //    url: "Default.aspx/InsertMethod",
             //    data: "{'Name:' '" + name + "', 'Email:' '" + email + "' }",
             //    success: function (response) {
             //        if (respo.d == true) {
             //            alert("Record Inserted Successfully.");
             //        }

             //    },
             //   else () {
             //       alert("Error Occured.");
             //   }

             //})



    </script>
</head>
<body>
    <form id="form1" runat="server">
    
    <div class="demo">  
                <div class="ui-widget">  
                    <label for="tbAuto">  
                        Enter UserName:  
                    </label>  
                       
                    <asp:TextBox ID="txtUserName" runat="server"  Width="202px" ClientIDMode="Static"></asp:TextBox>  
                    <br />  
                    <br /> 
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                    Email<asp:TextBox ID="txtEmail" runat="server" ClientIDMode="Static"  Width="202px" style="margin-left: 46px"></asp:TextBox>  
                    <br />  
                    <br />  
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;  
                    <asp:Button ID="btnSubmit" runat="server" Text="Submit" ClientIDMode="Static" />  
                </div>  
            </div>  
   
    </form>
</body>
</html>
