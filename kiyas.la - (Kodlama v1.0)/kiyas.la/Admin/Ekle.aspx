<%@ Page Title="" Language="C#" MasterPageFile="~/Folder/MasterPage/Admin.Master"
    AutoEventWireup="true" CodeBehind="Ekle.aspx.cs" Inherits="kiyas.la.Admin.Kategori.Ekle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="mainContentPlaceHolder" runat="server">
    <div class="form-group">
        <asp:Label ID="LblTelefonMarka" runat="server" Text="Telefon Markası" class="text-primary"></asp:Label><br />
        <asp:TextBox ID="TxtTlfnMarka" runat="server" CssClass="form-control" placeholder="Telefon Markası"></asp:TextBox>
        <br />
    </div>
    <div class="form-group">
        <asp:Label ID="LblTelefonModel" runat="server" Text="Telefon Modeli" class="text-primary"></asp:Label><br />
        <asp:TextBox ID="TxtTlfnModel" runat="server" CssClass="form-control" placeholder="Telefon Modeli"></asp:TextBox>
        <br />
    </div>
    <div class="form-group">
        <asp:Label ID="LblTlfnFotograf" runat="server" Text="Telefonun Fotoğrafı" class="text-primary"></asp:Label><br />
        <asp:FileUpload ID="FileUpload" runat="server" /><br />
        <br />
    </div>
    <div class="form-group">
        <asp:Label ID="LblEkranCözünürlügü" runat="server" Text="Ekran Çözünürlüğü" class="text-primary"></asp:Label><br />
        <asp:TextBox ID="TxtEkranCözürlügü" runat="server" CssClass="form-control" placeholder="1920x1080"></asp:TextBox>
        <br />
    </div>
    <asp:Label ID="LblArkaKamera" runat="server" Text="Arka Kamera" class="text-primary"></asp:Label><br />
    <asp:TextBox ID="TxtArkaKamera" runat="server" CssClass="form-control" placeholder="Arka Kamera"></asp:TextBox><br />
    <asp:Label ID="ÖnKameraPixel" runat="server" Text="Ön Kamera(Selfie Kamerası)" class="text-primary"></asp:Label><br />
    <asp:TextBox ID="TxtÖnKamerapixel" runat="server" CssClass="form-control" placeholder="Ön Kamera"></asp:TextBox><br />
    <asp:Label ID="LblİslemciMarkasi" runat="server" Text="İslemci Markasi" class="text-primary"></asp:Label><br />
    <asp:TextBox ID="TxtİslemciMarkasi" runat="server" CssClass="form-control" placeholder="İşlemci Markası"></asp:TextBox><br />
    <asp:Label ID="LblİslemciModeli" runat="server" Text="İslemci Modeli" class="text-primary"></asp:Label><br />
    <asp:TextBox ID="TxtİslemciModeli" runat="server" CssClass="form-control" placeholder="İslemci Modeli"></asp:TextBox><br />
    <asp:Label ID="LblİslemciHizi" runat="server" Text="İşlemciHızı" class="text-primary"></asp:Label><br />
    <asp:TextBox ID="TxtİslemciHizi" runat="server" CssClass="form-control" placeholder="İslemci Hızı"></asp:TextBox><br />
    <asp:Label ID="LblİslemciCekirdek" runat="server" Text="İşlemcideki Çekirdek Sayısı"
        class="text-primary"></asp:Label><br />
    <asp:TextBox ID="TxtİslemciCekirdek" runat="server" CssClass="form-control" placeholder="Çekirdek Sayısı (1-16)"></asp:TextBox><br />
    <asp:Label ID="LblGrafikİslemciModeli" runat="server" Text="Grafik İşlemci Modeli"
        class="text-primary"></asp:Label><br />
    <asp:TextBox ID="TxtGrafikİslemciModeli" runat="server" CssClass="form-control" placeholder="Grafik İslemci Modeli"></asp:TextBox><br />
    <asp:Label ID="LblGrafikİslemciHizi" runat="server" Text="Grafik İslemci Hizi (Mhz)"
        class="text-primary"></asp:Label><br />
    <asp:TextBox ID="TxtGrafikİslemciHizi" runat="server" CssClass="form-control" placeholder="Grafik İslemci Hizi(Mhz)"></asp:TextBox><br />
    <asp:Label ID="LblDahiliDepolama" runat="server" Text="Dahili Depolama (GB)" class="text-primary"></asp:Label><br />
    <asp:TextBox ID="TxtDahiliDepolama" runat="server" CssClass="form-control" placeholder="Dahili Depolama (GB) "></asp:TextBox><br />
    <asp:CheckBox ID="MicroSdVarmiCheckbox" runat="server" class="text-danger" Text="&nbsp&nbsp Micro Sd Var mi ?" /><br />
    <br />
    <asp:Label ID="LblMicroSd" runat="server" Text="Micro SD İle Kaç Gb Kadar Destekleniyor"
        class="text-primary"></asp:Label><br />
    <asp:TextBox ID="TxtMicroSd" runat="server" CssClass="form-control" placeholder="Micro SD"></asp:TextBox><br />
    <asp:Label ID="LblBatarya" runat="server" Text="Batarya Mh" class="text-primary"></asp:Label><br />
    <asp:TextBox ID="TxtBatarya" runat="server" CssClass="form-control" placeholder="Batarya"></asp:TextBox><br />
    <asp:Label ID="Agırlık" runat="server" Text="Telefonun Ağırlığı" class="text-primary"></asp:Label><br />
    <asp:TextBox ID="TxtAgirlik" runat="server" CssClass="form-control" placeholder="Ağırlık (Gram)"></asp:TextBox><br />
    <asp:Label ID="LblİsletimSistemi" runat="server" Text="İşletim Sistemi" class="text-primary"></asp:Label><br />
    <asp:TextBox ID="TxtİsletimSistemi" runat="server" CssClass="form-control" placeholder="İşletim Sistemi"></asp:TextBox><br />
    <asp:Label ID="LblSistemSürümü" runat="server" Text="İşletim Sistemi Sürümü" class="text-primary"></asp:Label><br />
    <asp:TextBox ID="TxtSistemSürümü" runat="server" CssClass="form-control" placeholder="İşletim Sistemi Sürümü"></asp:TextBox><br />
    <asp:Label ID="ErrorMessage" runat="server" Text="" class="text-primary"></asp:Label><br />
    <asp:Button ID="Button1" runat="server" Text="Ekle" OnClick="Button1_Click" class="btn btn-primary" />
    <br />
    <br />
    <br />
    <br />
</asp:Content>
