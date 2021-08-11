using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    class Dicecs
    {
        Random random = new Random();

        public int Dice1 { get; set; }
        public int Dice2 { get; set; }
        public int RandomizedNumber { get; set; }
        public int NumberOfRolls { get; set; }


        public Dicecs()
        {
            Dice1 = 0;
            Dice2 = 0;
            RandomizedNumber = 0;
            NumberOfRolls = 0;

        }
        public void Roll()
        {


            for (int i = 0; i < 3; i++)
            {
                NumberOfRolls++;
                Randomize();
                RandomizedNumber += Dice1 + Dice2;
                if (Dice1 != Dice2)
                    break;
            }

            if (NumberOfRolls == 3)
                RandomizedNumber = -1;

            //if number of rolls is equal to 3 than RandomizedNumber is set to -1 that means 
            //that player goes to the prison
            //TODO: in move sequencion
        }

        public void Randomize()
        {

            Dice1 = random.Next(1, 7);
            Dice2 = random.Next(1, 7);

        }


    }
}
