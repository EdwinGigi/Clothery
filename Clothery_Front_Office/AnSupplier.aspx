<%@ Page Language="C#" MasterPageFile="~/Clothery_shop.master" AutoEventWireup="true" CodeFile="AnSupplier.aspx.cs" Inherits="AnSupplier" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
            <asp:Label ID="lblSupplierID" runat="server" Text="Supplier Id" Width="121px"></asp:Label>
            &nbsp;<asp:TextBox ID="txtSupplierID" runat="server" Width="121px" ></asp:TextBox>
            <br />
            <asp:Label ID="lblSupplierName" runat="server" Text="Supplier Name" Width="121px"></asp:Label>
            &nbsp;<asp:TextBox ID="txtSupplierName" runat="server" ></asp:TextBox>
            <br />
            <asp:Label ID="lblSupplierAddress" runat="server"  Text="Supplier Address" Width="121px"></asp:Label>
            &nbsp;<asp:TextBox ID="txtSupplierAddress" runat="server" ></asp:TextBox>
            <br />
            <asp:Label ID="lblSupplierPostCode" runat="server" Text="Supplier Post-Code" Width="121px"></asp:Label>
            &nbsp;<asp:TextBox ID="txtSupplierPostCode" runat="server" ></asp:TextBox>
            <br />
            <br />
            &nbsp;<asp:Label ID="LblDescription" runat="server" Text="Description" Width="121px" Height="32px" style="margin-left: 0px"></asp:Label>
            <asp:TextBox ID="txtDescription" runat="server" Height="37px" Width="240px" ></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="LblDeliveryDate" runat="server" Text="Delivery Date" Width="121px"></asp:Label>
            &nbsp;<asp:TextBox ID="txtDeliveryDate" runat="server" ></asp:TextBox>
            <br />
            <br />
            <asp:CheckBox ID="chkStockAvailable" runat="server" style="z-index: 1;" Text="Is the Stock Available?" OnCheckedChanged="chkStockAvailable_CheckedChanged" />
            <br />
            <br />
            <asp:Label ID="lblError" runat="server" ></asp:Label>            
            <br />
            <br />
            <asp:Button ID="btnOK" runat="server" height="26px" Text="OK" width="61px" OnClick="btnOK_Click" />
            <asp:Button ID="btnCancel" runat="server" style="z-index: 1;" Text="Cancel" height="26px" width="61px" OnClick="btnCancel_Click" />

</asp:Content>
