using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    class PaymentField : Field
    {
        public int Payment { get; set; }

        public PaymentField(int id, string name, Color color, int payment) : base(id, name, color=Color.Transparent)
        {
            Payment = payment;
        }
    }
}
