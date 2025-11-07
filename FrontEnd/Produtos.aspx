<%@ Page Async="true" Title="Produtos" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Produtos.aspx.cs" Inherits="FrontEnd.Produtos" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Produtos</h2>

    <asp:Label ID="lblErro" runat="server" ForeColor="Red" />

    <asp:GridView ID="gvProdutos" runat="server" AutoGenerateColumns="false" 
        CssClass="table table-striped" EmptyDataText="Nenhum produto encontrado">

        <Columns>
            <asp:BoundField DataField="Id" HeaderText="ID" />
            <asp:BoundField DataField="Nome" HeaderText="Nome" />
        </Columns>

    </asp:GridView>

</asp:Content>
