using SWE2_TP2_4.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
//using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SWE2_TP2_4.DAO
{
    public class ManifestoContext : DbContext
    {
        public DbSet<BL> BLs { get; set; }

        public DbSet<Container> Containers { get; set; }
    }
}