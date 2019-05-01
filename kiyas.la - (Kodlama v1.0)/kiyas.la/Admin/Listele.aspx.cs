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
                                 i.RAM,
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