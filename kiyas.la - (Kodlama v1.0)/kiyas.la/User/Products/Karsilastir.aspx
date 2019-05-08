<%@ Page Title="" Language="C#" MasterPageFile="~/Folder/MasterPage/Main.Master"
    AutoEventWireup="true" CodeBehind="Karsilastir.aspx.cs" Inherits="kiyas.la.User.Products.Karsilastir" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style type="text/css">
        .sol
        {
            float: left;
            width: 48%;
        }
        .sag
        {
            float: left;
            width: 48%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContentHolder" runat="server">
    <div class="sol">
        Ürün Adı:
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </div>
    <div class="sag">
        Ürün Adı:
        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
    </div>
</asp:Content>
