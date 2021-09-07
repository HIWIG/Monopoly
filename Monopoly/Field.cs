using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    public class Field
    {


        public int Id { get; set; }
        public string Name { get; set; }

        public Color Color { get; set; }
        public Field(int id, string name, Color color)
        {
            Id = id;
            Name = name;
            Color = color;
        }

    }
}
