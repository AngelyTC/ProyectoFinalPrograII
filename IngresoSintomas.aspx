<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="IngresoSintomas.aspx.cs" Inherits="ProyectoFinalPrograII.IngresoSintomas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p style="font-size: medium">
        <asp:Label ID="Label1" runat="server" ForeColor="Blue" style="font-size: x-large" Text="SÍNTOMAS"></asp:Label>
        <br />
    </p>
    <p style="font-size: medium">
        Código Síntoma</p>
    <p>
        <asp:TextBox ID="txtCodigoS" runat="server" style="font-size: medium"></asp:TextBox>
    </p>
    <p style="font-size: medium">
        Descripción Síntoma</p>
    <p>
        <asp:TextBox ID="txtDescripcionS" runat="server" style="font-size: medium"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="btnIngresoS" runat="server" OnClick="btnIngresoS_Click" Text="Ingreso Síntoma" style="font-size: medium" />
    </p>
    <p>
        <asp:Button ID="btnLimpiar" runat="server" OnClick="btnLimpiar_Click" style="font-size: large" Text="Limpiar" />
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
