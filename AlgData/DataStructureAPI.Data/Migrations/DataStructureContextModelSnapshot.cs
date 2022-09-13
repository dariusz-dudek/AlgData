﻿// <auto-generated />
using System;
using DataStructureAPI.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataStructureAPI.Data.Migrations
{
    [DbContext(typeof(DataStructureContext))]
    partial class DataStructureContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DataStructureAPI.Data.Entries.BaseEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("BigONotationValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("BaseEntities");

                    b.HasData(
                        new
                        {
                            Id = new Guid("f101348b-eb42-48af-99aa-25204c2f1836"),
                            BigONotationValue = "N",
                            Description = "Stack Class. Represents a simple last-in-first-out (LIFO) non-generic collection of objects.",
                            Name = "Stack"
                        },
                        new
                        {
                            Id = new Guid("e28f6b76-1b88-49ba-9d25-2b7952bfadbf"),
                            BigONotationValue = "N",
                            Description = "Queue Class. Represents a first-in, first-out collection of objects.",
                            Name = "Queue"
                        },
                        new
                        {
                            Id = new Guid("9495a797-6843-4f84-a879-ddba9cfc108e"),
                            BigONotationValue = "N",
                            Description = "LinkedList<T> Class. Represents a doubly linked list.",
                            Name = "LinkedList"
                        },
                        new
                        {
                            Id = new Guid("426a8b57-a826-4511-880a-196967f2a3ef"),
                            BigONotationValue = "N",
                            Description = "Hashtable Class. Represents a collection of key/value pairs that are organized based on the hash code of the key.",
                            Name = "HashTable"
                        },
                        new
                        {
                            Id = new Guid("8175333d-5c5d-49c3-8074-c112e85fb704"),
                            BigONotationValue = "N",
                            Description = "Hashtable Class. A Binary Search Tree is a binary tree with search properties where elements in the left sub-tree are less than to the root and elements in the right sub-tree are greater than to the root.",
                            Name = "BinarySearchTree"
                        },
                        new
                        {
                            Id = new Guid("8210a1d0-bdd5-4e50-a0e1-5e4bb1fda9b9"),
                            BigONotationValue = "N",
                            Description = "A Graph is a data structure that contains a finite number of vertices (or nodes) and a finite set of edges connecting the vertices",
                            Name = "Graph"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}