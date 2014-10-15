<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="DatabaseExample.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1
        {
            width: 48%;
        }
        .auto-style2
        {
            text-align: center;
        }
        .auto-style3
        {
            width: 110px;
        }
        .auto-style4
        {
            width: 123px;
        }
        .auto-style5
        {
            text-align: center;
        }
        .auto-style6
        {
            width: 123px;
            text-align: center;
        }
        .auto-style7
        {
            width: 110px;
            text-align: center;
        }
        .auto-style8
        {
            width: 112px;
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:ListBox ID="ListBox1" runat="server"></asp:ListBox>
        <br />
        <br />
        <table class="auto-style1">
            <tr>
                <td class="auto-style8">Cust ID</td>
                <td class="auto-style7">Name</td>
                <td class="auto-style6">Area</td>
                <td class="auto-style5">Balance</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:TextBox ID="CustID_text" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style3">
                    <asp:TextBox ID="Name_text" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style4">
                    <asp:TextBox ID="area_text" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:TextBox ID="balance_text" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2" colspan="4">
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Store in Database" />
                </td>
            </tr>
        </table>
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
