using Microsoft.EntityFrameworkCore.Migrations;
using System;

#nullable disable

namespace DataStructureAPI.Migrations
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
                    { new Guid("304fbe62-b312-4411-be3c-573797e9f422"), "N", "A Graph is a data structure that contains a finite number of vertices (or nodes) and a finite set of edges connecting the vertices", "Graph" },
                    { new Guid("7b0608a2-6097-4cb2-b961-f5790d2bee2e"), "N", "Hashtable Class. Represents a collection of key/value pairs that are organized based on the hash code of the key.", "HashTable" },
                    { new Guid("8a90f00b-1f7e-4da2-bd2f-cd20019b62c9"), "N", "Stack Class. Represents a simple last-in-first-out (LIFO) non-generic collection of objects.", "Stack" },
                    { new Guid("98956246-de82-4e5e-ae8c-71f8cba8ff8f"), "N", "Queue Class. Represents a first-in, first-out collection of objects.", "Queue" },
                    { new Guid("c0761b5f-f7e9-412b-973b-86171d40aa2d"), "N", "Hashtable Class. A Binary Search Tree is a binary tree with search properties where elements in the left sub-tree are less than to the root and elements in the right sub-tree are greater than to the root.", "BinarySearchTree" },
                    { new Guid("d6b1e586-a588-4112-abee-31bd3a592f39"), "N", "LinkedList<T> Class. Represents a doubly linked list.", "LinkedList" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BaseEntities");
        }
    }
}
