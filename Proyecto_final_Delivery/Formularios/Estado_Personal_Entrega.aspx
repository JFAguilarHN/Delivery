<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="Estado_Personal_Entrega.aspx.cs" Inherits="Proyecto_final_Delivery.Formularios.Estado_Personal_Entrega" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            text-align: center;
            top: 40px;
            left: 10px;
            position: absolute;
            height: 26px;
            width: 578px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="Panel1" runat="server" Height="381px">
        <div class="auto-style1">
            ESTADO PERSONAL ENTREGA<asp:Label ID="Label1" runat="server" style="top: 105px; left: 84px; position: absolute; height: 19px; width: 176px" Text="Id Estado Personal Entrega"></asp:Label>
            <asp:Label ID="Label2" runat="server" style="top: 157px; left: 86px; position: absolute; height: 19px; width: 61px" Text="Nombre"></asp:Label>
            <asp:Label ID="Label3" runat="server" style="top: 217px; left: 87px; position: absolute; height: 19px; width: 76px" Text="Descripcion"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server" style="top: 151px; left: 258px; position: absolute; height: 22px; width: 128px"></asp:TextBox>
            <asp:TextBox ID="TextBox2" runat="server" style="top: 210px; left: 258px; position: absolute; height: 22px; width: 128px" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" style="top: 97px; left: 444px; position: absolute; height: 26px; width: 67px" Text="Agregar" OnClick="Button1_Click" />
            <asp:Button ID="Button2" runat="server" style="top: 153px; left: 444px; position: absolute; height: 26px; width: 72px" Text="Actualizar" OnClick="Button2_Click" />
            <asp:Button ID="Button3" runat="server" style="top: 220px; left: 447px; position: absolute; height: 26px; width: 69px" Text="Eliminar" OnClick="Button3_Click" />
            <asp:GridView ID="tabla" runat="server" style="top: 252px; left: 87px; position: absolute; height: 133px; width: 427px">
            </asp:GridView>
            <asp:DropDownList ID="id_estado_personal_entrega" runat="server" style="top: 101px; left: 264px; position: absolute; height: 22px; width: 91px">
            </asp:DropDownList>
        </div>
    </asp:Panel>
    <p>
        <br />
    </p>
</asp:Content>
