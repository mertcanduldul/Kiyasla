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
                    new Phone{ TelefonMarkasi="Blackberry",TelefonModeli="Z30",MarkaModel="Blackberry Z30",RAM=3,Ekrancözünürlügü="1280x720",ArkaKamerapixel=8,ÖnKamerapixel=2,İslemciMarkasi="Qualcomm Snapdragon",İslemciModeli="S4 Pro",İslemciHizi_Ghz=1.7,İslemciCekirdek=2,GrafikİslemciModeli="Adreno 320",GrafikİslemciHizi_Mhz=800,DahiliDepolama_GB=64,MicroSdVarmi=false,Batarya_Mh=2880,Agırlık_Gram=167,Renk="Black",İsletimSistemi="Blackberry OS",SistemSürümü="10.1.2",Fotograf="/Folder/Plugin/Site/Phone/Blackberry/BlackberryZ30.jpg"},                   
                    new Phone{ TelefonMarkasi="LG",TelefonModeli="G3",MarkaModel="LG G3",RAM=3,Ekrancözünürlügü="2540x1440",ArkaKamerapixel=12,ÖnKamerapixel=2.3,İslemciMarkasi="MediaTek MT",İslemciModeli="6582",İslemciHizi_Ghz=2.5,İslemciCekirdek=4,GrafikİslemciModeli="Adreno 430",GrafikİslemciHizi_Mhz=698,DahiliDepolama_GB=32,MicroSdVarmi=false,Batarya_Mh=2650,Agırlık_Gram=196,Renk="Siyah",İsletimSistemi="Android",SistemSürümü="5.1.0",Fotograf="/Folder/Plugin/Site/Phone/LG/G3.jpg"},
                    new Phone{ TelefonMarkasi="Sony Xperia",TelefonModeli="Z2",MarkaModel="Sony Xperia Z2",RAM=3,Ekrancözünürlügü="1920x1080",ArkaKamerapixel=20.7,ÖnKamerapixel=1.9,İslemciMarkasi="Qualcomm Snapdragon",İslemciModeli="801",İslemciHizi_Ghz=2.3,İslemciCekirdek=4,GrafikİslemciModeli="Adreno 330",GrafikİslemciHizi_Mhz=645,DahiliDepolama_GB=32,MicroSdVarmi=true,MicroSd_GB=128,Batarya_Mh=3200,Agırlık_Gram=176,Renk="Siyah"+"Beyaz",İsletimSistemi="Android",SistemSürümü="5.0.1",Fotograf="/Folder/Plugin/Site/Phone/Sony/Z2.jpg"},   
                    new Phone{ TelefonMarkasi="Samsung Galaxy",TelefonModeli="S6 Edge",MarkaModel="Samsung Galaxy S6 Edge",RAM=3,Ekrancözünürlügü="2540x1440",ArkaKamerapixel=16.2,ÖnKamerapixel=4,İslemciMarkasi="Samsung Exynos",İslemciModeli="7420",İslemciHizi_Ghz=1.9,İslemciCekirdek=8,GrafikİslemciModeli="PowerVRGT330",GrafikİslemciHizi_Mhz=765,DahiliDepolama_GB=32,MicroSdVarmi=false,Batarya_Mh=3200,Agırlık_Gram=176,Renk="Siyah"+"Beyaz",İsletimSistemi="Android",SistemSürümü="5.1.2",Fotograf="/Folder/Plugin/Site/Phone/Samsung/S6EDGE.jpg"},
                    new Phone{ TelefonMarkasi="HTC",TelefonModeli="ONE M9",MarkaModel="HTC ONE M9",RAM=3,Ekrancözünürlügü="1920x1080",ArkaKamerapixel=14,ÖnKamerapixel=4,İslemciMarkasi="Qualcomm Snapdragon",İslemciModeli="811",İslemciHizi_Ghz=2.5,İslemciCekirdek=4,GrafikİslemciModeli="Adreno 430",GrafikİslemciHizi_Mhz=996,DahiliDepolama_GB=64,MicroSdVarmi=false,Batarya_Mh=3800,Agırlık_Gram=143,Renk="Siyah"+"Beyaz",İsletimSistemi="Android",SistemSürümü="5.1.2",Fotograf="/Folder/Plugin/Site/Phone/HTC/M9.jpg"},
                    new Phone{ TelefonMarkasi="Samsung Galaxy",TelefonModeli="S6",MarkaModel="Samsung Galaxy S6",RAM=3,Ekrancözünürlügü="2540x1440",ArkaKamerapixel=14,ÖnKamerapixel=6,İslemciMarkasi="Samsung Exynos",İslemciModeli="7420",İslemciHizi_Ghz=2.1,İslemciCekirdek=8,GrafikİslemciModeli="Mali-T760",GrafikİslemciHizi_Mhz=1002,DahiliDepolama_GB=32,MicroSdVarmi=false,Batarya_Mh=2650,Agırlık_Gram=144,Renk="Black",İsletimSistemi="Android",SistemSürümü="5.0.2",Fotograf="/Folder/Plugin/Site/Phone/Samsung/S6.jpg"},
                    new Phone{ TelefonMarkasi="Samsung Galaxy",TelefonModeli="NOTE 4",MarkaModel="Samsung Galaxy NOTE 4",RAM=3,Ekrancözünürlügü="1920x1080",ArkaKamerapixel=18,ÖnKamerapixel=2,İslemciMarkasi="Samsung Exynos",İslemciModeli="7360",İslemciHizi_Ghz=2.1,İslemciCekirdek=8,GrafikİslemciModeli="Mali-550",GrafikİslemciHizi_Mhz=564,DahiliDepolama_GB=32,MicroSdVarmi=false,Batarya_Mh=3100,Agırlık_Gram=165,Renk="Black",İsletimSistemi="Android",SistemSürümü="5.0.2",Fotograf="/Folder/Plugin/Site/Phone/Samsung/NOTE4.jpg"},
                    new Phone{ TelefonMarkasi="Apple",TelefonModeli="Iphone 5S",MarkaModel="Apple Iphone 5S",RAM=768,Ekrancözünürlügü="800x600",ArkaKamerapixel=9,ÖnKamerapixel=2,İslemciMarkasi="Apple Chipset",İslemciModeli="A8",İslemciHizi_Ghz=1.4,İslemciCekirdek=1,GrafikİslemciModeli="Apple VR",GrafikİslemciHizi_Mhz=665,DahiliDepolama_GB=32,MicroSdVarmi=false,Batarya_Mh=1800,Agırlık_Gram=212,Renk="Black",İsletimSistemi="IOS",SistemSürümü="8.3",Fotograf="/Folder/Plugin/Site/Phone/Apple/Iphone5S.jpg"},                    
                    new Phone{ TelefonMarkasi="Sony Xperia",TelefonModeli="Z3",MarkaModel="Sony Xperia Z3",RAM=3,Ekrancözünürlügü="1920x1080",ArkaKamerapixel=20.7,ÖnKamerapixel=3,İslemciMarkasi="Qualcomm",İslemciModeli="801",İslemciHizi_Ghz=2.5,İslemciCekirdek=4,GrafikİslemciModeli="PowerVR680",GrafikİslemciHizi_Mhz=665,DahiliDepolama_GB=32,MicroSdVarmi=false,Batarya_Mh=3100,Agırlık_Gram=154,Renk="Black",İsletimSistemi="Android",SistemSürümü="5.0.1",Fotograf="/Folder/Plugin/Site/Phone/Sony/Z3.jpg"},                     
                    new Phone{ TelefonMarkasi="General Mobile",TelefonModeli="Discovery I",MarkaModel="General Mobile Discovery I",RAM=2,Ekrancözünürlügü="1366x720",ArkaKamerapixel=8,ÖnKamerapixel=3,İslemciMarkasi="MediaTek MT",İslemciModeli="6432",İslemciHizi_Ghz=1.4,İslemciCekirdek=4,GrafikİslemciModeli="Mali-450MP",GrafikİslemciHizi_Mhz=665,DahiliDepolama_GB=16,MicroSdVarmi=false,Batarya_Mh=1800,Agırlık_Gram=154,Renk="Black",İsletimSistemi="Android",SistemSürümü="4.4.4",Fotograf="/Folder/Plugin/Site/Phone/General Mobile/Discovery.jpg"},                     
                    new Phone{ TelefonMarkasi="Apple",TelefonModeli="Iphone6",MarkaModel="Apple Iphone 6",RAM=1,Ekrancözünürlügü="1160x720",ArkaKamerapixel=9,ÖnKamerapixel=1.7,İslemciMarkasi="Apple Chipset",İslemciModeli="A9",İslemciHizi_Ghz=1.7,İslemciCekirdek=2,GrafikİslemciModeli="Apple VR",GrafikİslemciHizi_Mhz=665,DahiliDepolama_GB=32,MicroSdVarmi=false,Batarya_Mh=1800,Agırlık_Gram=212,Renk="Black",İsletimSistemi="IOS",SistemSürümü="8.3",Fotograf="/Folder/Plugin/Site/Phone/Apple/IPHONE6BLACK.jpg"},
                };
            Phones.ForEach(s => context.SmartPhone.Add((s)));
            context.SaveChanges();
        }
    }
}
