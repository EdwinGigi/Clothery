<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstOrders" runat="server" Height="430px" Width="691px"></asp:ListBox>
        <p>
            <asp:Button ID="btnAdd" runat="server" Text="Add" />
            <asp:Button ID="btnEdit" runat="server" Text="Edit" />
            <asp:Button ID="btnDelete" runat="server" Text="Delete" />
        </p>
        <asp:Label ID="lblError" runat="server" ></asp:Label>
    </form>
</body>
</html>
