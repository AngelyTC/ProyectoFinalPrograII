<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Editar_Medicamentos.aspx.cs" Inherits="ProyectoFinalPrograII.Editar_Medicamentos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>
        <br />
        Ingrese el codigo del medicamento que desea editar</h1>
    <h3>Ingresar código del medicamento</h3>
    <p>
        <asp:TextBox ID="TextBoxBuscarMedic" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="ButtonBuscarMedi" runat="server" OnClick="ButtonBuscarMedi_Click" Text="Buscar medicamento" />
    </p>
    <h3>Ingrediente génerico</h3>
    <p>
        <asp:TextBox ID="TextBoxIngreMedic" runat="server"></asp:TextBox>
    </p>
    <p>
        &nbsp;</p>
    <h3>Laboratorio (Marca Comercial)</h3>
    <p>
        <asp:TextBox ID="TextBoxLabMedic" runat="server"></asp:TextBox>
    </p>
    <p>
        &nbsp;</p>
    <h3>Listado de enfermedades para ser recetado </h3>
    <p>
        <asp:TextBox ID="TextBoxListadoMedic" runat="server"></asp:TextBox>
    </p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        <asp:Button ID="ButtonActualizarDatos" runat="server" Text="Actualizar datos" OnClick="ButtonActualizarDatos_Click" />
    </p>
</asp:Content>
