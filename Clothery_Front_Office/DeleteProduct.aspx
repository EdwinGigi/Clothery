<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DeleteProduct.aspx.cs" Inherits="DeleteProduct" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Are you sure you want to delete this record?<br />

            <asp:Button ID="BtnYes" runat="server" height="26px" Text="Yes" width="40px" OnClick="BtnYes_Click" />
            <asp:Button ID="BtnNo" runat="server" height="26px" Text="No" width="40px" OnClick="BtnNo_Click" />

        </div>
    </form>
</body>
</html>
