using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using kiyas.la.Context;
using kiyas.la.Entities;

namespace kiyas.la.Admin.Kategori
{
    public partial class Ekle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Phone a = new Phone();
            a.TelefonMarkasi = TxtTlfnMarka.Text;
            a.TelefonModeli = TxtTlfnModel.Text;
            using (KiyaslaContext db = new KiyaslaContext())
            {
                db.SmartPhone.Add(a);
                db.SaveChanges();
                ErrorMessage.Text = "SmartPhone Added...";
            }
        }
    }
}