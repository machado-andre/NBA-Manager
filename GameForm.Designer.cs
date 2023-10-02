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
            this.components = new System.ComponentModel.Container();
            this.labelVisitor = new System.Windows.Forms.Label();
            this.labelHome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelVisitorScore = new System.Windows.Forms.Label();
            this.labelHomeScore = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelTimer = new System.Windows.Forms.Label();
            this.btnStart = new Guna.UI2.WinForms.Guna2Button();
            this.Timer3 = new System.Windows.Forms.Timer(this.components);
            this.comboBoxCenter = new Guna.UI2.WinForms.Guna2ComboBox();
            this.comboBoxPF = new Guna.UI2.WinForms.Guna2ComboBox();
            this.comboBoxSF = new Guna.UI2.WinForms.Guna2ComboBox();
            this.comboBoxSG = new Guna.UI2.WinForms.Guna2ComboBox();
            this.labelCenter = new System.Windows.Forms.Label();
            this.labelPF = new System.Windows.Forms.Label();
            this.labelSF = new System.Windows.Forms.Label();
            this.labelSG = new System.Windows.Forms.Label();
            this.labelPG = new System.Windows.Forms.Label();
            this.comboBoxPG = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxGamePlays = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // labelVisitor
            // 
            this.labelVisitor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelVisitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.labelVisitor.Location = new System.Drawing.Point(113, 115);
            this.labelVisitor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelVisitor.Name = "labelVisitor";
            this.labelVisitor.Size = new System.Drawing.Size(265, 46);
            this.labelVisitor.TabIndex = 0;
            this.labelVisitor.Text = "Visitor Team";
            this.labelVisitor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelHome
            // 
            this.labelHome.AutoSize = true;
            this.labelHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.labelHome.Location = new System.Drawing.Point(460, 115);
            this.labelHome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHome.Name = "labelHome";
            this.labelHome.Size = new System.Drawing.Size(239, 46);
            this.labelHome.TabIndex = 1;
            this.labelHome.Text = "Home Team";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(386, 115);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 46);
            this.label1.TabIndex = 2;
            this.label1.Text = "@";
            // 
            // labelVisitorScore
            // 
            this.labelVisitorScore.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelVisitorScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.labelVisitorScore.Location = new System.Drawing.Point(232, 176);
            this.labelVisitorScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelVisitorScore.Name = "labelVisitorScore";
            this.labelVisitorScore.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelVisitorScore.Size = new System.Drawing.Size(138, 46);
            this.labelVisitorScore.TabIndex = 3;
            this.labelVisitorScore.Text = "0";
            this.labelVisitorScore.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelHomeScore
            // 
            this.labelHomeScore.AutoSize = true;
            this.labelHomeScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.labelHomeScore.Location = new System.Drawing.Point(435, 176);
            this.labelHomeScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHomeScore.Name = "labelHomeScore";
            this.labelHomeScore.Size = new System.Drawing.Size(42, 46);
            this.labelHomeScore.TabIndex = 4;
            this.labelHomeScore.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label2.Location = new System.Drawing.Point(394, 176);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 46);
            this.label2.TabIndex = 5;
            this.label2.Text = "-";
            // 
            // labelTimer
            // 
            this.labelTimer.AutoSize = true;
            this.labelTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.labelTimer.Location = new System.Drawing.Point(199, 585);
            this.labelTimer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.Size = new System.Drawing.Size(119, 46);
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
            this.btnStart.Location = new System.Drawing.Point(113, 636);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(280, 74);
            this.btnStart.TabIndex = 14;
            this.btnStart.Text = "Play Game";
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // Timer3
            // 
            this.Timer3.Interval = 2000;
            this.Timer3.Tick += new System.EventHandler(this.Timer3_Tick);
            // 
            // comboBoxCenter
            // 
            this.comboBoxCenter.BackColor = System.Drawing.Color.Transparent;
            this.comboBoxCenter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxCenter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCenter.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxCenter.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxCenter.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBoxCenter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboBoxCenter.ItemHeight = 30;
            this.comboBoxCenter.Location = new System.Drawing.Point(119, 505);
            this.comboBoxCenter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxCenter.Name = "comboBoxCenter";
            this.comboBoxCenter.Size = new System.Drawing.Size(238, 36);
            this.comboBoxCenter.TabIndex = 33;
            // 
            // comboBoxPF
            // 
            this.comboBoxPF.BackColor = System.Drawing.Color.Transparent;
            this.comboBoxPF.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxPF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPF.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxPF.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxPF.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBoxPF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboBoxPF.ItemHeight = 30;
            this.comboBoxPF.Location = new System.Drawing.Point(119, 440);
            this.comboBoxPF.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxPF.Name = "comboBoxPF";
            this.comboBoxPF.Size = new System.Drawing.Size(238, 36);
            this.comboBoxPF.TabIndex = 32;
            // 
            // comboBoxSF
            // 
            this.comboBoxSF.BackColor = System.Drawing.Color.Transparent;
            this.comboBoxSF.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxSF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSF.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxSF.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxSF.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBoxSF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboBoxSF.ItemHeight = 30;
            this.comboBoxSF.Location = new System.Drawing.Point(119, 375);
            this.comboBoxSF.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxSF.Name = "comboBoxSF";
            this.comboBoxSF.Size = new System.Drawing.Size(238, 36);
            this.comboBoxSF.TabIndex = 31;
            // 
            // comboBoxSG
            // 
            this.comboBoxSG.BackColor = System.Drawing.Color.Transparent;
            this.comboBoxSG.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxSG.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSG.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxSG.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxSG.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBoxSG.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboBoxSG.ItemHeight = 30;
            this.comboBoxSG.Location = new System.Drawing.Point(119, 311);
            this.comboBoxSG.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxSG.Name = "comboBoxSG";
            this.comboBoxSG.Size = new System.Drawing.Size(238, 36);
            this.comboBoxSG.TabIndex = 30;
            // 
            // labelCenter
            // 
            this.labelCenter.AutoSize = true;
            this.labelCenter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelCenter.Location = new System.Drawing.Point(85, 520);
            this.labelCenter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCenter.Name = "labelCenter";
            this.labelCenter.Size = new System.Drawing.Size(27, 25);
            this.labelCenter.TabIndex = 29;
            this.labelCenter.Text = "C";
            // 
            // labelPF
            // 
            this.labelPF.AutoSize = true;
            this.labelPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelPF.Location = new System.Drawing.Point(73, 454);
            this.labelPF.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPF.Name = "labelPF";
            this.labelPF.Size = new System.Drawing.Size(37, 25);
            this.labelPF.TabIndex = 28;
            this.labelPF.Text = "PF";
            // 
            // labelSF
            // 
            this.labelSF.AutoSize = true;
            this.labelSF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelSF.Location = new System.Drawing.Point(73, 391);
            this.labelSF.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSF.Name = "labelSF";
            this.labelSF.Size = new System.Drawing.Size(38, 25);
            this.labelSF.TabIndex = 27;
            this.labelSF.Text = "SF";
            // 
            // labelSG
            // 
            this.labelSG.AutoSize = true;
            this.labelSG.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelSG.Location = new System.Drawing.Point(69, 323);
            this.labelSG.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSG.Name = "labelSG";
            this.labelSG.Size = new System.Drawing.Size(41, 25);
            this.labelSG.TabIndex = 26;
            this.labelSG.Text = "SG";
            // 
            // labelPG
            // 
            this.labelPG.AutoSize = true;
            this.labelPG.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelPG.Location = new System.Drawing.Point(69, 260);
            this.labelPG.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPG.Name = "labelPG";
            this.labelPG.Size = new System.Drawing.Size(40, 25);
            this.labelPG.TabIndex = 25;
            this.labelPG.Text = "PG";
            // 
            // comboBoxPG
            // 
            this.comboBoxPG.BackColor = System.Drawing.Color.Transparent;
            this.comboBoxPG.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxPG.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPG.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxPG.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxPG.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBoxPG.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboBoxPG.ItemHeight = 30;
            this.comboBoxPG.Location = new System.Drawing.Point(119, 246);
            this.comboBoxPG.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxPG.Name = "comboBoxPG";
            this.comboBoxPG.Size = new System.Drawing.Size(238, 36);
            this.comboBoxPG.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2592, 458);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 20);
            this.label3.TabIndex = 34;
            this.label3.Text = "- PG ";
            // 
            // listBoxGamePlays
            // 
            this.listBoxGamePlays.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listBoxGamePlays.FormattingEnabled = true;
            this.listBoxGamePlays.ItemHeight = 20;
            this.listBoxGamePlays.Location = new System.Drawing.Point(948, 55);
            this.listBoxGamePlays.Name = "listBoxGamePlays";
            this.listBoxGamePlays.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listBoxGamePlays.Size = new System.Drawing.Size(348, 664);
            this.listBoxGamePlays.TabIndex = 35;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1344, 712);
            this.Controls.Add(this.listBoxGamePlays);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxCenter);
            this.Controls.Add(this.comboBoxPF);
            this.Controls.Add(this.comboBoxSF);
            this.Controls.Add(this.comboBoxSG);
            this.Controls.Add(this.labelCenter);
            this.Controls.Add(this.labelPF);
            this.Controls.Add(this.labelSF);
            this.Controls.Add(this.labelSG);
            this.Controls.Add(this.labelPG);
            this.Controls.Add(this.comboBoxPG);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.labelTimer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelHomeScore);
            this.Controls.Add(this.labelVisitorScore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelHome);
            this.Controls.Add(this.labelVisitor);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "GameForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "GameForm";
            this.Load += new System.EventHandler(this.GameForm_Load);
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
        private System.Windows.Forms.Timer Timer3;
        private Guna.UI2.WinForms.Guna2ComboBox comboBoxCenter;
        private Guna.UI2.WinForms.Guna2ComboBox comboBoxPF;
        private Guna.UI2.WinForms.Guna2ComboBox comboBoxSF;
        private Guna.UI2.WinForms.Guna2ComboBox comboBoxSG;
        private System.Windows.Forms.Label labelCenter;
        private System.Windows.Forms.Label labelPF;
        private System.Windows.Forms.Label labelSF;
        private System.Windows.Forms.Label labelSG;
        private System.Windows.Forms.Label labelPG;
        private Guna.UI2.WinForms.Guna2ComboBox comboBoxPG;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBoxGamePlays;
    }
}