namespace werewolf_öğrendik_artık
{
    partial class WerewolfKillScreen
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
            label1 = new Label();
            checkedListBox1 = new CheckedListBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.ImageAlign = ContentAlignment.TopCenter;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(126, 15);
            label1.TabIndex = 0;
            label1.Text = "Choose to kill a player:";
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(12, 27);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(120, 184);
            checkedListBox1.TabIndex = 2;
            checkedListBox1.ThreeDCheckBoxes = true;
            checkedListBox1.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(12, 217);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "Kill!";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // WerewolfKillScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(215, 272);
            Controls.Add(button1);
            Controls.Add(checkedListBox1);
            Controls.Add(label1);
            Name = "WerewolfKillScreen";
            Text = "WerewolfKillScreen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private CheckedListBox checkedListBox1;
        private Button button1;
    }
    
}