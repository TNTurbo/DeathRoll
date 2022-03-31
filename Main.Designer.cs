namespace DeathRollSim
{
    partial class Deathroll
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
            this.dgvRolls = new System.Windows.Forms.DataGridView();
            this.txtPlayer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtGame = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtRoll = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rdoAFirst = new System.Windows.Forms.RadioButton();
            this.rdoRandom = new System.Windows.Forms.RadioButton();
            this.grpOptions = new System.Windows.Forms.GroupBox();
            this.btnSim = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtGames = new System.Windows.Forms.TextBox();
            this.dgvFrequency = new System.Windows.Forms.DataGridView();
            this.txtEnded = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtFrequency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtStartingNum = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtBWins = new System.Windows.Forms.TextBox();
            this.txtAWins = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRolls)).BeginInit();
            this.grpOptions.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFrequency)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvRolls
            // 
            this.dgvRolls.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvRolls.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRolls.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtPlayer,
            this.txtGame,
            this.txtRoll,
            this.txtMax});
            this.dgvRolls.Location = new System.Drawing.Point(330, 51);
            this.dgvRolls.Name = "dgvRolls";
            this.dgvRolls.ReadOnly = true;
            this.dgvRolls.RowHeadersVisible = false;
            this.dgvRolls.Size = new System.Drawing.Size(375, 504);
            this.dgvRolls.TabIndex = 2;
            // 
            // txtPlayer
            // 
            this.txtPlayer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtPlayer.HeaderText = "Player";
            this.txtPlayer.Name = "txtPlayer";
            this.txtPlayer.ReadOnly = true;
            // 
            // txtGame
            // 
            this.txtGame.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtGame.HeaderText = "Game Number";
            this.txtGame.Name = "txtGame";
            this.txtGame.ReadOnly = true;
            // 
            // txtRoll
            // 
            this.txtRoll.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtRoll.HeaderText = "Roll Result";
            this.txtRoll.Name = "txtRoll";
            this.txtRoll.ReadOnly = true;
            // 
            // txtMax
            // 
            this.txtMax.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtMax.HeaderText = "Out Of";
            this.txtMax.Name = "txtMax";
            this.txtMax.ReadOnly = true;
            // 
            // rdoAFirst
            // 
            this.rdoAFirst.AutoSize = true;
            this.rdoAFirst.Location = new System.Drawing.Point(6, 13);
            this.rdoAFirst.Name = "rdoAFirst";
            this.rdoAFirst.Size = new System.Drawing.Size(64, 17);
            this.rdoAFirst.TabIndex = 4;
            this.rdoAFirst.TabStop = true;
            this.rdoAFirst.Text = "Player A";
            this.rdoAFirst.UseVisualStyleBackColor = true;
            // 
            // rdoRandom
            // 
            this.rdoRandom.AutoSize = true;
            this.rdoRandom.Location = new System.Drawing.Point(76, 13);
            this.rdoRandom.Name = "rdoRandom";
            this.rdoRandom.Size = new System.Drawing.Size(65, 17);
            this.rdoRandom.TabIndex = 5;
            this.rdoRandom.TabStop = true;
            this.rdoRandom.Text = "Random";
            this.rdoRandom.UseVisualStyleBackColor = true;
            // 
            // grpOptions
            // 
            this.grpOptions.Controls.Add(this.rdoAFirst);
            this.grpOptions.Controls.Add(this.rdoRandom);
            this.grpOptions.Location = new System.Drawing.Point(437, 9);
            this.grpOptions.Name = "grpOptions";
            this.grpOptions.Size = new System.Drawing.Size(143, 36);
            this.grpOptions.TabIndex = 7;
            this.grpOptions.TabStop = false;
            this.grpOptions.Text = "First Roll";
            // 
            // btnSim
            // 
            this.btnSim.Location = new System.Drawing.Point(12, 7);
            this.btnSim.Name = "btnSim";
            this.btnSim.Size = new System.Drawing.Size(121, 38);
            this.btnSim.TabIndex = 8;
            this.btnSim.Text = "Simulate";
            this.btnSim.UseVisualStyleBackColor = true;
            this.btnSim.Click += new System.EventHandler(this.btnSim_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(584, 7);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(121, 38);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear Data";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtGames);
            this.groupBox1.Location = new System.Drawing.Point(139, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(143, 36);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Play n Games";
            // 
            // txtGames
            // 
            this.txtGames.Location = new System.Drawing.Point(6, 13);
            this.txtGames.Name = "txtGames";
            this.txtGames.Size = new System.Drawing.Size(131, 20);
            this.txtGames.TabIndex = 0;
            this.txtGames.Text = "1";
            // 
            // dgvFrequency
            // 
            this.dgvFrequency.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvFrequency.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFrequency.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtEnded,
            this.txtFrequency});
            this.dgvFrequency.Location = new System.Drawing.Point(12, 51);
            this.dgvFrequency.Name = "dgvFrequency";
            this.dgvFrequency.ReadOnly = true;
            this.dgvFrequency.RowHeadersVisible = false;
            this.dgvFrequency.Size = new System.Drawing.Size(312, 572);
            this.dgvFrequency.TabIndex = 11;
            // 
            // txtEnded
            // 
            this.txtEnded.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtEnded.HeaderText = "Ended After";
            this.txtEnded.Name = "txtEnded";
            this.txtEnded.ReadOnly = true;
            // 
            // txtFrequency
            // 
            this.txtFrequency.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtFrequency.HeaderText = "Frequency";
            this.txtFrequency.Name = "txtFrequency";
            this.txtFrequency.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtStartingNum);
            this.groupBox2.Location = new System.Drawing.Point(288, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(143, 36);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Roll Starting At";
            // 
            // txtStartingNum
            // 
            this.txtStartingNum.Location = new System.Drawing.Point(6, 13);
            this.txtStartingNum.Name = "txtStartingNum";
            this.txtStartingNum.Size = new System.Drawing.Size(131, 20);
            this.txtStartingNum.TabIndex = 0;
            this.txtStartingNum.Text = "100";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtBWins);
            this.groupBox3.Controls.Add(this.txtAWins);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(330, 561);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(375, 62);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Stats";
            // 
            // txtBWins
            // 
            this.txtBWins.Location = new System.Drawing.Point(113, 36);
            this.txtBWins.Name = "txtBWins";
            this.txtBWins.Size = new System.Drawing.Size(256, 20);
            this.txtBWins.TabIndex = 3;
            this.txtBWins.Text = "0";
            // 
            // txtAWins
            // 
            this.txtAWins.Location = new System.Drawing.Point(113, 16);
            this.txtAWins.Name = "txtAWins";
            this.txtAWins.Size = new System.Drawing.Size(256, 20);
            this.txtAWins.TabIndex = 2;
            this.txtAWins.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Player B Wins: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Player A Wins: ";
            // 
            // Deathroll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
            this.ClientSize = new System.Drawing.Size(716, 635);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvFrequency);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSim);
            this.Controls.Add(this.grpOptions);
            this.Controls.Add(this.dgvRolls);
            this.Name = "Deathroll";
            this.Text = "DRS";
            this.Load += new System.EventHandler(this.Deathroll_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRolls)).EndInit();
            this.grpOptions.ResumeLayout(false);
            this.grpOptions.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFrequency)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvRolls;
        private System.Windows.Forms.RadioButton rdoAFirst;
        private System.Windows.Forms.RadioButton rdoRandom;
        private System.Windows.Forms.GroupBox grpOptions;
        private System.Windows.Forms.Button btnSim;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtGames;
        private System.Windows.Forms.DataGridView dgvFrequency;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtEnded;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtFrequency;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtStartingNum;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtBWins;
        private System.Windows.Forms.TextBox txtAWins;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtPlayer;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtGame;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtRoll;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtMax;
    }
}

