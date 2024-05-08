using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace XML_API.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NamedIndividual",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IRI = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NamedIndividual", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ontologies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ontologies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AnnotationAssertion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AnnotationProperty = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IRI = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Literal = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AbbreviatedIRI = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OntologyId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnnotationAssertion", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AnnotationAssertion_Ontologies_OntologyId",
                        column: x => x.OntologyId,
                        principalTable: "Ontologies",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Declaration",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OntologyId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Declaration", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Declaration_Ontologies_OntologyId",
                        column: x => x.OntologyId,
                        principalTable: "Ontologies",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "InverseObjectProperties",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OntologyId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InverseObjectProperties", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InverseObjectProperties_Ontologies_OntologyId",
                        column: x => x.OntologyId,
                        principalTable: "Ontologies",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SubClassOf",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OntologyId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubClassOf", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubClassOf_Ontologies_OntologyId",
                        column: x => x.OntologyId,
                        principalTable: "Ontologies",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SubObjectPropertyOf",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OntologyId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubObjectPropertyOf", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubObjectPropertyOf_Ontologies_OntologyId",
                        column: x => x.OntologyId,
                        principalTable: "Ontologies",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Class",
                columns: table => new
                {
                    ClassId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IRI = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SubClassOfId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Class", x => x.ClassId);
                    table.ForeignKey(
                        name: "FK_Class_SubClassOf_SubClassOfId",
                        column: x => x.SubClassOfId,
                        principalTable: "SubClassOf",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ObjectProperty",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IRI = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InverseObjectPropertiesId = table.Column<int>(type: "int", nullable: true),
                    SubObjectPropertyOfId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ObjectProperty", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ObjectProperty_InverseObjectProperties_InverseObjectPropertiesId",
                        column: x => x.InverseObjectPropertiesId,
                        principalTable: "InverseObjectProperties",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ObjectProperty_SubObjectPropertyOf_SubObjectPropertyOfId",
                        column: x => x.SubObjectPropertyOfId,
                        principalTable: "SubObjectPropertyOf",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ClassAssertion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClassId = table.Column<int>(type: "int", nullable: false),
                    NamedIndividualId = table.Column<int>(type: "int", nullable: false),
                    OntologyId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassAssertion", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ClassAssertion_Class_ClassId",
                        column: x => x.ClassId,
                        principalTable: "Class",
                        principalColumn: "ClassId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClassAssertion_NamedIndividual_NamedIndividualId",
                        column: x => x.NamedIndividualId,
                        principalTable: "NamedIndividual",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClassAssertion_Ontologies_OntologyId",
                        column: x => x.OntologyId,
                        principalTable: "Ontologies",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ObjectPropertyDomain",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ObjectPropertyId = table.Column<int>(type: "int", nullable: false),
                    ClassId = table.Column<int>(type: "int", nullable: false),
                    OntologyId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ObjectPropertyDomain", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ObjectPropertyDomain_Class_ClassId",
                        column: x => x.ClassId,
                        principalTable: "Class",
                        principalColumn: "ClassId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ObjectPropertyDomain_ObjectProperty_ObjectPropertyId",
                        column: x => x.ObjectPropertyId,
                        principalTable: "ObjectProperty",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ObjectPropertyDomain_Ontologies_OntologyId",
                        column: x => x.OntologyId,
                        principalTable: "Ontologies",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ObjectPropertyRange",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ObjectPropertyId = table.Column<int>(type: "int", nullable: false),
                    ClassId = table.Column<int>(type: "int", nullable: false),
                    OntologyId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ObjectPropertyRange", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ObjectPropertyRange_Class_ClassId",
                        column: x => x.ClassId,
                        principalTable: "Class",
                        principalColumn: "ClassId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ObjectPropertyRange_ObjectProperty_ObjectPropertyId",
                        column: x => x.ObjectPropertyId,
                        principalTable: "ObjectProperty",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ObjectPropertyRange_Ontologies_OntologyId",
                        column: x => x.OntologyId,
                        principalTable: "Ontologies",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AnnotationAssertion_OntologyId",
                table: "AnnotationAssertion",
                column: "OntologyId");

            migrationBuilder.CreateIndex(
                name: "IX_Class_SubClassOfId",
                table: "Class",
                column: "SubClassOfId");

            migrationBuilder.CreateIndex(
                name: "IX_ClassAssertion_ClassId",
                table: "ClassAssertion",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_ClassAssertion_NamedIndividualId",
                table: "ClassAssertion",
                column: "NamedIndividualId");

            migrationBuilder.CreateIndex(
                name: "IX_ClassAssertion_OntologyId",
                table: "ClassAssertion",
                column: "OntologyId");

            migrationBuilder.CreateIndex(
                name: "IX_Declaration_OntologyId",
                table: "Declaration",
                column: "OntologyId");

            migrationBuilder.CreateIndex(
                name: "IX_InverseObjectProperties_OntologyId",
                table: "InverseObjectProperties",
                column: "OntologyId");

            migrationBuilder.CreateIndex(
                name: "IX_ObjectProperty_InverseObjectPropertiesId",
                table: "ObjectProperty",
                column: "InverseObjectPropertiesId");

            migrationBuilder.CreateIndex(
                name: "IX_ObjectProperty_SubObjectPropertyOfId",
                table: "ObjectProperty",
                column: "SubObjectPropertyOfId");

            migrationBuilder.CreateIndex(
                name: "IX_ObjectPropertyDomain_ClassId",
                table: "ObjectPropertyDomain",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_ObjectPropertyDomain_ObjectPropertyId",
                table: "ObjectPropertyDomain",
                column: "ObjectPropertyId");

            migrationBuilder.CreateIndex(
                name: "IX_ObjectPropertyDomain_OntologyId",
                table: "ObjectPropertyDomain",
                column: "OntologyId");

            migrationBuilder.CreateIndex(
                name: "IX_ObjectPropertyRange_ClassId",
                table: "ObjectPropertyRange",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_ObjectPropertyRange_ObjectPropertyId",
                table: "ObjectPropertyRange",
                column: "ObjectPropertyId");

            migrationBuilder.CreateIndex(
                name: "IX_ObjectPropertyRange_OntologyId",
                table: "ObjectPropertyRange",
                column: "OntologyId");

            migrationBuilder.CreateIndex(
                name: "IX_SubClassOf_OntologyId",
                table: "SubClassOf",
                column: "OntologyId");

            migrationBuilder.CreateIndex(
                name: "IX_SubObjectPropertyOf_OntologyId",
                table: "SubObjectPropertyOf",
                column: "OntologyId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AnnotationAssertion");

            migrationBuilder.DropTable(
                name: "ClassAssertion");

            migrationBuilder.DropTable(
                name: "Declaration");

            migrationBuilder.DropTable(
                name: "ObjectPropertyDomain");

            migrationBuilder.DropTable(
                name: "ObjectPropertyRange");

            migrationBuilder.DropTable(
                name: "NamedIndividual");

            migrationBuilder.DropTable(
                name: "Class");

            migrationBuilder.DropTable(
                name: "ObjectProperty");

            migrationBuilder.DropTable(
                name: "SubClassOf");

            migrationBuilder.DropTable(
                name: "InverseObjectProperties");

            migrationBuilder.DropTable(
                name: "SubObjectPropertyOf");

            migrationBuilder.DropTable(
                name: "Ontologies");
        }
    }
}
