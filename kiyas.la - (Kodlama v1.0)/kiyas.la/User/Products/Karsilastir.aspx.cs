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
                    if (p1Id == p2Id)
                    {
                        Response.Redirect("Listele.aspx");
                    }
                    else
                    {
                        using (KiyaslaContext db = new KiyaslaContext())
                        {
                            var p1 = (from i in db.SmartPhone
                                      where i.Id == p1Id
                                      select i).FirstOrDefault();
                            var p2 = (from i in db.SmartPhone
                                      where i.Id == p2Id
                                      select i).FirstOrDefault();
                            LblUrunMarkaAdi1.Text = p1.TelefonMarkasi;
                            LblUrunMarkaAdi2.Text = p2.TelefonMarkasi;
                            LblUrunModelAdi1.Text = p1.TelefonModeli;
                            LblUrunModelAdi2.Text = p2.TelefonModeli;
                            Urun1Img.ImageUrl = p1.Fotograf;
                            Urun2Img.ImageUrl = p2.Fotograf;
                            LblRam1.Text = p1.RAM.ToString() + " GB";
                            LblRam2.Text = p2.RAM.ToString() + " GB";
                            LblİslemciMarkasi1.Text = p1.İslemciMarkasi;
                            LblIslemciHizCekirdek1.Text = ((p1.İslemciHizi_Ghz) + " Ghz " + " " + (p1.İslemciCekirdek)).ToString() + " Çekirdek";
                            LblİslemciMarkasi2.Text = p2.İslemciMarkasi;
                            LblIslemciHizCekirdek2.Text = ((p2.İslemciHizi_Ghz) + " Ghz " + " " + (p2.İslemciCekirdek)).ToString() + " Çekirdek";
                            LblArkaKamera1.Text = p1.ArkaKamerapixel.ToString();
                            LblBatarya1.Text = p1.Batarya_Mh.ToString();
                            LblDepolama1.Text = p1.DahiliDepolama_GB.ToString();
                            LblArkaKamera2.Text = p2.ArkaKamerapixel.ToString();
                            LblBatarya2.Text = p2.Batarya_Mh.ToString();
                            LblDepolama2.Text = p2.DahiliDepolama_GB.ToString();
                            LblOnKmr1.Text = p1.ÖnKamerapixel.ToString();
                            LblOnKmr2.Text = p2.ÖnKamerapixel.ToString();


                            if (p1 != null || p2 != null)
                            {
                                {
                                    if (p1.RAM > p2.RAM)
                                    {
                                        LblKarsilastirmaRamSnc.Text = p1.TelefonModeli + " Modelinde Ram Miktarı Daha Fazla.";
                                    }
                                    else if (p1.RAM == p2.RAM)
                                    {
                                        LblKarsilastirmaRamSnc.Text = " RAM Miktarları Aynı ";
                                    }
                                    else if (p2.RAM > p1.RAM)
                                    {
                                        LblKarsilastirmaRamSnc.Text = p2.TelefonModeli + " Modelinde Ram Miktarı Daha Fazla.";
                                    }
                                }
                                {
                                    if (LblİslemciMarkasi1.Text == "Qualcomm Snapdragon" && LblİslemciMarkasi2.Text == "Qualcomm Snapdragon")
                                    {
                                        LblKarsilastirmaİslemciMarkaSnc.Text = "Işlemciler Ayni";
                                    }
                                    else if (LblİslemciMarkasi1.Text == "MediaTek MT" && LblİslemciMarkasi2.Text == "Qualcomm Snapdragon")
                                    {
                                        LblKarsilastirmaİslemciMarkaSnc.Text = " Qualcomm Işlemciler Daha Stabilizedir. ";
                                    }
                                    else if (LblİslemciMarkasi1.Text == "Qualcomm Snapdragon" && LblİslemciMarkasi2.Text == "MediaTek MT")
                                    {
                                        LblKarsilastirmaİslemciMarkaSnc.Text = " Qualcomm Işlemciler Daha Stabilizedir. ";
                                    }
                                    else if (LblİslemciMarkasi2.Text == "Qualcomm Snapdragon" && LblİslemciMarkasi1.Text == "MediaTek MT")
                                    {
                                        LblKarsilastirmaİslemciMarkaSnc.Text = " Qualcomm Işlemciler Daha Stabilizedir. ";
                                    }
                                    else if (LblİslemciMarkasi1.Text == "Samsung Exynos" && LblİslemciMarkasi2.Text == "Qualcomm Snapdragon")
                                    {
                                        LblKarsilastirmaİslemciMarkaSnc.Text = "Performans Açısından Qualcomm Marka İşlemciler Daha İyidir. ";
                                    }
                                    else if (LblİslemciMarkasi1.Text == "Qualcomm Snapdragon" && LblİslemciMarkasi2.Text == "Samsung Exynos")
                                    {
                                        LblKarsilastirmaİslemciMarkaSnc.Text = "Performans Açısından Qualcomm Marka İşlemciler Daha İyidir. ";
                                    }
                                    else if (LblİslemciMarkasi1.Text == "Samsung Exynos" && LblİslemciMarkasi2.Text == "MediaTek MT")
                                    {
                                        LblKarsilastirmaİslemciMarkaSnc.Text = "Samsung Işlemciler MediaTek İşlemcilere Göre Daha Az Güç Harcar. ";
                                    }
                                    else if (LblİslemciMarkasi1.Text == "Samsung Exynos" && LblİslemciMarkasi2.Text == "Samsung Exynos")
                                    {
                                        LblKarsilastirmaİslemciMarkaSnc.Text = "Işlemciler Ayni. ";
                                    }
                                    else if (LblİslemciMarkasi2.Text == "Samsung Exynos" && LblİslemciMarkasi1.Text == "MediaTek MT")
                                    {
                                        LblKarsilastirmaİslemciMarkaSnc.Text = "Samsung Işlemciler MediaTek İşlemcilere Göre Daha Az Güç Harcar. ";
                                    }

                                }
                                {
                                    if (p1.İslemciHizi_Ghz > p2.İslemciHizi_Ghz || p1.İslemciCekirdek > p2.İslemciCekirdek)
                                    {
                                        double a = (p1.İslemciHizi_Ghz) / p2.İslemciHizi_Ghz;
                                        LblKarsilastirmaİslemciHizCkrdkSnc.Text = "Uygulamalarınız ve oyunlarınız için daha güçlü ve hızlı bir işlemci" + " Yaklaşık " + "%" + Math.Round(a, 2).ToString();
                                    }
                                    else
                                    {
                                        double a = (p1.İslemciHizi_Ghz) / p2.İslemciHizi_Ghz;
                                        LblKarsilastirmaİslemciHizCkrdkSnc.Text = "Uygulamalarınız ve oyunlarınız için daha güçlü ve hızlı bir işlemci " + " Yaklaşık  " + "%" + Math.Round(a, 2).ToString();
                                    }

                                }
                                {
                                    LblArkaKamera1.Text += " MP ";
                                    LblArkaKamera2.Text += " MP ";
                                    if (p1.ArkaKamerapixel > p2.ArkaKamerapixel)
                                    {
                                        double a = (p1.ArkaKamerapixel / p2.ArkaKamerapixel);

                                        LblArkaKameraSnc.Text = "Fotoğraflarınızı, büyük ve kaliteli baskı için " + " % " + Math.Round(a, 2).ToString() + " kat daha detaylı çekin";
                                    }
                                    else if (p1.ArkaKamerapixel < p2.ArkaKamerapixel)
                                    {
                                        double a = (p2.ArkaKamerapixel / p1.ArkaKamerapixel);

                                        LblArkaKameraSnc.Text = "Fotoğraflarınızı, büyük ve kaliteli baskı için " + " % " + Math.Round(a, 2).ToString() + " kat daha detaylı çekin";
                                    }
                                    else if (p1.ArkaKamerapixel == p2.ArkaKamerapixel)
                                    {
                                        LblArkaKameraSnc.Text = "Aynı Özellikte Kameralar Mevcut";
                                    }
                                }
                                {
                                    if (p1.Batarya_Mh > p2.Batarya_Mh)
                                    {
                                        LblBataryaSnc.Text = " Daha Uzun Batarya Süresi Sağlar. ";
                                    }
                                    else if (p2.Batarya_Mh > p1.Batarya_Mh)
                                    {
                                        LblBataryaSnc.Text = " Günü Rahat Bir Şekilde Çıkarır. ";
                                    }
                                    else if (p1.Batarya_Mh == p2.Batarya_Mh)
                                    {
                                        LblBataryaSnc.Text = " Batarya Büyüklükleri Aynı. ";
                                    }
                                }
                                {
                                    LblDepolama1.Text += " GB ";
                                    LblDepolama2.Text += " GB ";
                                    if (p1.DahiliDepolama_GB > p2.DahiliDepolama_GB)
                                    {
                                        LblDepolamaSnc.Text = " Uygulamalarınız Için Daha Fazla Alan. ";
                                    }
                                    else if (p2.DahiliDepolama_GB > p1.DahiliDepolama_GB)
                                    {
                                        LblDepolamaSnc.Text = " Daha yüksek Dahili Depolama Alanı. ";
                                    }
                                    else if (p1.DahiliDepolama_GB == p2.DahiliDepolama_GB)
                                    {
                                        LblDepolamaSnc.Text = " Depolama Alanları Aynı Büyüklükte. ";
                                    }
                                }
                                {
                                    if (p1.ÖnKamerapixel < p2.ÖnKamerapixel)
                                    {
                                        double a = p1.ÖnKamerapixel / p2.ÖnKamerapixel;
                                        LblOnKmrSnc.Text = " % " + Math.Round(a, 2) + "Daha iyi kaliteli Fotoğraf";
                                    }
                                    else if (p1.ÖnKamerapixel > p2.ÖnKamerapixel)
                                    {
                                        double a = p1.ÖnKamerapixel / p2.ÖnKamerapixel;
                                        LblOnKmrSnc.Text = " % " + Math.Round(a, 2) + "Daha iyi kaliteli Fotoğraf";
                                    }
                                    else if (p1.ÖnKamerapixel == p2.ÖnKamerapixel)
                                    {
                                        LblOnKmrSnc.Text = "Kameralar Aynı Kalitede. ";
                                    }
                                }
                            }
                            else
                            {
                                Response.Redirect("Listele.aspx");
                            }
                        }
                    }
                }
            }
        }
    }
}
