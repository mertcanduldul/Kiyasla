using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using kiyas.la.Context;

namespace kiyas.la.Admin
{
    public partial class Listele : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                TelefonYükle();
            }
        }
        private void TelefonYükle()
        {
            using (KiyaslaContext db = new KiyaslaContext())
            {
                var yükle = (from i in db.SmartPhone
                             select new
                             {
                                 i.Id,
                                 i.TelefonMarkasi,
                                 i.TelefonModeli,
                                 i.İslemciMarkasi,
                                 i.İslemciModeli,
                                 i.İslemciCekirdek,
                                 i.İslemciHizi_Ghz,
                                 i.İsletimSistemi,
                                 i.Ekrancözünürlügü,
                             }).ToList();
                ÜrünListe.DataSource = yükle;
                ÜrünListe.DataBind();
            }

        }
    }
}



//<Columns>
//            <asp:BoundField DataField="Id" HeaderText="Id" />
//            <asp:BoundField DataField="TelefonMarkasi" HeaderText="Telefon Markasi" />
//            <asp:BoundField DataField="TelefonModeli" HeaderText="Telefon Modeli" />
//            <asp:BoundField DataField="İslemciMarkasi" HeaderText="İslemci Markası" />
//            <asp:BoundField DataField="İslemciModeli" HeaderText="İslemci Modeli" />
//            <asp:BoundField DataField="İslemciCekirdek" HeaderText="İslemci Kaç Çekirdek" />
//            <asp:BoundField DataField="İslemciHizi_Ghz" HeaderText="İslemci Hizi" />
//            <asp:BoundField DataField="İsletimSistemi" HeaderText="İsletim Sistemi" />
//            <asp:BoundField DataField="Ekrancözünürlügü" HeaderText="Ekran Çözünürlügü" />
//            <asp:TemplateField>
//                <ItemTemplate>
//                    <a href='Detay?id=<%#Eval("Id")%>'>Detay</a>
//                </ItemTemplate>
//            </asp:TemplateField>
//        </Columns>