using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Serialization;

namespace XML_API.Core.Entities
{
    [XmlRoot(ElementName = "Ontology", Namespace = "http://www.w3.org/2002/07/owl#")]
    public class Ontology
    {
      
        [Key]
        [XmlIgnore]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [XmlElement(ElementName = "Declaration")]
        public List<Declaration>? Declarations { get; set; }

        [XmlElement(ElementName = "SubClassOf")]
        public List<SubClassOf>? SubClassOfs { get; set; }

        [XmlElement(ElementName = "ClassAssertion")]
        public List<ClassAssertion>? ClassAssertions { get; set; }

        [XmlElement(ElementName = "SubObjectPropertyOf")]
        public List<SubObjectPropertyOf>? SubObjectPropertyOfs { get; set; }

        [XmlElement(ElementName = "InverseObjectProperties")]
        public List<InverseObjectProperties>? InverseObjectProperties { get; set; }

        [XmlElement(ElementName = "ObjectPropertyDomain")]
        public List<ObjectPropertyDomain>? ObjectPropertyDomains { get; set; }

        [XmlElement(ElementName = "ObjectPropertyRange")]
        public List<ObjectPropertyRange>? ObjectPropertyRanges { get; set; }

        [XmlElement(ElementName = "AnnotationAssertion")]
        public List<AnnotationAssertion>? AnnotationAssertions { get; set; }
    }

    // Define other classes (Declaration, NamedIndividual, SubClassOf, etc.) similarly
    public class Declaration
    {
        [Key]
        [XmlIgnore]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [XmlAttribute("itemtype")]
        public string? ItemType { get; set; } // New field for item type

        [XmlElement("NamedIndividual", typeof(NamedIndividual))]
        [XmlElement("Class", typeof(Class))]
        [XmlElement("ObjectProperty", typeof(ObjectProperty))]
        [NotMapped]
        public object Item { get; set; }
    }


    public class NamedIndividual
    {
        [Key]
        [XmlIgnore]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [XmlAttribute(AttributeName = "IRI")]
        public string? IRI { get; set; }
    }

    public class SubClassOf
    {
        [Key]
        [XmlIgnore]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [XmlElement(ElementName = "Class")]
        public List<Class>? Classes { get; set; }
    }

    public class Class
    {
        [Key]
        [XmlIgnore]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ClassId { get; set; }


        [XmlAttribute(AttributeName = "IRI")]
        public string? IRI { get; set; }
    }

    public class ClassAssertion
    {
        [Key]
        [XmlIgnore]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [XmlElement(ElementName = "Class")]
        public Class? Class { get; set; }
        [XmlIgnore]
        public int? ClassId { get; set; } // Foreign key property
       

        [XmlElement(ElementName = "NamedIndividual")]
        public NamedIndividual? NamedIndividual { get; set; }
    }

    public class SubObjectPropertyOf
    {
        [Key]
        [XmlIgnore]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [XmlElement(ElementName = "ObjectProperty")]
        public List<ObjectProperty>? ObjectProperties { get; set; }
    }

    public class ObjectProperty
    {
        [Key]
        [XmlIgnore]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [XmlAttribute(AttributeName = "IRI")]
        public string? IRI { get; set; }
    }

    public class InverseObjectProperties
    {
        [Key]
        [XmlIgnore]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [XmlElement(ElementName = "ObjectProperty")]
        public List<ObjectProperty>? ObjectProperties { get; set; }
    }

    public class ObjectPropertyDomain
    {
        [Key]
        [XmlIgnore]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [XmlElement(ElementName = "ObjectProperty")]
        public ObjectProperty? ObjectProperty { get; set; }

        [XmlElement(ElementName = "Class")]
        public Class? Class { get; set; }
    }

    public class ObjectPropertyRange
    {
        [Key]
        [XmlIgnore]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [XmlElement(ElementName = "ObjectProperty")]
        public ObjectProperty? ObjectProperty { get; set; }

        [XmlElement(ElementName = "Class")]
        public Class? Class { get; set; }
    }

    public class AnnotationAssertion
    {
        [Key]
        [XmlIgnore]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [XmlElement(ElementName = "AnnotationProperty")]
        public string? AnnotationProperty { get; set; }

        [XmlElement(ElementName = "IRI")]
        public string? IRI { get; set; }

        [XmlElement(ElementName = "Literal")]
        public string? Literal { get; set; }

        [XmlElement(ElementName = "AnnotationProperty", Namespace = "http://www.w3.org/1999/02/22-rdf-syntax-ns#")]
        public string? AbbreviatedIRI { get; set; }
    }

    public class OntologyElement
    {
        [Key]
        [XmlIgnore]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string? IRI { get; set; }
        public List<OntologyElement>? Subclasses { get; } = new List<OntologyElement>();
    }
}