using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BevKi
{
    internal class MongoDBHelper
    {
        private IMongoDatabase _database;
        private string _MongoConString = "mongodb://localhost:27017";
        private string _databaseName = "cashflow";
        private string _collectionName = "myCashFlow";

        public MongoDBHelper()
        {
            var client = new MongoClient(_MongoConString);
            _database = client.GetDatabase(_databaseName);
        }

        public void AddCashFlowData(string desc, decimal value, string type) 
        {
            var _newCashFlowData = _database.GetCollection<CashFlowData>(_collectionName);
            var cashFolwData = new CashFlowData
            {
                Value = value,
                Type = type,
                Description = desc,
                Date = DateTime.Now
            };
            _newCashFlowData.InsertOne(cashFolwData);
        }

        public List<CashFlowData> GetCashFlowData()
        {
            var cashFlowCollection = _database.GetCollection<CashFlowData>(_collectionName);
            return cashFlowCollection.Find(FilterDefinition<CashFlowData>.Empty).ToList();
        }

        public decimal SumOfValues(string type)
        { 
            List<CashFlowData> cashFlowDatas = new List<CashFlowData>();
            var cashFlowCollection = _database.GetCollection<CashFlowData>(_collectionName);
            var filter = Builders<CashFlowData>.Filter.Eq("Type", type);
            cashFlowDatas = cashFlowCollection.Find(filter).ToList();
            return cashFlowDatas.Sum(s => s.Value);
        }

        public decimal SumOfValues2(string type)
        {
            List<CashFlowData> cashFlowDatas = new List<CashFlowData>();
            var cashFlowCollection = _database.GetCollection<CashFlowData>(_collectionName);
            cashFlowDatas = cashFlowCollection.Find(FilterDefinition<CashFlowData>.Empty).ToList();
            return cashFlowDatas.Where(s => s.Type == type).Sum(s => s.Value);
        }
    }
}
