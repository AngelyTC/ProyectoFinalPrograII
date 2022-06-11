<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Medicamentos.aspx.cs" Inherits="ProyectoFinalPrograII.Medicamentos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>
        HOSPITAL LA ULTIMA CAMA</h1>
    <h3>
        Ingreso de medicamentos</h3>
    <p>
        Código del medicamento</p>
    <asp:TextBox ID="TextBoxCodigoMedi" runat="server"></asp:TextBox>
    <br />
    <br />
    Ingrediente genérico<br />
    <br />
    <asp:TextBox ID="TextBoxIngreMedi" runat="server"></asp:TextBox>
    <br />
    <br />
    Laboratorio (Marca Comercial)<br />
    <br />
    <asp:TextBox ID="TextBoxLabMedi" runat="server"></asp:TextBox>
    <br />
    <br />
    Listado de enfermedades para ser recetado<br />
    <br />
    <asp:TextBox ID="TextBoxListadoMedi" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="ButtonIngresoListadoMedi" runat="server" Text="Ingreso de enfermedades" OnClick="ButtonIngresoListadoMedi_Click" />
    <br />
    <br />
    <asp:Button ID="Button1" runat="server" Text="Ingreso de todos datos " />
    <br />
</asp:Content>
