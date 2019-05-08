using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using kiyas.la.Context;

namespace kiyas.la.User.Products
{
    public partial class Karsilastir : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["p1"] != null && Request.QueryString["p2"] != null)
                {
                    int p1Id = int.Parse(Request.QueryString["p1"].ToString());
                    int p2Id = int.Parse(Request.QueryString["p2"].ToString());
                    using (KiyaslaContext db = new KiyaslaContext())
                    {
                        var p1 = (from i in db.SmartPhone
                                  where i.Id == p1Id
                                  select i).FirstOrDefault();
                        var p2 = (from i in db.SmartPhone
                                  where i.Id == p2Id
                                  select i).FirstOrDefault();
                        LblUrunAdi1.Text = (p1.TelefonMarkasi) + " " + (p1.TelefonModeli);
                        LblUrunAdi2.Text = (p2.TelefonMarkasi) + " " + (p2.TelefonModeli);
                        Urun1Img.ImageUrl = p1.Fotograf;
                        Urun2Img.ImageUrl = p2.Fotograf;
                        LblRam1.Text = p1.RAM.ToString();
                        LblİslemciMarkasi1.Text = p1.İslemciMarkasi;
                        LblIslemciHizCekirdek1.Text = ((p1.İslemciHizi_Ghz) + " Ghz " + " " + (p1.İslemciCekirdek)).ToString() + " Çekirdek";
                        LblArkaKamera1.Text = p1.ArkaKamerapixel.ToString();
                        LblBatarya1.Text = p1.Batarya_Mh.ToString();
                        LblDepolama1.Text = p1.DahiliDepolama_GB.ToString();

                        LblRam2.Text = p2.RAM.ToString();
                        LblİslemciMarkasi2.Text = p2.İslemciMarkasi;
                        LblIslemciHizCekirdek2.Text = ((p2.İslemciHizi_Ghz) + " Ghz " + " " + (p2.İslemciCekirdek)).ToString() + " Çekirdek";
                        LblArkaKamera2.Text = p2.ArkaKamerapixel.ToString();
                        LblBatarya2.Text = p2.Batarya_Mh.ToString();
                        LblDepolama2.Text = p2.DahiliDepolama_GB.ToString();
                    }

                }
            }
        }
    }
}