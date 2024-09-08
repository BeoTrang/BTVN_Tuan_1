<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Website_v1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Chương trình tính toán số ước của một số bất kỳ</title>
    <link href="StyleSheet1.css" rel="stylesheet" />
</head>
<body>
    <h1>Chương trình tính số ước của một số bất kì</h1>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td>
                        <asp:Label Class="Label1" runat="server" Text="Nhập số: "></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button Class="Button1" runat="server" Text="Tính toán" OnClick="Button1_Click" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <div id="KetQua" runat="server"></div>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
