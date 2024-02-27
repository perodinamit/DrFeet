using Domain.Entities;
using Domain.Repository;
using Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class SoleRepository : GenericRepository<Sole>, ISoleRepository
    {
        public SoleRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
