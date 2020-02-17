<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AnCustomer.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    </form>
    <table width="100%">
        <tr>
            <td>
                <p class="menu3">
                    Name:
                    <br />
                    <input name="name" size="15" type="text" /></p>
                <p class="menu3">
                    E-Mail:
                    <br />
                    <input name="email" size="15" type="text" /></p>
                <p class="menu3">
                    Telephone: <br />
                    <input name="telephone" size="15" type="text" /></p>
                <p class="menu3">
                    Query:<table width="100%">
                        <tr>
                            <td>
                                <p class="menu3">
                                    Name:
                                    <br />
                                    <input name="name0" size="15" type="text" /></p>
                                <p class="menu3">
                                    E-Mail:
                                    <br />
                                    <input name="email0" size="15" type="text" /></p>
                                <p class="menu3">
                                    Telephone:
                                    <br />
                                    <input name="telephone0" size="15" type="text" /></p>
                                <p class="menu3">
                                    Query:<br />
                                    <textarea cols="40" name="query" rows="6"></textarea></p>
                                <p>
                                    <input type="submit" value="Post Your Comment" />
                                    <input type="reset" /></p>
                            </td>
                        </tr>
                    </table>
                </p>
                <p>
                    <input type="submit" value="Post Your Comment" />
                    <input type="reset" /></p>
            </td>
        </tr>
    </table>
</body>
</html>
