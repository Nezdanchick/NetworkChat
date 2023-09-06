using NSFW;

namespace NetworkChat
{
    public partial class Lobby : Form
    {
        public string IPEndPoint => textIP.Text;

        private Form? _chat;

        public Lobby()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedToolWindow;

            SaveDefaultIfEmpty();
            LoadSettings();

            User.Server.OnClientConnected += Server_OnClientConnected;
        }

        private void ShowChat()
        {
            _chat ??= new Chat();
            Hide();
            _chat.ShowDialog();
            Show();
        }

        private void Server_OnClientConnected()
        {
            MessageBox.Show("Client connected!");
        }

        private void ButtonConnect_Click(object sender, EventArgs e)
        {
            IPAction(() =>
            {
                User.Client.Connect(IPEndPoint);
            });
        }

        private void ButtonHost_Click(object sender, EventArgs e)
        {
            IPAction(() =>
            {
                var port = Address.GetPort(IPEndPoint);
                User.Server.Start(port);
                User.Server.ListenAsync();
                User.Client.Connect(Address.GetLocalEndPoint(port).ToString());
            });
        }

        private void TextUsername_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Username = User.Name;
        }

        private void TextIP_TextChanged(object sender, EventArgs e)
        {
            if (Address.IsValid(IPEndPoint))
                Properties.Settings.Default.IPEndPoint = IPEndPoint;
        }

        private void IPAction(Action action)
        {
            if (Address.IsValid(IPEndPoint))
            {
                action.Invoke();
                if (User.Connected)
                    ShowChat();
            }
            else
            {
                MessageBox.Show("IP Address should be in this format:\n\"192.168.0.1:12345\"",
                    "Invalid IP Address",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                textIP.Text = Properties.Settings.Default.IPEndPoint;
            }
        }

        private static void SaveDefaultIfEmpty()
        {
            if (Properties.Settings.Default.Username == string.Empty)
                Properties.Settings.Default.Username = User.Name;

            if (Properties.Settings.Default.IPEndPoint == string.Empty)
                Properties.Settings.Default.IPEndPoint = Address.GetLocalEndPoint(12345).ToString();

            Properties.Settings.Default.Save();
        }
        private void LoadSettings()
        {
            User.Name = Properties.Settings.Default.Username;
            textUsername.Text = Properties.Settings.Default.Username;
            textIP.Text = Properties.Settings.Default.IPEndPoint;
        }

        private void Lobby_FormClosing(object sender, FormClosingEventArgs e)
        {
            User.Server.OnClientConnected -= Server_OnClientConnected;
            Properties.Settings.Default.Save();
        }

        private void ShowLocalIP_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show(
                $"{Address.LocalIP}",
                "Local IP Address",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}
