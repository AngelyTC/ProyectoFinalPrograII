<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ReporteEnfermedadesComunes.aspx.cs" Inherits="ProyectoFinalPrograII.ReporteEnfermedadesComunes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        Repororte Enfermedad Comun<br />
    </p>
    <p>
        <asp:GridView ID="GridView1" runat="server" Height="203px" Width="412px">
        </asp:GridView>
    </p>
    <p>
        <asp:Button ID="btnVer" runat="server" OnClick="btnVer_Click" Text="Ver" />
    </p>
</asp:Content>
