using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace werewolf_öğrendik_artık
{
    public partial class SeerScreen : Form
    {
        public SeerScreen()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckedListBox.CheckedIndexCollection selected = checkedListBox1.CheckedIndices;
            if (selected.Count == 1)
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            var selectedPlayerName = checkedListBox1.CheckedItems[0].ToString();
            var player = WerewolfGame.players.FirstOrDefault(p => p.Name == selectedPlayerName);
            if (player != null )
            {
                MessageBox.Show($"{player.Name} is {player.Role.ToString()}");
            }

            NightWaitScreen nightWaitScreen = new NightWaitScreen();
            this.Close();
            this.FormClosed += (s, args) => nightWaitScreen.Show();
        }
    }
}
