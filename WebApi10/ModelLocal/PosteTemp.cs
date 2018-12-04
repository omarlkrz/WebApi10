using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using inventV2.Models;

namespace inventV2.Models
{
    public class PosteTemp
    {
        public String name { get; set; }
        public String ip { get; set; }
        public List<Composant> moniteurs { get; set; }
        public List<Composant> usbDevices { get; set; }
        public List<Composant> computers { get; set; }

        public PosteTemp(string name, string ip, List<Composant> moniteurs, List<Composant> usbDevices, List<Composant> computers)
        {
            this.name = name;
            this.ip = ip;
            this.moniteurs = moniteurs;
            this.usbDevices = usbDevices;
            this.computers = computers;
        }
        public PosteTemp()
        {
            
        }
    }
}