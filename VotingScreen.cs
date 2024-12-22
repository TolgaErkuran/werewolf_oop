using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace werewolf_öğrendik_artık
{
    public partial class VotingScreen : Form
    {
        public string SelectedPlayer { get; private set; } // The player selected by the vote

        public VotingScreen(List<string> alivePlayers)
        {
            InitializeComponent();

            // Populate the ListBox with alive players
            lstAlivePlayers.Items.AddRange(alivePlayers.ToArray());
        }

        private void btnVote_Click(object sender, EventArgs e)
        {
            // Check if a player is selected
            if (lstAlivePlayers.SelectedItem != null)
            {
                SelectedPlayer = lstAlivePlayers.SelectedItem.ToString();
                this.DialogResult = DialogResult.OK; // Close the form and signal success
            }
            else
            {
                MessageBox.Show("Please select a player to vote for.", "Vote Error");
            }
        }
    }
}
