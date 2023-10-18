using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AlexCaicedoRamos_EjercicioCF2.Models;

namespace AlexCaicedoRamos_EjercicioCF2.Data
{
    public class AlexCaicedoRamos_EjercicioCF2Context : DbContext
    {
        public AlexCaicedoRamos_EjercicioCF2Context (DbContextOptions<AlexCaicedoRamos_EjercicioCF2Context> options)
            : base(options)
        {
        }

        public DbSet<AlexCaicedoRamos_EjercicioCF2.Models.Burger> Burger { get; set; } = default!;

        public DbSet<AlexCaicedoRamos_EjercicioCF2.Models.Promo>? Promo { get; set; }
    }
}
