using System;
using System.Collections.Generic;

namespace MySqlBug.Entities
{
    public class Rack
    {
        public Guid Id { get; private set; }
        public Guid RackTypeId { get; private set; }

        public virtual RackType Type { get; private set; }
        public virtual ICollection<Shelf> Shelves { get; private set; } = new HashSet<Shelf>();

        public Rack()
        {
        }
    }
}
