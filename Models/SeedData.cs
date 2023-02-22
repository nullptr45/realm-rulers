using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using realm_rulers.Data;
using System;
using System.Linq;

namespace realm_rulers.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RealmRulersContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<RealmRulersContext>>()))
            {
                // Look for any movies.
                if (context.Match.Any())
                {
                    return;   // DB has been seeded
                }

                context.SaveChanges();
            }
        }
    }
}