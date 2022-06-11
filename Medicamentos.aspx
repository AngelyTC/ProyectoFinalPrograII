<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Medicamentos.aspx.cs" Inherits="ProyectoFinalPrograII.Medicamentos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Ingreso de medicamentos</h1>
    <h4>Código del medicamento</h4>
    <p>
        <asp:TextBox ID="TextCodigoMedi" runat="server"></asp:TextBox>
    </p>
    <p>
        &nbsp;</p>
    <h4>Ingrediente génerico</h4>
    <p>
        <asp:TextBox ID="TextIngredienteMedi" runat="server"></asp:TextBox>
    </p>
    <p>
        &nbsp;</p>
    <h4>Laboratorio (Marca comercial)</h4>
    <p>
        <asp:TextBox ID="TextLabMedi" runat="server"></asp:TextBox>
    </p>
    <p>
        &nbsp;</p>
    <h4>Listado de enfermedades para recetar el medicamento</h4>
    <p>
        <asp:TextBox ID="TextListMedi" runat="server"></asp:TextBox>
&nbsp;-
        <asp:Button ID="ButtonIngresarEnfermedad" runat="server" OnClick="ButtonIngresarEnfermedad_Click" Text="Ingresar enfermedad" />
    </p>
    <asp:Button ID="ButtonIngresogeneral" runat="server" OnClick="ButtonIngresogeneral_Click" Text="INGRESAR DATOS" />
</asp:Content>
