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
    public class PurposeRepository : GenericRepository<Purpose>, IPurposeRepository
    {
        public PurposeRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
