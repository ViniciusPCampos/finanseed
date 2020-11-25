using System;
using System.Collections.Generic;

namespace Finanseed.Core.Entities 
{
    public class Transaction : IAggregationRoot
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public decimal Value { get; set; }
        public string Date { get; set; }
        public string Type { get; set; }
        public string Parcel { get; set; }
        public string Category { get; set; }
        public List<string> Tags { get; set; }
    }
}