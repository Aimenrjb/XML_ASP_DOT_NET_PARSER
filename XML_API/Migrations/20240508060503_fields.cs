using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace XML_API.Migrations
{
    /// <inheritdoc />
    public partial class fields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClassAssertion_Class_ClassId",
                table: "ClassAssertion");

            migrationBuilder.DropForeignKey(
                name: "FK_ClassAssertion_NamedIndividual_NamedIndividualId",
                table: "ClassAssertion");

            migrationBuilder.DropForeignKey(
                name: "FK_ObjectPropertyDomain_Class_ClassId",
                table: "ObjectPropertyDomain");

            migrationBuilder.DropForeignKey(
                name: "FK_ObjectPropertyDomain_ObjectProperty_ObjectPropertyId",
                table: "ObjectPropertyDomain");

            migrationBuilder.DropForeignKey(
                name: "FK_ObjectPropertyRange_Class_ClassId",
                table: "ObjectPropertyRange");

            migrationBuilder.DropForeignKey(
                name: "FK_ObjectPropertyRange_ObjectProperty_ObjectPropertyId",
                table: "ObjectPropertyRange");

            migrationBuilder.AlterColumn<int>(
                name: "ObjectPropertyId",
                table: "ObjectPropertyRange",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ClassId",
                table: "ObjectPropertyRange",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ObjectPropertyId",
                table: "ObjectPropertyDomain",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ClassId",
                table: "ObjectPropertyDomain",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "IRI",
                table: "ObjectProperty",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "IRI",
                table: "NamedIndividual",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ItemType",
                table: "Declaration",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "NamedIndividualId",
                table: "ClassAssertion",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ClassId",
                table: "ClassAssertion",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "IRI",
                table: "Class",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Literal",
                table: "AnnotationAssertion",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "IRI",
                table: "AnnotationAssertion",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "AnnotationProperty",
                table: "AnnotationAssertion",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "AbbreviatedIRI",
                table: "AnnotationAssertion",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClassAssertion_Class_ClassId",
                table: "ClassAssertion");

            migrationBuilder.DropForeignKey(
                name: "FK_ClassAssertion_NamedIndividual_NamedIndividualId",
                table: "ClassAssertion");

            migrationBuilder.DropForeignKey(
                name: "FK_ObjectPropertyDomain_Class_ClassId",
                table: "ObjectPropertyDomain");

            migrationBuilder.DropForeignKey(
                name: "FK_ObjectPropertyDomain_ObjectProperty_ObjectPropertyId",
                table: "ObjectPropertyDomain");

            migrationBuilder.DropForeignKey(
                name: "FK_ObjectPropertyRange_Class_ClassId",
                table: "ObjectPropertyRange");

            migrationBuilder.DropForeignKey(
                name: "FK_ObjectPropertyRange_ObjectProperty_ObjectPropertyId",
                table: "ObjectPropertyRange");

            migrationBuilder.AlterColumn<int>(
                name: "ObjectPropertyId",
                table: "ObjectPropertyRange",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ClassId",
                table: "ObjectPropertyRange",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ObjectPropertyId",
                table: "ObjectPropertyDomain",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ClassId",
                table: "ObjectPropertyDomain",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "IRI",
                table: "ObjectProperty",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "IRI",
                table: "NamedIndividual",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ItemType",
                table: "Declaration",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "NamedIndividualId",
                table: "ClassAssertion",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ClassId",
                table: "ClassAssertion",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "IRI",
                table: "Class",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Literal",
                table: "AnnotationAssertion",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "IRI",
                table: "AnnotationAssertion",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AnnotationProperty",
                table: "AnnotationAssertion",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AbbreviatedIRI",
                table: "AnnotationAssertion",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ClassAssertion_Class_ClassId",
                table: "ClassAssertion",
                column: "ClassId",
                principalTable: "Class",
                principalColumn: "ClassId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ClassAssertion_NamedIndividual_NamedIndividualId",
                table: "ClassAssertion",
                column: "NamedIndividualId",
                principalTable: "NamedIndividual",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ObjectPropertyDomain_Class_ClassId",
                table: "ObjectPropertyDomain",
                column: "ClassId",
                principalTable: "Class",
                principalColumn: "ClassId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ObjectPropertyDomain_ObjectProperty_ObjectPropertyId",
                table: "ObjectPropertyDomain",
                column: "ObjectPropertyId",
                principalTable: "ObjectProperty",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ObjectPropertyRange_Class_ClassId",
                table: "ObjectPropertyRange",
                column: "ClassId",
                principalTable: "Class",
                principalColumn: "ClassId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ObjectPropertyRange_ObjectProperty_ObjectPropertyId",
                table: "ObjectPropertyRange",
                column: "ObjectPropertyId",
                principalTable: "ObjectProperty",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
