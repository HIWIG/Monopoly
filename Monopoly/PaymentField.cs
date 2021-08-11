using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    class PaymentField : Field
    {
        public int Payment { get; set; }

        public PaymentField(int id, string name, int payment) : base(id, name)
        {
            Payment = payment;
        }
    }
}
