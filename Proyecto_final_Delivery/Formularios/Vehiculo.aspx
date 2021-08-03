<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="Vehiculo.aspx.cs" Inherits="Proyecto_final_Delivery.Formularios.Vehiculo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="Panel1" runat="server" Height="437px">
        <div class="auto-style1">
            VEHICULOS<asp:Label ID="Label1" runat="server" style="top: 91px; left: 82px; position: absolute; height: 19px; width: 71px" Text="Id Vehiculo"></asp:Label>
            <asp:Label ID="Label2" runat="server" style="top: 123px; left: 81px; position: absolute; height: 19px; width: 51px" Text="Patente"></asp:Label>
            <asp:Label ID="Label3" runat="server" style="top: 192px; left: 84px; position: absolute; height: 19px; width: 50px" Text="Modelo"></asp:Label>
            <asp:Label ID="Label4" runat="server" style="top: 240px; left: 83px; position: absolute; height: 19px; width: 104px" Text="Id Tipo Vehiculo"></asp:Label>
            <asp:Label ID="Label5" runat="server" style="top: 151px; left: 83px; position: absolute; height: 19px; " Text="Marca"></asp:Label>
            <asp:Label ID="Label6" runat="server" style="top: 278px; left: 84px; position: absolute; height: 19px; width: 120px" Text="Id Personal Entrega"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server" style="top: 85px; left: 250px; position: absolute; height: 22px; width: 128px" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
            <asp:TextBox ID="TextBox2" runat="server" style="top: 118px; left: 250px; position: absolute; height: 22px; width: 128px"></asp:TextBox>
            <asp:TextBox ID="TextBox3" runat="server" style="top: 156px; left: 250px; position: absolute; height: 22px; width: 128px" OnTextChanged="TextBox3_TextChanged"></asp:TextBox>
            <asp:TextBox ID="TextBox4" runat="server" style="top: 187px; left: 250px; position: absolute; height: 22px; width: 128px" OnTextChanged="TextBox4_TextChanged"></asp:TextBox>
            <asp:DropDownList ID="id_tipo_vehiculo" runat="server" style="top: 236px; left: 249px; position: absolute; height: 22px; width: 91px">
            </asp:DropDownList>
            <asp:GridView ID="tabla" runat="server" style="top: 307px; left: 81px; position: absolute; height: 133px; width: 457px">
            </asp:GridView>
            <asp:Button ID="Button1" runat="server" style="top: 89px; left: 456px; position: absolute; height: 26px; width: 67px" Text="Agregar" OnClick="Button1_Click" />
            <asp:Button ID="Button2" runat="server" style="top: 160px; left: 457px; position: absolute; height: 26px; width: 67px" Text="Actualizar" OnClick="Button2_Click" />
            <asp:Button ID="Button3" runat="server" style="top: 245px; left: 458px; position: absolute; height: 26px; width: 69px" Text="Eliminar" OnClick="Button3_Click" />
            <asp:DropDownList ID="idpersonalentrega" runat="server" style="top: 274px; left: 249px; position: absolute; height: 22px; width: 91px">
            </asp:DropDownList>
        </div>
    </asp:Panel>
    <p>
        <br />
    </p>
</asp:Content>
