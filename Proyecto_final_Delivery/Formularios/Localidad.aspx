<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="Localidad.aspx.cs" Inherits="Proyecto_final_Delivery.Formularios.Localidad" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="Panel1" runat="server" Height="323px">
        <div class="auto-style1">
            LOCALIDAD<asp:Label ID="Label1" runat="server" style="top: 73px; left: 67px; position: absolute; height: 19px; width: 83px" Text="Id Localidad"></asp:Label>
            <asp:Label ID="Label2" runat="server" style="top: 120px; left: 58px; position: absolute; height: 19px; width: 75px" Text="Nombre"></asp:Label>
            <asp:Label ID="Label3" runat="server" style="top: 168px; left: 64px; position: absolute; height: 19px; width: 98px" Text="Codigo Postal"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server" style="top: 115px; left: 196px; position: absolute; height: 22px; width: 128px"></asp:TextBox>
            <asp:DropDownList ID="id_localidad" runat="server" style="top: 70px; left: 197px; position: absolute; height: 22px; width: 91px">
            </asp:DropDownList>
            <asp:TextBox ID="TextBox2" runat="server" style="top: 160px; left: 197px; position: absolute; height: 22px; width: 128px"></asp:TextBox>
            <asp:GridView ID="tabla" runat="server" style="top: 213px; left: 10px; position: absolute; height: 133px; width: 482px">
            </asp:GridView>
            <asp:Button ID="Button1" runat="server" style="top: 49px; left: 426px; position: absolute; width: 64px" Text="Agregar" OnClick="Button1_Click" />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" style="top: 113px; left: 425px; position: absolute; height: 26px; width: 66px" Text="Actualizar" />
            <asp:Button ID="Button3" runat="server" style="top: 167px; left: 422px; position: absolute; height: 26px; width: 69px" Text="Eliminar" OnClick="Button3_Click" />
        </div>
    </asp:Panel>
    <p>
        <br />
    </p>
</asp:Content>
