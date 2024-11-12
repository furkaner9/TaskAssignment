using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using TaskAssignment.Models.Personel;
using TaskAssignment.Models.ProjeTakip;

namespace TaskAssignment.Models.DateContext
{
    public class ProjeTakipDBContext : DbContext
    {
        public ProjeTakipDBContext() : base("ProjeTakipDb")
        {

        }
        public DbSet<PersonelBilgileri>PersonelBilgileris { get; set; }
        public DbSet<PersonelProjeleri> PersonelProjeleri { get; set; }
    }
}