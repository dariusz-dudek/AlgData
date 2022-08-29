﻿namespace DataStructureAPI.Data.Entries
{
    public class BaseEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string BigONotationValue { get; set; }
    }
}
