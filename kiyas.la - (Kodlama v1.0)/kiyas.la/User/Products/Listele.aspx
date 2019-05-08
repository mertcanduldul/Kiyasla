<%@ Page Title="" Language="C#" MasterPageFile="~/Folder/MasterPage/Main.Master"
    AutoEventWireup="true" CodeBehind="Listele.aspx.cs" Inherits="kiyas.la.User.Products.Listele" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <input id="hiddenProductType" name="hiddenProductType" type="hidden" value="-1" />
    <asp:DropDownList ID="Product1" runat="server" name="Product1" type="" value="">
    </asp:DropDownList>
    <span>vs</span>
    <asp:DropDownList ID="Product2" runat="server" name="Product2" type="" value="">
    </asp:DropDownList>
    <asp:Button ID="BtnKarsilastir" runat="server" Text="Karşılaştır" CssClass="btn btn-info"
        OnClick="BtnKarsilastir_Click" />
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContentHolder" runat="server">
    <div class="popularComparisons">
        <asp:ListView ID="ListView1" runat="server">
            <ItemTemplate>
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
            </ItemTemplate>
        </asp:ListView>
    </div>
</asp:Content>
