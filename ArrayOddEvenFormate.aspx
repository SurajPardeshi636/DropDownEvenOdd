<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ArrayOddEvenFormate.aspx.cs" Inherits="ArrayTask08Dec.ArrayOddEvenFormate" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 100px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>Array Even & Odd</h3>
        </div>
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">Array List:</td>
                <td>
                    <asp:DropDownList ID="DrpArrayList" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DrpArrayList_SelectedIndexChanged">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">EvenArray:</td>
                <td>
                    <asp:DropDownList ID="DrpEven" runat="server">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">OddArray:</td>
                <td>
                    <asp:DropDownList ID="DrpOdd" runat="server">
                    </asp:DropDownList>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
