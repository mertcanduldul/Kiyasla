using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using kiyas.la.Context;
using kiyas.la.Entities;

namespace kiyas.la.Admin
{
    public partial class ÜrünEslestir : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                using (KiyaslaContext db = new KiyaslaContext())
                {
                    var cat = db.SmartPhone.ToList();

                    Dropdownürün1.DataSource = cat;
                    Dropdownürün1.DataTextField = "TelefonMarkasi";
                    Dropdownürün1.DataValueField = "Id";
                    Dropdownürün1.DataBind();

                    Dropdownürün2.DataSource = cat;
                    Dropdownürün2.DataTextField = "TelefonMarkasi";
                    Dropdownürün2.DataValueField = "Id";
                    Dropdownürün2.DataBind();
                }
            }

        }

        protected void BtnEslestir_Click(object sender, EventArgs e)
        {

            Eslestir a = new Eslestir();
            a.SecilenSira = Dropdownürün1.SelectedIndex;
            a.SecilenSira2 = Dropdownürün2.SelectedIndex;
            a.TelefonMarkasi = Dropdownürün1.SelectedItem.ToString();
            a.TelefonMarkasi2 = Dropdownürün2.SelectedItem.ToString();

            if (a.SecilenSira == a.SecilenSira2 || a.TelefonMarkasi == a.TelefonMarkasi2)
            {
                LblErrorMessage.Text = "Aynı Ürünler Karşılaştırılamaz";
            }
            else
            {
                using (KiyaslaContext db = new KiyaslaContext())
                {
                    db.Eslestirmeler.Add(a);
                    db.SaveChanges();
                    LblErrorMessage.Text = "Ürünler Eşleştirildi";
                }
            }

            //using (KiyaslaContext db = new KiyaslaContext())
            //{
            //    var bul = (from i in db.SmartPhone
            //               where i.Id == a.SecilenSira
            //               select i).FirstOrDefault();


            //}





        }

    }
}