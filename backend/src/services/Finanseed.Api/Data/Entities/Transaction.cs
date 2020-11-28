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
        public int ParcelIndex { get; set; }
        public Guid ParcelId { get; set; }
        public Guid CategoryId { get; set; }
        public EnumTransactionType EnumTransactionType { get; set; }
        
        // Relationships
        
        public Category Category { get; set; }
        public Parcel Parcel { get; set; }
        public List<Tag> Tags { get; set; }
    }
}