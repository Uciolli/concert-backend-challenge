
using Microsoft.EntityFrameworkCore;

namespace backend_challenge.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Empregado> Empregados { get; set;}
        public DbSet<Projeto> Projetos { get; set;}
        public DbSet<Membro> Membros { get; set;}
        

    protected override void OnModelCreating( ModelBuilder modelBuilder)
    {   
        modelBuilder.Entity<Empregado>()
            .HasKey(c => c.id_empregado);

        modelBuilder.Entity<Empregado>()
            .HasData(
               new Empregado {id_empregado = 1, primeiro_nome = "Big", ultimo_nome = "BOSS", telefone = 936854270, endereco = "big.boss@company.com"},
               new Empregado {id_empregado = 2, primeiro_nome = "Jonas", ultimo_nome = "Xavier", telefone = 936854271, endereco = "jonas.xavier@company.com"},
               new Empregado {id_empregado = 3, primeiro_nome = "Linus", ultimo_nome = "TORVALDS", telefone = 936854272, endereco = "linus.torvalds@company.com"},
               new Empregado {id_empregado = 4, primeiro_nome = "Jimmy", ultimo_nome = "WALES", telefone = 936854273, endereco = "jimmy.wales@company.com"},
               new Empregado {id_empregado = 5, primeiro_nome = "Larry", ultimo_nome = "PAGE", telefone = 936854274, endereco = "larry.page@company.com"}
            );

        modelBuilder.Entity<Projeto>()
                .HasKey(p => p.id_projeto);

        modelBuilder.Entity<Projeto>()
            .HasData(
               new Projeto {id_projeto = 1, nome = "Google", data_criacao = "1998-09-08", data_termino ="NULL", gerenteId = 5},
               new Projeto {id_projeto = 2, nome = "Linux", data_criacao = "1991-01-01" , data_termino ="NULL", gerenteId = 3},
               new Projeto {id_projeto = 3, nome = "Wikipedia", data_criacao = "2001-01-01", data_termino ="NULL", gerenteId = 4},
               new Projeto {id_projeto = 4, nome = "CRM", data_criacao = "2015-09-14", data_termino ="NULL", gerenteId = 5}
            );

         modelBuilder.Entity<Membro>()
                .HasKey(x => new { x.id_empregado, x.id_projeto});
        
    }
}
}