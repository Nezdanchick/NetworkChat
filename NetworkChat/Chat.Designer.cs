namespace NetworkChat
{
    partial class Chat
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
            timer = new System.Windows.Forms.Timer(components);
            labelChat = new Label();
            panel = new Panel();
            richTextBoxMessage = new RichTextBox();
            buttonAdd = new Button();
            buttonSend = new Button();
            panel.SuspendLayout();
            SuspendLayout();
            // 
            // labelChat
            // 
            labelChat.AutoSize = true;
            labelChat.Dock = DockStyle.Fill;
            labelChat.Location = new Point(0, 0);
            labelChat.Name = "labelChat";
            labelChat.Size = new Size(70, 20);
            labelChat.TabIndex = 0;
            labelChat.Text = "Chat Text";
            // 
            // panel
            // 
            panel.BackColor = Color.Silver;
            panel.Controls.Add(richTextBoxMessage);
            panel.Controls.Add(buttonAdd);
            panel.Controls.Add(buttonSend);
            panel.Dock = DockStyle.Bottom;
            panel.Location = new Point(0, 530);
            panel.Name = "panel";
            panel.Size = new Size(914, 70);
            panel.TabIndex = 1;
            // 
            // richTextBoxMessage
            // 
            richTextBoxMessage.Dock = DockStyle.Fill;
            richTextBoxMessage.Location = new Point(90, 0);
            richTextBoxMessage.Name = "richTextBoxMessage";
            richTextBoxMessage.Size = new Size(734, 70);
            richTextBoxMessage.TabIndex = 2;
            richTextBoxMessage.Text = "";
            // 
            // buttonAdd
            // 
            buttonAdd.Dock = DockStyle.Left;
            buttonAdd.Location = new Point(0, 0);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(90, 70);
            buttonAdd.TabIndex = 1;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            // 
            // buttonSend
            // 
            buttonSend.Dock = DockStyle.Right;
            buttonSend.Location = new Point(824, 0);
            buttonSend.Name = "buttonSend";
            buttonSend.Size = new Size(90, 70);
            buttonSend.TabIndex = 0;
            buttonSend.Text = "Send";
            buttonSend.UseVisualStyleBackColor = true;
            buttonSend.Click += ButtonSend_Click;
            // 
            // Chat
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(panel);
            Controls.Add(labelChat);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Chat";
            Text = "Chat";
            panel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Timer timer;
        private Label labelChat;
        private Panel panel;
        private Button buttonAdd;
        private Button buttonSend;
        private RichTextBox richTextBoxMessage;
    }
}