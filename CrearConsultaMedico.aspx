<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CrearConsultaMedico.aspx.cs" Inherits="ProyectoFinalPrograII.CrearConsulta" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        <br style="font-size: small" />
        <span style="font-size: small">CONSULTA PACIENTE</span></p>
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
    <p>
        <span style="font-size: small">Fecha y Hora de la consulta</p>
    <p>
        <asp:Calendar ID="txtFechaHora" runat="server"></asp:Calendar>
    </p>
    <p>
        Temperatura</span></p>
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
        <asp:Button ID="btnIngreSintomas" runat="server" OnClick="btnIngreSintomas_Click" Text="Ingrese sintomas" />
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
    <p style="font-size: medium">
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
        Horas de administración</p>
    <p>
        <asp:TextBox ID="txtHorasAdmin" runat="server" style="font-size: small"></asp:TextBox>
        <asp:Button ID="btnIngresoReceta" runat="server" OnClick="btnIngresoReceta_Click" style="font-size: small" Text="IngresoReceta" />
    </p>
    <p style="font-size: small">
        Próxima visita</p>
    <p>
        <asp:TextBox ID="txtNextVisit" runat="server" OnTextChanged="TextBox9_TextChanged" style="font-size: small"></asp:TextBox>
    </p>
    <p style="font-size: small">
        Costo de consulta</p>
    <p>
        <asp:TextBox ID="txtCosto" runat="server" style="font-size: small"></asp:TextBox>
    </p>
    <p>
        <span style="font-size: small">Imágenes Varias</p>
    <p>
        <asp:FileUpload ID="FileUpload1" runat="server" />
    </p>
    <p>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:ImageField DataImageUrlField="imagenesP" ControlStyle-Width="100" ControlStyle-Height = "100" HeaderText="Imagen">
                </asp:ImageField>
                <asp:BoundField DataField="IdConsulta" HeaderText="Id consulta" />
                <asp:BoundField DataField="FechaHoraConsultas" HeaderText="Fecha consulta" />
                <asp:BoundField DataField="TemperaturaP" HeaderText="Temperatura" />
                <asp:BoundField DataField="PresionP" HeaderText="Presion" />
                <asp:BoundField DataField="CodigoMedicamento" HeaderText="CodigoMedicamento" />
                <asp:BoundField DataField="sintomasPaciente" HeaderText="Síntomas" />
                <asp:BoundField DataField="DiagnosticoP" HeaderText="Diagnóstico" />
                <asp:BoundField DataField="TratamientoP" HeaderText="Tratamiento" />
                <asp:BoundField DataField="RecetaP" HeaderText="Receta" />
                <asp:BoundField DataField="VisitaProximaP" HeaderText="VistitaProxima" />
                <asp:BoundField DataField="CostoConsultaP" HeaderText="CostoConsulta" />
                <asp:BoundField />
                <asp:TemplateField>
                    <EditItemTemplate>
                        <asp:CheckBox ID="CheckBox1" runat="server" />
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:CheckBox ID="CheckBox1" runat="server" />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </p>
    <p>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </span>
    </p>
    <p>
        <asp:Button ID="btnIngresoConsulta" runat="server" OnClick="btnIngresoConsulta_Click" style="font-size: small" Text="IngresoConsulta" />
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
    <p>
    </p>
    <p>
    </p>
</asp:Content>
