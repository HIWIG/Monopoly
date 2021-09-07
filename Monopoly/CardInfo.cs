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
    public partial class CardInfo : Form
    {

        public int CurrentPlayer { get; set; }
        private List<Field> fields;
        private List<Player> players;
        public int Index { get; set; }
        public CardInfo(Field field, int currentPlayer, List<Field>fields, List<Player>players, int index)
        {
            InitializeComponent();
            button1.Visible = false;
            button2.Visible = false;
            button1.Text = "Sprzedaj";
            button2.Text = "Kup domki";
            CurrentPlayer = currentPlayer;
            this.fields = fields;
            this.players = players;
            if (field is CityField)
            {
                var x = (CityField)field;
                label1.Text = x.Id.ToString();
                label2.Text = x.Name;
                label2.BackColor = x.Color;
                label3.Text = "Cena zakupu: " + x.Price.ToString();
                label4.Text = "Cena za niezabudowany: " + x.Payment.ToString();
                label5.Text = "Cena z 1 domem: " + x.PaymentOneHouse.ToString();
                label6.Text = "Cena z 2 domami: " + x.PaymentTwoHouse.ToString();
                label7.Text = "Cena z 3 domami: " + x.PaymentThreeHouse.ToString();
                label8.Text = "Cena z 4 domami: " + x.PaymentFourHouse.ToString();
                label9.Text = "Cena z hotelem: " + x.PaymentHotel.ToString();
                if (x.Owner != null)
                    label10.Text = "Właściciel: " + x.Owner.Name;
                else
                    label10.Text = "Właściciel: Brak";
                if (x.Owner==players.ElementAt(CurrentPlayer-1))
                {
                    button1.Visible = true;
                    button2.Visible = true;
                    
                }

            }
            else if (field is PaymentField)
            {
                var x = (PaymentField)field;

                label1.Text = field.Id.ToString();
                label2.Text = field.Name;
                label3.Text = "Opłata wynosi " + x.Payment;
            }

            else
            {
                label1.Text = field.Id.ToString();
                label2.Text = field.Name;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var x = (CityField)fields.ElementAt(Index - 1);
            x.Owner = null;
            players.ElementAt(CurrentPlayer - 1).Money += x.Payment;
        }





        //public CardInfo(int id, string city, Color color, int price)
        //{
        //    InitializeComponent();
        //    label1.Text = id.ToString();
        //    label2.Text = city;
        //    label2.BackColor = color;
        //    label3.Text = "Cena: " + price.ToString();
        //}

    }
}
