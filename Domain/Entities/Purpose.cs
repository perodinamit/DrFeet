using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
<<<<<<< HEAD:Domain/Entities/Color.cs
    public class Color
=======
    public class Purpose
>>>>>>> renaming:Domain/Entities/Purpose.cs
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; } = string.Empty;
        public DateTime AddedOn { get; set; } = DateTime.Now;
    }
}
