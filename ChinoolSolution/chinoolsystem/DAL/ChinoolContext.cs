using chinoolsystem.Data.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chinoolsystem.DAL
{
   internal class ChinoolContext:DbContext
    {
        public ChinoolContext():base("ChinoolDB")
            {

            }

        public DbSet<Artist> Artists{ get; set; }
        public DbSet<Album> Albums { get; set; }




    }
}
