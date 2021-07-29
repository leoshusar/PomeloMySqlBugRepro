using System;
using System.Collections.Generic;

namespace MySqlBug.Entities
{
    public class RackType
    {
        public Guid Id { get; set; }
        public int Size { get; set; }

        public virtual ICollection<Rack> Racks { get; private set; } = new HashSet<Rack>();

        public RackType()
        {
        }
    }
}
