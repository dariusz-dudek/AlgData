using Microsoft.EntityFrameworkCore.Migrations;
using System;

#nullable disable

namespace DataStructureAPI.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BaseEntities",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BigONotationValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BaseEntities", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "BaseEntities",
                columns: new[] { "Id", "BigONotationValue", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("426a8b57-a826-4511-880a-196967f2a3ef"), "N", "Hashtable Class. Represents a collection of key/value pairs that are organized based on the hash code of the key.", "HashTable" },
                    { new Guid("8175333d-5c5d-49c3-8074-c112e85fb704"), "N", "Hashtable Class. A Binary Search Tree is a binary tree with search properties where elements in the left sub-tree are less than to the root and elements in the right sub-tree are greater than to the root.", "BinarySearchTree" },
                    { new Guid("8210a1d0-bdd5-4e50-a0e1-5e4bb1fda9b9"), "N", "A Graph is a data structure that contains a finite number of vertices (or nodes) and a finite set of edges connecting the vertices", "Graph" },
                    { new Guid("9495a797-6843-4f84-a879-ddba9cfc108e"), "N", "LinkedList<T> Class. Represents a doubly linked list.", "LinkedList" },
                    { new Guid("e28f6b76-1b88-49ba-9d25-2b7952bfadbf"), "N", "Queue Class. Represents a first-in, first-out collection of objects.", "Queue" },
                    { new Guid("f101348b-eb42-48af-99aa-25204c2f1836"), "N", "Stack Class. Represents a simple last-in-first-out (LIFO) non-generic collection of objects.", "Stack" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BaseEntities");
        }
    }
}
