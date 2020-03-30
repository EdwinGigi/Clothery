<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DeleteOrder.aspx.cs" Inherits="DeleteOrder" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblmessage" runat="server" Text="Are you sure you want to delete this record? "></asp:Label>
        <p>
            <asp:Button ID="btnyes" runat="server" Text="Yes" OnClick="btnyes_Click" />
            <asp:Button ID="btnno" runat="server" Text="No" />
        </p>
    </form>
</body>
</html>
