namespace PokemonGame_FinalProject
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.titleLabel = new System.Windows.Forms.Label();
            this.characterLabel = new System.Windows.Forms.Label();
            this.playerNameInput = new System.Windows.Forms.TextBox();
            this.continueButton = new System.Windows.Forms.Button();
            this.pokemonPreview = new System.Windows.Forms.PictureBox();
            this.playerPreview = new System.Windows.Forms.PictureBox();
            this.squirtle = new System.Windows.Forms.Button();
            this.bulbasaur = new System.Windows.Forms.Button();
            this.charmander = new System.Windows.Forms.Button();
            this.pikachu = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pokemonPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Location = new System.Drawing.Point(217, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(320, 131);
            this.titleLabel.TabIndex = 0;
            // 
            // characterLabel
            // 
            this.characterLabel.BackColor = System.Drawing.Color.Transparent;
            this.characterLabel.Font = new System.Drawing.Font("Segoe MDL2 Assets", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.characterLabel.Location = new System.Drawing.Point(8, 226);
            this.characterLabel.Name = "characterLabel";
            this.characterLabel.Size = new System.Drawing.Size(338, 33);
            this.characterLabel.TabIndex = 7;
            this.characterLabel.Text = "Enter a Name for your Character:";
            // 
            // playerNameInput
            // 
            this.playerNameInput.Location = new System.Drawing.Point(68, 376);
            this.playerNameInput.Name = "playerNameInput";
            this.playerNameInput.Size = new System.Drawing.Size(100, 20);
            this.playerNameInput.TabIndex = 9;
            // 
            // continueButton
            // 
            this.continueButton.Image = ((System.Drawing.Image)(resources.GetObject("continueButton.Image")));
            this.continueButton.Location = new System.Drawing.Point(59, 416);
            this.continueButton.Name = "continueButton";
            this.continueButton.Size = new System.Drawing.Size(127, 33);
            this.continueButton.TabIndex = 11;
            this.continueButton.UseVisualStyleBackColor = true;
            this.continueButton.Click += new System.EventHandler(this.continueButton_Click);
            // 
            // pokemonPreview
            // 
            this.pokemonPreview.Location = new System.Drawing.Point(527, 226);
            this.pokemonPreview.Name = "pokemonPreview";
            this.pokemonPreview.Size = new System.Drawing.Size(228, 213);
            this.pokemonPreview.TabIndex = 10;
            this.pokemonPreview.TabStop = false;
            // 
            // playerPreview
            // 
            this.playerPreview.BackColor = System.Drawing.Color.Transparent;
            this.playerPreview.Image = ((System.Drawing.Image)(resources.GetObject("playerPreview.Image")));
            this.playerPreview.Location = new System.Drawing.Point(85, 262);
            this.playerPreview.Name = "playerPreview";
            this.playerPreview.Size = new System.Drawing.Size(69, 108);
            this.playerPreview.TabIndex = 8;
            this.playerPreview.TabStop = false;
            // 
            // squirtle
            // 
            this.squirtle.BackColor = System.Drawing.Color.YellowGreen;
            this.squirtle.Image = ((System.Drawing.Image)(resources.GetObject("squirtle.Image")));
            this.squirtle.Location = new System.Drawing.Point(598, 12);
            this.squirtle.Name = "squirtle";
            this.squirtle.Size = new System.Drawing.Size(174, 196);
            this.squirtle.TabIndex = 6;
            this.squirtle.UseVisualStyleBackColor = false;
            this.squirtle.Click += new System.EventHandler(this.squirtle_Click);
            // 
            // bulbasaur
            // 
            this.bulbasaur.BackColor = System.Drawing.Color.YellowGreen;
            this.bulbasaur.Image = ((System.Drawing.Image)(resources.GetObject("bulbasaur.Image")));
            this.bulbasaur.Location = new System.Drawing.Point(404, 12);
            this.bulbasaur.Name = "bulbasaur";
            this.bulbasaur.Size = new System.Drawing.Size(174, 196);
            this.bulbasaur.TabIndex = 5;
            this.bulbasaur.UseVisualStyleBackColor = false;
            this.bulbasaur.Click += new System.EventHandler(this.bulbasaur_Click);
            // 
            // charmander
            // 
            this.charmander.BackColor = System.Drawing.Color.YellowGreen;
            this.charmander.Image = ((System.Drawing.Image)(resources.GetObject("charmander.Image")));
            this.charmander.Location = new System.Drawing.Point(209, 12);
            this.charmander.Name = "charmander";
            this.charmander.Size = new System.Drawing.Size(174, 196);
            this.charmander.TabIndex = 4;
            this.charmander.UseVisualStyleBackColor = false;
            this.charmander.Click += new System.EventHandler(this.charmander_Click);
            // 
            // pikachu
            // 
            this.pikachu.BackColor = System.Drawing.Color.YellowGreen;
            this.pikachu.Image = ((System.Drawing.Image)(resources.GetObject("pikachu.Image")));
            this.pikachu.Location = new System.Drawing.Point(12, 12);
            this.pikachu.Name = "pikachu";
            this.pikachu.Size = new System.Drawing.Size(174, 196);
            this.pikachu.TabIndex = 3;
            this.pikachu.UseVisualStyleBackColor = false;
            this.pikachu.Click += new System.EventHandler(this.pikachu_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.OrangeRed;
            this.exitButton.Image = ((System.Drawing.Image)(resources.GetObject("exitButton.Image")));
            this.exitButton.Location = new System.Drawing.Point(305, 364);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(153, 75);
            this.exitButton.TabIndex = 2;
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.YellowGreen;
            this.startButton.Image = ((System.Drawing.Image)(resources.GetObject("startButton.Image")));
            this.startButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.startButton.Location = new System.Drawing.Point(289, 214);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(184, 114);
            this.startButton.TabIndex = 1;
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(633, 278);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.continueButton);
            this.Controls.Add(this.pokemonPreview);
            this.Controls.Add(this.playerNameInput);
            this.Controls.Add(this.playerPreview);
            this.Controls.Add(this.characterLabel);
            this.Controls.Add(this.squirtle);
            this.Controls.Add(this.bulbasaur);
            this.Controls.Add(this.charmander);
            this.Controls.Add(this.pikachu);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.titleLabel);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Pokemon";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pokemonPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerPreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button pikachu;
        private System.Windows.Forms.Button charmander;
        private System.Windows.Forms.Button bulbasaur;
        private System.Windows.Forms.Button squirtle;
        private System.Windows.Forms.Label characterLabel;
        private System.Windows.Forms.PictureBox playerPreview;
        private System.Windows.Forms.TextBox playerNameInput;
        private System.Windows.Forms.PictureBox pokemonPreview;
        private System.Windows.Forms.Button continueButton;
        private System.Windows.Forms.Button button1;
    }
}

