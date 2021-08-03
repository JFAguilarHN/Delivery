<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="MENU.aspx.cs" Inherits="Proyecto_final_Delivery.Formularios.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <br />
    </p>
    <asp:Menu ID="Menu1" runat="server" OnMenuItemClick="Menu1_MenuItemClick">
        <Items>
            <asp:MenuItem NavigateUrl="~/Formularios/Barrio.aspx" Text="BARRIO" Value="BARRIO"></asp:MenuItem>
        </Items>
    </asp:Menu>
    <asp:XmlDataSource ID="XmlDataSource1" runat="server"></asp:XmlDataSource>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
</asp:Content>
