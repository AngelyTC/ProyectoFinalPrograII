<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CrearConsultaMedico.aspx.cs" Inherits="ProyectoFinalPrograII.CrearConsulta" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        <br />
        <span style="font-size: medium">CONSULTA PACIENTE</span></p>
    <p>
        Id Consulta</p>
    <p>
        <asp:TextBox ID="txtIdConsulta" runat="server"></asp:TextBox>
    </p>
    <p>
        NIT paciente</p>
    <p>
        <asp:TextBox ID="txtNITpaciente" runat="server"></asp:TextBox>
    </p>
    <p>
        Fecha y Hora de la consulta</p>
    <p>
        <asp:Calendar ID="txtFechaHora" runat="server"></asp:Calendar>
    </p>
    <p>
        Temperatura</p>
    <p>
        <asp:TextBox ID="txtTemperatura" runat="server"></asp:TextBox>
    </p>
    <p>
        Presión</p>
    <p>
        <asp:TextBox ID="txtPresion" runat="server"></asp:TextBox>
    </p>
    <p>
        Síntomas</p>
    <p>
        <asp:TextBox ID="txtSintomas" runat="server"></asp:TextBox>
    </p>
    <p>
        Diagnóstico</p>
    <p>
        <asp:TextBox ID="txtDiagnostico" runat="server"></asp:TextBox>
    </p>
    <p>
        Tratamiento</p>
    <p>
        <asp:TextBox ID="txtTratamiento" runat="server"></asp:TextBox>
    </p>
    <p>
        Receta</p>
    <p>
        <asp:TextBox ID="txtReceta" runat="server"></asp:TextBox>
    </p>
    <p>
        Próxima visita</p>
    <p>
        <asp:TextBox ID="txtNextVisit" runat="server" OnTextChanged="TextBox9_TextChanged"></asp:TextBox>
    </p>
    <p>
        Costo de consulta</p>
    <p>
        <asp:TextBox ID="txtCosto" runat="server"></asp:TextBox>
    </p>
    <p>
        Imágenes Varias</p>
    <p>
        &nbsp;</p>
    <p>
        <asp:Button ID="btnIngresoConsulta" runat="server" Text="IngresoConsulta" />
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
