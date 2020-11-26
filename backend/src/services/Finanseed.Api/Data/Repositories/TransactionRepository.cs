using System;
using System.Collections.Generic;
using System.Linq;
using Finanseed.Api.Data.Contexts;
using Finanseed.Api.Data.Entities;
using Finanseed.Core.Entities;

namespace Finanseed.Api.Data.Repositories
{
    public class TransactionRepository : ITransactionRepository
    {
        private readonly FinanseedContext _context;

        public TransactionRepository(FinanseedContext context)
        {
            _context = context;
        }
        
        public List<Transaction> GetByDateTimeRange(DateTime initialDate, DateTime finalDate)
        {
            return _context.Set<Transaction>()
                .Where(x => x.Date >= initialDate && x.Date <= finalDate)
                .ToList();
        }

        public void Register(Transaction entity)
        {
            _context.Set<Transaction>().Add(entity);
        }

        public Transaction GetById(Guid id)
        {
            return _context.Set<Transaction>().Find(id);
        }

        public List<Transaction> List()
        {
            return _context.Set<Transaction>().ToList();
        }
    }
}