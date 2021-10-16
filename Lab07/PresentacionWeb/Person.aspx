<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Person.aspx.cs" Inherits="PresentacionWeb.Person" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <div >
        <div class="row">
            <div class="col-md-4 mb-3">
                <asp:Label ID="Label1" Text="Nombre:"
                    runat="server" />
                <asp:TextBox ID="txtFirstName" CssClass="form-control"
                    placeholder="Ingrese nombre" runat="server"/>
            </div>
            <div class="col-md-4 mb-3">
                <asp:Label ID="Label2" runat="server"
                    Text="Apellido:" AssociatedControlID="txtLastName"/>
                <asp:TextBox runat="server" ID="txtLastName"
                    CssClass="form-control" placeholder="Ingrese Apellido"/>
            </div>
            <div class="col-md-4 mb-3">
                <asp:Label runat="server" ID="Label3"
                    Text="Fecha de contratación:" AssociatedControlID="txtHireDate"/>
                <asp:TextBox runat="server" TextMode="Date" ID="txtHireDate" CssClass="form-control"/>
            </div>
        </div>

          <div class="form-group">
                <asp:Label runat="server" ID="Label4"
                    Text="Fecha de inscripción:" AssociatedControlID="txtEnrollmentDate"/>
                <asp:TextBox runat="server" TextMode="Date" ID="txtEnrollmentDate" CssClass="form-control"/>
            </div>

        <asp:Button
                    ID="btnRegistrar"
                    Text="Registrar"
                    CssClass="btn btn-primary"
                    runat="server" OnClick="btnRegistrar_Click" />
    </div>
    <br />
    <asp:GridView 
        CssClass="table"
        ID="dgvDatos" runat="server"></asp:GridView>
</asp:Content>
