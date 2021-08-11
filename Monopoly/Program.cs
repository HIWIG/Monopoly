using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monopoly
{
    static class Program
    {
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]

        static void Run()
        {

            //List<Player> players = new List<Player>();
            //List<Field> fields = new List<Field>();
            //List<Field> treasureFields = new List<Field>();

            //InitializeFields(ref fields);


            //InitializePlayer(ref players);

        }

        //static void InitializePlayer(ref List<Player> players)
        //{
        //    players.Add(new Player(1,"Player1", 3000, 3000, 1));
        //    players.Add(new Player(2,"Player2", 3000, 3000, 1));
        //    players.Add(new Player(3,"Player3", 3000, 3000, 1));
        //}

        //static void InitializeFields(ref List<Field> fields)
        //{
        //    fields.Add(new Field(1, "Start"));
        //    fields.Add(new CityField(2, "Saloniki", 120, 1,10,40,120,360,640,900));
        //    //fields.Add(new TreasureField(3));
        //    fields.Add(new CityField(4, "Ateny", 120, 1, 10, 40, 120, 360, 640, 900));
        //    fields.Add(new PaymentField(5, "Parking strzeżony", 400));
        //    //fields.Add(new CityField(6, "Koleje Południowe", 400, 10));
        //    fields.Add(new CityField(7, "Neapol", 200, 2,15,60,180,540,800,1100));
        //    //fields.Add(new TreasureField(8));
        //    fields.Add(new CityField(9, "Mediolan", 200, 2, 15, 60, 180, 540, 800, 1100));
        //    fields.Add(new CityField(10, "Rzym", 240, 2,20,80,200,600,900,1200));
        //    fields.Add(new Field(11, "Więzienie"));
        //    fields.Add(new CityField(12, "Barcelona", 280, 3,20,100,300,900,1250,1500));
        //    //fields.Add(TODO: elektrownia id 13));
        //    fields.Add(new CityField(14, "Sewilla", 280, 3, 20, 100, 300, 900, 1250, 1500));
        //    fields.Add(new CityField(15, "Madryt", 320, 3,25,120,360,100,1400,1800));
        //    //fields.Add(new CityField(16, "Koleje Zachodnie", 400, 10));
        //    fields.Add(new CityField(17, "Liverpool", 360, 4,30,140,400,1100,1500,1900));
        //    //fields.Add(new TreasureField(18));
        //    fields.Add(new CityField(19, "Glasgow", 360, 4, 30, 140, 400, 1100, 1500, 1900));
        //    fields.Add(new CityField(20, "Londyn", 400, 4,35,160,440,1200,1600,2000));
        //    fields.Add(new Field(21, "Darmowy parking"));
        //    fields.Add(new CityField(22, "Rotterdam", 440, 5,35,180,500,1400,1750,2100));
        //    //fields.Add(new TreasureField(23));
        //    fields.Add(new CityField(24, "Bruksela", 440, 5, 35, 180, 500, 1400, 1750, 2100));
        //    fields.Add(new CityField(25, "Amsterdam", 480, 5,40,200,600,1500,1850,2200));
        //    //fields.Add(new CityField(26, "Koleje Północne", 400, 10));
        //    fields.Add(new CityField(27, "Malmo", 520, 6,15,220,660,1600,1950,2300));
        //    fields.Add(new CityField(28, "Goteborg", 520, 6, 15, 220, 660, 1600, 1950, 2300));
        //    //fields.Add(TODO: wodociągi id 29));
        //    fields.Add(new CityField(30, "Sztokholm", 560, 6,50,240,720,1700,2050,2400));
        //    fields.Add(new Field(31, "Idziesz do więzienia"));
        //    fields.Add(new CityField(32, "Frankfurt", 600, 7,55,260,780,1900,2200,2550));
        //    fields.Add(new CityField(33, "Kolonia", 600, 7, 55, 260, 780, 1900, 2200, 2550));
        //    //fields.Add(new TreasureField(34));
        //    fields.Add(new CityField(35, "Bonn", 640, 7,60,300,900,2000,2400,2800));
        //    //fields.Add(new CityField(36, "Koleje Wschodnie", 400, 10));
        //    //fields.Add(new TreasureField(37));
        //    fields.Add(new CityField(38, "Insbruck", 700, 8,70,350,1000,2200,2600,3000));
        //    fields.Add(new PaymentField(39, "Podatek od wzbogacenia", 200));
        //    fields.Add(new CityField(40, "Wiedeń", 800, 8,100,400,1200,2800,3400,4000));
            
        //}

        //static void InitializeTeasures(ref List<Field> treasureFields)
        //{
        //    treasureFields.Add(new TreasureField(TreasureTypeEnum.Payment, 40,1,"Piłeś w czasie pracy, płacisz karę 40."));
        //    treasureFields.Add(new TreasureField(TreasureTypeEnum.Payment, 30,2,"Mandat za szybką jazdę. Płacisz 30."));
        //    treasureFields.Add(new TreasureField(TreasureTypeEnum.Payment, 300,3,"Płacisz opłatę za szkołę 300."));
        //    treasureFields.Add(new TreasureField(TreasureTypeEnum.Payment, 400,4,"Płacisz na budowę szpitala 400."));
        //    treasureFields.Add(new TreasureField(TreasureTypeEnum.Payment, 20,5,"Płacisz koszty leczenia w wysokości 20."));
        //    treasureFields.Add(new TreasureField(TreasureTypeEnum.Payment, 20,6,"Płacisz składkę ubezpieczeniową w wysokości 20."));
        //    treasureFields.Add(new TreasureField(TreasureTypeEnum.Reward, 300,7,"Bank wypłaca Ci należne odsetki 300."));
        //    treasureFields.Add(new TreasureField(TreasureTypeEnum.Reward, 200,8,"Rozwiałeś dobrze krzyżówkę. Jako I nagrodę otrzymujesz 200."));
        //    treasureFields.Add(new TreasureField(TreasureTypeEnum.Reward, 100,9,"Bank wypłaca Ci procenty w wysokości 100."));
        //    treasureFields.Add(new TreasureField(TreasureTypeEnum.Reward, 50,10,"Bank wypłaca Ci należne 7% odsetek od kapitałów - otrzymujesz 50."));
        //    treasureFields.Add(new TreasureField(TreasureTypeEnum.Reward, 400,11,"Bank omylił się na twoją korzyść otrzymujesz 400."));
        //    treasureFields.Add(new TreasureField(TreasureTypeEnum.Reward, 200,12,"Otrzymujesz w spadku 200."));
        //    treasureFields.Add(new TreasureField(TreasureTypeEnum.Reward, 200,13,"Zająłeś II miejsce w konkursie pięknoiści, otrzymujesz 200."));
        //    treasureFields.Add(new TreasureField(TreasureTypeEnum.Reward, 40,14,"Otrzymujesz zwrot nadpłaconego podatku dochodowego 40."));
        //    treasureFields.Add(new TreasureField(TreasureTypeEnum.Reward, 200,15,"Otrzymujesz roczną rentę w wysokości 200"));
        //    treasureFields.Add(new TreasureField(TreasureTypeEnum.Reward, 20,16,"Z magazynu, w którym kupujesz otrzymujesz rabat w wysokości 20."));
        //    treasureFields.Add(new TreasureField(TreasureTypeEnum.EscapeCard, 0,17,"Karta wychodzisz wolny z więzienia"));
        //    treasureFields.Add(new TreasureField(TreasureTypeEnum.EscapeCard, 0,18,"Karta wychodzisz wolny z więzienia"));
        //}

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            Run();


        }
    }
}
