using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    class CityField : Field
    {
        public int Price { get; set; }
        public int Country { get; set; }
        public Player Owner { get; set; }
        public int Payment { get; set; }
        public int PaymentOneHouse { get; set; }
        public int PaymentTwoHouse { get; set; }
        public int PaymentThreeHouse { get; set; }
        public int PaymentFourHouse { get; set; }
        public int PaymentHotel { get; set; }
        //todo: 
        //public bool Active { get; set; }


        public CityField(int id, string name, int price, int country, int payment, int paymentOneHouse, int paymentTwoHouse, int paymentThreeHouse, int paymentFourHouse, int paymentHotel, Player owner = null) : base(id, name)
        {
            Price = price;
            Country = country;
            Owner = owner;
            Payment = payment;
            PaymentOneHouse = paymentOneHouse;
            PaymentTwoHouse = paymentTwoHouse;
            PaymentThreeHouse = paymentThreeHouse;
            PaymentFourHouse = paymentFourHouse;
            PaymentHotel = paymentHotel;
        }

    }
}
