using DM_WEB.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace DM_WEB.Data
{
    public class DMContext : DbContext
    {
        public DMContext() : base("DbDM")
        {

        }

        public DbSet<People> People { get; set; }
    }
}
