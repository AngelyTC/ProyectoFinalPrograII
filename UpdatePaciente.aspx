<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UpdatePaciente.aspx.cs" Inherits="ProyectoFinalPrograII.UpdatePaciente" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
        <div>
            <h1>Editar Paciente:</h1>
            <p>Nit del paciente:
                <asp:TextBox ID="txtBuscar" runat="server"></asp:TextBox>
            </p>
            <p>
                <asp:Button ID="btnBuscar" runat="server" OnClick="btnBuscar_Click" Text="Buscar Paciente" />
            </p>
            <p>&nbsp;</p>
            <p>Nombre:
                <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
            </p>
            <p>Apellido:
                <asp:TextBox ID="TxtApellido" runat="server"></asp:TextBox>
            </p>
            <p>Direccion:
                <asp:TextBox ID="txtDireccion" runat="server"></asp:TextBox>
            </p>
            <p>Telefono:
                <asp:TextBox ID="txtTelefono" runat="server"></asp:TextBox>
            </p>
            <p>&nbsp;</p>
            <p>
                <asp:Button ID="btnActualizar" runat="server" Enabled="False" OnClick="btnActualizar_Click" Text="Actualizar paciente" />
            </p>
        </div>
        
</asp:Content>