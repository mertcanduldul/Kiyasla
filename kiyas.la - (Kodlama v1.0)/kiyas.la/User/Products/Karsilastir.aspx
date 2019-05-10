<%@ Page Title="" Language="C#" MasterPageFile="~/Folder/MasterPage/Main.Master"
    AutoEventWireup="true" CodeBehind="Karsilastir.aspx.cs" Inherits="kiyas.la.User.Products.Karsilastir" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContentHolder" runat="server">
    <div class="comparedItem persist-area">
        <div class="persist-header">
            <h1>
                <a href="#top"><span></span></a>
            </h1>
            <div class="itemOSandSpecs">
                <span class="itemOS"><strong></strong> <strong></strong><strong></strong></span>
                <span class="itemAllSpecs"><a class="showFullSpecs cboxElement" href="#"></a></span>
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
                    <asp:Label ID="LblArkaKamera1" runat="server" Text=""></asp:Label></center>
            </span><span class="versus">vs</span> <span class="itemSecond">
                <center>
                    <asp:Label ID="LblArkaKamera2" runat="server" Text=""></asp:Label></center>
            </span><span class="itemPropDesc">
                <center>
                    <asp:Label ID="LblArkaKameraSnc" runat="server" Text=""></asp:Label></center>
            </span></li>
            <li><span class="specImg">
                <img src="/Folder/Plugin/Site/icon/BATTERY_USAGE_TIME_3G.png" />
            </span><span class="itemProp">
                <center>
                    Batarya Mh</center>
            </span><span class="itemFirst">
                <center>
                    <asp:Label ID="LblBatarya1" runat="server" Text=""></asp:Label>Mh</center>
            </span><span class="versus">vs</span> <span class="itemSecond">
                <center>
                    <asp:Label ID="LblBatarya2" runat="server" Text=""></asp:Label>Mh</center>
            </span><span class="itemPropDesc">
                <center>
                    <asp:Label ID="LblBataryaSnc" runat="server" Text=""></asp:Label></center>
            </span></li>
            <li><span class="specImg">
                <img src="/Folder/Plugin/Site/icon/DISK_STORAGE.png" style="float: left" />
            </span><span class="itemProp">
                <center>
                    Depolama Alanı</center>
            </span><span class="itemFirst">
                <center>
                    <asp:Label ID="LblDepolama1" runat="server" Text=""></asp:Label></center>
            </span><span class="versus">vs</span> <span class="itemSecond">
                <center>
                    <asp:Label ID="LblDepolama2" runat="server" Text=""></asp:Label></center>
            </span><span class="itemPropDesc">
                <center>
                    <asp:Label ID="LblDepolamaSnc" runat="server" Text=""></asp:Label></center>
            </span></li>
            <li><span class="specImg">
                <img src="/Folder/Plugin/Site/icon/CAMERA.png" style="float: left" />
            </span><span class="itemProp">
                <center>
                    Ön Kamera</center>
            </span><span class="itemFirst">
                <center>
                    <asp:Label ID="LblOnKmr1" runat="server" Text=""></asp:Label></center>
            </span><span class="versus">vs</span> <span class="itemSecond">
                <center>
                    <asp:Label ID="LblOnKmr2" runat="server" Text=""></asp:Label></center>
            </span><span class="itemPropDesc">
                <center>
                    <asp:Label ID="LblOnKmrSnc" runat="server" Text=""></asp:Label></center>
            </span></li>
        </ul>
    </div>
</asp:Content>
