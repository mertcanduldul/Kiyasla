<%@ Page Title="" Language="C#" MasterPageFile="~/Folder/MasterPage/Main.Master"
    AutoEventWireup="true" CodeBehind="Detay.aspx.cs" Inherits="kiyas.la.User.Products.Detay" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContentHolder" runat="server">
    <asp:ListView ID="ListView1" runat="server">
        <ItemTemplate>
            <div class="thumbnail">
                <img src="<%#Eval("Fotograf") %>" alt="" />
                <div class="caption">
                    <h2>
                        <a href='Detay?id=<%#Eval("Id")%>'>
                            <%#Eval("TelefonMarkasi") %>
                            <%#Eval("TelefonModeli")%>
                        </a>
                    </h2>
                    <%#Eval("İslemciMarkasi")%>
                    <%#Eval("İslemciModeli")%><br />
                    <%#Eval("İslemciCekirdek")%>
                    Çekirdek
                    <%#Eval("İslemciHizi_Ghz")%>
                    Ghz İşlemci
                    <br />
                    Ön Kamera
                    <%#Eval("ArkaKamerapixel")%>MP
                    <%#Eval("Batarya_Mh")%>
                    MH Batarya<br />
                    <%#Eval("DahiliDepolama_GB")%>
                    GB Dahili Depolama Alanı<br />
                </div>
            </div>
        </ItemTemplate>
    </asp:ListView>
</asp:Content>
