<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Length.aspx.cs" Inherits="UnitesWebConverterGroup_P14_1205_11181_2.HomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            Converter App - LENGTH<br />
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Value"></asp:Label>
            :
            <asp:TextBox ID="TextValue" runat="server"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="From:"></asp:Label>
            <asp:DropDownList ID="DropDownFrom" runat="server">
                <asp:ListItem Selected="True" Value="F">Foot</asp:ListItem>
                <asp:ListItem Value="M">Meter</asp:ListItem>
                <asp:ListItem Value="K">Kilometer</asp:ListItem>
            </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; To:
            <asp:DropDownList ID="DropDownTo" runat="server">
                <asp:ListItem Selected="True" Value="F">Foot</asp:ListItem>
                <asp:ListItem Value="M">Meter</asp:ListItem>
                <asp:ListItem Value="K">Kilometer</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <br />
            <asp:Button ID="ButtonConvert" runat="server" OnClick="ButtonConvert_Click" Text="Convert" />
            <br />
            <br />
            <br />
            Result:
            <asp:TextBox ID="TextResult" runat="server"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:Label ID="LabelError" runat="server" BackColor="#FF3300" Visible="False"></asp:Label>
            <br />
            <br />
            <br />
            <a href="HomePage.aspx">Return</a>
        </div>
    </form>
</body>
</html>
