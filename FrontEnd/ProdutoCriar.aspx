<%@ Page Title="Criar Produto" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" 
    CodeBehind="ProdutoCriar.aspx.cs" Inherits="FrontEnd.ProdutoCriar" Async="true" %>

<asp:Content ID="MainContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Criar Produto</h2>

    <div class="form-group">
        <label>Nome do Produto:</label>
        <asp:TextBox ID="txtNome" runat="server" CssClass="form-control" />
    </div>

    <br />

    <asp:Button ID="btnSalvar" runat="server" Text="Salvar" CssClass="btn btn-primary" OnClick="btnSalvar_Click" />

    <br /><br />

    <asp:Label ID="lblMensagem" runat="server" ForeColor="Red" />
</asp:Content>
