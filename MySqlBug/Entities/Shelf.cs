using System;

namespace MySqlBug.Entities
{
    public class Shelf
    {
        public Guid Id { get; set; }
        public Guid ShelfTypeId { get; set; }
        public Guid RackId { get; set; }
        public int VerticalPosition { get; set; }

        public virtual ShelfType Type { get; set; }
        public virtual Rack Rack { get; set; }

        public Shelf()
        {
        }
    }
}
