using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Money { get; set; }
        //money that player owns

        public int InPrison { get; set; }
        //if not in prison set the value to 0, the number tells how long will he stay
        public int Value { get; set; }
        //count player's fortune

        public int Location { get; set; }
        //shows current player's location on the map 

        public Player(int id, string name, int money, int value, int location, int inPrison = 0)
        {
            Id = id;
            Name = name;
            Money = money;
            Value = value;
            Location = location;
            InPrison = inPrison;

        }


    }
}
