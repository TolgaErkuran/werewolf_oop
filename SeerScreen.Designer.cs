namespace werewolf_öğrendik_artık
{
    partial class SeerScreen
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
            checkedListBox1 = new CheckedListBox();
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(12, 52);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(120, 256);
            checkedListBox1.TabIndex = 0;
            checkedListBox1.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 34);
            label1.Name = "label1";
            label1.Size = new Size(187, 15);
            label1.TabIndex = 1;
            label1.Text = "Choose a player to learn their role:";
            // 
            // button1
            // 
            button1.Location = new Point(12, 314);
            button1.Name = "button1";
            button1.Size = new Size(120, 34);
            button1.TabIndex = 2;
            button1.Text = "See!";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // SeerScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(222, 352);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(checkedListBox1);
            Name = "SeerScreen";
            Text = "SeerScreen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckedListBox checkedListBox1;
        private Label label1;
        private Button button1;
    }
}