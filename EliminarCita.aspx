<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EliminarCita.aspx.cs" Inherits="ProyectoFinalPrograII.EliminarCita" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        <br />
        Eliminar Citas:</p>
    <p>
        Fecha:<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Buscar" />
    </p>
    <p>
        Nit de paciente:
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
    </p>
    <p>
        Hora inicio:<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    </p>
    <p>
        Hora fin:<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Delete" />
    </p>
</asp:Content>
