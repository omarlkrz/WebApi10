using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace inventV2.Models
{
    public class Composant
    {
        public String modele { get; set; }
        public String type { get; set; }
        public String vid { get; set; }
        public String sn { get; set; }

        public Composant(string modele, string type, string vid, string sn)
        {
            this.modele = modele;
            this.type = type;
            this.vid = vid;
            this.sn = sn;
        }

        public Composant()
        {
            
        }
    }
}