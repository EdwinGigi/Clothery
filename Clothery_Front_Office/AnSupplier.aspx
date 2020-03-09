<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AnSupplier.aspx.cs" Inherits="AnSupplier" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            Supplier ID<br /> <input name="ID" size="15" type="int32" />
        <br />

        
            Supplier Name<br /> <input name="Supplier_Name" size="15" type="text" />
        <br />

        
            Supplier Address<br /> <input name="Supplier_Address" size="15" type="text" />
        <br />

        
            Supplier Post Code<br /> <input name="Supplier_Post_Code" size="15" type="text" />
       <br />

            Delivery Date<br /> <input name="Delivery_Date" size="15" type="text" />
       <br />
      
            Delivery Date<br /> &nbsp;<input name="Delivery_Date" size="15" type="date" /><br />

      
            Stock Available&nbsp; <br />

   

        &nbsp;<input name="Stock_Available" size="15" type="boolean" /></p>

        <asp:Button ID="BtnSubmit" runat="server" Text="Submit" OnClick="BtnSubmit_Click" style="height: 26px" />

    </form>
 
</body>
</html>
