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
    public partial class FieldAction : Form
    {
        private List<Field> fields;
        private List<Player> players;
        public int CurrentPlayer { get; set; }

        public FieldAction(List<Field> fields, List<Player> players, int currentPlayer)
        {
            InitializeComponent();
            button1.Visible = false;
            button2.Visible = false;
            this.fields = fields;
            this.players = players;
            CurrentPlayer = currentPlayer;
            label2.Text = fields.ElementAt(players.ElementAt(CurrentPlayer-1).Location-1).Name;

            if (fields.ElementAt(players.ElementAt(CurrentPlayer - 1).Location-1) is CityField)
            {


                var x = (CityField)(fields.ElementAt(players.ElementAt(CurrentPlayer - 1).Location-1));
                if (x.Owner == null)
                {
                    if (x.Price <= players.ElementAt(CurrentPlayer - 1).Money)
                        button1.Visible = true;
                    label1.Text = $"Cena: {x.Price}";
                    button1.Text = "Kup";
                    button2.Text = "Nie kupuj";
                    button2.Visible = true;
                }
                else if (x.Owner == players.ElementAt(CurrentPlayer - 1))
                {
                    label1.Text = "Twoje miasto";
                    button2.Text = "Zamknij";
                    button2.Visible = true;
                }
                else if (x.Owner != null)
                {
                    switch (x.AmountOfHouses)
                    {
                        case 0:
                            players.ElementAt(CurrentPlayer-1).Money -= x.Payment;
                            players.ElementAt(x.Owner.Id - 1).Money += x.Payment;
                            label1.Text = $"Płacisz: {x.Payment}";
                            button2.Text = "Zamknij";
                            button2.Visible = true;
                            break;
                        case 1:
                            players.ElementAt(CurrentPlayer-1).Money -= x.PaymentOneHouse;
                            players.ElementAt(x.Owner.Id - 1).Money += x.PaymentOneHouse;
                            label1.Text = $"Płacisz: {x.PaymentOneHouse}";
                            button2.Text = "Zamknij";
                            button2.Visible = true;
                            break;
                        case 2:
                            players.ElementAt(CurrentPlayer-1).Money -= x.PaymentTwoHouse;
                            players.ElementAt(x.Owner.Id - 1).Money += x.PaymentTwoHouse;
                            label1.Text = $"Płacisz: {x.PaymentTwoHouse}";
                            button2.Text = "Zamknij";
                            button2.Visible = true;
                            break;
                        case 3:
                            players.ElementAt(CurrentPlayer-1).Money -= x.PaymentThreeHouse;
                            players.ElementAt(x.Owner.Id - 1).Money += x.PaymentThreeHouse;
                            label1.Text = $"Płacisz: {x.PaymentThreeHouse}";
                            button2.Text = "Zamknij";
                            button2.Visible = true;
                            break;
                        case 4:
                            players.ElementAt(CurrentPlayer-1).Money -= x.PaymentFourHouse;
                            players.ElementAt(x.Owner.Id - 1).Money += x.PaymentFourHouse;
                            label1.Text = $"Płacisz: {x.PaymentFourHouse}";
                            button2.Text = "Zamknij";
                            button2.Visible = true;
                            break;
                        case 5:
                            players.ElementAt(CurrentPlayer-1).Money -= x.PaymentHotel;
                            players.ElementAt(x.Owner.Id - 1).Money += x.PaymentHotel;
                            label1.Text = $"Płacisz: {x.PaymentHotel}";
                            button2.Text = "Zamknij";
                            button2.Visible = true;
                            break;

                    }
                }
            }
            else if (fields.ElementAt(players.ElementAt(CurrentPlayer - 1).Location-1) is PaymentField)
            {
                var x = (PaymentField)(fields.ElementAt(players.ElementAt(CurrentPlayer - 1).Location-1));
                players.ElementAt(CurrentPlayer-1).Money -= x.Payment;
            }
            else if (fields.ElementAt(players.ElementAt(CurrentPlayer - 1).Location-1) is RandomField)
            {
                label1.Text = "Płacisz na budowę szkoły 400";
                button2.Text = "Zamknij";
                button2.Visible = true;
                players.ElementAt(CurrentPlayer-1).Money -= 400;

            }
            else
            {
                label1.Text = fields.ElementAt(players.ElementAt(CurrentPlayer - 1).Location-1).Name;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var x = (CityField)(fields.ElementAt(players.ElementAt(CurrentPlayer - 1).Location-1));



            players.ElementAt(CurrentPlayer - 1).Money -= x.Price;
            x.Owner = players.ElementAt(CurrentPlayer - 1);


            ActiveForm.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }
    }


}

