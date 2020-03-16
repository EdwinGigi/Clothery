<%@ Page Title="" Language="C#" MasterPageFile="~/Clothery_shop.master" AutoEventWireup="true" CodeFile="AnOrderLine.aspx.cs" Inherits="AnOrderLine" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
            <asp:Label ID="lblOrderLineId" runat="server" Text="OrderLine Id" Width="168px"></asp:Label>
            &nbsp;<asp:TextBox ID="txtOrderLineId" runat="server" Width="243px" ></asp:TextBox>
            <br />
            <asp:Label ID="lblOrderId" runat="server" Text="Order Id" Width="168px"></asp:Label>
            &nbsp;<asp:TextBox ID="txtOrderId" runat="server" Width="248px" ></asp:TextBox>
            <br />
            <asp:Label ID="lblProductId" runat="server"  Text="Product Id" Width="168px"></asp:Label>
            &nbsp;<asp:TextBox ID="txtProductId" runat="server" ></asp:TextBox>
            <br />
            <asp:Label ID="lblQuantity" runat="server" Text="Quantity" Width="168px"></asp:Label>
            &nbsp;<asp:TextBox ID="txtQuantity" runat="server" ></asp:TextBox>
            <br />
            <asp:Label ID="lblPrice" runat="server" Text="Price" Width="168px"></asp:Label>
            &nbsp;<asp:TextBox ID="txtPrice" runat="server" ></asp:TextBox>
            <br />
            <asp:Label ID="lblSize" runat="server" Text="Size" Width="168px"></asp:Label>
            &nbsp;<asp:TextBox ID="txtSize" runat="server" ></asp:TextBox>
            <br />
            <asp:Label ID="lblDescription" runat="server" Text="Description" Width="168px"></asp:Label>
            &nbsp;<asp:TextBox ID="txtDescription" runat="server" ></asp:TextBox>
            <br />
            <br />
            <asp:CheckBox ID="chkShipped" runat="server" style="z-index: 1;" Text="Shipped?" />
            <br />
            <br />
            <asp:Label ID="lblError" runat="server" ></asp:Label>            
            <br />
            <br />
            <asp:Button ID="btnOK" runat="server" height="26px" Text="OK" width="61px" OnClick="btnOK_Click" />
            <asp:Button ID="btnCancel" runat="server" style="z-index: 1;" Text="Cancel" height="26px" width="117px" OnClick="btnCancel_Click" />

</asp:Content>

