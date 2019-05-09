<%@ Page Title="" Language="C#" MasterPageFile="~/Folder/MasterPage/Main.Master"
    AutoEventWireup="true" CodeBehind="Karsilastir.aspx.cs" Inherits="kiyas.la.User.Products.Karsilastir" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <%--    <style type="text/css">
        .sol
        {
            float: left;
            width: 50%;
        }
        .sag
        {
            float: left;
            width: 50%;
        }
        .karsilastir
        {
            float: inherit;
            width: 100%;
            font-family: @Tahoma;
            font-family: Tahoma;
        }
    </style>--%>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContentHolder" runat="server">
    <%--    <div class="sol">
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
    </div>--%>
    <div class="comparedItem persist-area">
        <div class="persist-header">
            <h1>
                Sony Xperia Z2 seçmek için <strong>haklı nedenleriniz</strong><a href="#top"><span>YUKARI</span>.:.</a>
            </h1>
            <div class="itemOSandSpecs">
                <span class="itemOS"><strong>4G </strong>, <strong>İşletim Sistemi : </strong>Google
                    Android 4.4 (KitKat), <strong>Yılı : </strong>2014</span> <span class="itemAllSpecs">
                        <a class="showFullSpecs cboxElement" href="/tr/cep-telefonu/Sony-Xperia-Z2/TeknikOzellikler/3054">
                            Sony Xperia Z2 tüm özelliklerini görmek için tıklayınız</a></span>
            </div>
            <div class="vsHeader">
                <table>
                    <tbody>
                        <tr>
                            <td class="vsHeaderLeft itemGreen">
                                <asp:Image ID="Urun1Img" runat="server" ImageAlign="Left" />
                                <span>
                                    <asp:Label ID="LblUrunMarkaAdi1" runat="server" Text=""></asp:Label></span>
                                <span>
                                    <asp:Label ID="LblUrunModelAdi1" runat="server" Text=""></asp:Label></span>
                            </td>
                            <td>
                                vs
                            </td>
                            <td class="vsHeaderRight itemBlue">
                                <asp:Image ID="Urun2Img" runat="server" ImageAlign="Right" />
                                <span>
                                    <asp:Label ID="LblUrunMarkaAdi2" runat="server" Text=""></asp:Label></span>
                                <span>
                                    <asp:Label ID="LblUrunModelAdi2" runat="server" Text=""></asp:Label></span>
                            </td>
                        </tr>
                    </tbody>
                </table>
            </div>
        </div>
        <div class="persist-header floatingHeader" style="width: 960px; visibility: hidden;">
            <h1>
                Sony Xperia Z2 seçmek için <strong>haklı nedenleriniz</strong><a href="#top"><span>YUKARI</span>.:.</a>
            </h1>
            <div class="vsHeader">
                <table>
                    <tbody>
                        <tr>
                            <td class="vsHeaderLeft itemGreen">
                                <span>Sony</span> <span>Xperia Z2</span>
                            </td>
                            <td>
                                vs
                            </td>
                            <td class="vsHeaderRight itemBlue">
                                <span>Sony</span> <span>Xperia Z3</span>
                            </td>
                        </tr>
                    </tbody>
                </table>
            </div>
        </div>
        <ul class="greenBlue">
            <li><span class="specImg">
                <img src="/Folder/Plugin/Site/icon/MEMORY.png" />
            </span><span class="itemProp">
                <center>
                    RAM Miktarı</center>
            </span><span class="itemFirst">
                <asp:Label ID="LblRam1" runat="server" Text=""></asp:Label>
            </span><span class="versus">vs</span><span class="itemSecond"><asp:Label ID="LblRam2"
                runat="server" Text=""></asp:Label>
            </span><span class="itemPropDesc">
                <center>
                    <asp:Label ID="LblKarsilastirmaRamSnc" runat="server" Text=""></asp:Label></center>
            </span></li>
            <li><span class="specImg">
                <img src="/Folder/Plugin/Site/icon/PROCESSOR.png" style="float: left" />
            </span><span class="itemProp">
                <center>
                    İşlemci Markasi</center>
            </span><span class="itemFirst">
                <center>
                    <asp:Label ID="LblİslemciMarkasi1" runat="server" Text=""></asp:Label></center>
            </span><span class="versus">vs</span> <span class="itemSecond">
                <center>
                    <asp:Label ID="LblİslemciMarkasi2" runat="server" Text=""></asp:Label></center>
            </span><span class="itemPropDesc">
                <center>
                    <asp:Label ID="LblKarsilastirmaİslemciMarkaSnc" runat="server" Text=""></asp:Label></center>
            </span></li>
            <li><span class="specImg">
                <img src="/Folder/Plugin/Site/icon/PROCESSOR_CORE_COUNT.png" style="float: left" />
            </span><span class="itemProp">
                <center>
                    İşlemci Hizi Ve Çekirdek</center>
            </span><span class="itemFirst">
                <center>
                    <asp:Label ID="LblIslemciHizCekirdek1" runat="server" Text=""></asp:Label></center>
            </span><span class="versus">vs</span> <span class="itemSecond">
                <center>
                    <asp:Label ID="LblIslemciHizCekirdek2" runat="server" Text=""></asp:Label></center>
            </span><span class="itemPropDesc">
                <center>
                    <asp:Label ID="LblKarsilastirmaİslemciHizCkrdkSnc" runat="server" Text=""></asp:Label></center>
            </span></li>
            <li><span class="specImg">
                <img src="/Folder/Plugin/Site/icon/CAMERA.png" style="float: left" />
            </span><span class="itemProp">
                <center>
                    Kamera</center>
            </span><span class="itemFirst">
                <center>
                    <asp:Label ID="LblArkaKamera1" runat="server" Text=""></asp:Label>MP</center>
            </span><span class="versus">vs</span> <span class="itemSecond">
                <center>
                    <asp:Label ID="LblArkaKamera2" runat="server" Text=""></asp:Label>MP</center>
            </span><span class="itemPropDesc">
                <center>
                    <asp:Label ID="LblArkaKameraSnc" runat="server" Text=""></asp:Label></center>
            </span></li>
        </ul>
    </div>
</asp:Content>
