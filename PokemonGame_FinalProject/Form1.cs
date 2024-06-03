using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace PokemonGame_FinalProject
{
    public partial class Form1 : Form
    {

        //Todo:
        //Store
        //Battle
        //End screen


        Random randGen = new Random();


        //Player
        List<Rectangle> treesList = new List<Rectangle>();
        List<Rectangle> treesHitBoxList = new List<Rectangle>();
        List<Rectangle> chestList = new List<Rectangle>();

       

        Image[] treesImg = { Properties.Resources.tree1, Properties.Resources.tree2, Properties.Resources.tree3, Properties.Resources.grass };
        List<Image> treeImgList = new List<Image>();
        Image[] playerMovements = { Properties.Resources.down1, Properties.Resources.left1, Properties.Resources.right1, Properties.Resources.up1 };
        Image playerCurrentDirection;
        Image playerHouse = Properties.Resources.house;
        Image HouseInteriorImg = Properties.Resources.houseInterior;
        Image vendingMachineImg = Properties.Resources.evolveMachine;
        Image[] pokemonsList = { Properties.Resources.pikachu, Properties.Resources.squirtle, Properties.Resources.charmander, Properties.Resources.bulbasaur };
        Image grassImg = Properties.Resources.bg;
        Image forrestImg = Properties.Resources.forest;
        Image chestImg = Properties.Resources.chestImg;
        Image plantArena = Properties.Resources.arena_plant;



        Rectangle actualChest = new Rectangle(20, 50, 30, 20);
        Rectangle player1 = new Rectangle(400, 250, 35, 40);

        //Player House 
        Rectangle house = new Rectangle(480, 100, 230, 200);
        Rectangle door = new Rectangle(578, 290, 35, 10);

        Rectangle houseInterior = new Rectangle(200, -20, 400, 500);
        Rectangle exitDoor = new Rectangle(310, 450, 45, 10);
        Rectangle vendingMachine = new Rectangle(250, 100, 40, 70);

        Rectangle houseWall = new Rectangle(500, 240, 200, 58);
        Rectangle houseWallInterior1 = new Rectangle(220, -20, 10, 500);
        Rectangle houseWallInterior2 = new Rectangle(190, 100, 400, 10);
        Rectangle houseWallInterior3 = new Rectangle(570, -20, 10, 500);
        Rectangle houseWallInterior4 = new Rectangle(200, 440, 110, 10);
        Rectangle houseWallInterior5 = new Rectangle(355, 440, 215, 10);

        Rectangle grass = new Rectangle(0, 0, 1000, 600);
        Rectangle grassArena = new Rectangle(300, 100, 200, 200);

        String actualPokemon;


        //Brush
        SolidBrush transparent = new SolidBrush(Color.Transparent);
        SolidBrush blackBrush = new SolidBrush(Color.Black);
        SolidBrush redBrush = new SolidBrush(Color.Red);
        Font drawFont = new Font("Arial", 16, FontStyle.Bold);


        //Player Stats
        string playerName;
        string gameState = "Start Screen";

        int player1Speed = 15;
        int pokemonLv = 1;
        int pokemonHealth = 1000;
        int bossHealth = 10000;
        int playerMoney = 0;

        //Player Movement Booleans
        bool wPressed = false;
        bool sPressed = false;
        bool aPressed = false;
        bool dPressed = false;


        public Form1()
        {
            InitializeComponent();
            InitializeMainScreen();
            playerCurrentDirection = playerMovements[1];

            gameTimer.Enabled = false;
        }

        public void PlayerMovement()
        {

            if (wPressed == true && player1.Y > 0) 
            {
                player1.Y -= player1Speed;
                playerCurrentDirection = playerMovements[3];
            }

            if (sPressed == true && player1.Y < this.Height - 80)
            {
                player1.Y += player1Speed;
                playerCurrentDirection = playerMovements[0];
            }
            if (aPressed == true && player1.X > 0)
            {
                if (player1.X < player1.Width && gameState == "Battle Screen")
                {
                    gameState = "Main Screen";
                    player1.X = this.Width - player1.Width;
                    obstacleSpawn();
                    doorCollision();    
                    obstacleHitBoxSpawn();
                }

                    player1.X -= player1Speed;
                playerCurrentDirection = playerMovements[1];
            }
            if (dPressed == true)
            {
                player1.X += player1Speed;
                playerCurrentDirection = playerMovements[2];

                if (player1.X > this.Width && gameState == "Main Screen")
                {
                    gameState = "Battle Screen";
                    player1.X = 0;
                }
                //Add so that player can go back from the arena screen to the main screen

            }
            if (dPressed == true && gameState == "Battle Screen" && player1.X > this.Width - player1.Width)
            {
                player1.X = player1.X - player1Speed;
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (gameState == "Start Screen")
            {
                e.Graphics.Clear(Color.White);
                e.Graphics.DrawImage(forrestImg, grass);
                titleLabel.Image = Properties.Resources.Pokemon_Sign;
            }
            else if (gameState == "Choosing Screen")
            {
                e.Graphics.Clear(Color.White);
                e.Graphics.DrawImage(forrestImg, grass);
            }
            else if (gameState == "Main Screen")
            {
                e.Graphics.Clear(Color.White);
                e.Graphics.DrawImage(grassImg, grass);
                e.Graphics.DrawImage(playerCurrentDirection, player1);

                for (int i = 0; i < treesList.Count; i++)
                {
                    e.Graphics.DrawImage(treeImgList[i], treesList[i]);
                }
                

                e.Graphics.DrawImage(chestImg, actualChest);

                e.Graphics.DrawImage(playerHouse, house);
                e.Graphics.DrawString($"{playerName}  LV:{pokemonLv}\nCoins:{playerMoney}", drawFont, blackBrush, 20, 30);
            }

            else if (gameState == "Battle Screen")
            {
                e.Graphics.Clear(Color.White);
                e.Graphics.DrawImage(grassImg, grass);
                e.Graphics.DrawImage(playerCurrentDirection, player1);
                e.Graphics.DrawImage(plantArena, grassArena);
                e.Graphics.DrawString($"LV:{pokemonLv}\nCoins:{playerMoney}", drawFont, blackBrush, 20, 30);
            }

            else if (gameState == "House Interior")
            {
                e.Graphics.Clear(Color.Black);
                e.Graphics.DrawImage(HouseInteriorImg, houseInterior);
                e.Graphics.DrawImage(playerCurrentDirection, player1);
                e.Graphics.DrawString($"Coins:{playerMoney}", drawFont, blackBrush, 20, 30);
                e.Graphics.DrawImage(vendingMachineImg, vendingMachine);
            }
        }
        private void gameTimer_Tick(object sender, EventArgs e)
        {
            PlayerMovement();
            doorCollision();
            obstacleCollision();
            houseCollision();
            InteriorCollision();
            chestSpawn();
            chestCollision();
            Refresh();
        }

        private void obstacleHitBoxSpawn()
        {
            Rectangle treeHitBox1 = new Rectangle(30, 110, 75, 40);
            treesHitBoxList.Add(treeHitBox1);
            Rectangle treeHitBox2 = new Rectangle(200, 95, 75, 40);
            treesHitBoxList.Add(treeHitBox2);
            Rectangle treeHitBox3 = new Rectangle(500, 75, 75, 40);
            treesHitBoxList.Add(treeHitBox3);
            Rectangle treeHitBox4 = new Rectangle(700, 85, 75, 40);
            treesHitBoxList.Add(treeHitBox4);
            Rectangle treeHitBox5 = new Rectangle(100, 410, 75, 40);
            treesHitBoxList.Add(treeHitBox5);
            Rectangle treeHitBox6 = new Rectangle(300, 260, 75, 40);
            treesHitBoxList.Add(treeHitBox6);
            Rectangle treeHitBox7 = new Rectangle(600, 430, 75, 40);
            treesHitBoxList.Add(treeHitBox7);
            Rectangle treeHitBox8 = new Rectangle(450, 380, 75, 40);
            treesHitBoxList.Add(treeHitBox8);
            Rectangle treeHitBox9 = new Rectangle(80, 250, 75, 40);
            treesHitBoxList.Add(treeHitBox9);
        }

        private void obstacleSpawn()
        {
            Rectangle tree1 = new Rectangle(30, 50, 75, 100);
            treesList.Add(tree1);
            Rectangle tree2 = new Rectangle(200, 35, 75, 100);
            treesList.Add(tree2);
            Rectangle tree3 = new Rectangle(500, 15, 75, 100);
            treesList.Add(tree3);
            Rectangle tree4 = new Rectangle(700, 25, 75, 100);
            treesList.Add(tree4);
            Rectangle tree5 = new Rectangle(100, 350, 75, 100);
            treesList.Add(tree5);
            Rectangle tree6 = new Rectangle(300, 200, 75, 100);
            treesList.Add(tree6);
            Rectangle tree7 = new Rectangle(600, 370, 75, 100);
            treesList.Add(tree7);
            Rectangle tree8 = new Rectangle(450, 320, 75, 100);
            treesList.Add(tree8);
            Rectangle tree9 = new Rectangle(80, 190, 75, 100);
            treesList.Add(tree9);

                for (int i = 0; i < treesList.Count; i++)
                {
                    if (i % 3 == 0)
                    {
                        treeImgList.Add(Properties.Resources.tree1);
                    }

                    else if (i % 3 == 1)
                    {
                        treeImgList.Add(Properties.Resources.tree2);
                    }

                    else
                    {
                        treeImgList.Add(Properties.Resources.tree3);
                    }
                }
        }
        private void obstacleCollision()
        {
            for (int i = 0; i < treesHitBoxList.Count; i++)
            {
                if (player1.IntersectsWith(treesHitBoxList[i]))
                {
                    if (wPressed == true)
                    {
                        player1.Y += player1Speed;
                    }
                    if (sPressed == true)
                    {
                        player1.Y -= player1Speed; 
                    }
                    if (aPressed == true)
                    {
                        player1.X += player1Speed; 
                    }
                    if (dPressed == true)
                    {
                        player1.X -= player1Speed;
                    }
                }
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            InitializePokemonChoosingScreen();
            gameState = "Choosing Screen";
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
            InitializeMainScreen();
            gameState = "Main Screen";
            chestSpawn();
            playerName = playerNameInput.Text;
            if (pokemonPreview.Image == pokemonsList[0])
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

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
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

        public void InitializeMainScreen()
        {
            gameTimer.Enabled = true;
            pikachu.Visible = false;
            squirtle.Visible = false;
            charmander.Visible = false;
            bulbasaur.Visible = false;
            playerPreview.Visible = false;
            pokemonPreview.Visible = false;
            continueButton.Visible = false;
            characterLabel.Visible = false;
            playerNameInput.Visible = false;
            this.BackgroundImage = Properties.Resources.bg;
            obstacleSpawn();
            doorCollision();
            obstacleHitBoxSpawn();

        }

        public void InitializePokemonChoosingScreen()
        {
            startButton.Visible = false;
            exitButton.Visible = false;
            titleLabel.Visible = false;

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

        private void chestSpawn()
        {
            if (gameState == "Main Screen")
            {
                Rectangle chest1 = new Rectangle(20, 50, 30, 20);
                chestList.Add(chest1);
                Rectangle chest2 = new Rectangle(150, 90, 30, 20);
                chestList.Add(chest2);
                Rectangle chest3 = new Rectangle(400, 100, 30, 20);
                chestList.Add(chest3);
                Rectangle chest4 = new Rectangle(670, 100, 30, 20);
                chestList.Add(chest4);
                Rectangle chest5 = new Rectangle(100, 300, 30, 20);
                chestList.Add(chest5);
                Rectangle chest6 = new Rectangle(100, 150, 30, 20);
                chestList.Add(chest6);
                Rectangle chest7 = new Rectangle(250, 300, 30, 20);
                chestList.Add(chest7);
                Rectangle chest8 = new Rectangle(400, 300, 30, 20);
                chestList.Add(chest8);
                Rectangle chest9 = new Rectangle(700, 300, 30, 20);
                chestList.Add(chest9);
                Rectangle chest10 = new Rectangle(20, 400, 30, 20);
                chestList.Add(chest10);
                Rectangle chest11 = new Rectangle(350, 400, 30, 20);
                chestList.Add(chest11);
                Rectangle chest12 = new Rectangle(500, 430, 30, 20);
                chestList.Add(chest12);
                Rectangle chest13 = new Rectangle(700, 400, 30, 20);
                chestList.Add(chest13);



            }
        }
        private void chestCollision()
        {
            int chestRand = randGen.Next(0, chestList.Count);
            int loot = randGen.Next(1, 4);

            if (gameState == "Main Screen" && player1.IntersectsWith(actualChest))
            {
                actualChest.X = chestList[chestRand].X;
                actualChest.Y = chestList[chestRand].Y;
                playerMoney += loot;
            }
        }
        private void doorCollision()
        {

            if (gameState == "Main Screen" && player1.IntersectsWith(door))
            {
                gameState = "House Interior";
                player1.X = 317;
                player1.Y = 380;

            }

            for (int i = 0; i < treesList.Count(); i++)
            {
                if (gameState == "House Interior" || gameState == "Battle Screen")
                {
                    treesList.RemoveAt(i);
                    treesHitBoxList.RemoveAt(i);
                }
            }

            for(int i = 0; i < chestList.Count(); i++)
            {
                if(gameState == "House Interior" || gameState == "Battle Screen")
                {
                    chestList.RemoveAt(i);
                }
            }

            if( gameState == "House Interior" && player1.IntersectsWith(exitDoor))
            {
                gameState = "Main Screen";
                player1.X = door.X + 10;
                player1.Y = door.Y + 10;
                obstacleSpawn();
                doorCollision();    
                obstacleHitBoxSpawn();
                chestSpawn();
            }
             if(gameState == "House Interior" && player1.IntersectsWith(vendingMachine)){
                gameState = "Evolve Screen";
            }


        }
        
        private void houseCollision()
        {
            if (gameState == "Main Screen" && player1.IntersectsWith(houseWall))
            {
                if (wPressed == true)
                {
                    player1.Y += player1Speed;
                }
                if (sPressed == true)
                {
                    player1.Y -= player1Speed;
                }
                if (aPressed == true)
                {
                    player1.X += player1Speed;
                }
                if (dPressed == true)
                {
                    player1.X -= player1Speed;
                }
            }
        }
        private void InteriorCollision()
        {
            if (gameState == "House Interior" && player1.IntersectsWith(houseWallInterior1))
            {
                if (aPressed == true)
                {
                    player1.X += player1Speed;
                }
            }
            if(gameState == "House Interior" && player1.IntersectsWith(houseWallInterior2))
            {
                if(wPressed == true)
                {
                    player1.Y += player1Speed;
                }
            }
            if(gameState == "House Interior" && player1.IntersectsWith(houseWallInterior3))
            {
                if (dPressed == true)
                {
                    player1.X -= player1Speed;
                }
            }
            if (gameState == "House Interior" && player1.IntersectsWith(houseWallInterior4))
            {
                if (sPressed == true)
                {
                    player1.Y -= player1Speed;
                }
            }
            if (gameState == "House Interior" && player1.IntersectsWith(houseWallInterior5))
            {
                if (sPressed == true)
                {
                    player1.Y -= player1Speed;
                }
            }
        }
    }
}
