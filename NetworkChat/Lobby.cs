using NSFW;

namespace NetworkChat
{
    public partial class Lobby : Form
    {
        public Lobby()
        {
            InitializeComponent();
            SaveDefaultIfEmpty();
            LoadSettings();
        }

        private void ButtonConnect_Click(object sender, EventArgs e)
        {
            textUsername.Text = Properties.Settings.Default.Username;
        }

        private void ButtonHost_Click(object sender, EventArgs e)
        {
            textIP.Text = Properties.Settings.Default.IPAddres;
        }

        private void TextUsername_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Username = User.Name;
        }

        private void TextIP_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.IPAddres = textIP.Text;
        }

        private void SaveDefaultIfEmpty()
        {
            if (Properties.Settings.Default.Username == string.Empty)
                Properties.Settings.Default.Username = User.Name;

            if (Properties.Settings.Default.IPAddres == string.Empty)
                Properties.Settings.Default.IPAddres = textIP.Text;

            Properties.Settings.Default.Save();
        }
        private void LoadSettings()
        {
            User.Name = Properties.Settings.Default.Username;
            textUsername.Text = User.Name;
            textIP.Text = Properties.Settings.Default.IPAddres;
        }

        private void Lobby_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Save();
        }
    }
}
