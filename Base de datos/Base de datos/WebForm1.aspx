<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Base_de_datos.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="background-image: url('Images/id.PNG'); height: 608px;">
            <asp:GridView ID="GridView1" runat="server" BorderColor="Black" CellPadding="10" ForeColor="White" HorizontalAlign="Right">
                <EmptyDataRowStyle Font-Bold="True" />
                <SelectedRowStyle Font-Bold="False" />
            </asp:GridView>
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox1" runat="server" Width="176px" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox2" runat="server" Width="176px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            &nbsp;<br />
&nbsp;&nbsp;&nbsp;
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox3" runat="server" Width="176px"></asp:TextBox>
&nbsp;<br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox4" runat="server" Width="176px"></asp:TextBox>
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox5" runat="server" Width="176px"></asp:TextBox>
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" Text="Insertar" Width="184px" OnClick="Button1_Click" />
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" Text="Modificar" Width="184px" OnClick="Button2_Click" />
            <br />
&nbsp;<br />
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button3" runat="server" Text="Eliminar" Width="184px" OnClick="Button3_Click" />
            <br />
            <br />
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button4" runat="server" Text="Empleados" Width="184px" OnClick="Button4_Click" />
            <br />
&nbsp;&nbsp;&nbsp;
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button5" runat="server" Text="Libros" Width="184px" OnClick="Button5_Click" />
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button6" runat="server" Text="Prestamos" Width="184px" OnClick="Button6_Click" />
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button7" runat="server" Text="Computadores" Width="184px" OnClick="Button7_Click" />
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button8" runat="server" Text="Socios" Width="184px" OnClick="Button8_Click" />
            </div>
        </form>
    </body>
</html>
