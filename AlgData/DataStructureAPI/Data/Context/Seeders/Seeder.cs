namespace DataStructureAPI.Data.Context.Seeders
{
    public static class Seeder
    {
        public static void SeedDatabase(this ModelBuilder builder)
        {
            List<BaseEntity> entities = new()
            {
                new BaseEntity
                {
                    Id = Guid.NewGuid(),
                    Name = "Stack",
                    Description = "Stack Class. Represents a simple last-in-first-out (LIFO) non-generic collection of objects.",
                    BigONotationValue = "N"
                },
                new BaseEntity
                {
                    Id = Guid.NewGuid(),
                    Name = "Queue",
                    Description = "Queue Class. Represents a first-in, first-out collection of objects.",
                    BigONotationValue = "N"
                },
                new BaseEntity
                {
                    Id = Guid.NewGuid(),
                    Name = "LinkedList",
                    Description = "LinkedList<T> Class. Represents a doubly linked list.",
                    BigONotationValue = "N"
                },
                new BaseEntity
                {
                    Id = Guid.NewGuid(),
                    Name = "HashTable",
                    Description = "Hashtable Class. Represents a collection of key/value pairs that are organized based on the hash code of the key.",
                    BigONotationValue = "N"
                },
                new BaseEntity
                {
                    Id = Guid.NewGuid(),
                    Name = "BinarySearchTree",
                    Description = "Hashtable Class. A Binary Search Tree is a binary tree with search properties where elements in the left sub-tree are less than to the root and elements in the right sub-tree are greater than to the root.",
                    BigONotationValue = "N"
                },
                new BaseEntity
                {
                    Id = Guid.NewGuid(),
                    Name = "Graph",
                    Description = "A Graph is a data structure that contains a finite number of vertices (or nodes) and a finite set of edges connecting the vertices",
                    BigONotationValue = "N"
                },
            };

            builder.Entity<BaseEntity>().HasData(entities);
        }
    }
}
