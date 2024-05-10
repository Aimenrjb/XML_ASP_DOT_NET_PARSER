using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace XML_API.Migrations
{
    /// <inheritdoc />
    public partial class dbsets : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AnnotationAssertion_Ontologies_OntologyId",
                table: "AnnotationAssertion");

            migrationBuilder.DropForeignKey(
                name: "FK_Class_SubClassOf_SubClassOfId",
                table: "Class");

            migrationBuilder.DropForeignKey(
                name: "FK_ClassAssertion_Class_ClassId",
                table: "ClassAssertion");

            migrationBuilder.DropForeignKey(
                name: "FK_ClassAssertion_NamedIndividual_NamedIndividualId",
                table: "ClassAssertion");

            migrationBuilder.DropForeignKey(
                name: "FK_ClassAssertion_Ontologies_OntologyId",
                table: "ClassAssertion");

            migrationBuilder.DropForeignKey(
                name: "FK_Declaration_Ontologies_OntologyId",
                table: "Declaration");

            migrationBuilder.DropForeignKey(
                name: "FK_ObjectProperty_SubObjectPropertyOf_SubObjectPropertyOfId",
                table: "ObjectProperty");

            migrationBuilder.DropForeignKey(
                name: "FK_ObjectPropertyDomain_Class_ClassId",
                table: "ObjectPropertyDomain");

            migrationBuilder.DropForeignKey(
                name: "FK_ObjectPropertyDomain_ObjectProperty_ObjectPropertyId",
                table: "ObjectPropertyDomain");

            migrationBuilder.DropForeignKey(
                name: "FK_ObjectPropertyDomain_Ontologies_OntologyId",
                table: "ObjectPropertyDomain");

            migrationBuilder.DropForeignKey(
                name: "FK_ObjectPropertyRange_Class_ClassId",
                table: "ObjectPropertyRange");

            migrationBuilder.DropForeignKey(
                name: "FK_ObjectPropertyRange_ObjectProperty_ObjectPropertyId",
                table: "ObjectPropertyRange");

            migrationBuilder.DropForeignKey(
                name: "FK_ObjectPropertyRange_Ontologies_OntologyId",
                table: "ObjectPropertyRange");

            migrationBuilder.DropForeignKey(
                name: "FK_SubClassOf_Ontologies_OntologyId",
                table: "SubClassOf");

            migrationBuilder.DropForeignKey(
                name: "FK_SubObjectPropertyOf_Ontologies_OntologyId",
                table: "SubObjectPropertyOf");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SubObjectPropertyOf",
                table: "SubObjectPropertyOf");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SubClassOf",
                table: "SubClassOf");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ObjectPropertyRange",
                table: "ObjectPropertyRange");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ObjectPropertyDomain",
                table: "ObjectPropertyDomain");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Declaration",
                table: "Declaration");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ClassAssertion",
                table: "ClassAssertion");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AnnotationAssertion",
                table: "AnnotationAssertion");

            migrationBuilder.RenameTable(
                name: "SubObjectPropertyOf",
                newName: "SubObjectPropertyOfs");

            migrationBuilder.RenameTable(
                name: "SubClassOf",
                newName: "SubClassOfs");

            migrationBuilder.RenameTable(
                name: "ObjectPropertyRange",
                newName: "ObjectPropertyRanges");

            migrationBuilder.RenameTable(
                name: "ObjectPropertyDomain",
                newName: "ObjectPropertyDomains");

            migrationBuilder.RenameTable(
                name: "Declaration",
                newName: "Declarations");

            migrationBuilder.RenameTable(
                name: "ClassAssertion",
                newName: "ClassAssertions");

            migrationBuilder.RenameTable(
                name: "AnnotationAssertion",
                newName: "AnnotationAssertions");

            migrationBuilder.RenameIndex(
                name: "IX_SubObjectPropertyOf_OntologyId",
                table: "SubObjectPropertyOfs",
                newName: "IX_SubObjectPropertyOfs_OntologyId");

            migrationBuilder.RenameIndex(
                name: "IX_SubClassOf_OntologyId",
                table: "SubClassOfs",
                newName: "IX_SubClassOfs_OntologyId");

            migrationBuilder.RenameIndex(
                name: "IX_ObjectPropertyRange_OntologyId",
                table: "ObjectPropertyRanges",
                newName: "IX_ObjectPropertyRanges_OntologyId");

            migrationBuilder.RenameIndex(
                name: "IX_ObjectPropertyRange_ObjectPropertyId",
                table: "ObjectPropertyRanges",
                newName: "IX_ObjectPropertyRanges_ObjectPropertyId");

            migrationBuilder.RenameIndex(
                name: "IX_ObjectPropertyRange_ClassId",
                table: "ObjectPropertyRanges",
                newName: "IX_ObjectPropertyRanges_ClassId");

            migrationBuilder.RenameIndex(
                name: "IX_ObjectPropertyDomain_OntologyId",
                table: "ObjectPropertyDomains",
                newName: "IX_ObjectPropertyDomains_OntologyId");

            migrationBuilder.RenameIndex(
                name: "IX_ObjectPropertyDomain_ObjectPropertyId",
                table: "ObjectPropertyDomains",
                newName: "IX_ObjectPropertyDomains_ObjectPropertyId");

            migrationBuilder.RenameIndex(
                name: "IX_ObjectPropertyDomain_ClassId",
                table: "ObjectPropertyDomains",
                newName: "IX_ObjectPropertyDomains_ClassId");

            migrationBuilder.RenameIndex(
                name: "IX_Declaration_OntologyId",
                table: "Declarations",
                newName: "IX_Declarations_OntologyId");

            migrationBuilder.RenameIndex(
                name: "IX_ClassAssertion_OntologyId",
                table: "ClassAssertions",
                newName: "IX_ClassAssertions_OntologyId");

            migrationBuilder.RenameIndex(
                name: "IX_ClassAssertion_NamedIndividualId",
                table: "ClassAssertions",
                newName: "IX_ClassAssertions_NamedIndividualId");

            migrationBuilder.RenameIndex(
                name: "IX_ClassAssertion_ClassId",
                table: "ClassAssertions",
                newName: "IX_ClassAssertions_ClassId");

            migrationBuilder.RenameIndex(
                name: "IX_AnnotationAssertion_OntologyId",
                table: "AnnotationAssertions",
                newName: "IX_AnnotationAssertions_OntologyId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SubObjectPropertyOfs",
                table: "SubObjectPropertyOfs",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SubClassOfs",
                table: "SubClassOfs",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ObjectPropertyRanges",
                table: "ObjectPropertyRanges",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ObjectPropertyDomains",
                table: "ObjectPropertyDomains",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Declarations",
                table: "Declarations",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ClassAssertions",
                table: "ClassAssertions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AnnotationAssertions",
                table: "AnnotationAssertions",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AnnotationAssertions_Ontologies_OntologyId",
                table: "AnnotationAssertions",
                column: "OntologyId",
                principalTable: "Ontologies",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Class_SubClassOfs_SubClassOfId",
                table: "Class",
                column: "SubClassOfId",
                principalTable: "SubClassOfs",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ClassAssertions_Class_ClassId",
                table: "ClassAssertions",
                column: "ClassId",
                principalTable: "Class",
                principalColumn: "ClassId");

            migrationBuilder.AddForeignKey(
                name: "FK_ClassAssertions_NamedIndividual_NamedIndividualId",
                table: "ClassAssertions",
                column: "NamedIndividualId",
                principalTable: "NamedIndividual",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ClassAssertions_Ontologies_OntologyId",
                table: "ClassAssertions",
                column: "OntologyId",
                principalTable: "Ontologies",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Declarations_Ontologies_OntologyId",
                table: "Declarations",
                column: "OntologyId",
                principalTable: "Ontologies",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ObjectProperty_SubObjectPropertyOfs_SubObjectPropertyOfId",
                table: "ObjectProperty",
                column: "SubObjectPropertyOfId",
                principalTable: "SubObjectPropertyOfs",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ObjectPropertyDomains_Class_ClassId",
                table: "ObjectPropertyDomains",
                column: "ClassId",
                principalTable: "Class",
                principalColumn: "ClassId");

            migrationBuilder.AddForeignKey(
                name: "FK_ObjectPropertyDomains_ObjectProperty_ObjectPropertyId",
                table: "ObjectPropertyDomains",
                column: "ObjectPropertyId",
                principalTable: "ObjectProperty",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ObjectPropertyDomains_Ontologies_OntologyId",
                table: "ObjectPropertyDomains",
                column: "OntologyId",
                principalTable: "Ontologies",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ObjectPropertyRanges_Class_ClassId",
                table: "ObjectPropertyRanges",
                column: "ClassId",
                principalTable: "Class",
                principalColumn: "ClassId");

            migrationBuilder.AddForeignKey(
                name: "FK_ObjectPropertyRanges_ObjectProperty_ObjectPropertyId",
                table: "ObjectPropertyRanges",
                column: "ObjectPropertyId",
                principalTable: "ObjectProperty",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ObjectPropertyRanges_Ontologies_OntologyId",
                table: "ObjectPropertyRanges",
                column: "OntologyId",
                principalTable: "Ontologies",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SubClassOfs_Ontologies_OntologyId",
                table: "SubClassOfs",
                column: "OntologyId",
                principalTable: "Ontologies",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SubObjectPropertyOfs_Ontologies_OntologyId",
                table: "SubObjectPropertyOfs",
                column: "OntologyId",
                principalTable: "Ontologies",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AnnotationAssertions_Ontologies_OntologyId",
                table: "AnnotationAssertions");

            migrationBuilder.DropForeignKey(
                name: "FK_Class_SubClassOfs_SubClassOfId",
                table: "Class");

            migrationBuilder.DropForeignKey(
                name: "FK_ClassAssertions_Class_ClassId",
                table: "ClassAssertions");

            migrationBuilder.DropForeignKey(
                name: "FK_ClassAssertions_NamedIndividual_NamedIndividualId",
                table: "ClassAssertions");

            migrationBuilder.DropForeignKey(
                name: "FK_ClassAssertions_Ontologies_OntologyId",
                table: "ClassAssertions");

            migrationBuilder.DropForeignKey(
                name: "FK_Declarations_Ontologies_OntologyId",
                table: "Declarations");

            migrationBuilder.DropForeignKey(
                name: "FK_ObjectProperty_SubObjectPropertyOfs_SubObjectPropertyOfId",
                table: "ObjectProperty");

            migrationBuilder.DropForeignKey(
                name: "FK_ObjectPropertyDomains_Class_ClassId",
                table: "ObjectPropertyDomains");

            migrationBuilder.DropForeignKey(
                name: "FK_ObjectPropertyDomains_ObjectProperty_ObjectPropertyId",
                table: "ObjectPropertyDomains");

            migrationBuilder.DropForeignKey(
                name: "FK_ObjectPropertyDomains_Ontologies_OntologyId",
                table: "ObjectPropertyDomains");

            migrationBuilder.DropForeignKey(
                name: "FK_ObjectPropertyRanges_Class_ClassId",
                table: "ObjectPropertyRanges");

            migrationBuilder.DropForeignKey(
                name: "FK_ObjectPropertyRanges_ObjectProperty_ObjectPropertyId",
                table: "ObjectPropertyRanges");

            migrationBuilder.DropForeignKey(
                name: "FK_ObjectPropertyRanges_Ontologies_OntologyId",
                table: "ObjectPropertyRanges");

            migrationBuilder.DropForeignKey(
                name: "FK_SubClassOfs_Ontologies_OntologyId",
                table: "SubClassOfs");

            migrationBuilder.DropForeignKey(
                name: "FK_SubObjectPropertyOfs_Ontologies_OntologyId",
                table: "SubObjectPropertyOfs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SubObjectPropertyOfs",
                table: "SubObjectPropertyOfs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SubClassOfs",
                table: "SubClassOfs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ObjectPropertyRanges",
                table: "ObjectPropertyRanges");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ObjectPropertyDomains",
                table: "ObjectPropertyDomains");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Declarations",
                table: "Declarations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ClassAssertions",
                table: "ClassAssertions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AnnotationAssertions",
                table: "AnnotationAssertions");

            migrationBuilder.RenameTable(
                name: "SubObjectPropertyOfs",
                newName: "SubObjectPropertyOf");

            migrationBuilder.RenameTable(
                name: "SubClassOfs",
                newName: "SubClassOf");

            migrationBuilder.RenameTable(
                name: "ObjectPropertyRanges",
                newName: "ObjectPropertyRange");

            migrationBuilder.RenameTable(
                name: "ObjectPropertyDomains",
                newName: "ObjectPropertyDomain");

            migrationBuilder.RenameTable(
                name: "Declarations",
                newName: "Declaration");

            migrationBuilder.RenameTable(
                name: "ClassAssertions",
                newName: "ClassAssertion");

            migrationBuilder.RenameTable(
                name: "AnnotationAssertions",
                newName: "AnnotationAssertion");

            migrationBuilder.RenameIndex(
                name: "IX_SubObjectPropertyOfs_OntologyId",
                table: "SubObjectPropertyOf",
                newName: "IX_SubObjectPropertyOf_OntologyId");

            migrationBuilder.RenameIndex(
                name: "IX_SubClassOfs_OntologyId",
                table: "SubClassOf",
                newName: "IX_SubClassOf_OntologyId");

            migrationBuilder.RenameIndex(
                name: "IX_ObjectPropertyRanges_OntologyId",
                table: "ObjectPropertyRange",
                newName: "IX_ObjectPropertyRange_OntologyId");

            migrationBuilder.RenameIndex(
                name: "IX_ObjectPropertyRanges_ObjectPropertyId",
                table: "ObjectPropertyRange",
                newName: "IX_ObjectPropertyRange_ObjectPropertyId");

            migrationBuilder.RenameIndex(
                name: "IX_ObjectPropertyRanges_ClassId",
                table: "ObjectPropertyRange",
                newName: "IX_ObjectPropertyRange_ClassId");

            migrationBuilder.RenameIndex(
                name: "IX_ObjectPropertyDomains_OntologyId",
                table: "ObjectPropertyDomain",
                newName: "IX_ObjectPropertyDomain_OntologyId");

            migrationBuilder.RenameIndex(
                name: "IX_ObjectPropertyDomains_ObjectPropertyId",
                table: "ObjectPropertyDomain",
                newName: "IX_ObjectPropertyDomain_ObjectPropertyId");

            migrationBuilder.RenameIndex(
                name: "IX_ObjectPropertyDomains_ClassId",
                table: "ObjectPropertyDomain",
                newName: "IX_ObjectPropertyDomain_ClassId");

            migrationBuilder.RenameIndex(
                name: "IX_Declarations_OntologyId",
                table: "Declaration",
                newName: "IX_Declaration_OntologyId");

            migrationBuilder.RenameIndex(
                name: "IX_ClassAssertions_OntologyId",
                table: "ClassAssertion",
                newName: "IX_ClassAssertion_OntologyId");

            migrationBuilder.RenameIndex(
                name: "IX_ClassAssertions_NamedIndividualId",
                table: "ClassAssertion",
                newName: "IX_ClassAssertion_NamedIndividualId");

            migrationBuilder.RenameIndex(
                name: "IX_ClassAssertions_ClassId",
                table: "ClassAssertion",
                newName: "IX_ClassAssertion_ClassId");

            migrationBuilder.RenameIndex(
                name: "IX_AnnotationAssertions_OntologyId",
                table: "AnnotationAssertion",
                newName: "IX_AnnotationAssertion_OntologyId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SubObjectPropertyOf",
                table: "SubObjectPropertyOf",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SubClassOf",
                table: "SubClassOf",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ObjectPropertyRange",
                table: "ObjectPropertyRange",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ObjectPropertyDomain",
                table: "ObjectPropertyDomain",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Declaration",
                table: "Declaration",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ClassAssertion",
                table: "ClassAssertion",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AnnotationAssertion",
                table: "AnnotationAssertion",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AnnotationAssertion_Ontologies_OntologyId",
                table: "AnnotationAssertion",
                column: "OntologyId",
                principalTable: "Ontologies",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Class_SubClassOf_SubClassOfId",
                table: "Class",
                column: "SubClassOfId",
                principalTable: "SubClassOf",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ClassAssertion_Class_ClassId",
                table: "ClassAssertion",
                column: "ClassId",
                principalTable: "Class",
                principalColumn: "ClassId");

            migrationBuilder.AddForeignKey(
                name: "FK_ClassAssertion_NamedIndividual_NamedIndividualId",
                table: "ClassAssertion",
                column: "NamedIndividualId",
                principalTable: "NamedIndividual",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ClassAssertion_Ontologies_OntologyId",
                table: "ClassAssertion",
                column: "OntologyId",
                principalTable: "Ontologies",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Declaration_Ontologies_OntologyId",
                table: "Declaration",
                column: "OntologyId",
                principalTable: "Ontologies",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ObjectProperty_SubObjectPropertyOf_SubObjectPropertyOfId",
                table: "ObjectProperty",
                column: "SubObjectPropertyOfId",
                principalTable: "SubObjectPropertyOf",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ObjectPropertyDomain_Class_ClassId",
                table: "ObjectPropertyDomain",
                column: "ClassId",
                principalTable: "Class",
                principalColumn: "ClassId");

            migrationBuilder.AddForeignKey(
                name: "FK_ObjectPropertyDomain_ObjectProperty_ObjectPropertyId",
                table: "ObjectPropertyDomain",
                column: "ObjectPropertyId",
                principalTable: "ObjectProperty",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ObjectPropertyDomain_Ontologies_OntologyId",
                table: "ObjectPropertyDomain",
                column: "OntologyId",
                principalTable: "Ontologies",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ObjectPropertyRange_Class_ClassId",
                table: "ObjectPropertyRange",
                column: "ClassId",
                principalTable: "Class",
                principalColumn: "ClassId");

            migrationBuilder.AddForeignKey(
                name: "FK_ObjectPropertyRange_ObjectProperty_ObjectPropertyId",
                table: "ObjectPropertyRange",
                column: "ObjectPropertyId",
                principalTable: "ObjectProperty",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ObjectPropertyRange_Ontologies_OntologyId",
                table: "ObjectPropertyRange",
                column: "OntologyId",
                principalTable: "Ontologies",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SubClassOf_Ontologies_OntologyId",
                table: "SubClassOf",
                column: "OntologyId",
                principalTable: "Ontologies",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SubObjectPropertyOf_Ontologies_OntologyId",
                table: "SubObjectPropertyOf",
                column: "OntologyId",
                principalTable: "Ontologies",
                principalColumn: "Id");
        }
    }
}
