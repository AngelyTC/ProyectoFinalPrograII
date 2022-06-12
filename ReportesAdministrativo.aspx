<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ReportesAdministrativo.aspx.cs" Inherits="ProyectoFinalPrograII.ReportesAdministrativo" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
        <div>
            <h1>Reportes Administrativo:</h1>
            <p>&nbsp;</p>
            <p>Dia del mes con más pacientes:</p>
            <p>
                <asp:Button ID="btnReMasDias" runat="server" OnClick="btnReMasDias_Click" Text="Generar Reporte" />
&nbsp;&nbsp;
                <asp:Label ID="lbDiaMasPacientes" runat="server"></asp:Label>
            </p>
            <p>&nbsp;</p>
            <p>Total de pacientes atentidos entre dos fechas:</p>
            <p>Ingrese fecha 1:
                <asp:TextBox ID="txtFecha1" runat="server"></asp:TextBox>
            </p>
            <p>Ingrese fecha 2:
                <asp:TextBox ID="txtFecha2" runat="server"></asp:TextBox>
            </p>
            <p>
&nbsp;&nbsp;<asp:Button ID="btnReEntre" runat="server" OnClick="btnReEntre_Click" Text="Generar Reporte" />
&nbsp;<asp:Label ID="lbEntre" runat="server"></asp:Label>
            </p>
            <p>&nbsp;</p>
            <p>Total de pacientes que realizaron citas y no se presentaron:</p>
            <p>
&nbsp;<asp:Button ID="btnReNoLLega" runat="server" OnClick="btnReNoLLega_Click" Text="Generar Reporte" />
&nbsp;<asp:Label ID="lbSinPresentar" runat="server"></asp:Label>
            </p>
        </div>
        
</asp:Content>