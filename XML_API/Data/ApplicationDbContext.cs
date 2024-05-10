using Microsoft.EntityFrameworkCore;
using XML_API.Core.Entities;
using Microsoft.EntityFrameworkCore.Design;
using System.Reflection.Emit;
namespace XML_API.Core.Data
{
    // Classe de contexte pour l'acc�s � la base de donn�es
    public class ApplicationDbContext :DbContext
    {
        public DbSet<Ontology> Ontologies { get; set; }
        public DbSet<Declaration> Declarations { get; set; }
        public DbSet<SubClassOf> SubClassOfs { get; set; }
        public DbSet<ClassAssertion> ClassAssertions { get; set; }
        public DbSet<SubObjectPropertyOf> SubObjectPropertyOfs { get; set; }
        public DbSet<InverseObjectProperties> InverseObjectProperties { get; set; }
        public DbSet<ObjectPropertyDomain> ObjectPropertyDomains { get; set; }
        public DbSet<ObjectPropertyRange> ObjectPropertyRanges { get; set; }
        public DbSet<AnnotationAssertion> AnnotationAssertions { get; set; }

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
