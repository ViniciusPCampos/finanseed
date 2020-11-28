using System;
using System.Collections.Generic;

namespace Finanseed.Api.Data.Entities
{
    public class Parcel
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public int Number { get; set; }
        public List<Transaction> Transactions { get; set; }
    }
}