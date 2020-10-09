using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace wpf_oefeningen_3
{
    class Persoon
    {
        string Voornaam { get; }
        string Achternaam { get; }
        bool Ingelogd { get; set; }
        public string InlogImg
        {
            get
            {
                string answer = Directory.GetCurrentDirectory() + "/img/";
                if (Ingelogd)
                {
                    return answer + "Check.png";
                }
                else
                {
                    return answer + "Cross.png";
                }
            }
        }

        public Persoon(string voornaam, string achternaam, bool ingelogd = false)
        {
            Voornaam = voornaam;
            Achternaam = achternaam;
            this.Ingelogd = ingelogd;
        }

        public override string ToString()
        {
            return Voornaam + " " + Achternaam;
        }
    }
}
