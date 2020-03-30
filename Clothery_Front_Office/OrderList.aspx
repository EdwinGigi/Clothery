<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderList.aspx.cs" Inherits="OrderList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstOrderList" runat="server" Height="524px" Width="653px"></asp:ListBox>
        <p>
            <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click" />
            <asp:Button ID="btnEdit" runat="server" Text="Edit" OnClick="btnEdit_Click" />
            <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" />
        </p>
        <asp:Label ID="lbl1" runat="server" Text="Enter a Shipping Address:  "></asp:Label>
        <asp:TextBox ID="txtShippinAddress" runat="server"></asp:TextBox>
        <p>
        <asp:Button ID="btnApply" runat="server"  Text="Apply" OnClick="btnApply_Click" />
        <asp:Button ID="btnClear" runat="server" Text="Clear" OnClick="btnClear_Click" />
        </p>
        <p>
        <asp:Label ID="lblError" runat="server"></asp:Label>
        </p>
    </form>
</body>
</html>
