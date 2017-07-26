using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace ClassLibrary3
{
    public class ReadingEntityContext : DbContext
    {
        public ReadingEntityContext() : base("name=Flag33") {  }
        public virtual DbSet<Reading> Readings { get; set; }
        public virtual DbSet<SupplyType> SupplyTypes { get; set; }
        public virtual DbSet<Meter> Meters { get; set; }
        public virtual DbSet<ViolationType> ViolationTypes { get; set; }
        public virtual DbSet<Violation> Violations { get; set; }    
    }
}
