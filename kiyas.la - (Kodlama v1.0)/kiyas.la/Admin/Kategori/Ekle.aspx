<%@ Page Title="" Language="C#" MasterPageFile="~/Folder/MasterPage/Admin.Master" AutoEventWireup="true" CodeBehind="Ekle.aspx.cs" Inherits="kiyas.la.Admin.Kategori.Ekle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="mainContentPlaceHolder" runat="server">
    <asp:Label ID="LblTlfnMarka" runat="server" Text="Telefon Markası"></asp:Label><br />
    <asp:TextBox ID="TxtTlfnMarka" runat="server"></asp:TextBox><br /><br />
    <asp:Label ID="LblTlfnModel" runat="server" Text="Telefon Modeli"></asp:Label><br /><br />
    <asp:TextBox ID="TxtTlfnModel" runat="server" Width="128px"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="ErrorMessage" runat="server" Text="   "></asp:Label>
    <br /><br />
    <asp:Button ID="Button1" runat="server" Text="Ekle" onclick="Button1_Click" />
</asp:Content>
