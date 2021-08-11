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
        List<Player> players = new List<Player>();
        List<Field> fields = new List<Field>();
        List<Field> treasureFields = new List<Field>();
        public Form1()
        {
            InitializeComponent();

            InitializeFields(ref fields);


            InitializePlayer(ref players);
        }



        private void initializeMap(object sender, EventArgs e)
        {
            List<Label> labels = new List<Label>();

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
            players.Add(new Player(1, "Player1", 3000, 3000, 1));
            players.Add(new Player(2, "Player2", 3000, 3000, 1));
            players.Add(new Player(3, "Player3", 3000, 3000, 1));
        }

        static void InitializeFields(ref List<Field> fields)
        {
            fields.Add(new Field(1, "Start", Color.Transparent));
            fields.Add(new CityField(2, "Saloniki", Color.Yellow, 120, 1, 10, 40, 120, 360, 640, 900));
            fields.Add(new RandomField(3, "?", Color.Transparent));
            fields.Add(new CityField(4, "Ateny", Color.Yellow, 120, 1, 10, 40, 120, 360, 640, 900));
            fields.Add(new PaymentField(5, "Parking strzeżony", Color.Transparent, 400));
            fields.Add(new RandomField(3, "Koleje Południowe", Color.Transparent));
            fields.Add(new CityField(7, "Neapol", Color.Red, 200, 2, 15, 60, 180, 540, 800, 1100));
            fields.Add(new RandomField(8, "?", Color.Transparent));
            fields.Add(new CityField(9, "Mediolan", Color.Red, 200, 2, 15, 60, 180, 540, 800, 1100));
            fields.Add(new CityField(10, "Rzym", Color.Red, 240, 2, 20, 80, 200, 600, 900, 1200));
            fields.Add(new Field(11, "Więzienie", Color.Transparent));
            fields.Add(new CityField(12, "Barcelona", Color.DodgerBlue, 280, 3, 20, 100, 300, 900, 1250, 1500));
            //fields.Add(TODO: elektrownia id 13));
            fields.Add(new CityField(14, "Sewilla", Color.DodgerBlue, 280, 3, 20, 100, 300, 900, 1250, 1500));
            fields.Add(new CityField(15, "Madryt", Color.DodgerBlue, 320, 3, 25, 120, 360, 100, 1400, 1800));
            //fields.Add(new CityField(16, "Koleje Zachodnie", 400, 10));
            fields.Add(new CityField(17, "Liverpool", Color.OrangeRed, 360, 4, 30, 140, 400, 1100, 1500, 1900));
            //fields.Add(new TreasureField(18));
            fields.Add(new CityField(19, "Glasgow", Color.OrangeRed, 360, 4, 30, 140, 400, 1100, 1500, 1900));
            fields.Add(new CityField(20, "Londyn", Color.OrangeRed, 400, 4, 35, 160, 440, 1200, 1600, 2000));
            fields.Add(new Field(21, "Darmowy parking", Color.Transparent));
            fields.Add(new CityField(22, "Rotterdam", Color.Green, 440, 5, 35, 180, 500, 1400, 1750, 2100));
            //fields.Add(new TreasureField(23));
            fields.Add(new CityField(24, "Bruksela", Color.Green, 440, 5, 35, 180, 500, 1400, 1750, 2100));
            fields.Add(new CityField(25, "Amsterdam", Color.Green, 480, 5, 40, 200, 600, 1500, 1850, 2200));
            //fields.Add(new CityField(26, "Koleje Północne", 400, 10));
            fields.Add(new CityField(27, "Malmo", Color.Purple, 520, 6, 15, 220, 660, 1600, 1950, 2300));
            fields.Add(new CityField(28, "Goteborg", Color.Purple, 520, 6, 15, 220, 660, 1600, 1950, 2300));
            //fields.Add(TODO: wodociągi id 29));
            fields.Add(new CityField(30, "Sztokholm", Color.Purple, 560, 6, 50, 240, 720, 1700, 2050, 2400));
            fields.Add(new Field(31, "Idziesz do więzienia", Color.Transparent));
            fields.Add(new CityField(32, "Frankfurt", Color.SaddleBrown, 600, 7, 55, 260, 780, 1900, 2200, 2550));
            fields.Add(new CityField(33, "Kolonia", Color.SaddleBrown, 600, 7, 55, 260, 780, 1900, 2200, 2550));
            //fields.Add(new TreasureField(34));
            fields.Add(new CityField(35, "Bonn", Color.SaddleBrown, 640, 7, 60, 300, 900, 2000, 2400, 2800));
            //fields.Add(new CityField(36, "Koleje Wschodnie", 400, 10));
            //fields.Add(new TreasureField(37));
            fields.Add(new CityField(38, "Insbruck", Color.Black, 700, 8, 70, 350, 1000, 2200, 2600, 3000));
            fields.Add(new PaymentField(39, "Podatek od wzbogacenia", Color.Transparent, 200));
            fields.Add(new CityField(40, "Wiedeń", Color.Black, 800, 8, 100, 400, 1200, 2800, 3400, 4000));

        }

        private void showCard()
        {
            if (fields.ElementAt(infoIndex) is CityField)
            {

            }
            else if (fields.ElementAt(infoIndex) is RandomField)
            {

            }
            else if (fields.ElementAt(infoIndex) is PaymentField)
            {

            }
        }

        private void button41_Click(object sender, EventArgs e)
        {
            initializeMap(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            showCard();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

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
