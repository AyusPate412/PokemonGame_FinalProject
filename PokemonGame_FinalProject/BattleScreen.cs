using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace PokemonGame_FinalProject
{
    public partial class BattleScreen : UserControl
    {
        string playerChoice, cpuChoice;
        int choicePause = 1000;
        int outcomePause = 3000;
        Random randGen = new Random();
        int playerTurnCount = 0;
        int cpuTurnCount = 0;
        bool playerSpAttackOnCooldown = false;
        bool cpuSpAttackOnCooldown = false;

        public BattleScreen()
        {
            InitializeComponent();
            battlePokemon.Image = GameScreen.playerPokemon;
            battleBoss.Image = GameScreen.boss1;
            playerHealth.Text = $"{GameScreen.pokemonHealth}";
            bossHealth.Text = $"{GameScreen.bossHealth}";
        }

        private void attackButton_Click(object sender, EventArgs e)
        {
            playerChoice = "Normal Attack";
            playerTurn();
        }

        private void healButton_Click(object sender, EventArgs e)
        {
            playerChoice = "Heal";
            playerTurn();
        }

        private void spAttackButton_Click(object sender, EventArgs e)
        {
            if (!playerSpAttackOnCooldown)
            {
                playerChoice = "Special Attack";
                playerSpAttackOnCooldown = true;
                playerTurnCount = 0;  // Reset cooldown counter for player
                playerTurn();
            }
            else
            {
                MessageBox.Show("Special Attack is on cooldown!");
            }
        }

        private void playerTurn()
        {
            playerFightingResult();
            Refresh();
            checkWinCondition();
            cpuTurn();
        }

        private void cpuTurn()
        {
            computerChoice();
            computerFightingResult();
            Refresh();
            checkWinCondition();

            // Update cooldown counters
            playerTurnCount++;
            cpuTurnCount++;

            // Reset cooldown if enough turns have passed
            if (playerTurnCount >= 3)
            {
                playerSpAttackOnCooldown = false;
            }
            if (cpuTurnCount >= 3)
            {
                cpuSpAttackOnCooldown = false;
            }
        }

        public void computerChoice()
        {
            int randValue = randGen.Next(1, 100);
            if (cpuSpAttackOnCooldown && randValue < 60)
            {
                cpuChoice = "Normal Attack";
            }
            else if (cpuSpAttackOnCooldown && randValue < 90)
            {
                cpuChoice = "Heal";
            }
            else if (!cpuSpAttackOnCooldown && randValue < 30)
            {
                cpuChoice = "Heal";
            }
            else if (!cpuSpAttackOnCooldown && randValue < 90)
            {
                cpuChoice = "Special Attack";
                cpuSpAttackOnCooldown = true;
                cpuTurnCount = 0;  // Reset cooldown counter for CPU
            }
            else
            {
                cpuChoice = "Normal Attack";
            }
            Thread.Sleep(choicePause);
        }

        public void playerFightingResult()
        {
            if (playerChoice == "Heal")
            {
                GameScreen.pokemonHealth += GameScreen.pokemonHeal;
            }
            else if (playerChoice == "Normal Attack")
            {
                GameScreen.bossHealth -= GameScreen.pokemonAtk;
            }
            else if (playerChoice == "Special Attack")
            {
                GameScreen.bossHealth -= GameScreen.pokemonSpAtk;
            }
            playerHealth.Text = $"{GameScreen.pokemonHealth}";
            bossHealth.Text = $"{GameScreen.bossHealth}";
            Thread.Sleep(outcomePause);
        }

        public void computerFightingResult()
        {
            if (cpuChoice == "Heal")
            {
                GameScreen.bossHealth += GameScreen.bossHeal;
            }
            else if (cpuChoice == "Normal Attack")
            {
                GameScreen.pokemonHealth -= GameScreen.bossAtk;
            }
            else if (cpuChoice == "Special Attack")
            {
                GameScreen.pokemonHealth -= GameScreen.bossSpAtk;
            }
            playerHealth.Text = $"{GameScreen.pokemonHealth}";
            bossHealth.Text = $"{GameScreen.bossHealth}";
            Thread.Sleep(outcomePause);
        }

        private void checkWinCondition()
        {
            if (GameScreen.pokemonHealth <= 0)
            {
                MessageBox.Show("You lose!");

                GameScreen gs = new GameScreen();
                GameScreen.t1.Enabled = true;
                
                foreach (Control c in gs.Controls)
                {
                    if (c is Button)
                    {
                        c.Enabled = false;
                        c.Visible = false;
                    }
                }

                Form1.ChangeScreen(this, gs);
                GameScreen.gameState = "Main Screen";
                 
            }
            else if (GameScreen.bossHealth <= 0)
            {
                MessageBox.Show("You win!");
                GameScreen.t1.Enabled = false;
;               Form1.ChangeScreen(this, new EndScreen());  
            }
        }

        private void BattleScreen_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
    
