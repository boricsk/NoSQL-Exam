using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace BevKi
{
    public class CashFlowData
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)] 
        public string Id { get; set; }
        [BsonElement("Date")]
        public DateTime Date { get; set; }
        [BsonElement("Description")]
        public string Description { get; set; }
        [BsonElement("Value")]
        public decimal Value { get; set; }
        [BsonElement("Type")]
        public string Type { get; set; }
    }
}
