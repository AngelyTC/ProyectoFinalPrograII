<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TotalDinero.aspx.cs" Inherits="ProyectoFinalPrograII.TotalDinero" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        Total de dinero ingresado entre dos fechas:</p>
    <p>
        Fecha 1:<asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
    </p>
    <p>
        Fecha 2:
        <asp:Calendar ID="Calendar2" runat="server"></asp:Calendar>
    </p>
    <p>
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
    </p>
    <p>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Mostrar total" />
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
