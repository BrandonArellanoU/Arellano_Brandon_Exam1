using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Arellano_Brandon_Exam1.Models;

namespace Arellano_Brandon_Exam1.Data
{
    public class Arellano_Brandon_Exam1Context : DbContext
    {
        public Arellano_Brandon_Exam1Context (DbContextOptions<Arellano_Brandon_Exam1Context> options)
            : base(options)
        {
        }

        public DbSet<Arellano_Brandon_Exam1.Models.ArellanoB> ArellanoB { get; set; } = default!;
        public DbSet<Arellano_Brandon_Exam1.Models.Celular> Celular { get; set; } = default!;
    }
}
