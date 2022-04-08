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
using System.Media;

namespace LostAdventure
{
    public partial class Form1 : Form
    {
        // Tracks what page of the story the user is at
        int page = 1;

        public Form1()
        {
            InitializeComponent();

            DisplayPage();
        }

        private void option1Button_Click(object sender, EventArgs e)
        {
            /// Check what page we are currently on, and then flip
            /// to the page you need to go to if you selected option 1
            
            if (page == 1) 
            {
                page = 2;
            }
            else if (page == 2) 
            {
                page = 4;
            }
            else if (page == 3) 
            {
                page = 1;
            }
            else if (page == 4) 
            {
                page = 6;
            }
            else if (page == 5) 
            {
                page = 1;
            }
            else if (page == 6) 
            {
                page = 1;
            }
            else if (page == 7) 
            {
                page = 8;
            }
            else if (page == 8)
            {
                page = 12;
            }
            else if (page == 9)
            {
                page = 1;
            }
            else if (page == 10)
            {
                page = 1;
            }
           else if (page == 11)
            {
                page = 12;
            }
            else if (page== 12)
            {
                page = 1;
            }
            else if(page== 13)
            {
                page = 14;
            }
            else if (page==14)
            {
                page = 1;
            }
            else if (page==15)
            {
                page=1;
            }
            /// Display text and game options to screen based on the 
            /// current page
            DisplayPage();
          
        }

        private void option2Button_Click(object sender, EventArgs e)
        {
            /// Check what page we are currently on, and then flip
            /// to the page you need to go to if you selected option 1

            if (page == 1)
            {
                page = 3;
            }
            else if (page == 2)
            {
                page = 5;
            }
            else if (page == 3)
            {
                page = 99;
            }
            else if (page == 4)
            {
                page = 7;
            }
            else if (page == 5)
            {
                page = 99;
            }
            else if (page == 6)
            {
                page = 99;
            }
            else if (page == 7)
            {
                page = 9;
            }
            else if (page == 8)
            {
                page = 11;
            }
            else if (page == 9)
            {
                page = 99;
            }
            else if (page == 10)
            {
                page = 99;
            }
            else if (page == 11)
            {
                page = 13;
            }
            else if (page == 12)
            {
                page = 99;
            }
            else if (page == 13)
            {
                page = 15;
            }
            else if (page == 14)
            {
                page = 99;
            }
            else if (page == 15)
            {
             page = 99;
            }

            /// Display text and game options to screen based on the 
            /// current page

            DisplayPage();

        }

