using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class CalculationItem
    {
        public int Id { get; set; }
        public string Type { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Color { get; set; } = string.Empty;
        public string Material { get; set; } = string.Empty;
        public decimal Price { get; set; } = decimal.Zero;
        public string Normativ { get; set; } = string.Empty;

        public int? CalculationId { get; set; }
        public Calculation? Calculation { get; set; }

    }
}
