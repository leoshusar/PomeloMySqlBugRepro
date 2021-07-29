using System;
using System.Collections.Generic;

namespace MySqlBug.Entities
{
    public class ShelfType
    {
        public Guid Id { get; set; }
        public int Thickness { get; set; }

        public virtual ICollection<Shelf> Shelves { get; set; } = new HashSet<Shelf>();

        public ShelfType()
        {
        }
    }
}
