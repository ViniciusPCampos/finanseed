using System;
using System.Collections.Generic;
using Finanseed.Core.Entities;

namespace Finanseed.Api.Data.Entities 
{
    public class Transaction : IAggregationRoot
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public decimal Value { get; set; }
        public DateTime Date { get; set; }
        public string Type { get; set; }
        public string Parcel { get; set; }
        public string Category { get; set; }
        public List<string> Tags { get; set; }
    }
}