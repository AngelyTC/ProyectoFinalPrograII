<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ReporteDinero.aspx.cs" Inherits="ProyectoFinalPrograII.ReporteDinero" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        REPORTE DINERO:<br />
    </p>
    <p>
        <asp:GridView ID="GridView1" runat="server" Height="269px" Width="529px">
        </asp:GridView>
    </p>
    <p>
        <asp:Label ID="Label1" runat="server" Text="Total:"></asp:Label>
        <asp:Label ID="Label2" runat="server" Text="-"></asp:Label>
    </p>
    <p>
        <asp:Button ID="btnVisualizar" runat="server" OnClick="btnVisualizar_Click" Text="Visualizar" />
    </p>
    <p>
    </p>
    <p>
    </p>
</asp:Content>
