<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SintomasPaciente.aspx.cs" Inherits="ProyectoFinalPrograII.SintomasPaciente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        SÍNTOMAS</p>
    <p>
        Código Síntoma</p>
    <p>
        <asp:TextBox ID="txtCodigoSintoma" runat="server"></asp:TextBox>
    </p>
    <p>
        Descripción Sintoma</p>
    <p>
        <asp:TextBox ID="txtDescripcionSintoma" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="btnIngreso" runat="server" Height="36px" OnClick="btnIngreso_Click" Text="Ingresar" />
    </p>
    <asp:Button ID="btnLimpiar" runat="server" OnClick="btnLimpiar_Click" Text="Limpiar" />
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
</asp:Content>
