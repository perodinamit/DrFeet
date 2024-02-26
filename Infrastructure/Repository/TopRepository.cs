using Domain.Entities;
using Domain.Repository;
using Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class TopRepository : GenericRepository<Top>, ITopRepository
    {
        public TopRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
