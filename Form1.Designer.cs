namespace werewolf_öğrendik_artık
{
    partial class GameForm
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

        private void InitializeComponent()
        {
            btnAddPlayer = new Button();
            btnStartGame = new Button();
            btnNightPhase = new Button();
            lstPlayers = new ListBox();
            txtPlayerName = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnAddPlayer
            // 
            btnAddPlayer.Location = new Point(12, 38);
            btnAddPlayer.Name = "btnAddPlayer";
            btnAddPlayer.Size = new Size(125, 23);
            btnAddPlayer.TabIndex = 0;
            btnAddPlayer.Text = "Add Player";
            btnAddPlayer.UseVisualStyleBackColor = true;
            btnAddPlayer.Click += btnAddPlayer_Click;
            // 
            // btnStartGame
            // 
            btnStartGame.Location = new Point(143, 38);
            btnStartGame.Name = "btnStartGame";
            btnStartGame.Size = new Size(125, 23);
            btnStartGame.TabIndex = 1;
            btnStartGame.Text = "Set Roles";
            btnStartGame.UseVisualStyleBackColor = true;
            btnStartGame.Click += btnStartGame_Click;
            // 
            // btnNightPhase
            // 
            btnNightPhase.Location = new Point(111, 303);
            btnNightPhase.Name = "btnNightPhase";
            btnNightPhase.Size = new Size(125, 23);
            btnNightPhase.TabIndex = 2;
            btnNightPhase.Text = "Start Night Phase";
            btnNightPhase.UseVisualStyleBackColor = true;
            btnNightPhase.Click += btnNightPhase_Click;
            // 
            // lstPlayers
            // 
            lstPlayers.FormattingEnabled = true;
            lstPlayers.ItemHeight = 15;
            lstPlayers.Location = new Point(12, 67);
            lstPlayers.Name = "lstPlayers";
            lstPlayers.Size = new Size(256, 124);
            lstPlayers.TabIndex = 4;
            // 
            // txtPlayerName
            // 
            txtPlayerName.Location = new Point(12, 12);
            txtPlayerName.Name = "txtPlayerName";
            txtPlayerName.Size = new Size(256, 23);
            txtPlayerName.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(73, 219);
            label1.Name = "label1";
            label1.Size = new Size(144, 15);
            label1.TabIndex = 6;
            label1.Text = "Phase controls and voting";
            // 
            // GameForm
            // 
            ClientSize = new Size(367, 375);
            Controls.Add(label1);
            Controls.Add(txtPlayerName);
            Controls.Add(lstPlayers);
            Controls.Add(btnNightPhase);
            Controls.Add(btnStartGame);
            Controls.Add(btnAddPlayer);
            Name = "GameForm";
            Text = "Werewolf Moderator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnAddPlayer;
        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.Button btnNightPhase;
        private System.Windows.Forms.ListBox lstPlayers;
        private System.Windows.Forms.TextBox txtPlayerName;
        private System.Windows.Forms.Label label1;
    }

}