using System;
using System.Windows.Forms;
using werewolf_öğrendik_artık;

namespace werewolf_öğrendik_artık
{
    public partial class GameForm : Form
    {
        private WerewolfGame game;

        public GameForm()
        {
            InitializeComponent();
            game = new WerewolfGame();
        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            // Additional initialization code here if necessary
        }

        private void btnAddPlayer_Click(object sender, EventArgs e)
        {
            string playerName = txtPlayerName.Text;
            if (!string.IsNullOrEmpty(playerName))
            {
                game.AddPlayer(playerName, Role.Villager);
                lstPlayers.Items.Add(playerName);
            }
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            game.AssignRoles();
            MessageBox.Show("Game started! Roles have been assigned.");
            UpdatePlayerList();
        }

        private void btnNightPhase_Click(object sender, EventArgs e)
        {
            game.NightPhase();
            UpdatePlayerList();
        }

        private void btnDayPhase_Click(object sender, EventArgs e)
        {
            string votedPlayer = lstPlayers.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(votedPlayer))
            {
                game.DayPhase();
                UpdatePlayerList();
            }
        }

        private void UpdatePlayerList()
        {
            lstPlayers.Items.Clear();
            foreach (var player in WerewolfGame.players)
            {
                lstPlayers.Items.Add(player.Name + (player.IsAlive ? "" : " (Eliminated)"));
            }
        }
    }
}
