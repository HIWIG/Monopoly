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
    public partial class PlayerActions : Form
    {
        private DiceRoll diceRoll;
        public int CurrentPlayer { get; set; }

        public List<Player> players;
        private List<Label> playerPosition;
        private List<Field> fields;


        public PlayerActions(DiceRoll dices, ref List<Player> players, ref List<Label> playerPosition, ref List<Field> fields, int currentPlayer)
        {
            InitializeComponent();
            this.diceRoll = dices;
            CurrentPlayer = currentPlayer;
            this.players = players;
            this.fields = fields;
            this.playerPosition = playerPosition;
            label1.Text = $"Ruch gracza nr {CurrentPlayer}";

        }


        private void button1_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
            Dice dice = new Dice(diceRoll, ref players, ref playerPosition, ref fields, CurrentPlayer);
            dice.Show();



        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

    }
}
