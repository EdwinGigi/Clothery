<%@ Page Language="C#" MasterPageFile="~/Clothery_shop.master" AutoEventWireup="true" CodeFile="AnSupplier.aspx.cs" Inherits="AnSupplier" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

            <asp:Label ID="lblSupplierID" runat="server" Text="Supplier Id" Width="121px"></asp:Label>
            &nbsp;<asp:TextBox ID="txtSupplierID" runat="server" Width="121px" ></asp:TextBox>
            <asp:Button ID="BtnFind" runat="server" height="26px" Text="Find" width="40px" OnClick="btnFind_Click" />
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
            &nbsp;<asp:Label ID="lblDescription" runat="server" Text="Description" Width="121px" Height="33px" style="margin-left: 0px"></asp:Label>
            <asp:TextBox ID="txtDescription" runat="server" Height="37px" Width="240px" ></asp:TextBox>
            <br />
            <asp:Label ID="lblDeliveryDate" runat="server" Text="Delivery Date" Width="121px"></asp:Label>
            &nbsp;<asp:TextBox ID="txtDeliveryDate" runat="server" ></asp:TextBox>
            <br />
            <asp:Label ID="lblStockAvailable" runat="server" Text="Stock Available" Width="121px"></asp:Label>
            &nbsp;<asp:TextBox ID="txtStockAvailable" runat="server" ></asp:TextBox>
            <br />
            <asp:CheckBox ID="CheckStock" runat="server" style="z-index: 1;" Text="Check Stock"  OnCheckedChanged="CheckStock_CheckedChanged"/>
            <br />
            <asp:Label ID="lblError" runat="server" ></asp:Label>            
            <br />
            <asp:Button ID="btnOK" runat="server" height="26px" Text="OK" width="61px" OnClick="btnOK_Click" />
            <asp:Button ID="btnCancel" runat="server" style="z-index: 1;" Text="Cancel" height="26px" width="61px" OnClick="btnCancel_Click" />

</asp:Content>
