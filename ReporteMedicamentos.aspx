<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ReporteMedicamentos.aspx.cs" Inherits="ProyectoFinalPrograII.ReporteMedicamentos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        <br />
        Medicamentos más utilizados:</p>
    <p>
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
    </p>
    <p>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Visualizar" />
    </p>
    <p>
    </p>
    <p>
    </p>
</asp:Content>
