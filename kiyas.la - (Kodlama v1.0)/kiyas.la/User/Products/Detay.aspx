<%@ Page Title="" Language="C#" MasterPageFile="~/Folder/MasterPage/Main.Master"
    AutoEventWireup="true" CodeBehind="Detay.aspx.cs" Inherits="kiyas.la.User.Products.Detay" EnableEventValidation="false" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContentHolder" runat="server">
    <link href="https://maxcdn.bootstrapcdn.com/font-awesome/4.3.0/css/font-awesome.min.css" rel="stylesheet" />
    <link href="../../Folder/Plugin/Detaycss/css.css" rel="Stylesheet" />
    <div class="popularComparisons">
        <asp:ListView ID="ListView1" runat="server">
            <ItemTemplate>
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
                    </ul>
                </div>
            </ItemTemplate>
        </asp:ListView>
    </div>
    <asp:ListView ID="CommentView" runat="server">
        
        <ItemTemplate>
            <ul class="media-list">
                <li class="media" style="margin: 25px;">
                    <a href="#" class="pull-left">
                        <img id="img1" src='<%#Eval("randomphoto") %>' alt="" class="img-circle">
                    </a>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<div class="media-body">
                        <span class="text-muted pull-right">
                            <small class="text-muted"><%#((DateTime.Now)-((DateTime)Eval("Time"))).Minutes%> dakika önce  </small>
                        </span>
                        <strong class="text-success">@<%#Eval("Name")%></strong><p><%#Eval("Yorum") %></p>
                    </div>

                </li>
                <hr />
        </ItemTemplate>
    </asp:ListView>
    <div class="container">
        <div class="be-comment-block">
            <div class="row">
                <div class="col-xs-12 col-sm-6">
                    <div class="form-group fl_icon">
                        <div class="icon"><i class="fa fa-user"></i></div>
                        <!--  <input id="Isim" class="form-input" type="text" placeholder="Isminizi Giriniz ...">-->
                        <asp:TextBox ID="Isim" runat="server" class="form-input" type="text" placeholder="Isminizi Giriniz ..."></asp:TextBox>
                    </div>
                </div>
                <div class="col-xs-12 col-sm-6 fl_icon">
                    <div class="form-group fl_icon">
                        <div class="icon"><i class="fa fa-envelope-o"></i></div>
                         <input class="form-input" type="text" placeholder="Mail Adresiniz">
                    </div>
                </div>
                <div class="col-xs-12">
                    <div class="form-group">
                        <asp:TextBox ID="Yorum" runat="server" TextMode="MultiLine" class="form-input" Width="863"></asp:TextBox>
                        <!--  <textarea id="Yorum" class="form-input" required="" placeholder="Yorum Yazınız ..."></textarea>-->
                    </div>
                </div>
                <asp:Button ID="YrmEkle" runat="server" type="button" class="btn btn-primary pull-right" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false" Text="Yorum Ekle !" OnClick="YrmEkle_Click" style="margin:auto;"/>
            </div>
        </div>
    </div>

</asp:Content>
