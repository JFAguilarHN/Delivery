<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="Tipo_Vehiculo.aspx.cs" Inherits="Proyecto_final_Delivery.Formularios.Tipo_Vehiculo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 578px;
            position: absolute;
            left: 10px;
            top: 34px;
        }
        .auto-style2 {
            text-align: center;
            top: 0px;
            left: 0px;
            position: absolute;
            height: 19px;
            width: 578px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="Panel1" runat="server" CssClass="auto-style1" Height="396px">
        <div class="auto-style2">
            TIPO DE VEHICULO<asp:Label ID="Label1" runat="server" style="top: 52px; left: 101px; position: absolute; height: 19px; width: 106px" Text="Id Tipo Vehiculo"></asp:Label>
            <asp:Label ID="Label2" runat="server" style="top: 104px; left: 105px; position: absolute; height: 19px; width: 34px" Text="Tipo_Vehiculo"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server" style="top: 46px; left: 235px; position: absolute; height: 22px; width: 128px"></asp:TextBox>
        </div>
        <asp:TextBox ID="TextBox2" runat="server" style="top: 99px; left: 233px; position: absolute; height: 22px; width: 128px"></asp:TextBox>
        <asp:GridView ID="tabla" runat="server" style="top: 161px; left: 104px; position: absolute; height: 133px; width: 359px">
        </asp:GridView>
        <asp:Button ID="Button1" runat="server" style="top: 44px; left: 393px; position: absolute; height: 26px; width: 67px" Text="Agregar" OnClick="Button1_Click" />
        <asp:Button ID="Button2" runat="server" style="top: 86px; left: 394px; position: absolute; height: 26px; width: 67px" Text="Actualizar" OnClick="Button2_Click" />
        <asp:Button ID="Button3" runat="server" style="top: 126px; left: 393px; position: absolute; height: 26px; width: 69px" Text="Eliminar" OnClick="Button3_Click" />
    </asp:Panel>
    <p>
        <br />
    </p>
</asp:Content>
