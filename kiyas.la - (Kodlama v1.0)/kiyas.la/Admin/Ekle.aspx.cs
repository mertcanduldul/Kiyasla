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
            a.Ekrancözünürlügü = TxtEkranCözürlügü.Text;
            a.ArkaKamerapixel = double.Parse(TxtArkaKamera.Text);
            a.ÖnKamerapixel = double.Parse(TxtÖnKamerapixel.Text);
            a.İslemciMarkasi = TxtİslemciMarkasi.Text;
            a.İslemciModeli = TxtİslemciModeli.Text;
            a.İslemciHizi_Ghz = double.Parse(TxtİslemciHizi.Text);
            a.İslemciCekirdek = int.Parse(TxtİslemciCekirdek.Text);
            a.GrafikİslemciModeli = TxtGrafikİslemciModeli.Text;
            a.GrafikİslemciHizi_Mhz = int.Parse(TxtGrafikİslemciHizi.Text);
            a.DahiliDepolama_GB = int.Parse(TxtDahiliDepolama.Text);
            a.MicroSdVarmi = MicroSdVarmiCheckbox.Checked;
            a.MicroSd_GB = int.Parse(TxtMicroSd.Text);
            a.Batarya_Mh = int.Parse(TxtBatarya.Text);
            a.Agırlık_Gram = int.Parse(TxtAgirlik.Text);
            

            using (KiyaslaContext db = new KiyaslaContext())
            {
                if (String.IsNullOrEmpty(TxtTlfnMarka.Text) || String.IsNullOrEmpty(TxtTlfnModel.Text) || String.IsNullOrEmpty(TxtİsletimSistemi.Text))
                {
                    ErrorMessage.Text = "Değerler Boş Geçilemez";
                    return;
                }
                db.SmartPhone.Add(a);
                db.SaveChanges();
                ErrorMessage.Text = "Telefon Eklendi...";
            }
        }
    }
}