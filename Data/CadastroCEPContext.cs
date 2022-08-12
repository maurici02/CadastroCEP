using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CadastroCEP.Models;

    public class CadastroCEPContext : DbContext
    {
        public CadastroCEPContext (DbContextOptions<CadastroCEPContext> options)
            : base(options)
        {
        }

        public DbSet<CadastroCEP.Models.Usuario> Usuario { get; set; }

        public DbSet<CadastroCEP.Models.Endereco> Endereco { get; set; }
    }
