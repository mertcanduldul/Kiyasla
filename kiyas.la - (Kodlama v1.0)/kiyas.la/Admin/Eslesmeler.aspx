<%@ Page Title="" Language="C#" MasterPageFile="~/Folder/MasterPage/Admin.Master"
    AutoEventWireup="true" CodeBehind="Eslesmeler.aspx.cs" Inherits="kiyas.la.Admin.Eslesmeler" %>

<asp:Content ID="Content1" ContentPlaceHolderID="mainContentPlaceHolder" runat="server">
    <asp:GridView ID="GridView1" runat="server" CssClass="table table-hover" AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField DataField="Id" HeaderText="Sıra" />
            <asp:BoundField DataField="TelefonMarkasi" HeaderText="1. Telefonun Markasi" />
            <asp:BoundField DataField="TelefonMarkasi2" HeaderText="2. Telefonun Markası" />
            <asp:TemplateField></asp:TemplateField>
        </Columns>
    </asp:GridView>
    <br />
    <a href="/Admin/ÜrünEslestir.aspx" class="btn btn-danger">Yeni Telefon Eşleştir</a>
</asp:Content>
