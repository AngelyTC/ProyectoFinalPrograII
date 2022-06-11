<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditarMedicamentos.aspx.cs" Inherits="ProyectoFinalPrograII.EditarMedicamentos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Actualizar medicamentos</h1>
    <p>
        &nbsp;</p>
    <p>
        Ingrese el código del medicamento</p>
    <p>
        <asp:TextBox ID="TextCodMedi" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="ButtonBuscarMedi" runat="server" OnClick="Button1_Click" Text="Buscar medicamento" />
    </p>
    <p>
        &nbsp;</p>
    <p>
        Ingrediente genérico</p>
    <p>
        <asp:TextBox ID="TextIngreMedi" runat="server"></asp:TextBox>
    </p>
    <p>
        &nbsp;</p>
    <p>
        Laboratorio (Marca Comercial)</p>
    <p>
        <asp:TextBox ID="TextLabMedi" runat="server"></asp:TextBox>
    </p>
    <p>
        &nbsp;</p>
    <p>
        <asp:Button ID="ButtonActualizarDatos" runat="server" OnClick="ButtonActualizarDatos_Click" Text="ACTUALIZAR DATOS" />
    </p>
</asp:Content>
