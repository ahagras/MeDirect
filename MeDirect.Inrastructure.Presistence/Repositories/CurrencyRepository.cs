using MeDirect.Core.Domain.Entities;
using MeDirect.Core.Domain.Repositories;
using MeDirect.Infrastructure.Presistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeDirect.Inrastructure.Presistence.Repositories
{
    public class CurrencyRepository : Repository<Currency>, ICurrencyRepository
    {
        public CurrencyRepository(MeDirectContext dbContext) : base(dbContext)
        {
        }
    }
}
