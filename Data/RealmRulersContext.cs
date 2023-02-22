using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using realm_rulers.Models;

namespace realm_rulers.Data
{
    public class RealmRulersContext : DbContext
    {
        public RealmRulersContext (DbContextOptions<RealmRulersContext> options)
            : base(options)
        {
        }

        public DbSet<realm_rulers.Models.Match> Match { get; set; }
    }
}
