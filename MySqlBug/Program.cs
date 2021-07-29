using MySqlBug;
using System.Linq;

using var context = new Context();
context.Database.EnsureCreated();

var shelfIndex = 1;

var result = context.Racks
    .Select(r => new
    {
        RackSize = r.Type.Size,
        ShelvesOrdered = r.Shelves
            .OrderBy(s => s.VerticalPosition)
            .ToList()
    })
    .Select(r => new
    {
        r.RackSize,
        AboveShelfThickness = r.ShelvesOrdered
            .Skip(shelfIndex + 1)
            .Select(s => (int?)s.Type.Thickness)
            .FirstOrDefault(),
    })
    .FirstOrDefault();

System.Diagnostics.Debugger.Break();