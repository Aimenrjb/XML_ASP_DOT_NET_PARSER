﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using XML_API.Core.Data;

#nullable disable

namespace XML_API.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240508052043_init")]
    partial class init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("XML_API.Core.Entities.AnnotationAssertion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AbbreviatedIRI")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AnnotationProperty")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IRI")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Literal")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("OntologyId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OntologyId");

                    b.ToTable("AnnotationAssertion");
                });

            modelBuilder.Entity("XML_API.Core.Entities.Class", b =>
                {
                    b.Property<int>("ClassId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ClassId"));

                    b.Property<string>("IRI")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SubClassOfId")
                        .HasColumnType("int");

                    b.HasKey("ClassId");

                    b.HasIndex("SubClassOfId");

                    b.ToTable("Class");
                });

            modelBuilder.Entity("XML_API.Core.Entities.ClassAssertion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ClassId")
                        .HasColumnType("int");

                    b.Property<int>("NamedIndividualId")
                        .HasColumnType("int");

                    b.Property<int?>("OntologyId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClassId");

                    b.HasIndex("NamedIndividualId");

                    b.HasIndex("OntologyId");

                    b.ToTable("ClassAssertion");
                });

            modelBuilder.Entity("XML_API.Core.Entities.Declaration", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ItemType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("OntologyId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OntologyId");

                    b.ToTable("Declaration");
                });

            modelBuilder.Entity("XML_API.Core.Entities.InverseObjectProperties", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("OntologyId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OntologyId");

                    b.ToTable("InverseObjectProperties");
                });

            modelBuilder.Entity("XML_API.Core.Entities.NamedIndividual", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("IRI")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("NamedIndividual");
                });

            modelBuilder.Entity("XML_API.Core.Entities.ObjectProperty", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("IRI")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("InverseObjectPropertiesId")
                        .HasColumnType("int");

                    b.Property<int?>("SubObjectPropertyOfId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("InverseObjectPropertiesId");

                    b.HasIndex("SubObjectPropertyOfId");

                    b.ToTable("ObjectProperty");
                });

            modelBuilder.Entity("XML_API.Core.Entities.ObjectPropertyDomain", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ClassId")
                        .HasColumnType("int");

                    b.Property<int>("ObjectPropertyId")
                        .HasColumnType("int");

                    b.Property<int?>("OntologyId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClassId");

                    b.HasIndex("ObjectPropertyId");

                    b.HasIndex("OntologyId");

                    b.ToTable("ObjectPropertyDomain");
                });

            modelBuilder.Entity("XML_API.Core.Entities.ObjectPropertyRange", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ClassId")
                        .HasColumnType("int");

                    b.Property<int>("ObjectPropertyId")
                        .HasColumnType("int");

                    b.Property<int?>("OntologyId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClassId");

                    b.HasIndex("ObjectPropertyId");

                    b.HasIndex("OntologyId");

                    b.ToTable("ObjectPropertyRange");
                });

            modelBuilder.Entity("XML_API.Core.Entities.Ontology", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.HasKey("Id");

                    b.ToTable("Ontologies");
                });

            modelBuilder.Entity("XML_API.Core.Entities.SubClassOf", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("OntologyId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OntologyId");

                    b.ToTable("SubClassOf");
                });

            modelBuilder.Entity("XML_API.Core.Entities.SubObjectPropertyOf", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("OntologyId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OntologyId");

                    b.ToTable("SubObjectPropertyOf");
                });

            modelBuilder.Entity("XML_API.Core.Entities.AnnotationAssertion", b =>
                {
                    b.HasOne("XML_API.Core.Entities.Ontology", null)
                        .WithMany("AnnotationAssertions")
                        .HasForeignKey("OntologyId");
                });

            modelBuilder.Entity("XML_API.Core.Entities.Class", b =>
                {
                    b.HasOne("XML_API.Core.Entities.SubClassOf", null)
                        .WithMany("Classes")
                        .HasForeignKey("SubClassOfId");
                });

            modelBuilder.Entity("XML_API.Core.Entities.ClassAssertion", b =>
                {
                    b.HasOne("XML_API.Core.Entities.Class", "Class")
                        .WithMany()
                        .HasForeignKey("ClassId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("XML_API.Core.Entities.NamedIndividual", "NamedIndividual")
                        .WithMany()
                        .HasForeignKey("NamedIndividualId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("XML_API.Core.Entities.Ontology", null)
                        .WithMany("ClassAssertions")
                        .HasForeignKey("OntologyId");

                    b.Navigation("Class");

                    b.Navigation("NamedIndividual");
                });

            modelBuilder.Entity("XML_API.Core.Entities.Declaration", b =>
                {
                    b.HasOne("XML_API.Core.Entities.Ontology", null)
                        .WithMany("Declarations")
                        .HasForeignKey("OntologyId");
                });

            modelBuilder.Entity("XML_API.Core.Entities.InverseObjectProperties", b =>
                {
                    b.HasOne("XML_API.Core.Entities.Ontology", null)
                        .WithMany("InverseObjectProperties")
                        .HasForeignKey("OntologyId");
                });

            modelBuilder.Entity("XML_API.Core.Entities.ObjectProperty", b =>
                {
                    b.HasOne("XML_API.Core.Entities.InverseObjectProperties", null)
                        .WithMany("ObjectProperties")
                        .HasForeignKey("InverseObjectPropertiesId");

                    b.HasOne("XML_API.Core.Entities.SubObjectPropertyOf", null)
                        .WithMany("ObjectProperties")
                        .HasForeignKey("SubObjectPropertyOfId");
                });

            modelBuilder.Entity("XML_API.Core.Entities.ObjectPropertyDomain", b =>
                {
                    b.HasOne("XML_API.Core.Entities.Class", "Class")
                        .WithMany()
                        .HasForeignKey("ClassId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("XML_API.Core.Entities.ObjectProperty", "ObjectProperty")
                        .WithMany()
                        .HasForeignKey("ObjectPropertyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("XML_API.Core.Entities.Ontology", null)
                        .WithMany("ObjectPropertyDomains")
                        .HasForeignKey("OntologyId");

                    b.Navigation("Class");

                    b.Navigation("ObjectProperty");
                });

            modelBuilder.Entity("XML_API.Core.Entities.ObjectPropertyRange", b =>
                {
                    b.HasOne("XML_API.Core.Entities.Class", "Class")
                        .WithMany()
                        .HasForeignKey("ClassId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("XML_API.Core.Entities.ObjectProperty", "ObjectProperty")
                        .WithMany()
                        .HasForeignKey("ObjectPropertyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("XML_API.Core.Entities.Ontology", null)
                        .WithMany("ObjectPropertyRanges")
                        .HasForeignKey("OntologyId");

                    b.Navigation("Class");

                    b.Navigation("ObjectProperty");
                });

            modelBuilder.Entity("XML_API.Core.Entities.SubClassOf", b =>
                {
                    b.HasOne("XML_API.Core.Entities.Ontology", null)
                        .WithMany("SubClassOfs")
                        .HasForeignKey("OntologyId");
                });

            modelBuilder.Entity("XML_API.Core.Entities.SubObjectPropertyOf", b =>
                {
                    b.HasOne("XML_API.Core.Entities.Ontology", null)
                        .WithMany("SubObjectPropertyOfs")
                        .HasForeignKey("OntologyId");
                });

            modelBuilder.Entity("XML_API.Core.Entities.InverseObjectProperties", b =>
                {
                    b.Navigation("ObjectProperties");
                });

            modelBuilder.Entity("XML_API.Core.Entities.Ontology", b =>
                {
                    b.Navigation("AnnotationAssertions");

                    b.Navigation("ClassAssertions");

                    b.Navigation("Declarations");

                    b.Navigation("InverseObjectProperties");

                    b.Navigation("ObjectPropertyDomains");

                    b.Navigation("ObjectPropertyRanges");

                    b.Navigation("SubClassOfs");

                    b.Navigation("SubObjectPropertyOfs");
                });

            modelBuilder.Entity("XML_API.Core.Entities.SubClassOf", b =>
                {
                    b.Navigation("Classes");
                });

            modelBuilder.Entity("XML_API.Core.Entities.SubObjectPropertyOf", b =>
                {
                    b.Navigation("ObjectProperties");
                });
#pragma warning restore 612, 618
        }
    }
}
