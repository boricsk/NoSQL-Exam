namespace Chat
{
    partial class ChatForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            btnSendMessage = new Button();
            tbMessage = new TextBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            tbNewRoom = new TextBox();
            btnCreateRoom = new Button();
            chatRoomListBox = new ListBox();
            groupBox3 = new GroupBox();
            messageData = new DataGridView();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            User = new DataGridViewTextBoxColumn();
            Date = new DataGridViewTextBoxColumn();
            Message = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)messageData).BeginInit();
            SuspendLayout();
            // 
            // btnSendMessage
            // 
            btnSendMessage.Location = new Point(814, 430);
            btnSendMessage.Name = "btnSendMessage";
            btnSendMessage.Size = new Size(108, 23);
            btnSendMessage.TabIndex = 2;
            btnSendMessage.Text = "Send";
            btnSendMessage.UseVisualStyleBackColor = true;
            btnSendMessage.Click += btnSendMessage_Click;
            // 
            // tbMessage
            // 
            tbMessage.Location = new Point(6, 430);
            tbMessage.Name = "tbMessage";
            tbMessage.Size = new Size(802, 23);
            tbMessage.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(chatRoomListBox);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(212, 459);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Rooms";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tbNewRoom);
            groupBox2.Controls.Add(btnCreateRoom);
            groupBox2.Location = new Point(6, 365);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 88);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Create new room";
            // 
            // tbNewRoom
            // 
            tbNewRoom.Location = new Point(9, 24);
            tbNewRoom.Name = "tbNewRoom";
            tbNewRoom.Size = new Size(183, 23);
            tbNewRoom.TabIndex = 9;
            // 
            // btnCreateRoom
            // 
            btnCreateRoom.Location = new Point(9, 53);
            btnCreateRoom.Name = "btnCreateRoom";
            btnCreateRoom.Size = new Size(183, 23);
            btnCreateRoom.TabIndex = 8;
            btnCreateRoom.Text = "Create";
            btnCreateRoom.UseVisualStyleBackColor = true;
            btnCreateRoom.Click += btnCreateRoom_Click;
            // 
            // chatRoomListBox
            // 
            chatRoomListBox.FormattingEnabled = true;
            chatRoomListBox.ItemHeight = 15;
            chatRoomListBox.Location = new Point(6, 22);
            chatRoomListBox.Name = "chatRoomListBox";
            chatRoomListBox.Size = new Size(200, 334);
            chatRoomListBox.TabIndex = 2;
            chatRoomListBox.SelectedIndexChanged += chatRoomListBox_SelectedIndexChanged;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(messageData);
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(tbMessage);
            groupBox3.Controls.Add(btnSendMessage);
            groupBox3.Location = new Point(230, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(928, 459);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            groupBox3.Text = "Chat";
            // 
            // messageData
            // 
            messageData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            messageData.Columns.AddRange(new DataGridViewColumn[] { User, Date, Message });
            messageData.Location = new Point(6, 37);
            messageData.Name = "messageData";
            messageData.Size = new Size(916, 387);
            messageData.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 7;
            label1.Text = "label1";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // User
            // 
            User.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            User.HeaderText = "User";
            User.Name = "User";
            User.ReadOnly = true;
            User.Width = 55;
            // 
            // Date
            // 
            Date.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Date.HeaderText = "Date";
            Date.Name = "Date";
            Date.ReadOnly = true;
            Date.Width = 56;
            // 
            // Message
            // 
            Message.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Message.HeaderText = "Message";
            Message.Name = "Message";
            Message.ReadOnly = true;
            Message.Width = 78;
            // 
            // ChatForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1170, 480);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Name = "ChatForm";
            Text = "ChatForm";
            FormClosing += ChatForm_FormClosing;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)messageData).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnSendMessage;
        private TextBox tbMessage;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox tbNewRoom;
        private Button btnCreateRoom;
        private ListBox chatRoomListBox;
        private GroupBox groupBox3;
        private Label label1;
        private System.Windows.Forms.Timer timer1;
        private ListBox chatMessageListBox;
        private DataGridView messageData;
        private DataGridViewTextBoxColumn User;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn Message;
    }
}