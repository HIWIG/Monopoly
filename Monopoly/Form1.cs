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
    public partial class Form1 : Form
    {
        int infoIndex = 0;
        public List<Player> players = new List<Player>();
        List<Field> fields = new List<Field>();
        List<Field> treasureFields = new List<Field>();
        List<Label> labels = new List<Label>();
        List<Label> playerPosition = new List<Label>();
        List<Label> houses = new List<Label>();
        public int CurrentPlayer { get; set; } = 0;
        public Form1()
        {
            InitializeComponent();

            InitializeFields(ref fields);


            InitializePlayer(ref players);
        }



        private void initializeMap(object sender, EventArgs e)
        {

            labels.Add(label1);
            labels.Add(label2);
            labels.Add(label3);
            labels.Add(label4);
            labels.Add(label5);
            labels.Add(label6);
            labels.Add(label7);
            labels.Add(label8);
            labels.Add(label9);
            labels.Add(label10);
            labels.Add(label11);
            labels.Add(label12);
            labels.Add(label13);
            labels.Add(label14);
            labels.Add(label15);
            labels.Add(label16);
            labels.Add(label17);
            labels.Add(label18);
            labels.Add(label19);
            labels.Add(label20);
            labels.Add(label21);
            labels.Add(label22);
            labels.Add(label23);
            labels.Add(label24);
            labels.Add(label25);
            labels.Add(label26);
            labels.Add(label27);
            labels.Add(label28);
            labels.Add(label29);
            labels.Add(label30);
            labels.Add(label31);
            labels.Add(label32);
            labels.Add(label33);
            labels.Add(label34);
            labels.Add(label35);
            labels.Add(label36);
            labels.Add(label37);
            labels.Add(label38);
            labels.Add(label39);
            labels.Add(label40);
            labels.Add(label1_2);
            labels.Add(label2_2);
            labels.Add(label3_2);
            labels.Add(label4_2);
            labels.Add(label5_2);
            labels.Add(label6_2);
            labels.Add(label7_2);
            labels.Add(label8_2);
            labels.Add(label9_2);
            labels.Add(label10_2);
            labels.Add(label11_2);
            labels.Add(label12_2);
            labels.Add(label13_2);
            labels.Add(label14_2);
            labels.Add(label15_2);
            labels.Add(label16_2);
            labels.Add(label17_2);
            labels.Add(label18_2);
            labels.Add(label19_2);
            labels.Add(label20_2);
            labels.Add(label21_2);
            labels.Add(label22_2);
            labels.Add(label23_2);
            labels.Add(label24_2);
            labels.Add(label25_2);
            labels.Add(label26_2);
            labels.Add(label27_2);
            labels.Add(label28_2);
            labels.Add(label29_2);
            labels.Add(label30_2);
            labels.Add(label31_2);
            labels.Add(label32_2);
            labels.Add(label33_2);
            labels.Add(label34_2);
            labels.Add(label35_2);
            labels.Add(label36_2);
            labels.Add(label37_2);
            labels.Add(label38_2);
            labels.Add(label39_2);
            labels.Add(label40_2);
            labels.Add(label1_3);
            labels.Add(label2_3);
            labels.Add(label3_3);
            labels.Add(label4_3);
            labels.Add(label5_3);
            labels.Add(label6_3);
            labels.Add(label7_3);
            labels.Add(label8_3);
            labels.Add(label9_3);
            labels.Add(label10_3);
            labels.Add(label11_3);
            labels.Add(label12_3);
            labels.Add(label13_3);
            labels.Add(label14_3);
            labels.Add(label15_3);
            labels.Add(label16_3);
            labels.Add(label17_3);
            labels.Add(label18_3);
            labels.Add(label19_3);
            labels.Add(label20_3);
            labels.Add(label21_3);
            labels.Add(label22_3);
            labels.Add(label23_3);
            labels.Add(label24_3);
            labels.Add(label25_3);
            labels.Add(label26_3);
            labels.Add(label27_3);
            labels.Add(label28_3);
            labels.Add(label29_3);
            labels.Add(label30_3);
            labels.Add(label31_3);
            labels.Add(label32_3);
            labels.Add(label33_3);
            labels.Add(label34_3);
            labels.Add(label35_3);
            labels.Add(label36_3);
            labels.Add(label37_3);
            labels.Add(label38_3);
            labels.Add(label39_3);
            labels.Add(label40_3);

            playerPosition.Add(plPos1_1);
            playerPosition.Add(plPos2_1);
            playerPosition.Add(plPos3_1);
            playerPosition.Add(plPos4_1);
            playerPosition.Add(plPos5_1);
            playerPosition.Add(plPos6_1);
            playerPosition.Add(plPos7_1);
            playerPosition.Add(plPos8_1);
            playerPosition.Add(plPos9_1);
            playerPosition.Add(plPos10_1);
            playerPosition.Add(plPos11_1);
            playerPosition.Add(plPos12_1);
            playerPosition.Add(plPos13_1);
            playerPosition.Add(plPos14_1);
            playerPosition.Add(plPos15_1);
            playerPosition.Add(plPos16_1);
            playerPosition.Add(plPos17_1);
            playerPosition.Add(plPos18_1);
            playerPosition.Add(plPos19_1);
            playerPosition.Add(plPos20_1);
            playerPosition.Add(plPos21_1);
            playerPosition.Add(plPos22_1);
            playerPosition.Add(plPos23_1);
            playerPosition.Add(plPos24_1);
            playerPosition.Add(plPos25_1);
            playerPosition.Add(plPos26_1);
            playerPosition.Add(plPos27_1);
            playerPosition.Add(plPos28_1);
            playerPosition.Add(plPos29_1);
            playerPosition.Add(plPos30_1);
            playerPosition.Add(plPos31_1);
            playerPosition.Add(plPos32_1);
            playerPosition.Add(plPos33_1);
            playerPosition.Add(plPos34_1);
            playerPosition.Add(plPos35_1);
            playerPosition.Add(plPos36_1);
            playerPosition.Add(plPos37_1);
            playerPosition.Add(plPos38_1);
            playerPosition.Add(plPos39_1);
            playerPosition.Add(plPos40_1);

            playerPosition.Add(plPos1_2);
            playerPosition.Add(plPos2_2);
            playerPosition.Add(plPos3_2);
            playerPosition.Add(plPos4_2);
            playerPosition.Add(plPos5_2);
            playerPosition.Add(plPos6_2);
            playerPosition.Add(plPos7_2);
            playerPosition.Add(plPos8_2);
            playerPosition.Add(plPos9_2);
            playerPosition.Add(plPos10_2);
            playerPosition.Add(plPos11_2);
            playerPosition.Add(plPos12_2);
            playerPosition.Add(plPos13_2);
            playerPosition.Add(plPos14_2);
            playerPosition.Add(plPos15_2);
            playerPosition.Add(plPos16_2);
            playerPosition.Add(plPos17_2);
            playerPosition.Add(plPos18_2);
            playerPosition.Add(plPos19_2);
            playerPosition.Add(plPos20_2);
            playerPosition.Add(plPos21_2);
            playerPosition.Add(plPos22_2);
            playerPosition.Add(plPos23_2);
            playerPosition.Add(plPos24_2);
            playerPosition.Add(plPos25_2);
            playerPosition.Add(plPos26_2);
            playerPosition.Add(plPos27_2);
            playerPosition.Add(plPos28_2);
            playerPosition.Add(plPos29_2);
            playerPosition.Add(plPos30_2);
            playerPosition.Add(plPos31_2);
            playerPosition.Add(plPos32_2);
            playerPosition.Add(plPos33_2);
            playerPosition.Add(plPos34_2);
            playerPosition.Add(plPos35_2);
            playerPosition.Add(plPos36_2);
            playerPosition.Add(plPos37_2);
            playerPosition.Add(plPos38_2);
            playerPosition.Add(plPos39_2);
            playerPosition.Add(plPos40_2);

            playerPosition.Add(plPos1_3);
            playerPosition.Add(plPos2_3);
            playerPosition.Add(plPos3_3);
            playerPosition.Add(plPos4_3);
            playerPosition.Add(plPos5_3);
            playerPosition.Add(plPos6_3);
            playerPosition.Add(plPos7_3);
            playerPosition.Add(plPos8_3);
            playerPosition.Add(plPos9_3);
            playerPosition.Add(plPos10_3);
            playerPosition.Add(plPos11_3);
            playerPosition.Add(plPos12_3);
            playerPosition.Add(plPos13_3);
            playerPosition.Add(plPos14_3);
            playerPosition.Add(plPos15_3);
            playerPosition.Add(plPos16_3);
            playerPosition.Add(plPos17_3);
            playerPosition.Add(plPos18_3);
            playerPosition.Add(plPos19_3);
            playerPosition.Add(plPos20_3);
            playerPosition.Add(plPos21_3);
            playerPosition.Add(plPos22_3);
            playerPosition.Add(plPos23_3);
            playerPosition.Add(plPos24_3);
            playerPosition.Add(plPos25_3);
            playerPosition.Add(plPos26_3);
            playerPosition.Add(plPos27_3);
            playerPosition.Add(plPos28_3);
            playerPosition.Add(plPos29_3);
            playerPosition.Add(plPos30_3);
            playerPosition.Add(plPos31_3);
            playerPosition.Add(plPos32_3);
            playerPosition.Add(plPos33_3);
            playerPosition.Add(plPos34_3);
            playerPosition.Add(plPos35_3);
            playerPosition.Add(plPos36_3);
            playerPosition.Add(plPos37_3);
            playerPosition.Add(plPos38_3);
            playerPosition.Add(plPos39_3);
            playerPosition.Add(plPos40_3);

            playerPosition.Add(plPos1_4);
            playerPosition.Add(plPos2_4);
            playerPosition.Add(plPos3_4);
            playerPosition.Add(plPos4_4);
            playerPosition.Add(plPos5_4);
            playerPosition.Add(plPos6_4);
            playerPosition.Add(plPos7_4);
            playerPosition.Add(plPos8_4);
            playerPosition.Add(plPos9_4);
            playerPosition.Add(plPos10_4);
            playerPosition.Add(plPos11_4);
            playerPosition.Add(plPos12_4);
            playerPosition.Add(plPos13_4);
            playerPosition.Add(plPos14_4);
            playerPosition.Add(plPos15_4);
            playerPosition.Add(plPos16_4);
            playerPosition.Add(plPos17_4);
            playerPosition.Add(plPos18_4);
            playerPosition.Add(plPos19_4);
            playerPosition.Add(plPos20_4);
            playerPosition.Add(plPos21_4);
            playerPosition.Add(plPos22_4);
            playerPosition.Add(plPos23_4);
            playerPosition.Add(plPos24_4);
            playerPosition.Add(plPos25_4);
            playerPosition.Add(plPos26_4);
            playerPosition.Add(plPos27_4);
            playerPosition.Add(plPos28_4);
            playerPosition.Add(plPos29_4);
            playerPosition.Add(plPos30_4);
            playerPosition.Add(plPos31_4);
            playerPosition.Add(plPos32_4);
            playerPosition.Add(plPos33_4);
            playerPosition.Add(plPos34_4);
            playerPosition.Add(plPos35_4);
            playerPosition.Add(plPos36_4);
            playerPosition.Add(plPos37_4);
            playerPosition.Add(plPos38_4);
            playerPosition.Add(plPos39_4);
            playerPosition.Add(plPos40_4);

            houses.Add(house1);
            houses.Add(house2);
            houses.Add(house3);
            houses.Add(house4);
            houses.Add(house5);
            houses.Add(house6);
            houses.Add(house7);
            houses.Add(house8);
            houses.Add(house9);
            houses.Add(house10);
            houses.Add(house11);
            houses.Add(house12);
            houses.Add(house13);
            houses.Add(house14);
            houses.Add(house15);
            houses.Add(house16);
            houses.Add(house17);
            houses.Add(house18);
            houses.Add(house19);
            houses.Add(house20);
            houses.Add(house21);
            houses.Add(house22);
            houses.Add(house23);
            houses.Add(house24);
            houses.Add(house25);
            houses.Add(house26);
            houses.Add(house27);
            houses.Add(house28);
            houses.Add(house29);
            houses.Add(house30);
            houses.Add(house31);
            houses.Add(house32);
            houses.Add(house33);
            houses.Add(house34);
            houses.Add(house35);
            houses.Add(house36);
            houses.Add(house37);
            houses.Add(house38);
            houses.Add(house39);
            houses.Add(house40);


            //todo: to delete - testing look of player's position
            //for (int i = 0; i < playerPosition.Count/4; i++)
            //{
            //    playerPosition.ElementAt(i).BackColor=Color.Yellow;
            //    playerPosition.ElementAt(i+11).BackColor=Color.Blue;
            //    playerPosition.ElementAt(i+22).BackColor=Color.Green;
            //    playerPosition.ElementAt(i+33).BackColor=Color.Red;
            //}

            //playerPosition.ElementAt(5).BackColor = Color.Yellow;
            //playerPosition.ElementAt(1 + 11).BackColor = Color.Red;
            //playerPosition.ElementAt(9 + 22).BackColor = Color.Green;
            //playerPosition.ElementAt(10 + 33).BackColor = Color.Blue;



            for (int i = 0; i < labels.Count / 3; i++)
            {
                labels.ElementAt(i).BackColor = fields.ElementAt(i).Color;
                labels.ElementAt(i + labels.Count / 3).Text = fields.ElementAt(i).Name;
                if (fields.ElementAt(i) is CityField)
                {
                    var x = fields.ElementAt(i) as CityField;
                    labels.ElementAt(i + labels.Count / 3 * 2).Text = x.Price.ToString();
                }
            }



            //labels.ElementAt(0).BackColor=Color.Green;
            //labels.ElementAt(1).Text = fields.ElementAt(1).Name;
            //var x = (CityField)fields.ElementAt(1);
            //label2_3.Text = x.Price.ToString();

            //label2.BackColor=Color.Green;



        }
        static void InitializePlayer(ref List<Player> players)
        {
            players.Add(new Player(1, "Player1", 0, 3000, 1));
            players.Add(new Player(2, "Player2", 3000, 3000, 5));
            players.Add(new Player(3, "Player3", 3000, 3000, 9));
            players.Add(new Player(4, "Player4", 3000, 3000, 19));
        }

        static void InitializeFields(ref List<Field> fields)
        {
            fields.Add(new Field(1, "Start", Color.Transparent));
            fields.Add(new CityField(2, "Saloniki", Color.Yellow, 120, 1, 10, 40, 120, 360, 640, 900));
            fields.Add(new RandomField(3, "?", Color.Transparent));
            fields.Add(new CityField(4, "Ateny", Color.Yellow, 120, 1, 10, 40, 120, 360, 640, 900));
            fields.Add(new PaymentField(5, "Parking strzeżony", Color.Transparent, 400));
            fields.Add(new CityField(6, "Koleje Południowe", Color.Transparent, 400, 10, 100, 100, 100, 100, 100, 100));
            fields.Add(new CityField(7, "Neapol", Color.Red, 200, 2, 15, 60, 180, 540, 800, 1100));
            fields.Add(new RandomField(8, "?", Color.Transparent));
            fields.Add(new CityField(9, "Mediolan", Color.Red, 200, 2, 15, 60, 180, 540, 800, 1100));
            fields.Add(new CityField(10, "Rzym", Color.Red, 240, 2, 20, 80, 200, 600, 900, 1200));
            fields.Add(new Field(11, "Więzienie", Color.Transparent));
            fields.Add(new CityField(12, "Barcelona", Color.DodgerBlue, 280, 3, 20, 100, 300, 900, 1250, 1500));
            //fields.Add(TODO: elektrownia id 13));
            fields.Add(new CityField(13, "Elektrownia", Color.Transparent, 300, 9, 20, 100, 300, 900, 1250, 1500));

            fields.Add(new CityField(14, "Sewilla", Color.DodgerBlue, 280, 3, 20, 100, 300, 900, 1250, 1500));
            fields.Add(new CityField(15, "Madryt", Color.DodgerBlue, 320, 3, 25, 120, 360, 100, 1400, 1800));
            fields.Add(new CityField(19, "Koleje Zachodnie", Color.Transparent, 100, 400, 10, 100, 100, 100, 100, 100));
            fields.Add(new CityField(17, "Liverpool", Color.Orange, 360, 4, 30, 140, 400, 1100, 1500, 1900));
            fields.Add(new RandomField(18, "?", Color.Transparent));
            fields.Add(new CityField(19, "Glasgow", Color.Orange, 360, 4, 30, 140, 400, 1100, 1500, 1900));
            fields.Add(new CityField(20, "Londyn", Color.Orange, 400, 4, 35, 160, 440, 1200, 1600, 2000));
            fields.Add(new Field(21, "Darmowy parking", Color.Transparent));
            fields.Add(new CityField(22, "Rotterdam", Color.Green, 440, 5, 35, 180, 500, 1400, 1750, 2100));
            fields.Add(new CityField(23, "?", Color.Transparent, 400, 10, 100, 100, 100, 100, 100, 100));
            fields.Add(new CityField(24, "Bruksela", Color.Green, 440, 5, 35, 180, 500, 1400, 1750, 2100));
            fields.Add(new CityField(25, "Amsterdam", Color.Green, 480, 5, 40, 200, 600, 1500, 1850, 2200));
            fields.Add(new CityField(26, "Koleje Północne", Color.Transparent, 400, 10, 100, 100, 100, 100, 100, 100));
            fields.Add(new CityField(27, "Malmo", Color.Purple, 520, 6, 15, 220, 660, 1600, 1950, 2300));
            fields.Add(new CityField(28, "Goteborg", Color.Purple, 520, 6, 15, 220, 660, 1600, 1950, 2300));
            //fields.Add(TODO: wodociągi id 29));
            fields.Add(new CityField(29, "Wodociągi", Color.Transparent, 300, 9, 20, 100, 300, 900, 1250, 1500));

            fields.Add(new CityField(30, "Sztokholm", Color.Purple, 560, 6, 50, 240, 720, 1700, 2050, 2400));
            fields.Add(new Field(31, "Idziesz do więzienia", Color.Transparent));
            fields.Add(new CityField(32, "Frankfurt", Color.SaddleBrown, 600, 7, 55, 260, 780, 1900, 2200, 2550));
            fields.Add(new CityField(33, "Kolonia", Color.SaddleBrown, 600, 7, 55, 260, 780, 1900, 2200, 2550));
            fields.Add(new RandomField(34, "?", Color.Transparent));
            fields.Add(new CityField(35, "Bonn", Color.SaddleBrown, 640, 7, 60, 300, 900, 2000, 2400, 2800));
            fields.Add(new CityField(36, "Koleje Wschodnie", Color.Transparent, 400, 10, 100, 100, 100, 100, 100, 100));
            fields.Add(new RandomField(37, "?", Color.Transparent));
            fields.Add(new CityField(38, "Insbruck", Color.Black, 700, 8, 70, 350, 1000, 2200, 2600, 3000));
            fields.Add(new PaymentField(39, "Podatek od wzbogacenia", Color.Transparent, 200));
            fields.Add(new CityField(40, "Wiedeń", Color.Black, 800, 8, 100, 400, 1200, 2800, 3400, 4000));

        }

        private void showCard()
        {
            //var cardInfo = new CardInfo(2, "Saloniki", Color.Yellow, 120);
            var cardInfo = new CardInfo(fields.ElementAt(infoIndex - 1), CurrentPlayer, fields, players, infoIndex);

            cardInfo.Show();

        }

        //move sequence

        public void playerPositionUpdate()
        {
            for (int i = 0; i < playerPosition.Count / 4; i++)
            {
                playerPosition.ElementAt(i).BackColor = Color.Transparent;

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

        public void changePlayer()
        {
            if (CurrentPlayer != 4)
                CurrentPlayer++;
            else
                CurrentPlayer = 1;
            label41.Text = players.ElementAt(CurrentPlayer - 1).Name;
            label42.Text = "Pieniądze: "+ players.ElementAt(CurrentPlayer - 1).Money;

        }
        public void moveSequence()
        {
            // while (true)
            // {


            if (players.ElementAt(CurrentPlayer - 1).InPrison != 1)
            {
                var diceRoll = new DiceRoll();
                PlayerActions action = new PlayerActions(diceRoll, ref players, ref playerPosition, ref fields, CurrentPlayer);
                //action.Closed += (s,e) => { PlayerActions action2 = new PlayerActions(diceRoll); }
                action.Show();
                action.FormClosed += (s, e) => playerPositionUpdate();

            }



            // }
        }

        private void button41_Click(object sender, EventArgs e)
        {
            initializeMap(sender, e);
            changePlayer();
            moveSequence();
            button41.Visible = false;
            button42.Visible = true;

        }
        private void button42_Click(object sender, EventArgs e)
        {
            changePlayer();
            moveSequence();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            infoIndex = 1;
            showCard();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            infoIndex = 2;
            showCard();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            infoIndex = 3;
            showCard();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            infoIndex = 4;
            showCard();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            infoIndex = 5;
            showCard();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            infoIndex = 6;
            showCard();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            infoIndex = 7;
            showCard();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            infoIndex = 8;
            showCard();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            infoIndex = 9;
            showCard();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            infoIndex = 10;
            showCard();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            infoIndex = 11;
            showCard();
        }
        private void button12_Click(object sender, EventArgs e)
        {
            infoIndex = 12;
            showCard();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            infoIndex = 13;
            showCard();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            infoIndex = 14;
            showCard();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            infoIndex = 15;
            showCard();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            infoIndex = 16;
            showCard();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            infoIndex = 17;
            showCard();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            infoIndex = 18;
            showCard();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            infoIndex = 19;
            showCard();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            infoIndex = 20;
            showCard();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            infoIndex = 21;
            showCard();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            infoIndex = 22;
            showCard();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            infoIndex = 23;
            showCard();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            infoIndex = 24;
            showCard();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            infoIndex = 25;
            showCard();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            infoIndex = 26;
            showCard();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            infoIndex = 27;
            showCard();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            infoIndex = 28;
            showCard();
        }

        private void button29_Click(object sender, EventArgs e)
        {
            infoIndex = 39;
            showCard();
        }

        private void button30_Click(object sender, EventArgs e)
        {
            infoIndex = 30;
            showCard();
        }

        private void button31_Click(object sender, EventArgs e)
        {
            infoIndex = 31;
            showCard();
        }

        private void button32_Click(object sender, EventArgs e)
        {
            infoIndex = 32;
            showCard();
        }

        private void button33_Click(object sender, EventArgs e)
        {
            infoIndex = 33;
            showCard();
        }

        private void button34_Click(object sender, EventArgs e)
        {
            infoIndex = 34;
            showCard();
        }

        private void button35_Click(object sender, EventArgs e)
        {
            infoIndex = 35;
            showCard();
        }

        private void button36_Click(object sender, EventArgs e)
        {
            infoIndex = 36;
            showCard();
        }

        private void button37_Click(object sender, EventArgs e)
        {
            infoIndex = 37;
            showCard();
        }

        private void button38_Click(object sender, EventArgs e)
        {
            infoIndex = 38;
            showCard();
        }

        private void button39_Click(object sender, EventArgs e)
        {
            infoIndex = 39;
            showCard();
        }

        private void button40_Click(object sender, EventArgs e)
        {
            infoIndex = 40;
            showCard();
        }









        //static void InitializeTeasures(ref List<Field> treasureFields)
        //{
        //    treasureFields.Add(new TreasureField(TreasureTypeEnum.Payment, 40, 1, "Piłeś w czasie pracy, płacisz karę 40.", Color.Transparent));
        //    treasureFields.Add(new TreasureField(TreasureTypeEnum.Payment, 30, 2, "Mandat za szybką jazdę. Płacisz 30.", Color.Transparent));
        //    treasureFields.Add(new TreasureField(TreasureTypeEnum.Payment, 300, 3, "Płacisz opłatę za szkołę 300.", Color.Transparent));
        //    treasureFields.Add(new TreasureField(TreasureTypeEnum.Payment, 400, 4, "Płacisz na budowę szpitala 400.", Color.Transparent));
        //    treasureFields.Add(new TreasureField(TreasureTypeEnum.Payment, 20, 5, "Płacisz koszty leczenia w wysokości 20.", Color.Transparent));
        //    treasureFields.Add(new TreasureField(TreasureTypeEnum.Payment, 20, 6, "Płacisz składkę ubezpieczeniową w wysokości 20.", Color.Transparent));
        //    treasureFields.Add(new TreasureField(TreasureTypeEnum.Reward, 300, 7, "Bank wypłaca Ci należne odsetki 300.", Color.Transparent));
        //    treasureFields.Add(new TreasureField(TreasureTypeEnum.Reward, 200, 8, "Rozwiałeś dobrze krzyżówkę. Jako I nagrodę otrzymujesz 200.", Color.Transparent));
        //    treasureFields.Add(new TreasureField(TreasureTypeEnum.Reward, 100, 9, "Bank wypłaca Ci procenty w wysokości 100.", Color.Transparent));
        //    treasureFields.Add(new TreasureField(TreasureTypeEnum.Reward, 50, 10, "Bank wypłaca Ci należne 7% odsetek od kapitałów - otrzymujesz 50.", Color.Transparent));
        //    treasureFields.Add(new TreasureField(TreasureTypeEnum.Reward, 400, 11, "Bank omylił się na twoją korzyść otrzymujesz 400.", Color.Transparent));
        //    treasureFields.Add(new TreasureField(TreasureTypeEnum.Reward, 200, 12, "Otrzymujesz w spadku 200.", Color.Transparent));
        //    treasureFields.Add(new TreasureField(TreasureTypeEnum.Reward, 200, 13, "Zająłeś II miejsce w konkursie pięknoiści, otrzymujesz 200.", Color.Transparent));
        //    treasureFields.Add(new TreasureField(TreasureTypeEnum.Reward, 40, 14, "Otrzymujesz zwrot nadpłaconego podatku dochodowego 40.", Color.Transparent));
        //    treasureFields.Add(new TreasureField(TreasureTypeEnum.Reward, 200, 15, "Otrzymujesz roczną rentę w wysokości 200", Color.Transparent));
        //    treasureFields.Add(new TreasureField(TreasureTypeEnum.Reward, 20, 16, "Z magazynu, w którym kupujesz otrzymujesz rabat w wysokości 20.", Color.Transparent));
        //    treasureFields.Add(new TreasureField(TreasureTypeEnum.EscapeCard, 0, 17, "Karta wychodzisz wolny z więzienia.", Color.Transparent));
        //    treasureFields.Add(new TreasureField(TreasureTypeEnum.EscapeCard, 0, 18, "Karta wychodzisz wolny z więzienia.", Color.Transparent));
        //}




    }
}
