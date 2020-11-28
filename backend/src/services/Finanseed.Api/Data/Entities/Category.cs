using System;
using System.Collections.Generic;

namespace Finanseed.Api.Data.Entities
{
    public class Category
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public List<Transaction> Transactions { get; set; }
    }
}