using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using kiyas.la.Entities;

namespace kiyas.la.Context
{
    public class Kiyaslaİnitializer : DropCreateDatabaseIfModelChanges<KiyaslaContext>
    {
        protected override void Seed(KiyaslaContext context)
        {
            var Phones = new List<Phone> 
                {
                    new Phone{TelefonMarkasi="LG",TelefonModeli="G3",RAM=3,Ekrancözünürlügü="2540x1440",ArkaKamerapixel=12,ÖnKamerapixel=2.3,İslemciMarkasi="MediaTek",İslemciModeli="MT6582",İslemciHizi_Ghz=2.5,İslemciCekirdek=4,GrafikİslemciModeli="Adreno 430",GrafikİslemciHizi_Mhz=698,DahiliDepolama_GB=32,MicroSdVarmi=false,Batarya_Mh=2650,Agırlık_Gram=196,Renk="Siyah",İsletimSistemi="Android",SistemSürümü="5.1.0",Fotograf="/Folder/Plugin/Site/Phone/LG/G3.jpg"},
                    new Phone{ TelefonMarkasi="Sony Xperia",TelefonModeli="Z2",RAM=3,Ekrancözünürlügü="1920x1080",ArkaKamerapixel=20.7,ÖnKamerapixel=1.9,İslemciMarkasi="Qualcomm",İslemciModeli="Snapdragon 801",İslemciHizi_Ghz=2.3,İslemciCekirdek=4,GrafikİslemciModeli="Adreno 330",GrafikİslemciHizi_Mhz=645,DahiliDepolama_GB=32,MicroSdVarmi=true,MicroSd_GB=128,Batarya_Mh=3200,Agırlık_Gram=176,Renk="Siyah"+"Beyaz",İsletimSistemi="Android",SistemSürümü="5.0.1",Fotograf="/Folder/Plugin/Site/Phone/Sony/Z2.jpg"},   
                    new Phone{ TelefonMarkasi="Samsuns Galaxy",TelefonModeli="S6 Edge",RAM=3,Ekrancözünürlügü="2540x1440",ArkaKamerapixel=16.2,ÖnKamerapixel=4,İslemciMarkasi="Samsung Exynos",İslemciModeli="7420",İslemciHizi_Ghz=1.9,İslemciCekirdek=8,GrafikİslemciModeli="PowerVRGT330",GrafikİslemciHizi_Mhz=765,DahiliDepolama_GB=32,MicroSdVarmi=false,Batarya_Mh=3200,Agırlık_Gram=176,Renk="Siyah"+"Beyaz",İsletimSistemi="Android",SistemSürümü="5.1.2",Fotograf="/Folder/Plugin/Site/Phone/Samsung/S6EDGE.jpg"},
                    new Phone{ TelefonMarkasi="Apple",TelefonModeli="Iphone6",RAM=3,Ekrancözünürlügü="1160x720",ArkaKamerapixel=9,ÖnKamerapixel=1.7,İslemciMarkasi="Apple Chipset",İslemciModeli="A9",İslemciHizi_Ghz=1.7,İslemciCekirdek=1,GrafikİslemciModeli="Apple VR",GrafikİslemciHizi_Mhz=665,DahiliDepolama_GB=32,MicroSdVarmi=false,Batarya_Mh=1800,Agırlık_Gram=212,Renk="Black",İsletimSistemi="IOS",SistemSürümü="8.3",Fotograf="/Folder/Plugin/Site/Phone/Apple/Iphone6Black.jpg"},
                };
            Phones.ForEach(s => context.SmartPhone.Add((s)));
            context.SaveChanges();
            var Eslestir = new List<Eslestir>
            {
                new Eslestir{SecilenSira=1,SecilenSira2=2,TelefonMarkasi="Sony Xperia",TelefonMarkasi2="Samsung Galaxy"},
            };
            Eslestir.ForEach(s => context.Eslestirmeler.Add((s)));
            context.SaveChanges();

        }
    }
}
