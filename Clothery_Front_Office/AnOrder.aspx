<%@ Page Title="" Language="C#" MasterPageFile="~/Clothery_shop.master" AutoEventWireup="true" CodeFile="AnOrder.aspx.cs" Inherits="AnOrder" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
            <asp:Label ID="lblOrderId" runat="server" Text="Order Id" Width="120px"></asp:Label>
            &nbsp;<asp:TextBox ID="txtOrderId" runat="server" Width="235px" ></asp:TextBox>
            <br />
            <asp:Label ID="lblOrderDate" runat="server" Text="Order Date" Width="120px"></asp:Label>
            &nbsp;<asp:TextBox ID="txtOrderDate" runat="server" ></asp:TextBox>
            <br />
            <asp:Label ID="lblShippingAddress" runat="server"  Text="Shipping Address" Width="120px"></asp:Label>
            &nbsp;<asp:TextBox ID="txtShippingAddress" runat="server" ></asp:TextBox>
            <br />
            <asp:Label ID="lblCustomerId" runat="server" Text="Customer Id" Width="120px"></asp:Label>
            &nbsp;<asp:TextBox ID="txtCustomerId" runat="server" ></asp:TextBox>
            <br />
            <br />
            <asp:CheckBox ID="chkPaid" runat="server" style="z-index: 1;" Text="Is Paid?" />
            <br />
            <br />
            <asp:Label ID="lblError" runat="server" ></asp:Label>            
            <br />
            <br />
            <asp:Button ID="btnOK" runat="server" height="26px" Text="OK" width="61px" OnClick="btnOK_Click" />
            <asp:Button ID="btnCancel" runat="server" style="z-index: 1;" Text="Cancel" height="26px" width="107px" OnClick="btnCancel_Click" />
            <asp:Button ID="btnFind" runat="server" style="z-index: 1;" Text="Find" height="26px" width="107px" OnClick="btnFind_Click" />

</asp:Content>

