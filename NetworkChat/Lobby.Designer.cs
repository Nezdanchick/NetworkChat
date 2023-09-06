namespace NetworkChat
{
    partial class Lobby
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
            textUsername = new TextBox();
            textIP = new TextBox();
            buttonConnect = new Button();
            buttonHost = new Button();
            linkLabelLocalIP = new LinkLabel();
            SuspendLayout();
            // 
            // textUsername
            // 
            textUsername.Location = new Point(12, 13);
            textUsername.Margin = new Padding(3, 4, 3, 4);
            textUsername.Name = "textUsername";
            textUsername.Size = new Size(114, 27);
            textUsername.TabIndex = 0;
            textUsername.Text = "Username";
            textUsername.TextChanged += TextUsername_TextChanged;
            // 
            // textIP
            // 
            textIP.Location = new Point(12, 48);
            textIP.Margin = new Padding(3, 4, 3, 4);
            textIP.Name = "textIP";
            textIP.Size = new Size(114, 27);
            textIP.TabIndex = 1;
            textIP.Text = "192.168.0.1:12345";
            textIP.TextChanged += TextIP_TextChanged;
            // 
            // buttonConnect
            // 
            buttonConnect.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonConnect.Location = new Point(137, 13);
            buttonConnect.Margin = new Padding(3, 4, 3, 4);
            buttonConnect.Name = "buttonConnect";
            buttonConnect.Size = new Size(86, 31);
            buttonConnect.TabIndex = 2;
            buttonConnect.Text = "Connect";
            buttonConnect.UseVisualStyleBackColor = true;
            buttonConnect.Click += ButtonConnect_Click;
            // 
            // buttonHost
            // 
            buttonHost.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHost.Location = new Point(137, 48);
            buttonHost.Margin = new Padding(3, 4, 3, 4);
            buttonHost.Name = "buttonHost";
            buttonHost.Size = new Size(86, 31);
            buttonHost.TabIndex = 3;
            buttonHost.Text = "Host";
            buttonHost.UseVisualStyleBackColor = true;
            buttonHost.Click += ButtonHost_Click;
            // 
            // linkLabelLocalIP
            // 
            linkLabelLocalIP.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            linkLabelLocalIP.AutoSize = true;
            linkLabelLocalIP.Location = new Point(14, 86);
            linkLabelLocalIP.Name = "linkLabelLocalIP";
            linkLabelLocalIP.Size = new Size(100, 20);
            linkLabelLocalIP.TabIndex = 4;
            linkLabelLocalIP.TabStop = true;
            linkLabelLocalIP.Text = "Show Local IP";
            linkLabelLocalIP.LinkClicked += ShowLocalIP_LinkClicked;
            // 
            // Lobby
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(235, 115);
            Controls.Add(linkLabelLocalIP);
            Controls.Add(buttonHost);
            Controls.Add(buttonConnect);
            Controls.Add(textIP);
            Controls.Add(textUsername);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Lobby";
            Text = "Lobby";
            FormClosing += Lobby_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textUsername;
        private TextBox textIP;
        private Button buttonConnect;
        private Button buttonHost;
        private LinkLabel linkLabelLocalIP;
    }
}