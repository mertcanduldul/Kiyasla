<%@ Page Title="" Language="C#" MasterPageFile="~/Folder/MasterPage/Main.Master"
    AutoEventWireup="true" CodeBehind="Listele.aspx.cs" Inherits="kiyas.la.User.Products.Listele" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContentHolder" runat="server">
    <asp:ListView ID="ListView1" runat="server">
        <ItemTemplate>
            <div class="thumbnail">
                <img src="<%#Eval("Fotograf") %>" alt="" />
                <div class="caption">
                    <h2>
                        <%#Eval("TelefonMarkasi") %> <%#Eval("TelefonModeli")%>
                    </h2>
                    
                    <%#Eval("İslemciMarkasi")%>
                    <%#Eval("İslemciModeli")%>
                </div>
            </div>
        </ItemTemplate>
    </asp:ListView>
</asp:Content>
