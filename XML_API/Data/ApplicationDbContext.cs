using Microsoft.EntityFrameworkCore;
using XML_API.Core.Entities;
using Microsoft.EntityFrameworkCore.Design;
using System.Reflection.Emit;
namespace XML_API.Core.Data
{
    // Classe de contexte pour l'acc�s � la base de donn�es
    public class ApplicationDbContext :DbContext
    {
        // Ensemble d'entit�s pour la table des pages
        public DbSet<Ontology> Ontologies => Set<Ontology>();

        // Constructeur de la classe ApplicationDbContext
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {

   

        }

        // M�thode pour la configuration du mod�le
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<ClassAssertion>()
       .HasOne(c => c.Class)
       .WithMany() // Assuming one Class can be associated with multiple ClassAssertions
       .HasForeignKey(c => c.ClassId); 
        }
        // Classe de contexte pour l'acc�s � la base de donn�es
       
    }
}
