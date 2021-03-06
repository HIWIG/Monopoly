using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{

    enum TreasureTypeEnum
    {
        Payment,
        Reward,
        Movement,
        EscapeCard
    }

    class TreasureField : Field
    {
        public TreasureTypeEnum Type { get; set; }
        public int Value { get; set; }

        public TreasureField(TreasureTypeEnum type, int value, int id, string name, Color color) : base(id, name, color)
        {
            Type = type;
            Value = value;
        }

    }
}
