using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Material
    {
        public int Id { get; set; }

        // stock keeping unit
        public string SKU { get; set; } = string.Empty;
        public string? Description { get; set; } = string.Empty;

        // Units of Measure (kg, L, pieces)
        public string UOM { get; set; } = string.Empty;
        public decimal? Price { get; set; } = decimal.Zero;
        public DateTime AddedOn { get; set; } = DateTime.Now;
        public int ColorTypeId { get; set; }
        public ColorType? ColorType { get; set; }

        public int SupplierId { get; set; }
        public Supplier? Supplier { get; set; }
    }
}
