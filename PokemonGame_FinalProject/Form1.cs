using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokemonGame_FinalProject
{
    public partial class Form1 : Form
    {
        //Player
        Rectangle player1 = new Rectangle(100, 100, 35, 40);

        Image[] playerMovements = { Properties.Resources.down1, Properties.Resources.left1, Properties.Resources.right1, Properties.Resources.up1 };
        Image playerCurrentDirection;

        //Pokemon Assets
        Image[] pokemonsList = { Properties.Resources.pikachu, Properties.Resources.squirtle, Properties.Resources.charmander, Properties.Resources.bulbasaur };
        String actualPokemon;

        //Grass
        Rectangle grass = new Rectangle(0, 0, 1000, 600);
        Image grassImg = Properties.Resources.bg;
        Image forrestImg = Properties.Resources.forest;

        //Brush
        SolidBrush transparent = new SolidBrush(Color.Transparent);

        //Player Speed
        int player1Speed = 5;

        int pokemonLv = 1;
        int pokemonHealth = 1000;
        int bossHealth = 10000;


        //Player Movement Booleans
        bool wPressed = false;
        bool sPressed = false;
        bool aPressed = false;
        bool dPressed = false;
        
        //Check the start button
        bool startButtonClicked = false;

        public Form1()
        {
            InitializeComponent();
            InitializeMainScreen();
            playerCurrentDirection = playerMovements[1];
            gameTimer.Enabled = false;

            this.KeyDown += new KeyEventHandler(Form1_KeyDown);
            this.KeyUp += new KeyEventHandler(Form1_KeyUp);
            this.Paint += new PaintEventHandler(Form1_Paint);
            this.gameTimer.Tick += new EventHandler(gameTimer_Tick);

            // Ensure the form has focus
            this.Focus();
        }

        

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    wPressed = false;
                    break;
                case Keys.S:
                    sPressed = false;
                    break;
                case Keys.A:
                    aPressed = false;
                    break;
                case Keys.D:
                    dPressed = false;
                    break;
            }
        }

        public void InitializeMainScreen()
        {
            pikachu.Visible = false;
            squirtle.Visible = false;
            charmander.Visible = false;
            bulbasaur.Visible = false;
            playerPreview.Visible = false;
            pokemonPreview.Visible = false;
            continueButton.Visible = false;
            characterLabel.Visible = false;
            playerNameInput.Visible = false;
        }
        
        public void InitializePokemonChoosingScreen()
        {
            startButton.Visible = false;
            exitButton.Visible = false;
            titleLabel.Image = null;

            pikachu.Visible = true;
            squirtle.Visible = true;
            charmander.Visible = true;
            bulbasaur.Visible = true;
            playerPreview.Visible = true;
            pokemonPreview.Visible = true;
            continueButton.Visible = true;
            characterLabel.Visible = true;
            playerNameInput.Visible = true;
        }

        public void PlayerMovement()
        {
            if (wPressed == true)
            {
                player1.Y -= player1Speed;
                playerCurrentDirection = playerMovements[3];
            }
            if (sPressed ==true)
            {
                player1.Y += player1Speed;
                playerCurrentDirection = playerMovements[0];
            }
            if (aPressed == true)
            {
                player1.X -= player1Speed;
                playerCurrentDirection = playerMovements[1];

            }
            if (dPressed == true)
            {
                player1.X += player1Speed;
                playerCurrentDirection = playerMovements[2];
            }
        }

       
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if(gameTimer.Enabled == false && startButtonClicked == false)
            {
                e.Graphics.DrawImage(forrestImg, grass);
                titleLabel.Image = Properties.Resources.Pokemon_Sign;
            }
            else if(gameTimer.Enabled == false && startButtonClicked == true)
            {
                InitializePokemonChoosingScreen();
                e.Graphics.DrawImage(forrestImg, grass);
            }
            else if (gameTimer.Enabled == true)
            {
                InitializeMainScreen();
                e.Graphics.DrawImage(grassImg, grass);
                e.Graphics.DrawImage(playerCurrentDirection, player1);
            }
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            PlayerMovement();
            Refresh();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            startButtonClicked = true;
            startButton.Visible = false;
            exitButton.Visible = false;
        }


        private void pikachu_Click(object sender, EventArgs e)
        {
            pokemonPreview.Image = pokemonsList[0];
        }

        private void charmander_Click(object sender, EventArgs e)
        {
            pokemonPreview.Image = pokemonsList[2];
        }

        private void bulbasaur_Click(object sender, EventArgs e)
        {
            pokemonPreview.Image = pokemonsList[3];
        }

        private void squirtle_Click(object sender, EventArgs e)
        {
            pokemonPreview.Image = pokemonsList[1];
        }

        private void continueButton_Click(object sender, EventArgs e)
        {
            gameTimer.Enabled = true;
            gameTimer.Start();
            if (pokemonPreview.Image == pokemonsList[1])
            {
                actualPokemon = "Pikachu";
            }
            else if (pokemonPreview.Image == pokemonsList[1])
            {
                actualPokemon = "Squirtle";
            }
            else if (pokemonPreview.Image == pokemonsList[2])
            {
                actualPokemon = "Charmander";
            }
            else if (pokemonPreview.Image == pokemonsList[3])
            {
                actualPokemon = "Bulbasaur";
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode)
            {
                case Keys.W:
                    wPressed = true;
                    break;
                case Keys.S: 
                    sPressed = true; 
                    break;
                case Keys.D: 
                    dPressed = true;
                    break;
                case Keys.A: 
                    aPressed = true; 
                    break;
            }
        }
    }
}
