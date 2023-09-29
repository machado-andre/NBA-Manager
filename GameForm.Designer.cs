namespace NBAManager
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelVisitor = new System.Windows.Forms.Label();
            this.labelHome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelVisitorScore = new System.Windows.Forms.Label();
            this.labelHomeScore = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelTimer = new System.Windows.Forms.Label();
            this.btnStart = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // labelVisitor
            // 
            this.labelVisitor.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelVisitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.labelVisitor.Location = new System.Drawing.Point(486, 94);
            this.labelVisitor.Name = "labelVisitor";
            this.labelVisitor.Size = new System.Drawing.Size(171, 31);
            this.labelVisitor.TabIndex = 0;
            this.labelVisitor.Text = "Visitor Team";
            this.labelVisitor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelHome
            // 
            this.labelHome.AutoSize = true;
            this.labelHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.labelHome.Location = new System.Drawing.Point(710, 94);
            this.labelHome.Name = "labelHome";
            this.labelHome.Size = new System.Drawing.Size(162, 31);
            this.labelHome.TabIndex = 1;
            this.labelHome.Text = "Home Team";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(663, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "@";
            // 
            // labelVisitorScore
            // 
            this.labelVisitorScore.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelVisitorScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.labelVisitorScore.Location = new System.Drawing.Point(565, 140);
            this.labelVisitorScore.Name = "labelVisitorScore";
            this.labelVisitorScore.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelVisitorScore.Size = new System.Drawing.Size(86, 31);
            this.labelVisitorScore.TabIndex = 3;
            this.labelVisitorScore.Text = "0";
            this.labelVisitorScore.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelHomeScore
            // 
            this.labelHomeScore.AutoSize = true;
            this.labelHomeScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.labelHomeScore.Location = new System.Drawing.Point(710, 140);
            this.labelHomeScore.Name = "labelHomeScore";
            this.labelHomeScore.Size = new System.Drawing.Size(29, 31);
            this.labelHomeScore.TabIndex = 4;
            this.labelHomeScore.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label2.Location = new System.Drawing.Point(672, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 31);
            this.label2.TabIndex = 5;
            this.label2.Text = "-";
            // 
            // labelTimer
            // 
            this.labelTimer.AutoSize = true;
            this.labelTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.labelTimer.Location = new System.Drawing.Point(643, 549);
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.Size = new System.Drawing.Size(82, 31);
            this.labelTimer.TabIndex = 6;
            this.labelTimer.Text = "12:00";
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Transparent;
            this.btnStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnStart.BorderColor = System.Drawing.Color.Silver;
            this.btnStart.BorderRadius = 20;
            this.btnStart.BorderThickness = 1;
            this.btnStart.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnStart.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnStart.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnStart.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnStart.FillColor = System.Drawing.Color.Azure;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnStart.ForeColor = System.Drawing.Color.DarkGray;
            this.btnStart.Location = new System.Drawing.Point(591, 596);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(187, 48);
            this.btnStart.TabIndex = 14;
            this.btnStart.Text = "Start Game";
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.labelTimer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelHomeScore);
            this.Controls.Add(this.labelVisitorScore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelHome);
            this.Controls.Add(this.labelVisitor);
            this.Name = "GameForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "GameForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelVisitor;
        private System.Windows.Forms.Label labelHome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelVisitorScore;
        private System.Windows.Forms.Label labelHomeScore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelTimer;
        private Guna.UI2.WinForms.Guna2Button btnStart;
    }
}