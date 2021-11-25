using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjetoLojaMVC.Models;

namespace ProjetoLojaMVC.Data
{
    public class ProjetoLojaMVCContext : DbContext
    {
        public ProjetoLojaMVCContext (DbContextOptions<ProjetoLojaMVCContext> options)
            : base(options)
        {
        }

        public DbSet<ProjetoLojaMVC.Models.Departament> Departament { get; set; }
    }
}
