<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ReporteMedicamento.aspx.cs" Inherits="ProyectoFinalPrograII.ReporteMedicamento" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
        <div>
            <h1>Reportes Medicamentos:</h1>
            <p>
                <asp:Button ID="btnRepoMedicamento" runat="server" OnClick="btnRepoMedicamento_Click" Text="Generar Reporte" />
            </p>
            <p>&nbsp;</p>
            <p>
                <asp:GridView ID="GridView1" runat="server">
                </asp:GridView>
            </p>
        </div>
        
</asp:Content>
