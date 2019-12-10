<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DataFiller.aspx.cs" Inherits="translator.DataFiller" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table>
        <tr>
            <td>Word</td>
            <td>
                <asp:TextBox ID="word" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Translation</td>
            <td>
                <asp:TextBox ID="translation" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Part of Speech</td>
            <td>
                <asp:TextBox ID="partOfSpeech" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="btnInsert" runat="server" Text="Insert" OnClick="btnInsert_Click" />
                <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" />
                <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click" />
            </td>     
        </tr>
        <asp:GridView ID="GridView1" runat="server"></asp:GridView>
    </table>
    </div>
    </form>
</body>
</html>
