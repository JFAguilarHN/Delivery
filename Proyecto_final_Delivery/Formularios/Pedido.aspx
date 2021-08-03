<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="Pedido.aspx.cs" Inherits="Proyecto_final_Delivery.Formularios.Pedido" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p class="auto-style1">
        <br />
        REGISTRO DE PEDIDOS</p>
    <asp:Panel ID="Panel1" runat="server" Height="605px">
        <asp:Label ID="Label1" runat="server" Text="Id Pedido" style="top: 138px; left: 23px; position: absolute; height: 19px; width: 63px"></asp:Label>
        <asp:Label ID="Label2" runat="server" style="top: 167px; left: 26px; position: absolute; height: 19px; width: 34px" Text="Numero"></asp:Label>
        <asp:Label ID="Label3" runat="server" style="top: 196px; left: 24px; position: absolute; height: 19px; width: 96px" Text="Fecha Creacion"></asp:Label>
        <asp:Label ID="Label4" runat="server" style="top: 224px; left: 23px; position: absolute; height: 19px; width: 95px" Text="Hora Creacion"></asp:Label>
        <asp:Label ID="Label5" runat="server" style="top: 253px; left: 24px; position: absolute; height: 19px; width: 89px" Text="Id Localidad"></asp:Label>
        <asp:Label ID="Label7" runat="server" style="top: 286px; left: 24px; position: absolute; height: 19px; width: 119px" Text="Id Personal entrega"></asp:Label>
        <asp:Label ID="Label8" runat="server" style="top: 322px; left: 25px; position: absolute; height: 19px; width: 105px" Text="Id Estado pedido"></asp:Label>
        <asp:Label ID="Label9" runat="server" style="top: 351px; left: 28px; position: absolute; height: 17px; width: 75px" Text="Id Fectura"></asp:Label>
        <asp:Label ID="Label10" runat="server" style="top: 383px; left: 26px; position: absolute; height: 19px; width: 101px" Text="Nombre Cliente"></asp:Label>
        <asp:Label ID="Label11" runat="server" style="top: 413px; left: 27px; position: absolute; height: 19px; width: 99px" Text="Telefono Cliente"></asp:Label>
        <asp:Label ID="Label13" runat="server" style="top: 445px; left: 28px; position: absolute; height: 19px; width: 109px" Text="Id Detalle pedido"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" style="top: 143px; left: 168px; position: absolute; height: 14px; width: 98px"></asp:TextBox>
        <asp:TextBox ID="TextBox2" runat="server" style="top: 167px; left: 168px; position: absolute; height: 14px; width: 97px"></asp:TextBox>
        <asp:TextBox ID="TextBox3" runat="server" style="top: 195px; left: 166px; position: absolute; height: 14px; width: 101px"></asp:TextBox>
        <asp:TextBox ID="TextBox4" runat="server" style="top: 222px; left: 166px; position: absolute; height: 14px; width: 99px"></asp:TextBox>
        <asp:TextBox ID="TextBox5" runat="server" style="top: 251px; left: 165px; position: absolute; height: 15px; width: 101px"></asp:TextBox>
        <asp:TextBox ID="TextBox6" runat="server" style="top: 285px; left: 166px; position: absolute; height: 15px; width: 104px"></asp:TextBox>
        <asp:TextBox ID="TextBox7" runat="server" style="top: 320px; left: 165px; position: absolute; height: 14px; width: 105px"></asp:TextBox>
        <asp:TextBox ID="TextBox8" runat="server" style="top: 350px; left: 164px; position: absolute; height: 15px; width: 106px"></asp:TextBox>
        <asp:TextBox ID="TextBox9" runat="server" style="top: 381px; left: 163px; position: absolute; height: 12px; width: 105px"></asp:TextBox>
        <asp:TextBox ID="TextBox10" runat="server" style="top: 412px; left: 164px; position: absolute; height: 15px; width: 104px"></asp:TextBox>
        <asp:TextBox ID="TextBox11" runat="server" style="top: 444px; left: 163px; position: absolute; height: 14px; width: 106px"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" style="top: 451px; left: 308px; position: absolute; height: 26px; width: 66px" Text="Agregar" OnClick="Button1_Click" />
        <asp:Button ID="Button2" runat="server" style="top: 451px; left: 396px; position: absolute; height: 26px; width: 69px" Text="Actualizar" OnClick="Button2_Click" />
        <asp:Button ID="Button3" runat="server" style="top: 450px; left: 489px; position: absolute; height: 26px; width: 73px" Text="Eliminar" OnClick="Button3_Click" />
        <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" style="top: 196px; left: 279px; position: absolute; height: 20px; width: 96px" Text="Selec fecha" />
        <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" style="top: 214px; left: 279px; position: absolute; width: 97px; bottom: 228px" Text="Selec hora" />
        <asp:Calendar ID="Calendar1" runat="server" style="top: 134px; left: 405px; position: absolute; height: 164px; width: 153px" OnSelectionChanged="Calendar1_SelectionChanged"></asp:Calendar>
        <asp:GridView ID="tabla" runat="server" style="top: 500px; left: 35px; position: absolute; height: 153px; width: 537px">
        </asp:GridView>
    </asp:Panel>
</asp:Content>
