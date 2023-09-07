using NSFW;

namespace NetworkChat
{
    public partial class Chat : Form
    {
        private int _chatMessageCount = 0;
        private readonly int _chatLineHeight;

        public Chat()
        {
            InitializeComponent();
            Text = $"{User.Name} {User.Server.EndPoint}";

            labelChat.Text = string.Empty;
            _chatLineHeight = labelChat.Height;

            timer.Interval = 100;
            timer.Tick += Timer_Tick;
            timer.Start();

            User.Server.BroadcastAsync();
        }
        private void ButtonSend_Click(object sender, EventArgs e)
        {
            var message = richTextBoxMessage.Text;
            if (message.Trim().Length > 0)
                User.Client.Send((User.Name, message));
        }
        private void Timer_Tick(object? sender, EventArgs e)
        {
            if (!User.Connected) // show msg box and return to lobby
            {
                timer.Stop();
                MessageBox.Show(
                    "Сheck the connection to the server and try again",
                    "Disconnected from server",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                Close();
            }
            UpdateChat();
        }
        private void UpdateChat()
        {
            var (name, message) = User.Client.Receive<(string, string)>();
            if (name != null && message != null)
                UserSay(name, message);
        }
        private void UserSay(string username, string text)
        {
            labelChat.Text += $"{username}: {text}\n";
            _chatMessageCount++;
            ShrinkText();
        }
        private void ShrinkText()
        {
            int borders = (_chatLineHeight + labelChat.Top) * 2 + panel.Height;
            int count = _chatMessageCount - (Height - borders) / _chatLineHeight;
            if (count <= 0)
                return;
            var text = labelChat.Text;
            for (int i = 0; i < count; i++)
            {
                var index = text.IndexOf('\n') + 1;
                text = text[index..];
                _chatMessageCount--;
            }
            labelChat.Text = text;
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            timer.Stop();
            base.OnFormClosed(e);
        }
    }
}
