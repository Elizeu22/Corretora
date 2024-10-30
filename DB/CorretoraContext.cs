using CadastroCorretora.Model;
using System.Collections.Generic;

namespace CadastroCorretora.DB
{
    using CadastroCorretora.Model;
    using Microsoft.EntityFrameworkCore;
    public class CorretoraContext:DbContext
    {

        public CorretoraContext(DbContextOptions<CorretoraContext> options) : base(options) { }

        public DbSet<CorretoraCadastro> Corretoras { get; set; }

        public DbSet<Corretor> Corretores { get; set; }


    }
}
