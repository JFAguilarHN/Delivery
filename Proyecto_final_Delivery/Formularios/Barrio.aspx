<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="Barrio.aspx.cs" Inherits="Proyecto_final_Delivery.Formularios.Barrio" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
        .auto-style2 {
            top: 128px;
            left: 480px;
            position: absolute;
            height: 26px;
            width: 67px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <br />
    </p>
    <asp:Panel ID="Panel1" runat="server" Height="359px">
        <div class="auto-style1">
            BARRIO<asp:Label ID="Label1" runat="server" style="top: 164px; left: 58px; position: absolute; height: 19px; width: 66px" Text="Id Barrio"></asp:Label>
            <asp:Label ID="Label2" runat="server" style="top: 201px; left: 58px; position: absolute; height: 19px; width: 61px" Text="Nombre"></asp:Label>
            <asp:Label ID="Label3" runat="server" style="top: 244px; left: 58px; position: absolute; height: 19px; width: 76px" Text="Descripcion"></asp:Label>
            <asp:Label ID="Label4" runat="server" style="top: 291px; left: 51px; position: absolute; height: 19px; width: 91px" Text="Id Localidad"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server" style="top: 158px; left: 185px; position: absolute; height: 22px; width: 128px"></asp:TextBox>
            <asp:TextBox ID="TextBox2" runat="server" style="top: 196px; left: 185px; position: absolute; height: 22px; width: 128px"></asp:TextBox>
            <asp:TextBox ID="TextBox3" runat="server" style="top: 240px; left: 184px; position: absolute; height: 22px; width: 128px"></asp:TextBox>
            <asp:GridView ID="tabla" runat="server" style="top: 318px; left: 55px; position: absolute; height: 117px; width: 492px">
            </asp:GridView>
            <asp:Button ID="Button1" runat="server" Text="Agregar" OnClick="Button1_Click" CssClass="auto-style2" />
            <asp:Button ID="Button2" runat="server" style="top: 210px; left: 478px; position: absolute; height: 26px; width: 73px" Text="Actualizar" OnClick="Button2_Click" />
            <asp:Button ID="Button3" runat="server" style="top: 275px; left: 479px; position: absolute; height: 26px; width: 69px" Text="Eliminar" OnClick="Button3_Click" />
            <asp:DropDownList ID="Id_localidad" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" style="top: 286px; left: 184px; position: absolute; height: 11px; width: 94px">
            </asp:DropDownList>
        </div>
    </asp:Panel>
</asp:Content>
