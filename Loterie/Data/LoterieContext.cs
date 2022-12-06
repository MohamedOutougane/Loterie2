using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Loterie.Models;

namespace Loterie.Data
{
    public class LoterieContext : DbContext
    {
        public LoterieContext (DbContextOptions<LoterieContext> options)
            : base(options)
        {
        }

        public DbSet<Loterie.Models.Session> Session { get; set; } = default!;

        public DbSet<Loterie.Models.Ticket> Ticket { get; set; } = default!;
    }
}
