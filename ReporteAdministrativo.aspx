<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ReporteAdministrativo.aspx.cs" Inherits="ProyectoFinalPrograII.ReporteAdministrativo" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
        <div>
            <h1>Reportes Administrativo:</h1>
            <p>&nbsp;</p>
            <p>Dia del mes con más pacientes:</p>
            <p>
                <asp:Button ID="btnDiaPacientes" runat="server" OnClick="btnDiaPacientes_Click" Text="Generar Reporte" />
&nbsp;&nbsp;
                <asp:Label ID="lbDiaMasPacientes" runat="server"></asp:Label>
            </p>
            <p>&nbsp;</p>
            <p>&nbsp;</p>
            <p>Total de pacientes atentidos entre dos fechas:</p>
            <p>Ingrese fecha 1:
                <asp:TextBox ID="txtFecha1" runat="server"></asp:TextBox>
            </p>
            <p>Ingrese fecha 2:
                <asp:TextBox ID="txtFecha2" runat="server"></asp:TextBox>
            </p>
            <p>
                <asp:Button ID="btnDosFechas" runat="server" OnClick="btnDosFechas_Click" Text="Generar Reporte" />
&nbsp;&nbsp;
                <asp:Label ID="lbEntreDosFechas" runat="server"></asp:Label>
            </p>
            <p>&nbsp;</p>
            <p>Total de pacientes que realizaron citas y no se presentaron:</p>
            <p>
                <asp:Button ID="btnSinPresentar" runat="server" Text="Generar Reporte" />
&nbsp;
                <asp:Label ID="lbSinPresentar" runat="server"></asp:Label>
            </p>
        </div>
        
</asp:Content>