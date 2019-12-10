<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Translator.aspx.cs" Inherits="translator.Translator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style = "margin-top:150px">
        <h1 style="margin-left:400px" >English to Roman Urdu Translator</h1>
        <asp:Label style="margin-left:500px" ID="lblTranslator" runat="server" Text="Enter English text here:"></asp:Label>
        <br />
        <asp:TextBox style="margin-left:500px" ID="txtInputString" runat="server" Height="78px" Width="193px" TextMode="MultiLine"></asp:TextBox>
        <br />
        <asp:Button style="margin-left:550px" ID="btnTranslate" runat="server" Text="Translate!" OnClick="btnTranslate_Click" />
        <br />
        <asp:Label style="margin-left:500px" ID="lblTranslated" runat="server" Text="RomanUrdu Translation:"></asp:Label>
        <br />
        <asp:TextBox style="margin-left:500px" ID="txtOutputString" runat="server" Height="104px" Width="186px" TextMode="MultiLine"></asp:TextBox>
    </div>
    </form>
</body>
</html>
