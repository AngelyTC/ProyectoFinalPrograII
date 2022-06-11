<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditarSintomasPaciente.aspx.cs" Inherits="ProyectoFinalPrograII.EditarSintomasPaciente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        <br />
        EDITAR SÍNTOMAS</p>
    <p>
        Ingrese código de síntoma</p>
    <p>
        <asp:TextBox ID="txtCodigoSintomaE" runat="server"></asp:TextBox>
        <asp:Button ID="btnBuscar" runat="server" OnClick="btnBuscar_Click" Text="Buscar" />
    </p>
    <p>
        Descripción</p>
    <p>
        <asp:TextBox ID="txtDescripcionSintomaE" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="btnEditar" runat="server" OnClick="btnEditar_Click" Text="Editar" />
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
