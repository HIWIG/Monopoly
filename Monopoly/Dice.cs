using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monopoly
{
    public partial class Dice : Form
    {
        private DiceRoll diceRoll;
        public List<Player> players;
        public List<Label> playerPosition;
        public List<Field> fields;
        public int CurrentPlayer { get; set; }
        public Dice(DiceRoll diceRoll, ref List<Monopoly.Player> players, ref List<Label> playerPosition, ref List<Field> fields, int currentPlayer)
        {
            this.players = players;
            this.playerPosition = playerPosition;
            CurrentPlayer = currentPlayer;
            this.diceRoll = diceRoll;
            this.fields = fields;
            InitializeComponent();
            diceRoll.Roll();
            label1.Text = "Wylosowałeś:";
            label2.Text = diceRoll.Dice1.ToString();
            label3.Text = diceRoll.Dice2.ToString();
            label4.Text = "Łącznie:" + diceRoll.RandomizedNumber.ToString();



        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (diceRoll.Exit)
            {
                case 1:
                    players.ElementAt(CurrentPlayer - 1).Location += diceRoll.RandomizedNumber;
                    if (players.ElementAt(CurrentPlayer - 1).Location > 40)
                    {
                        players.ElementAt(CurrentPlayer - 1).Location -= 40;
                        players.ElementAt(CurrentPlayer - 1).Money += 400;
                    }
                    playerPositionUpdate();
                    FieldAction fieldAction = new FieldAction(fields, players, CurrentPlayer);
                    ActiveForm.Close();
                    fieldAction.Show();
                    break;
                case 0:
                    this.diceRoll.Roll();
                    label1.Text = "Wylosowałeś:";
                    label2.Text = diceRoll.Dice1.ToString();
                    label3.Text = diceRoll.Dice2.ToString();
                    label4.Text = "Łącznie:" + diceRoll.RandomizedNumber.ToString();
                    //players.ElementAt(CurrentPlayer - 1).Location += diceRoll.RandomizedNumber;

                    break;
                case -1:
                    label1.Text = "Idziesz do więzienia";
                    diceRoll.Exit = -2;
                    diceRoll.RandomizedNumber = -1;
                    break;
                case -2:

                    players.ElementAt(CurrentPlayer - 1).Location = 11;
                    players.ElementAt(CurrentPlayer - 1).InPrison = 1;
                    playerPositionUpdate();
                    FieldAction fieldAction2 = new FieldAction(fields, players, CurrentPlayer);

                    ActiveForm.Close();
                    fieldAction2.Show();

                    break;
            }

        }

        public void playerPositionUpdate()
        {
            for (int i = 0; i < playerPosition.Count; i++)
            {
                playerPosition.ElementAt(i).BackColor = Color.Transparent;
            }
            for (int i = 0; i < playerPosition.Count / 4; i++)
            {
                for (int j = 0; j < players.Count; j++)
                {
                    if (players.ElementAt(j).Location - 1 == i)
                    {
                        switch (players.ElementAt(j).Id)
                        {
                            case 1:
                                playerPosition.ElementAt(i).BackColor = Color.Yellow;
                                break;
                            case 2:
                                playerPosition.ElementAt(i + 40).BackColor = Color.Green;
                                break;
                            case 3:
                                playerPosition.ElementAt(i + 80).BackColor = Color.Red;
                                break;
                            case 4:
                                playerPosition.ElementAt(i + 120).BackColor = Color.Blue;
                                break;
                        }
                    }
                }

            }



        }
    }
}
