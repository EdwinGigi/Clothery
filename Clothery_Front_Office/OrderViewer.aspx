<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderViewer.aspx.cs" Inherits="OrderViewer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblOrderId" runat="server" Text="Order Id"></asp:Label>
        <asp:TextBox ID="TxtOrderId" runat="server" Width="270px"></asp:TextBox>
        <p>
            <asp:Label ID="lblCutomerId" runat="server" Text="Customer Id"></asp:Label>
            <asp:TextBox ID="TxtCustomerId" runat="server"></asp:TextBox>
        </p>

             <asp:Label ID="lblShippingAddress" runat="server" Text="Shipping Address"></asp:Label>
             <asp:TextBox ID="TxtShippingAddress" runat="server"></asp:TextBox>
        
        <asp:Label ID="lblIsPaid" runat="server" Text="Is Paid?"></asp:Label>
        <asp:CheckBox ID="CheckBox1" runat="server" />
            <p>
        
            <asp:Label ID="lblOrderDate" runat="server" Text="Order Date"></asp:Label>
            <asp:TextBox ID="txtOrderDate" runat="server"  ></asp:TextBox>
        
        </p>
        <p>
            <asp:Button ID="Btn_OK" runat="server" Text="Ok" OnClick="Btn_OK_Click" />
        </p>
        </div>
    </form>
</body>
</html>
