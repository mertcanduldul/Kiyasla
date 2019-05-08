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
        <ul class="newAndFuriousSpecs">
            Ürün Adı:
            <asp:Image ID="Urun1Img" runat="server" /><br />
            <asp:Label ID="LblUrunAdi1" runat="server" Text=""></asp:Label><br />
            <br />
            <li>
                <img src="/Folder/Plugin/Site/icon/MEMORY.png" style="float: left" /><asp:Label ID="LblRam1"
                    runat="server" Text=""></asp:Label>RAM<br />
            </li>
            <br />
            <li>
                <img src="/Folder/Plugin/Site/icon/PROCESSOR.png" style="float: left" /><asp:Label
                    ID="LblİslemciMarkasi1" runat="server" Text="Label"></asp:Label><br />
            </li>
            <br />
            <li>
                <img src="/Folder/Plugin/Site/icon/PROCESSOR_CORE_COUNT.png" style="float: left" /><asp:Label
                    ID="LblIslemciHizCekirdek1" runat="server" Text="Label"></asp:Label><br />
            </li>
            <br />
            <li>
                <img src="/Folder/Plugin/Site/icon/CAMERA.png" style="float: left" /><asp:Label ID="LblArkaKamera1"
                    runat="server" Text="Label"></asp:Label>MP<br />
            </li>
            <br />
            <li>
                <img src="/Folder/Plugin/Site/icon/BATTERY_USAGE_TIME_3G.png" style="float: left" /><asp:Label
                    ID="LblBatarya1" runat="server" Text="Label"></asp:Label>Mh<br />
            </li>
            <br />
            <li>
                <img src="/Folder/Plugin/Site/icon/DISK_STORAGE.png" style="float: left" /><asp:Label
                    ID="LblDepolama1" runat="server" Text="Label"></asp:Label>GB<br />
            </li>
        </ul>
        <br />
    </div>
    <div class="sag">
        <ul class="newAndFuriousSpecs">
            Ürün Adı:
            <asp:Image ID="Urun2Img" runat="server" /><br />
            <asp:Label ID="LblUrunAdi2" runat="server" Text=""></asp:Label><br />
            <br />
            <li>
                <img src="/Folder/Plugin/Site/icon/MEMORY.png" style="float: left" /><asp:Label ID="LblRam2"
                    runat="server" Text=""></asp:Label>RAM<br />
            </li>
            <br />
            <li>
                <img src="/Folder/Plugin/Site/icon/PROCESSOR.png" style="float: left" /><asp:Label
                    ID="LblİslemciMarkasi2" runat="server" Text="Label"></asp:Label><br />
            </li>
            <br />
            <li>
                <img src="/Folder/Plugin/Site/icon/PROCESSOR_CORE_COUNT.png" style="float: left" /><asp:Label
                    ID="LblIslemciHizCekirdek2" runat="server" Text="Label"></asp:Label><br />
            </li>
            <br />
            <li>
                <img src="/Folder/Plugin/Site/icon/CAMERA.png" style="float: left" /><asp:Label ID="LblArkaKamera2"
                    runat="server" Text="Label"></asp:Label>MP<br />
            </li>
            <br />
            <li>
                <img src="/Folder/Plugin/Site/icon/BATTERY_USAGE_TIME_3G.png" style="float: left" /><asp:Label
                    ID="LblBatarya2" runat="server" Text="Label"></asp:Label>Mh<br />
            </li>
            <br />
            <li>
                <img src="/Folder/Plugin/Site/icon/DISK_STORAGE.png" style="float: left" /><asp:Label
                    ID="LblDepolama2" runat="server" Text="Label"></asp:Label>GB<br />
            </li>
        </ul>
        <br />
    </div>
</asp:Content>
