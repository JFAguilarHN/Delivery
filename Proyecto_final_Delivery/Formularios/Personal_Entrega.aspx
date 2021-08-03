<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="Personal_Entrega.aspx.cs" Inherits="Proyecto_final_Delivery.Formularios.Personal_Entrega" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="Panel1" runat="server" Height="436px">
        <div class="auto-style1">
            <br />
            <br />
            PERSONAL DE ENTREGA<br />
            <asp:Label ID="Label1" runat="server" style="top: 164px; left: 46px; position: absolute; height: 19px; width: 121px" Text="Id Personal Entrega"></asp:Label>
            <asp:Label ID="Label2" runat="server" style="top: 201px; left: 41px; position: absolute; height: 19px; width: 103px" Text="Numero Carnet"></asp:Label>
            <asp:Label ID="Label3" runat="server" style="top: 244px; left: 45px; position: absolute; height: 19px; width: 120px" Text="Fecha_Vencimiento_Carnet"></asp:Label>
            <asp:Label ID="Label4" runat="server" style="top: 291px; left: 38px; position: absolute; height: 19px; width: 175px" Text="Id Estado Personal Entrega"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server" style="top: 195px; left: 227px; position: absolute; height: 22px; width: 95px"></asp:TextBox>
            <asp:TextBox ID="TextBox2" runat="server" style="top: 239px; left: 225px; position: absolute; height: 22px; width: 96px"></asp:TextBox>
            <asp:TextBox ID="TextBox3" runat="server" style="top: 284px; left: 225px; position: absolute; height: 22px; width: 95px"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" style="top: 155px; left: 340px; position: absolute; height: 26px; width: 67px" Text="Agregar" OnClick="Button1_Click" />
            <asp:Button ID="Button2" runat="server" style="top: 216px; left: 339px; position: absolute; height: 26px; width: 67px" Text="Actualizar" OnClick="Button2_Click" />
            <asp:Button ID="Button3" runat="server" style="top: 284px; left: 339px; position: absolute; height: 26px; width: 69px" Text="Eliminar" OnClick="Button3_Click" />
            <asp:GridView ID="tabla" runat="server" style="top: 328px; left: 42px; position: absolute; height: 117px; width: 516px">
            </asp:GridView>
            <asp:Calendar ID="Calendar1" runat="server" style="top: 110px; left: 420px; position: absolute; height: 130px; width: 72px" OnSelectionChanged="Calendar1_SelectionChanged"></asp:Calendar>
            <asp:Button ID="Button4" runat="server" style="top: 248px; left: 334px; position: absolute; height: 17px; width: 71px" Text="Calendario" OnClick="Button4_Click" />
            <asp:DropDownList ID="id_personal_entrega" runat="server" style="top: 161px; left: 232px; position: absolute; height: 22px; width: 91px">
            </asp:DropDownList>
        </div>
    </asp:Panel>
    <p>
        <br />
    </p>
</asp:Content>