        public void DisplayPage()
        {
            switch (page)
            {
                case 1:
                    outputLabel.Text = "You wake up stranded in a dark rainy forest. ";
                    option1Label.Text = "Look around.";
                    option2Label.Text = "Call for help.";

                    imageBox.Image = Properties.Resources.deepBrush;
                    SoundPlayer player = new SoundPlayer(Properties.Resources.jungle);
                    player.Play();

                    break;
                case 2:
                    outputLabel.Text = "You come to a path. Do you want to go left or right?";
                    option1Label.Text = "Left.";
                    option2Label.Text = "Right.";

                    imageBox.Image = Properties.Resources.forestLake;
                    SoundPlayer player2 = new SoundPlayer(Properties.Resources.brook);
                    player2.Play();

                    break;
                case 3:
                    outputLabel.Text = "You wake up a sleeping bear. Play again?";
                    option1Label.Text = "Yes.";
                    option2Label.Text = "No.";
                    imageBox.Image = Properties.Resources.Grizzly_Bear_;
                    SoundPlayer pscreamlayer2 = new SoundPlayer(Properties.Resources.scream);
                    pscreamlayer2.Play();
                    break;
                case 4:
                    outputLabel.Text = "You find an village. Do you loot the village and leave or loot the village and take shelter? ";
                    option1Label.Text = "Leave.";
                    option2Label.Text = "Take shelter.";
                    imageBox.Image = Properties.Resources.old_village_in_korea_hyuntae_kim;
                    SoundPlayer pscrealayer2 = new SoundPlayer(Properties.Resources.Scary_Scream_SoundBible_com_1115384336);
                    pscrealayer2.Play();
                    break;
                case 5:
                    outputLabel.Text = "You fall into a pit and die.Play again?";
                    option1Label.Text = "Yes.";
                    option2Label.Text = "No.";
                    imageBox.Image = Properties.Resources.istockphoto_971302068_612x612__1_;
                    SoundPlayer pascreamlayer2 = new SoundPlayer(Properties.Resources.scream);
                    pascreamlayer2.Play();
                    break;
                case 6:
                    outputLabel.Text = "You run into angry villagers and they tie you up and sacrifice you. Play again?";
                    option1Label.Text = "Yes.";
                    option2Label.Text = "No.";
                    imageBox.Image = Properties.Resources.R;
                    SoundPlayer apscreamlayer2 = new SoundPlayer(Properties.Resources.scream);
                    apscreamlayer2.Play();
                    break;
                case 7:
                    outputLabel.Text = "You woke up angry villager's and they all rush at you will torches. Do you try reasoning or fight the angry villagers?";
                    option1Label.Text = "Reason with them.";
                    option2Label.Text = "Charge at them.";
                    imageBox.Image = Properties.Resources.R;
                    SoundPlayer pscreamlayer = new SoundPlayer(Properties.Resources.death_Roman_K_1190383229);
                    pscreamlayer.Play();
                    break;
                case 8:
                    outputLabel.Text = "They listen to your reasoning and they tell you 'If you want to stay in our village you must do a task for us.'.Do you corporate with the villagers or do you run away? ";
                    option1Label.Text = "Run away.";
                    option2Label.Text = "Corporate.";
                    imageBox.Image = Properties.Resources.Fotolia_53726764_XL;
                    break;
                case 9:
                    outputLabel.Text = "You try to fight them but there are too many of them and you die. Play again?";
                    option1Label.Text = "Yes.";
                    option2Label.Text = "No.";
                    imageBox.Image = Properties.Resources.R;
                    SoundPlayer pscareamlayer2 = new SoundPlayer(Properties.Resources.scream);
                    pscareamlayer2.Play();
                    break;
                case 10:
                    outputLabel.Text = "You try to run away but trip and fall and the villagers kill you. Play again?";
                    option1Label.Text = "Yes.";
                    option2Label.Text = "No.";
                    imageBox.Image = Properties.Resources.R;
                    SoundPlayer pscreamlayer3 = new SoundPlayer(Properties.Resources.scream);
                    pscreamlayer3.Play();
                    break;
                case 11:
                    outputLabel.Text = "You cooperate with the villagers and will do the task which is to slay a dragon. Do you choose a sword or a bow and arrow";
                    option1Label.Text = "Sword";
                    option2Label.Text = "Bow and arrows";
                    imageBox.Image = Properties.Resources.grassArrow;
                    SoundPlayer pcreamlayer2 = new SoundPlayer(Properties.Resources.Swords_Clashing_SoundBible_com_912903192);
                    pcreamlayer2.Play();
                    break;
                case 12:
                    outputLabel.Text = "You choose a sword but as you are leaving the village you slip and the sword slices your head open. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                        imageBox.Image = Properties.Resources.battle;
                    SoundPlayer pscreamlaer3 = new SoundPlayer(Properties.Resources.scream);
                    pscreamlaer3.Play();

                    break;
                case 13:
                    outputLabel.Text = "You choose a bow and arrows and go o your quest, you eventually find the dragon and enter the cave. Do you surprise the dragon or go head on?";
                    option1Label.Text = "Surprise.";
                    option2Label.Text = "Charge head on.";
                    imageBox.Image = Properties.Resources.bowww;
                    SoundPlayer screamlayer2 = new SoundPlayer(Properties.Resources.Throw_Knife_Anonymous_1894795848);
                    screamlayer2.Play();

                    break;
                case 14:
                    outputLabel.Text = "You surprise the dragon and kill it and bring back the head to the village and you live happily ever after. Play again?";
                    option1Label.Text = "Yes.";
                    option2Label.Text = "No.";
                    imageBox.Image = Properties.Resources.dargaon;
                    SoundPlayer pscreamlasayer2 = new SoundPlayer(Properties.Resources._1_person_cheering_Jett_Rifkin_1851518140);
                    pscreamlasayer2.Play();
                    break;
                case 15:
                    outputLabel.Text = "You take the dragon head on and he sees you immediately and eats you up. Play again>";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    imageBox.Image = Properties.Resources.swasf;
                    SoundPlayer pscreamlayer4 = new SoundPlayer(Properties.Resources.scream);
                    pscreamlayer4.Play();
                    break;
                case 99:
                    outputLabel.Text = "Thank you for playing.";
                    option1Label.Text = "";
                    option2Label.Text = "";
                    break;
                default:
                    break;
            }
        }
    }
}
