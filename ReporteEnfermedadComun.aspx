<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ReporteEnfermedadComun.aspx.cs" Inherits="ProyectoFinalPrograII.ReporteEnfermedadComun" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        <br />
        Enfermedades Comunes</p>
    <p>
        <asp:GridView ID="GridView1" runat="server" Height="312px" Width="740px">
            <Columns>
                <asp:BoundField DataField="DiagnosticoP" HeaderText="Enfermedad" />
            </Columns>
        </asp:GridView>
    </p>
    <p>
        <asp:Button ID="btnBuscar" runat="server" OnClick="btnBuscar_Click" Text="Buscar" />
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
