<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Paciente.aspx.cs" Inherits="ProyectoFinalPrograII.Paciente" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
        <div>
            <h1>Paciente:</h1>
            <p>Nit del paciente:
                <asp:TextBox ID="txtNit" runat="server"></asp:TextBox>
            </p>
            <p>Nombre:
                <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
            </p>
            <p>Apellido:
                <asp:TextBox ID="TxtApellido" runat="server"></asp:TextBox>
            </p>
            <p>Direccion:
                <asp:TextBox ID="txtDireccion" runat="server"></asp:TextBox>
            </p>
            <p>Fecha de nacimiento:
                <asp:Calendar ID="CalendarNacimiento" runat="server"></asp:Calendar>
            </p>
            <p>Telefono:
                <asp:TextBox ID="txtTelefono" runat="server"></asp:TextBox>
            </p>
            <p>&nbsp;</p>
            <p>
                <asp:Button ID="btnAgregar" runat="server" OnClick="btnAgregar_Click" Text="Agregar Paciente" />
            </p>
        </div>
        
</asp:Content>