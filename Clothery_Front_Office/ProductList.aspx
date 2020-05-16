<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ProductList.aspx.cs" Inherits="ProductList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    
        
        <asp:listbox ID="LstProductList" runat="server"  Width="500px"></asp:listbox>
        <br />

        <asp:Button ID="BtnAdd" runat="server" height="26px" Text="Add" width="40px" OnClick="btnAdd_Click" />
        <asp:Button ID="BtnEdit" runat="server" height="26px" Text="Edit" width="40px" OnClick="BtnEdit_Click" />
        <asp:Button ID="BtnDelete" runat="server" height="26px" Text="Delete" width="40px" OnClick="BtnDelete_Click" />
        <br />
        <asp:Label ID="LblType" runat="server" Text="Enter a clothes Type " Width="100px"></asp:Label>&nbsp;
        <asp:TextBox ID="TxtType" runat="server" Width="100px" ></asp:TextBox>

        <asp:Button ID="BtnApply" runat="server" height="26px" Text="Apply" width="40px" OnClick="BtnApply_Click" />
        <asp:Button ID="BtnClear" runat="server" height="26px" Text="Clear" width="40px" OnClick="BtnClear_Click" />

        <br />
        <asp:Label ID="LblError" runat="server" Text="" Width="500px"></asp:Label>
        </form>
    </body>
</html>
