<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="Localidad_Por_Barrio.aspx.cs" Inherits="Proyecto_final_Delivery.Formularios.Localidad_Por_Barrio" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            text-align: center;
            top: 36px;
            left: 10px;
            position: absolute;
            height: 26px;
            width: 578px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="Panel1" runat="server" Height="359px">
        <div class="auto-style1">
            LOCALIDAD POR BARRIO<asp:Label ID="Label1" runat="server" style="top: 92px; left: 47px; position: absolute; height: 19px; width: 162px" Text="Id Localidad por Barrio"></asp:Label>
            <asp:Label ID="Label2" runat="server" style="top: 137px; left: 51px; position: absolute; height: 24px; width: 90px" Text="Id Localidad"></asp:Label>
            <asp:Label ID="Label3" runat="server" style="top: 187px; left: 49px; position: absolute; height: 19px; width: 72px" Text="Id Barrio"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server" style="top: 86px; left: 224px; position: absolute; height: 22px; width: 128px"></asp:TextBox>
            <asp:GridView ID="tabla" runat="server" style="top: 231px; left: 59px; position: absolute; height: 133px; width: 455px">
            </asp:GridView>
            <asp:Button ID="Button1" runat="server" style="top: 72px; left: 444px; position: absolute; height: 26px; width: 67px" Text="Agregar" OnClick="Button1_Click" />
            <asp:Button ID="Button2" runat="server" style="top: 136px; left: 447px; position: absolute; height: 26px; width: 65px" Text="Actualizar" OnClick="Button2_Click" />
            <asp:Button ID="Button3" runat="server" style="top: 194px; left: 444px; position: absolute; height: 26px; width: 69px" Text="Eliminar" OnClick="Button3_Click" />
            <asp:DropDownList ID="idlocalidad" runat="server" OnSelectedIndexChanged="idlocalida_SelectedIndexChanged" style="top: 133px; left: 223px; position: absolute; height: 22px; width: 91px">
            </asp:DropDownList>
        </div>
        <br />
        <br />
        <asp:DropDownList ID="idbarrio" runat="server" style="top: 220px; left: 235px; position: absolute; height: 17px; width: 91px">
        </asp:DropDownList>
    </asp:Panel>
    <p>
        <br />
    </p>
    <p>
    </p>
</asp:Content>
