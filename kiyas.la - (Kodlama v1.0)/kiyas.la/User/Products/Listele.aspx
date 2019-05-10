<%@ Page Title="" Language="C#" MasterPageFile="~/Folder/MasterPage/Main.Master"
    AutoEventWireup="true" CodeBehind="Listele.aspx.cs" Inherits="kiyas.la.User.Products.Listele" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <input id="hiddenProductType" name="hiddenProductType" type="hidden" value="-1" />
    <asp:DropDownList ID="Product1" runat="server" name="Product1" type="button" value="" class="btn btn-default dropdown-toggle">
    </asp:DropDownList>
    <span>vs</span>
    <asp:DropDownList ID="Product2" runat="server" name="Product2" type="button" value="" class="btn btn-default dropdown-toggle">
    </asp:DropDownList>
    <asp:Button ID="BtnKarsilastir" runat="server" Text="Karşılaştır" CssClass="btn btn-info"
        OnClick="BtnKarsilastir_Click" />
</asp:Content>
<asp:Content ID="sliderCont" ContentPlaceHolderID="sliderCont" runat="server">
    <asp:ListView ID="sliderListview" runat="server">
        <ItemTemplate>
            <div class="col-md-4" >
                <div class="item-box-blog" style="padding:30px;">
                    <div class="item-box-blog-image">
                        <!--Date-->
                        <div class="item-box-blog-date bg-blue-ui white">
                            <span class="mon" style="">Ocak <%#randomdate() %></span>
                        </div>
                        <!--Image-->
                        <figure><img src="<%#Eval("Fotograf") %>" alt="" />  </figure>
                    </div>
                    <div class="item-box-blog-body">
                        <!--Heading-->
                        <div class="item-box-blog-heading">
                            <a href="#" tabindex="0">
                                <h5>
                                    <%#Eval("TelefonMarkasi") %>
                                    <%#Eval("TelefonModeli") %>
                                </h5>
                            </a>
                        </div>
                        <!--Data-->
                        <!--Text-->
                        <div class="item-box-blog-text">
                            <p>
                                <%#Eval("İslemciMarkasi") %> <%#Eval("İslemciModeli") %><br />

                            </p>
                        </div>
                        <div class="mt"><a href="#" tabindex="0" class="btn bg-blue-ui white read">KIYASLA</a> </div>
                        <!--Read More Button-->
                    </div>
                </div>
            </div>
        </ItemTemplate>
    </asp:ListView>

</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContentHolder" runat="server">
    <div class="popularComparisons">
        <asp:ListView ID="ListView1" runat="server">
            <ItemTemplate>
                <div class="caption">
                    <img src="<%#Eval("Fotograf") %>" alt="" />
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
                    Arka Kamera
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
