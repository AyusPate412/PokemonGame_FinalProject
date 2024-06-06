namespace PokemonGame_FinalProject
{
    partial class EndScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EndScreen));
            this.winnerImg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // winnerImg
            // 
            this.winnerImg.BackColor = System.Drawing.Color.Transparent;
            this.winnerImg.Location = new System.Drawing.Point(273, 169);
            this.winnerImg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.winnerImg.Name = "winnerImg";
            this.winnerImg.Size = new System.Drawing.Size(220, 207);
            this.winnerImg.TabIndex = 0;
            // 
            // EndScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.winnerImg);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "EndScreen";
            this.Size = new System.Drawing.Size(964, 612);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label winnerImg;
    }
}
