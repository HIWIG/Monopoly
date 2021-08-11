using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    class Field
    {


        public int Id { get; set; }
        public string Name { get; set; }

        public Field(int id, string name)
        {
            Id = id;
            Name = name;
        }

    }
}
