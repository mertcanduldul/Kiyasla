using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace kiyas.la.Entities
{
    public class Phone
    {
        public int Id { get; set; }

        public string TelefonMarkasi { get; set; }

        public string TelefonModeli { get; set; }

        public string Ekrancözünürlügü { get; set; }

        public double ArkaKamerapixel { get; set; }

        public double ÖnKamerapixel { get; set; }

        public string İslemciMarkasi { get; set; }

        public string İslemciModeli { get; set; }

        public double İslemciHizi_Ghz { get; set; }

        public int İslemciCekirdek { get; set; }

        public string GrafikİslemciModeli { get; set; }

        public double GrafikİslemciHizi_Mhz { get; set; }

        public double DahiliDepolama_GB { get; set; }

        public int MicroSd_GB { get; set; }

        public bool MicroSdVarmi { get; set; }

        public int Batarya_Mh { get; set; }

        public double Agırlık_Gram { get; set; }

        public string Renk { get; set; }

        public string İsletimSistemi { get; set; }

        public string SistemSürümü { get; set; }

    }
}