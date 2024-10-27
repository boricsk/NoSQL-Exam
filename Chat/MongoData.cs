using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Chat
{
    public class Room
    {
        [BsonId] // Ez a mező fogja tárolni az azonosítót
        [BsonRepresentation(BsonType.ObjectId)] // Automatikusan kezeli az ObjectId konverziót
        public string Id { get; set; }
        [BsonElement("Room name")]
        public string RoomName { get; set; }
    }

    public class ChatMessage
    {
        [BsonId] // Ez a mező fogja tárolni az azonosítót
        [BsonRepresentation(BsonType.ObjectId)] // Automatikusan kezeli az ObjectId konverziót
        public string Id { get; set; }
        [BsonElement("Room name")]
        public string RoomName { get; set; }
        [BsonElement("User name")]
        public string UserName { get; set; }
        [BsonElement("Chat message")]
        public string Message { get; set; }
        public DateTime MessageDate { get; set; }
    }
}
