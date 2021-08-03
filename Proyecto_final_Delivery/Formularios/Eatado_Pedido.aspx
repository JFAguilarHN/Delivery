<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="Eatado_Pedido.aspx.cs" Inherits="Proyecto_final_Delivery.Formularios.Eatado_Pedido" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="Panel1" runat="server" Height="410px">
        <div class="auto-style1">
            ESTADO_PEDIDO<asp:Label ID="Label2" runat="server" style="top: 138px; left: 82px; position: absolute; height: 19px; width: 61px" Text="Nombre"></asp:Label>
            <asp:Label ID="Label3" runat="server" style="top: 180px; left: 81px; position: absolute; height: 19px; width: 76px" Text="Descripcion"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server" style="top: 96px; left: 235px; position: absolute; height: 22px; width: 128px"></asp:TextBox>
            <asp:TextBox ID="TextBox2" runat="server" style="top: 138px; left: 235px; position: absolute; height: 22px; width: 128px"></asp:TextBox>
            <asp:TextBox ID="TextBox3" runat="server" style="top: 180px; left: 235px; position: absolute; height: 22px; width: 128px"></asp:TextBox>
            <asp:Label ID="Label1" runat="server" style="top: 91px; left: 81px; position: absolute; height: 22px; width: 106px; bottom: 353px;" Text="Id EstadoPedido"></asp:Label>
            <asp:Button ID="Button1" runat="server" style="top: 87px; left: 456px; position: absolute; height: 26px; width: 67px" Text="Agregar" OnClick="Button1_Click" />
            <asp:Button ID="Button2" runat="server" style="top: 138px; left: 455px; position: absolute; width: 72px" Text="Actualizar" OnClick="Button2_Click" />
            <asp:Button ID="Button3" runat="server" style="top: 183px; left: 455px; position: absolute; height: 26px; width: 69px" Text="Eliminar" OnClick="Button3_Click" />
            <asp:GridView ID="tabla" runat="server" style="top: 231px; left: 86px; position: absolute; height: 133px; width: 445px">
            </asp:GridView>
        </div>
    </asp:Panel>
    <p>
        <br />
    </p>
</asp:Content>
