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
            SuspendLayout();
            // 
            // textUsername
            // 
            textUsername.Location = new Point(12, 12);
            textUsername.Name = "textUsername";
            textUsername.Size = new Size(100, 23);
            textUsername.TabIndex = 0;
            textUsername.Text = "Username";
            // 
            // textIP
            // 
            textIP.Location = new Point(12, 41);
            textIP.Name = "textIP";
            textIP.Size = new Size(100, 23);
            textIP.TabIndex = 1;
            textIP.Text = "192.168.0.1:12345";
            // 
            // buttonConnect
            // 
            buttonConnect.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonConnect.Location = new Point(127, 12);
            buttonConnect.Name = "buttonConnect";
            buttonConnect.Size = new Size(75, 23);
            buttonConnect.TabIndex = 2;
            buttonConnect.Text = "Connect";
            buttonConnect.UseVisualStyleBackColor = true;
            // 
            // buttonHost
            // 
            buttonHost.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonHost.Location = new Point(127, 41);
            buttonHost.Name = "buttonHost";
            buttonHost.Size = new Size(75, 23);
            buttonHost.TabIndex = 3;
            buttonHost.Text = "Host";
            buttonHost.UseVisualStyleBackColor = true;
            // 
            // Chat
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(214, 76);
            Controls.Add(buttonHost);
            Controls.Add(buttonConnect);
            Controls.Add(textIP);
            Controls.Add(textUsername);
            Name = "Chat";
            Text = "Chat";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textUsername;
        private TextBox textIP;
        private Button buttonConnect;
        private Button buttonHost;
    }
}