using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SWE2_TP2_4.Models
{
    public class BL
    {
        public int Id { get; set; }
        public int Numero { get; set; }
        public string Consignee { get; set; }

        public string Navio { get; set; }
        public int ContainerId { get; set; }
    }
}