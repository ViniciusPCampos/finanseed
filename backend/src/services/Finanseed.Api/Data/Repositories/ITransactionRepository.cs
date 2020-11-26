using System;
using System.Collections.Generic;
using Finanseed.Api.Data.Entities;
using Finanseed.Core.Data;
using Finanseed.Core.Entities;

namespace Finanseed.Api.Data.Repositories
{
    public interface ITransactionRepository : IRepository<Transaction>
    {
        List<Transaction> GetByDateTimeRange(DateTime initialDate, DateTime finalDate);
    }
}