<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AProduct.aspx.cs" Inherits="AProduct" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            Product ID<br /> <input name="ID" size="15" type="text" />
        <br />

        
            Name<br /> <input name="name" size="15" type="text" />
        <br />

        
            Type<br /> <input name="Type" size="15" type="text" />
        <br />

        
            Colour<br /> <input name="Colour" size="15" type="text" />
       <br />

        
            Cost<br /> <input name="Cost" size="15" type="text" />
        <br />

      
            Stock Count<br /> <input name="Stock_Count" size="15" type="text" />
        <br />

      
            Is Available <input name="Is_Available" size="15" type="text" />
       <br />

        
            Next Delivery <input name="Next_Delivery" size="15" type="text" />
        </p>

        <input type="submit" value="Add" />
        <input type="reset" /></p>

    </form>
</body>
</html>
