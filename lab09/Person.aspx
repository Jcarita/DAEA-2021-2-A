<%@ Page Title="Person" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Person.aspx.cs" Inherits="lab09.Person" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div >
        <div class="row">
            <div class="col-md-4 mb-3">
                <asp:Label ID="Label1" Text="Nombre:" 
                    runat="server" />
                <asp:TextBox ID="txtNombre" CssClass="form-control" 
                    placeholder="Ingrese nombre" runat="server"/>
            </div>
            <div class="col-md-4 mb-3">
                <asp:Label ID="Label2" runat="server"
                    Text="Apellido:" AssociatedControlID="txtNombre"/>
                <asp:TextBox runat="server" ID="txtApellido"
                    CssClass="form-control" placeholder="Ingrese Apellido"/>
            </div>
            <div class="col-md-4 mb-3">
                <asp:Label runat="server" ID="Label3"
                    Text="Usuario:" AssociatedControlID="txtUsuario"/>
                <div class="input-group">
                    <div class="input-group-prepend">
                        <span class="input-group-text" id="inputGroupPrepend2">@</span>
                    </div>
                    <asp:TextBox runat="server" ID="txtUsuario"
                        CssClass="form-control" placeholder-="Usuario"
                        aria-describedby="inputGroupPrepend2"/>
                </div>
            </div>
        </div>

        <div class="form-row">
            <div class="col-md-6 mb-3">
                <asp:Label runat="server" id="Label4" 
                    Text="Departamento:"/>
                <asp:DropDownList runat="server" ID="ddlDepartamento" 
                    CssClass="form-control">

                    <asp:ListItem Text="Administracion" Value="1" />
                    <asp:ListItem Text="Contabilidad" Value="2" />
                    <asp:ListItem Text="Recursos Humanos" Value="3" />
                    <asp:ListItem Text="TI" Value="4" />
                
                </asp:DropDownList>
            </div>
            <div class="col-md-6 mb-3">
                <asp:Label ID="label5" runat="server"
                    Text="Direccion"/>
                <asp:TextBox runat="server" ID="txtDireccion" 
                    CssClass="form-control" placeholder="Ingrese direccion"/>
            </div>
        </div>

        <div class="form-group">
            <div class="form-check">
                <asp:CheckBox ID="CheckBox1" runat="server" CssClass="form-check-input"/>
                <asp:Label ID="Label6" Text="Aceptar los terminos y condiciones" 
                    runat="server" AssociatedControlID="CheckBox1"/>
            </div>
        </div>

        <asp:Button 
                    ID="btnSaludar" 
                    Text="Saludar" 
                    CssClass="btn btn-primary" 
                    runat="server" 
                    OnClick="btnSaludar_Click" />
    </div>
</asp:Content>
