<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CrearConsultaPaciente.aspx.cs" Inherits="ProyectoFinalPrograII.CrearConsultaPaciente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        <br style="font-size: small" />
        <span style="font-size: small">CONSULTA DEL PACIENTE</span></p>
    <p style="font-size: small">
        Id Consulta</p>
    <p>
        <asp:TextBox ID="txtIdConsulta" runat="server" style="font-size: small"></asp:TextBox>
    </p>
    <p style="font-size: small">
        NIT paciente</p>
    <p>
        <asp:TextBox ID="txtNITpaciente" runat="server" style="font-size: small"></asp:TextBox>
    </p>
    <p style="font-size: small">
        Fecha y hora de la consulta</p>
    <p>
        <asp:Calendar ID="cldConsulta" runat="server"></asp:Calendar>
    </p>
    <p style="font-size: small">
        Temperatura</p>
    <p>
        <asp:TextBox ID="txtTemperatura" runat="server" style="font-size: small"></asp:TextBox>
    </p>
    <p style="font-size: small">
        Presión</p>
    <p>
        <asp:TextBox ID="txtPresion" runat="server" style="font-size: small"></asp:TextBox>
    </p>
    <p style="font-size: small">
        Síntomas</p>
    <p>
        <asp:TextBox ID="txtSintomas" runat="server" style="font-size: small"></asp:TextBox>
        <asp:Button ID="btnIngresoSintoma" runat="server" style="font-size: small" Text="Ingreso Sintomas" OnClick="btnIngresoSintoma_Click" />
    </p>
    <p style="font-size: small">
        Diagnóstico</p>
    <p>
        <asp:TextBox ID="txtDiagnostico" runat="server" style="font-size: small"></asp:TextBox>
    </p>
    <p style="font-size: small">
        Tratamiento</p>
    <p>
        <asp:TextBox ID="txtTratamiento" runat="server" style="font-size: small"></asp:TextBox>
    </p>
    <p style="font-size: small">
        Receta</p>
    <p>
        <asp:TextBox ID="txtReceta" runat="server" style="font-size: small"></asp:TextBox>
    </p>
    <p style="font-size: small">
        Dosis</p>
    <p>
        <asp:TextBox ID="txtDosis" runat="server" style="font-size: small"></asp:TextBox>
    </p>
    <p style="font-size: small">
        Horas de Administración</p>
    <p>
        <asp:TextBox ID="txtHorasAdmin" runat="server" style="font-size: small"></asp:TextBox>
        <asp:Button ID="btnIngresoReceta" runat="server" style="font-size: small" Text="Ingreso Receta" OnClick="btnIngresoReceta_Click" />
    </p>
    <p style="font-size: small">
        Proxima visíta</p>
    <p>
        <asp:Calendar ID="cldProximaVisita" runat="server"></asp:Calendar>
    </p>
    <p style="font-size: small">
        Costo de consulta</p>
    <p>
        <asp:TextBox ID="txtCosto" runat="server" style="font-size: small"></asp:TextBox>
    </p>
    <p style="font-size: small">
        Imágenes varias</p>
    <p>
        <asp:FileUpload ID="FileUpload1" runat="server" />
    </p>
    <p>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:TemplateField>
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label1" runat="server"></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:ImageField ControlStyle-Width="100" ControlStyle-Height = "100" HeaderText="Imagen" DataImageUrlFormatString="imagenP">
                </asp:ImageField>
            </Columns>
        </asp:GridView>
    </p>
    <p>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </p>
    <p>
        <asp:Button ID="btnIngresoConsulta" runat="server" OnClick="btnIngresoConsulta_Click" style="font-size: small" Text="IngresoConsulta" />
    </p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
</asp:Content>
