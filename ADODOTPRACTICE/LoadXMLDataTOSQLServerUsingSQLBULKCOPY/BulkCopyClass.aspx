<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BulkCopyClass.aspx.cs" Inherits="LoadXMLDataTOSQLServerUsingSQLBULKCOPY.BulkCopyClass" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <p>Load XML Data to SQL Server.</p>
        <asp:Button ID="Button1" runat="server" Text="Sent Data" OnClick="Button1_Click" />
        <asp:Label ID="lblMessage" runat="server" ></asp:Label>
    </div>
    </form>
</body>
</html>
