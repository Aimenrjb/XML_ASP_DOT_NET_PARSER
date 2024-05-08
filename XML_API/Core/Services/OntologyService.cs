using System.Xml.Serialization;
using XML_API.Core.Interfaces;
using XML_API.Core.Entities;
using XML_API.Core.Data;

namespace Infrastructure.Services
{
    public class OntologyService 
    {
        private readonly string _xmlFilePath;
        private readonly ApplicationDbContext _context;

        public OntologyService(ApplicationDbContext applicationDbContext)
        {
            _xmlFilePath = "ness.owl";
            _context = applicationDbContext;
        }

        public Ontology GetOntology()
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Ontology));
                using (FileStream fileStream = new FileStream(_xmlFilePath, FileMode.Open))
                {
                    Ontology ontology = (Ontology)serializer.Deserialize(fileStream);
                    // Set ItemType for each Declaration based on the type of Item
                    foreach (var declaration in ontology.Declarations)
                    {
                        if (declaration.Item is NamedIndividual)
                        {
                            declaration.ItemType = "NamedIndividual";
                        }
                        else if (declaration.Item is Class)
                        {
                            declaration.ItemType = "Class";
                        }
                        else if (declaration.Item is ObjectProperty)
                        {
                            declaration.ItemType = "ObjectProperty";
                        }
                    }
                    _context.Ontologies.Add(ontology);
                    _context.SaveChangesAsync();
                    return ontology;
                   

                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error reading or deserializing the ontology: {ex.Message}");
            }
        }
    }
}