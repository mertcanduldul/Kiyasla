<%@ Page Title="" Language="C#" MasterPageFile="~/Folder/MasterPage/Main.Master"
    AutoEventWireup="true" CodeBehind="Detay.aspx.cs" Inherits="kiyas.la.User.Products.Detay" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContentHolder" runat="server">
    <form id="form1" runat="server">
    <asp:ListView ID="ListView1" runat="server">
        <ItemTemplate>
            <div class="thumbnail" align="left">
                <img src="<%#Eval("Fotograf") %>" alt="" />
                <div class="caption" align="left">
                    <h2>
                        <a href='Detay?id=<%#Eval("Id")%>'>
                            <%#Eval("TelefonMarkasi") %>
                            <%#Eval("TelefonModeli")%>
                        </a>
                    </h2>
                    <ul class="newAndFuriousSpecs" text-align="left" style="float: left">
                        <li>
                            <img src="/Folder/Plugin/Site/icon/MEMORY.png" style="float: left" /><%#Eval("RAM")%>
                            RAM </li>
                        <br />
                        <li>
                            <img src="/Folder/Plugin/Site/icon/PROCESSOR.png" style="float: left" /><%#Eval("İslemciMarkasi")%>&nbsp<%#Eval("İslemciModeli")%></li>
                        <br />
                        <li>
                            <img src="/Folder/Plugin/Site/icon/PROCESSOR_CORE_COUNT.png" style="float: left" /><%#Eval("İslemciCekirdek")%>&nbspÇekirdek
                            <%#Eval("İslemciHizi_Ghz")%>
                            Ghz İşlemci </li>
                        <br />
                        <li>
                            <img src="/Folder/Plugin/Site/icon/CAMERA.png" style="float: left" />
                            Kamera
                            <%#Eval("ArkaKamerapixel")%>MP </li>
                        <br />
                        <br />
                        <li>
                            <img src="/Folder/Plugin/Site/icon/BATTERY_USAGE_TIME_3G.png" style="float: left" />
                            <%#Eval("Batarya_Mh")%>
                            MH Batarya </li>
                        <br />
                        <li>
                            <img src="/Folder/Plugin/Site/icon/DISK_STORAGE.png" style="float: left" /><%#Eval("DahiliDepolama_GB")%>
                            GB Dahili Depolama Alanı </li>
                        <br />
                </div>
            </div>
        </ItemTemplate>
    </asp:ListView>
    <asp:ListView ID="CommentView" runat="server">
        <ItemTemplate>
            <br />
            Yorum yazan:<%#Eval("Name") %><br />
            <br />
            <%#Eval("Yorum") %><br />
        </ItemTemplate>
    </asp:ListView>
    <br />
    <asp:TextBox ID="Isim" runat="server"></asp:TextBox><br />
    <br />
    <asp:TextBox ID="Yorum" runat="server" TextMode="MultiLine"></asp:TextBox><br />
    <br />
    <asp:Button ID="YrmEkle" runat="server" Text="Button" OnClick="YrmEkle_Click" /><br />
    </form>
</asp:Content>
