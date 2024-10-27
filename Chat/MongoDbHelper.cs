using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat
{
    public class MongoDBHelper
    {
        private IMongoDatabase _database;

        public MongoDBHelper(string connectionString, string databaseName)
        {
            var client = new MongoClient(connectionString);
            _database = client.GetDatabase(databaseName);
        }

        public void RegisterUser(string username, string password)
        {
            string protectedPassword = Hashing.Sha512Hash(password);
            var users = _database.GetCollection<BsonDocument>("users");
            var user = new BsonDocument
            {
                { "username", username },
                { "password", protectedPassword }
            };
            users.InsertOne(user);
        }

        public bool LoginUser(string username, string password)
        {
            try
            {
                string protectedPassword = Hashing.Sha512Hash(password);
                var users = _database.GetCollection<BsonDocument>("users");
                var filter = Builders<BsonDocument>.Filter.Eq("username", username) & Builders<BsonDocument>.Filter.Eq("password", protectedPassword);
                var user = users.Find(filter).FirstOrDefault();
                return user != null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public void CreateRoom(string roomName)
        {
            var rooms = _database.GetCollection<Room>("rooms");
            var room = new Room
            {
                RoomName = roomName,
            };
            rooms.InsertOne(room);
        }

        public List<string> GetRooms()
        {
            var _mongoCollection = _database.GetCollection<Room>("rooms");
            var _rooms = _mongoCollection.Find(_ => true).ToList();
            var rooms = new List<string>();
            foreach (var room in _rooms)
            {
                rooms.Add(room.RoomName);
            }
            return rooms;
        }

        public void AddMessages(string room, string user, string msg, DateTime messageDate)
        {
            var _chatMsg = _database.GetCollection<ChatMessage>("messages");
            var chatMessage = new ChatMessage
            {
                RoomName = room,
                UserName = user,
                Message = msg,
                MessageDate = messageDate
            };
            _chatMsg.InsertOne(chatMessage);
        }

        public List<ChatMessage> GetMessagesByRoom(string roomName)
        {
            var _chatMsgCollection = _database.GetCollection<ChatMessage>("messages");
            var filter = Builders<ChatMessage>.Filter.Eq("RoomName", roomName);
            var messages = _chatMsgCollection.Find(filter).ToList();
            return messages;
        }
    }
}
