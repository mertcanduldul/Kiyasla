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
                    new Phone{Id=0 },
                    new Phone{ TelefonMarkasi="Sony Xperia",TelefonModeli="Z2",RAM=3,Ekrancözünürlügü="1920x1080",ArkaKamerapixel=20.7,ÖnKamerapixel=1.9,İslemciMarkasi="Qualcomm",İslemciModeli="Snapdragon 801",İslemciHizi_Ghz=2.3,İslemciCekirdek=4,GrafikİslemciModeli="Adreno 330",GrafikİslemciHizi_Mhz=645,DahiliDepolama_GB=32,MicroSdVarmi=true,MicroSd_GB=128,Batarya_Mh=3200,Agırlık_Gram=176,Renk="Siyah"+"Beyaz",İsletimSistemi="Android",SistemSürümü="5.0.1",Fotograf="/Folder/Plugin/Site/xtras/images/devices_CellPhone/Sony/pics/v-635288731258002444/Sony_Xperia_Z2.jpg"},   
                    new Phone{ TelefonMarkasi="Samsuns Galaxy",TelefonModeli="S6 Edge",RAM=3,Ekrancözünürlügü="2520x1440",ArkaKamerapixel=16.2,ÖnKamerapixel=4,İslemciMarkasi="Samsung Exynos",İslemciModeli="7420",İslemciHizi_Ghz=1.9,İslemciCekirdek=8,GrafikİslemciModeli="PowerVRGT330",GrafikİslemciHizi_Mhz=765,DahiliDepolama_GB=32,MicroSdVarmi=false,Batarya_Mh=3200,Agırlık_Gram=176,Renk="Siyah"+"Beyaz",İsletimSistemi="Android",SistemSürümü="5.1.2",Fotograf="/Folder/Plugin/Site/xtras/images/devices_CellPhone/Samsung/pics/v-635453706651923952/Samsung_Galaxy_Note_Edge_!_20140903195105.jpg"},
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
