<%@ Page Title="" Language="C#" MasterPageFile="~/Folder/MasterPage/Admin.Master"
    AutoEventWireup="true" CodeBehind="ÜrünEslestir.aspx.cs" Inherits="kiyas.la.Admin.ÜrünEslestir" %>

<asp:Content ID="Content1" ContentPlaceHolderID="mainContentPlaceHolder" runat="server">
    <asp:Label ID="Label1" runat="server" Text="1. Eşleştirilecek Ürünü Seçiniz" class="text-primary"></asp:Label><br />
    <asp:DropDownList ID="Dropdownürün1" runat="server">
    </asp:DropDownList>
    <br />
    <asp:Label ID="Label2" runat="server" Text="2. Eşleştirilecek Ürünü Seçiniz" class="text-primary"></asp:Label><br />
    <asp:DropDownList ID="Dropdownürün2" runat="server">
    </asp:DropDownList>
    <br />
    <br />
    <asp:Button ID="BtnEslestir" runat="server" Text="Eşleştir" 
        onclick="BtnEslestir_Click" />
    <br />
    <br />
    <asp:Label ID="LblErrorMessage" runat="server" Text=""></asp:Label>
</asp:Content>
