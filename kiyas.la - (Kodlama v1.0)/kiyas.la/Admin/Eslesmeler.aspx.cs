using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using kiyas.la.Context;

namespace kiyas.la.Admin
{
    public partial class Eslesmeler : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            EslesmeYükle();
        }
        private void EslesmeYükle()
        {
            using (KiyaslaContext db = new KiyaslaContext())
            {
                var yükle = (from i in db.Eslestirmeler
                             select new
                             {
                                 i.Id,
                                 i.TelefonMarkasi,
                                 i.TelefonMarkasi2,
                             }).ToList();
                GridView1.DataSource = yükle;
                GridView1.DataBind();
            }
        }
    }
}