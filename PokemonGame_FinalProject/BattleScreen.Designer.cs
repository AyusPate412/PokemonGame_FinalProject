namespace PokemonGame_FinalProject
{
    partial class BattleScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BattleScreen));
            this.attackButton = new System.Windows.Forms.Button();
            this.healButton = new System.Windows.Forms.Button();
            this.spAttackButton = new System.Windows.Forms.Button();
            this.battleBoss = new System.Windows.Forms.Label();
            this.battlePokemon = new System.Windows.Forms.Label();
            this.battleTimer = new System.Windows.Forms.Timer(this.components);
            this.playerHealth = new System.Windows.Forms.Label();
            this.bossHealth = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // attackButton
            // 
            this.attackButton.Image = ((System.Drawing.Image)(resources.GetObject("attackButton.Image")));
            this.attackButton.Location = new System.Drawing.Point(384, 385);
            this.attackButton.Margin = new System.Windows.Forms.Padding(2);
            this.attackButton.Name = "attackButton";
            this.attackButton.Size = new System.Drawing.Size(132, 74);
            this.attackButton.TabIndex = 0;
            this.attackButton.UseVisualStyleBackColor = true;
            this.attackButton.Click += new System.EventHandler(this.attackButton_Click);
            // 
            // healButton
            // 
            this.healButton.Image = ((System.Drawing.Image)(resources.GetObject("healButton.Image")));
            this.healButton.Location = new System.Drawing.Point(520, 385);
            this.healButton.Margin = new System.Windows.Forms.Padding(2);
            this.healButton.Name = "healButton";
            this.healButton.Size = new System.Drawing.Size(141, 74);
            this.healButton.TabIndex = 1;
            this.healButton.UseVisualStyleBackColor = true;
            this.healButton.Click += new System.EventHandler(this.healButton_Click);
            // 
            // spAttackButton
            // 
            this.spAttackButton.Image = ((System.Drawing.Image)(resources.GetObject("spAttackButton.Image")));
            this.spAttackButton.Location = new System.Drawing.Point(665, 385);
            this.spAttackButton.Margin = new System.Windows.Forms.Padding(2);
            this.spAttackButton.Name = "spAttackButton";
            this.spAttackButton.Size = new System.Drawing.Size(133, 74);
            this.spAttackButton.TabIndex = 2;
            this.spAttackButton.UseVisualStyleBackColor = true;
            this.spAttackButton.Click += new System.EventHandler(this.spAttackButton_Click);
            // 
            // battleBoss
            // 
            this.battleBoss.Location = new System.Drawing.Point(587, 121);
            this.battleBoss.Name = "battleBoss";
            this.battleBoss.Size = new System.Drawing.Size(197, 191);
            this.battleBoss.TabIndex = 4;
            // 
            // battlePokemon
            // 
            this.battlePokemon.Location = new System.Drawing.Point(16, 268);
            this.battlePokemon.Name = "battlePokemon";
            this.battlePokemon.Size = new System.Drawing.Size(197, 191);
            this.battlePokemon.TabIndex = 5;
            // 
            // battleTimer
            // 
            this.battleTimer.Enabled = true;
            this.battleTimer.Interval = 20;
            // 
            // playerHealth
            // 
            this.playerHealth.AutoSize = true;
            this.playerHealth.Location = new System.Drawing.Point(220, 416);
            this.playerHealth.Name = "playerHealth";
            this.playerHealth.Size = new System.Drawing.Size(0, 13);
            this.playerHealth.TabIndex = 6;
            // 
            // bossHealth
            // 
            this.bossHealth.AutoSize = true;
            this.bossHealth.Location = new System.Drawing.Point(661, 125);
            this.bossHealth.Name = "bossHealth";
            this.bossHealth.Size = new System.Drawing.Size(0, 13);
            this.bossHealth.TabIndex = 7;
            // 
            // BattleScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::PokemonGame_FinalProject.Properties.Resources.forest;
            this.Controls.Add(this.bossHealth);
            this.Controls.Add(this.playerHealth);
            this.Controls.Add(this.battlePokemon);
            this.Controls.Add(this.battleBoss);
            this.Controls.Add(this.spAttackButton);
            this.Controls.Add(this.healButton);
            this.Controls.Add(this.attackButton);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BattleScreen";
            this.Size = new System.Drawing.Size(800, 472);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.BattleScreen_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button attackButton;
        private System.Windows.Forms.Button healButton;
        private System.Windows.Forms.Button spAttackButton;
        private System.Windows.Forms.Label battleBoss;
        private System.Windows.Forms.Label battlePokemon;
        private System.Windows.Forms.Timer battleTimer;
        private System.Windows.Forms.Label playerHealth;
        private System.Windows.Forms.Label bossHealth;
    }
}
