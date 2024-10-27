using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chat
{
    public partial class ChatForm : Form
    {

        private string _currentRoom = "General";
        private string _userName;

        private string MongoConString = "mongodb://localhost:27017";
        private string MongoDatabase = "chat";
        private List<string> RoomList = new List<string>();

        public ChatForm(string userName)
        {
            InitializeComponent();
            _userName = userName;
            var mongoDBHelper = new MongoDBHelper(MongoConString, MongoDatabase);
            RoomList = mongoDBHelper.GetRooms();
            if (RoomList.Count != 0)
            {
                foreach (var room in RoomList)
                {
                    chatRoomListBox.Items.Add(room);
                }
            }
            else
            {
                string newRoom = "General";
                chatRoomListBox.Items.Add(newRoom);
                _currentRoom = newRoom;
                mongoDBHelper.CreateRoom(newRoom);
                tbNewRoom.Text = "";
            }

            label1.Text = $"Room : {_currentRoom}";
            this.Text = $"{this.Text} - {userName}";
        }

        private void ChatForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void ReceiveMessage(string userName, string messageDate, string message)
        {
            Invoke(new Action(() =>
            {
                messageData.Rows.Add(userName, messageDate, message);
            }));
        }

        private void btnSendMessage_Click(object sender, EventArgs e)
        {
            var mongoDBHelper = new MongoDBHelper(MongoConString, MongoDatabase);
            ReceiveMessage(_userName, DateTime.Now.ToString(), tbMessage.Text);
            mongoDBHelper.AddMessages(_currentRoom, _userName, tbMessage.Text, DateTime.Now);
            tbMessage.Clear();
        }

        private void btnCreateRoom_Click(object sender, EventArgs e)
        {
            string newRoom = tbNewRoom.Text;
            if (!string.IsNullOrEmpty(newRoom) && !chatRoomListBox.Items.Contains(newRoom))
            {
                chatRoomListBox.Items.Add(newRoom);
                _currentRoom = newRoom;
                var mongoDBHelper = new MongoDBHelper(MongoConString, MongoDatabase);
                mongoDBHelper.CreateRoom(newRoom);
                tbNewRoom.Text = "";
            }
        }

        private void chatRoomListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var mongoDBHelper = new MongoDBHelper(MongoConString, MongoDatabase);
            _currentRoom = chatRoomListBox.SelectedItem.ToString();
            List<ChatMessage> chatMessages = mongoDBHelper.GetMessagesByRoom(_currentRoom);

            for (int i = 0; i < chatMessages.Count - 1; i++)
            {
                messageData.Rows.Add(chatMessages[i].UserName, chatMessages[i].MessageDate, chatMessages[i].Message);
            }
            label1.Text = $"Room : {_currentRoom}";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var mongoDBHelper = new MongoDBHelper(MongoConString, MongoDatabase);
            List<ChatMessage> chatMessages = mongoDBHelper.GetMessagesByRoom(_currentRoom);
            if (chatMessages.Count != messageData.Rows.Count - 1)
            {
                messageData.Rows.Clear();
                for (int i = 0; i < chatMessages.Count; i++)
                {
                    messageData.Rows.Add(chatMessages[i].UserName, chatMessages[i].MessageDate, chatMessages[i].Message);
                }
            }

        }
    }
}
