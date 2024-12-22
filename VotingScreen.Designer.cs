namespace werewolf_öğrendik_artık
{
    partial class VotingScreen
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lstAlivePlayers = new System.Windows.Forms.ListBox();
            this.btnVote = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstAlivePlayers
            // 
            this.lstAlivePlayers.FormattingEnabled = true;
            this.lstAlivePlayers.Location = new System.Drawing.Point(12, 12);
            this.lstAlivePlayers.Name = "lstAlivePlayers";
            this.lstAlivePlayers.Size = new System.Drawing.Size(260, 199);
            this.lstAlivePlayers.TabIndex = 0;
            // 
            // btnVote
            // 
            this.btnVote.Location = new System.Drawing.Point(197, 217);
            this.btnVote.Name = "btnVote";
            this.btnVote.Size = new System.Drawing.Size(75, 23);
            this.btnVote.TabIndex = 1;
            this.btnVote.Text = "Vote";
            this.btnVote.UseVisualStyleBackColor = true;
            this.btnVote.Click += new System.EventHandler(this.btnVote_Click);
            // 
            // VotingForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 252);
            this.Controls.Add(this.btnVote);
            this.Controls.Add(this.lstAlivePlayers);
            this.Name = "VotingForm";
            this.Text = "Voting Screen";
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.ListBox lstAlivePlayers;
        private System.Windows.Forms.Button btnVote;
    }
}
