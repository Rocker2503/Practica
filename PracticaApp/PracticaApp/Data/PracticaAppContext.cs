using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PracticaApp.Models
{
    public class PracticaAppContext : DbContext
    {
        public PracticaAppContext (DbContextOptions<PracticaAppContext> options)
            : base(options)
        {
        }

        public DbSet<PracticaApp.Models.Recepcion> Recepcion { get; set; }
    }
}
