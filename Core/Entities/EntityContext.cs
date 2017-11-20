using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;

namespace Core.Entities
{
    
    public class EntityContext:DbContext 
    {
        public DbSet<DataRow> Symbols { get; set; }
    }
}
