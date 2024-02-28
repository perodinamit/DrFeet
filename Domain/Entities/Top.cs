﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Top
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; } = string.Empty;
        public DateTime AddedOn { get; set; } = DateTime.Now;

        public int ColorId { get; set; }

        public ColorType Color { get; set; }
    }
}
