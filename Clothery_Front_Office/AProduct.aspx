﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AProduct.aspx.cs" Inherits="AProduct" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            <asp:Label ID="LblID" runat="server" Text="Product ID" Width="100px"></asp:Label>
            &nbsp;<asp:TextBox ID="TxtID" runat="server" Width="100px" ></asp:TextBox>
            <br />
            <asp:Label ID="LblName" runat="server" Text="Name" Width="100px"></asp:Label>
            &nbsp;<asp:TextBox ID="TxtName" runat="server" Width="100px" ></asp:TextBox>
            <br />  
            <asp:Label ID="Lbltype" runat="server" Text="Type" Width="100px"></asp:Label>
            &nbsp; <asp:TextBox ID="TxtType" runat="server" Width="100px" ></asp:TextBox>
            <br />
            <asp:Label ID="LblColour" runat="server" Text="Colour" Width="100px"></asp:Label>
            &nbsp; <asp:TextBox ID="TxtColour" runat="server" Width="100px" ></asp:TextBox>
            <br />
            <asp:Label ID="LblCost" runat="server" Text="Cost" Width="100px"></asp:Label>
            &nbsp; <asp:TextBox ID="TxtCost" runat="server" Width="100px" ></asp:TextBox>
            <br />
            <asp:Label ID="LblStock_Count" runat="server" Text="Stock Count" Width="100px"></asp:Label>
            &nbsp; <asp:TextBox ID="TxtStock_Count" runat="server" Width="100px" ></asp:TextBox>
            <br />  
            <asp:CheckBox ID="ChkAvailable" runat="server" style="z-index: 1;" Text="Is Available" />
            <br />        
            Next Delivery <br /> <input name="txtNext_Delivery" size="15" type="text" />
        </p>
        
            <asp:Label ID="LblNext_Delivery" runat="server" Text="Next Delivery" Width="100px"></asp:Label>
            &nbsp; <asp:TextBox ID="TxtNext_Delivery" runat="server" Width="100px" ></asp:TextBox>
            <br />  


        <asp:Button ID="btnOK" runat="server" height="26px" Text="Add" width="61px" OnClick="btnOK_Click" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1;" Text="Cancel" height="26px" width="117px" />

    </form>
</body>
</html>