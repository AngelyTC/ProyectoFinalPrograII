<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ReporteConsulta.aspx.cs" Inherits="ProyectoFinalPrograII.ReporteConsulta" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        <br />
        REPORTE DE CONSULTA - EDADES PROMEDIO</p>
    <p>
        &nbsp;</p>
    <p>
        <asp:Button ID="Buttongenerargrid" runat="server" BackColor="#00FF99" OnClick="Buttongenerargrid_Click" Text="GENERAR DATOS" />
    </p>
    <p>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </p>
</asp:Content>
