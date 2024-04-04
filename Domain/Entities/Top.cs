using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Top
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; } = string.Empty;
        public DateTime AddedOn { get; set; } = DateTime.Now;
        public int? MaterialId { get; set; }
        public Material? Material { get; set; }
        public decimal? NumberOfUnits { get; set; } = null;
        public Units? Units { get; set; }
        public decimal? ExpensePerUnit { get; set; } = null!;
    }
}
