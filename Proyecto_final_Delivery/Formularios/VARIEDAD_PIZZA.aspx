<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="VARIEDAD_PIZZA.aspx.cs" Inherits="Formulario_de_clase.FORMULARIOS.MAESTROS.VARIEDAD_PIZZA" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <img alt="" class="auto-style1" src="../../imagenes/Sin-título-2.png" /></p>
    <p>
    </p>
    <p style="margin-left: 560px">
        NOMBRE<asp:TextBox ID="txt_nombre" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
    </p>
    <p style="margin-left: 560px">
        <asp:Label ID="Label2" runat="server" Text="INGREDIENTE"></asp:Label>
        <asp:TextBox ID="txt_ingrediente" runat="server" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
        <asp:GridView ID="tabla" runat="server" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Horizontal">
            <AlternatingRowStyle BackColor="#F7F7F7" />
            <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
            <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
            <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right" />
            <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
            <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
            <SortedAscendingCellStyle BackColor="#F4F4FD" />
            <SortedAscendingHeaderStyle BackColor="#5A4C9D" />
            <SortedDescendingCellStyle BackColor="#D8D8F0" />
            <SortedDescendingHeaderStyle BackColor="#3E3277" />
        </asp:GridView>
    </p>
    <p style="margin-left: 560px">
        <asp:Button ID="btn_agregar" runat="server" BackColor="#23B684" Font-Size="Large" ForeColor="White" OnClick="btn_agregar_Click" Text="AGREGAR" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btn_cancelar" runat="server" BackColor="#E91818" Font-Size="Large" ForeColor="White" OnClick="btn_cancelar_Click" Text="CANCELAR" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btn_salir" runat="server" BackColor="#032E46" Font-Size="Large" ForeColor="White" Text="SALIR" />
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
</asp:Content>
