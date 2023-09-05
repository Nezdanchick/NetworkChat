namespace NetworkChat
{
    public partial class Chat : Form
    {
        private int _chatMessageCount = 0;
        private int _chatLineHeight;

        public Chat()
        {
            InitializeComponent();
            labelChat.Text = string.Empty;
            _chatLineHeight = labelChat.Height;

            timer.Interval = 100;
            timer.Tick += Timer_Tick;
            timer.Start();
        }
        int i = 0;
        private void UserSay(string username, string text)
        {
            labelChat.Text += $"{username}: {text}{i++}\n";
            _chatMessageCount++;
            ShrinkText();
        }
        private void ShrinkText()
        {
            int borders = (_chatLineHeight + labelChat.Top) * 2;
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

        private void Timer_Tick(object? sender, EventArgs e)
        {
            UpdateText();
        }

        private void UpdateText()
        {
            UserSay("Nezdanchick", "lol");

        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            timer.Stop();
            base.OnFormClosed(e);
        }
    }
}
