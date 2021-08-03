<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="Barrio_Por_Calle.aspx.cs" Inherits="Proyecto_final_Delivery.Formularios.Barrio_Por_Calle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="Panel1" runat="server" Height="372px">
        <div class="auto-style1">
            BARRIO POR CALLE<asp:Label ID="Label1" runat="server" style="top: 105px; left: 90px; position: absolute; height: 19px; width: 115px" Text="Id Barrio por Calle"></asp:Label>
            <asp:Label ID="Label2" runat="server" style="top: 145px; left: 92px; position: absolute; height: 19px; width: 55px" Text="Id Barrio"></asp:Label>
            <asp:Label ID="Label3" runat="server" style="top: 189px; left: 94px; position: absolute; height: 19px; width: 55px" Text="Id Calle"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server" style="top: 96px; left: 235px; position: absolute; height: 22px; width: 128px"></asp:TextBox>
            <asp:GridView ID="tabla" runat="server" style="top: 231px; left: 95px; position: absolute; height: 133px; width: 457px">
            </asp:GridView>
            <asp:Button ID="Button1" runat="server" style="top: 87px; left: 483px; position: absolute; height: 26px; width: 67px" Text="Agregar" OnClick="Button1_Click" />
            <asp:Button ID="Button2" runat="server" style="top: 138px; left: 478px; position: absolute; height: 26px; width: 72px" Text="Actualizar" OnClick="Button2_Click" />
            <asp:Button ID="Button3" runat="server" style="top: 183px; left: 480px; position: absolute; height: 26px; width: 69px" Text="Eliminar" OnClick="Button3_Click" />
            <asp:DropDownList ID="id_barrio" runat="server" style="top: 141px; left: 237px; position: absolute; height: 22px; width: 91px">
            </asp:DropDownList>
            <asp:DropDownList ID="id_calle" runat="server" style="top: 184px; left: 238px; position: absolute; height: 22px; width: 91px">
            </asp:DropDownList>
        </div>
    </asp:Panel>
    <p>
        <br />
    </p>
</asp:Content>
