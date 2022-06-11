<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditarSintomas.aspx.cs" Inherits="ProyectoFinalPrograII.EditarSintomas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        <br />
    </p>
    <p>
        <asp:Label ID="Label1" runat="server" ForeColor="Blue" style="font-size: large" Text="EDITAR SÍNTOMAS"></asp:Label>
    </p>
    <p style="font-size: medium">
        Ingrese código del síntoma</p>
    <p>
        <asp:TextBox ID="txtCódigoEditarS" runat="server" style="font-size: medium"></asp:TextBox>
        <asp:Button ID="btnBuscarSintoma" runat="server" OnClick="btnBuscarSintoma_Click" Text="Buscar" />
    </p>
    <p style="font-size: medium">
        Descripción</p>
    <p>
        <asp:TextBox ID="txtDescripciónE" runat="server" style="font-size: medium"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="btnEditar" runat="server" OnClick="btnEditar_Click" style="font-size: medium" Text="Editar" />
    </p>
    <p>
        &nbsp;</p>
    <p>
    </p>
    <p>
    </p>
</asp:Content>
