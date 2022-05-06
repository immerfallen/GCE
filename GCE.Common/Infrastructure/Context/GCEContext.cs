using GCE.Common.Domain;
using Microsoft.EntityFrameworkCore;


namespace GCE.Common.Infrastructure.Context
{
    class GCEContext : DbContext
    {
        public GCEContext(DbContextOptions<GCEContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PessoaJuridica>(opts => 
            {
                opts.ToTable("PessoaJuridica");
                opts.Property(p => p.Id).ValueGeneratedNever();
            });
        }
    }
}
