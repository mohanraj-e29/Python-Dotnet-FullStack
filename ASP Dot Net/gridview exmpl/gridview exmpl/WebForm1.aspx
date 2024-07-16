<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="gridview_exmpl.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; User Information</p>
        <br />
        <label>Enter the user name:</label>
        <input type="text" id="usr" />
        <br />
        <br />
        <label>Enter the user age:</label>
        <input type="text" id="age" />
        <br />
<br />
        <label>Enter the user location:</label>
        <input type="text" id="loc" />
        <br />

<br />
        &nbsp;
        <asp:Button ID="Button1" runat="server" Text="add" Width="56px" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="print" Width="58px" />
        <br />
        <br />
        <br />
        <asp:GridView ID="grd" runat="server" AutoGenerateSelectButton="True" ClientIDMode="AutoID" OnSelectedIndexChanged="grd_SelectedIndexChanged" Width="306px">
        </asp:GridView>

        <br />
        












    </div>
    </form>
</body>
</html>
