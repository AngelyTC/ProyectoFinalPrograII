<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Citas.aspx.cs" Inherits="ProyectoFinalPrograII.Citas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        <br />
        Citas</p>
    <p style="font-size: medium">
        Nit del paciente:<asp:TextBox ID="TextBoxnit" runat="server"></asp:TextBox>
    </p>
    <p style="font-size: medium">
        Fecha:<asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
    </p>
    <p style="font-size: medium">
        Hora inicio:<asp:TextBox ID="TextBoxHI" runat="server"></asp:TextBox>
    </p>
    <p style="font-size: medium">
        Hora fin:<asp:TextBox ID="TextBoxHf" runat="server"></asp:TextBox>
    </p>
    <p style="font-size: medium">
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Verificar" />
    </p>
    <p>
        <asp:Button ID="Button1" runat="server" Height="37px" OnClick="Button1_Click" Text="Agendar cita" Width="200px" />
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
