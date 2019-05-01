using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using kiyas.la.Context;

namespace kiyas.la.Admin
{
    public partial class Detay : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadProductDetails();
            }

        }
        private void LoadProductDetails()
        {
            if (Request.QueryString["Id"] == null)
            {
                Response.Redirect("Listele.aspx");
            }
            else
            {
                int Id = int.Parse(Request.QueryString["Id"].ToString());
                using (KiyaslaContext db = new KiyaslaContext())
                {
                    var entity = (from i in db.SmartPhone
                                  where i.Id == Id
                                  select new
                                  {
                                      i.Id,
                                      i.TelefonMarkasi,
                                      i.TelefonModeli,
                                      i.RAM,
                                      i.Ekrancözünürlügü,
                                      i.ArkaKamerapixel,
                                      i.ÖnKamerapixel,
                                      i.İslemciMarkasi,
                                      i.İslemciModeli,
                                      i.İslemciHizi_Ghz,
                                      i.İslemciCekirdek,
                                      i.GrafikİslemciModeli,
                                      i.GrafikİslemciHizi_Mhz,
                                      i.DahiliDepolama_GB,
                                      i.Batarya_Mh,
                                      i.Agırlık_Gram,
                                      i.İsletimSistemi,
                                      i.SistemSürümü,
                                  }).FirstOrDefault();

                    if (entity != null)
                    {
                        TxtTlfnMarka.Text = entity.TelefonMarkasi;
                        TxtTlfnModel.Text = entity.TelefonModeli;
                        TxtRam.Text = entity.RAM.ToString();
                        TxtEkranCözürlügü.Text = entity.Ekrancözünürlügü;
                        TxtArkaKamera.Text = entity.ArkaKamerapixel.ToString();
                        TxtÖnKamerapixel.Text = entity.ÖnKamerapixel.ToString();
                        TxtİslemciMarkasi.Text = entity.İslemciMarkasi;
                        TxtİslemciModeli.Text = entity.İslemciModeli;
                        TxtİslemciHizi.Text = entity.İslemciHizi_Ghz.ToString();
                        TxtİslemciCekirdek.Text = entity.İslemciCekirdek.ToString();
                        TxtGrafikİslemciModeli.Text = entity.GrafikİslemciModeli;
                        TxtGrafikİslemciHizi.Text = entity.GrafikİslemciHizi_Mhz.ToString();
                        TxtDahiliDepolama.Text = entity.DahiliDepolama_GB.ToString();
                        TxtBatarya.Text = entity.Batarya_Mh.ToString();
                        TxtAgirlik.Text = entity.Agırlık_Gram.ToString();
                        TxtİsletimSistemi.Text = entity.İsletimSistemi;
                        TxtSistemSürümü.Text = entity.SistemSürümü;
                    }
                }
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["id"].ToString());
            using (KiyaslaContext db = new KiyaslaContext())
            {
                var entity = (from i in db.SmartPhone
                              where i.Id == id
                              select i).FirstOrDefault();

                if (entity != null)
                {
                    if (TxtTlfnMarka.Text != "")
                    {
                        if (entity.TelefonMarkasi != TxtTlfnMarka.Text.Trim())
                        {
                            entity.TelefonMarkasi = TxtTlfnMarka.Text.Trim();
                        }
                    }
                    else
                    {
                        ErrorMessage.Text = "Productname is required";
                        return;
                    }

                    entity.TelefonMarkasi = TxtTlfnMarka.Text.Trim();
                    entity.TelefonModeli = TxtTlfnModel.Text.Trim();
                    entity.RAM = int.Parse(TxtRam.Text.Trim());
                    entity.Ekrancözünürlügü = TxtEkranCözürlügü.Text.Trim();
                    entity.ArkaKamerapixel = double.Parse(TxtArkaKamera.Text.Trim());
                    entity.ÖnKamerapixel = double.Parse(TxtÖnKamerapixel.Text.Trim());
                    entity.İslemciMarkasi = TxtİslemciMarkasi.Text.Trim();
                    entity.İslemciModeli = TxtİslemciModeli.Text.Trim();
                    entity.İslemciHizi_Ghz = double.Parse(TxtİslemciHizi.Text.Trim());
                    entity.İslemciCekirdek = int.Parse(TxtİslemciCekirdek.Text.Trim());
                    entity.GrafikİslemciModeli = TxtGrafikİslemciModeli.Text.Trim();
                    entity.GrafikİslemciHizi_Mhz = double.Parse(TxtGrafikİslemciHizi.Text.Trim());
                    entity.DahiliDepolama_GB = double.Parse(TxtDahiliDepolama.Text.Trim());
                    if (MicroSdVarmiCheckbox.Checked == true)
                    {
                        entity.MicroSdVarmi = true;
                        entity.MicroSd_GB = int.Parse(TxtMicroSd.Text.Trim());
                    }
                    else
                    {

                        entity.MicroSdVarmi = false;
                        entity.MicroSd_GB = 0;
                    }
                    entity.Agırlık_Gram = double.Parse(TxtAgirlik.Text.Trim());
                    entity.İsletimSistemi = TxtİsletimSistemi.Text.Trim();
                    entity.SistemSürümü = TxtSistemSürümü.Text.Trim();

                    //entity.Description = txtDescription.Text.Trim();
                    //entity.Price = Convert.ToDouble(txtPrice.Text.Trim());
                    //entity.CategoryId = int.Parse(DDLCategory.SelectedValue);
                    // entity.ResimYol = resimUpload.FileName;

                    db.SaveChanges();
                    ErrorMessage.Text = "Ürün Değiştirildi...";
                }
            }
        }
    }
}