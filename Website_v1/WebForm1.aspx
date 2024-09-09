<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Website_v1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Chương trình tính toán số ước của một số bất kỳ</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Chương trình tính số ước của một số bất kì" Font-Size="Large" Font-Bold="True"></asp:Label>
            <table>
                <tr>
                    <td>
                        <asp:Label Class="Label1" runat="server" Text="Nhập số: " ForeColor="Black" Font-Size="Medium"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox1" runat="server" BorderStyle="Solid"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button Class="Button1" runat="server" Text="Tính toán" OnClick="Button1_Click" ForeColor="Red" Font-Size="Medium" />
                    </td>
                </tr> 
            </table>
            <div id="KetQua" runat="server"></div>
        </div>
    </form>
</body>
</html>
