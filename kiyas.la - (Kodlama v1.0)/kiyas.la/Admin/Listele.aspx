<%@ Page Title="" Language="C#" MasterPageFile="~/Folder/MasterPage/Admin.Master"
    AutoEventWireup="true" CodeBehind="Listele.aspx.cs" Inherits="kiyas.la.Admin.Listele" %>

<asp:Content ID="Content1" ContentPlaceHolderID="mainContentPlaceHolder" runat="server">
    <asp:GridView ID="ÜrünListe" runat="server" CssClass="table table-hover" AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField DataField="Id" HeaderText="Id" />
            <asp:BoundField DataField="TelefonMarkasi" HeaderText="Telefon Markası" />
            <asp:BoundField DataField="TelefonModeli" HeaderText="Telefon Modeli" />
            <asp:BoundField DataField="İslemciMarkasi" HeaderText="İslemci Markası" />
            <asp:BoundField DataField="İslemciModeli" HeaderText="İslemci Modeli" />
            <asp:BoundField DataField="İslemciCekirdek" HeaderText="İslemci Çekirdek Sayısı" />
            <asp:BoundField DataField="İslemciHizi_Ghz" HeaderText="İslemci Hızı (Ghz)" />
            <asp:BoundField DataField="İsletimSistemi" HeaderText="İşletim Sistemi" />
            <asp:BoundField DataField="EkranCözünürlügü" HeaderText="Ekran Çözünürlüğü" />
            <asp:TemplateField>
                <ItemTemplate>
                    <a href='Detay.aspx?Id=<%#Eval("Id")%>'>Detay </a>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
    <br />
    <a href="/Admin/Ekle.aspx" class="btn btn-danger">Yeni Telefon Ekle</a>
</asp:Content>
