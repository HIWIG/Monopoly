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
    public partial class CardInfo : Form
    {
        

        public CardInfo(Field field)
        {
            InitializeComponent();
            if (field is CityField)
            {
                var x = (CityField) field;
                label1.Text = x.Id.ToString();
                label2.Text = x.Name;
                label2.BackColor = x.Color;
                label3.Text = "Cena zakupu: " + x.Price.ToString();
                label4.Text = "Cena za niezabudowany: " + x.Payment.ToString();
                label5.Text = "Cena z 1 domem: " + x.PaymentOneHouse.ToString();
                label6.Text = "Cena z 2 domami: " + x.PaymentTwoHouse.ToString();
                label7.Text = "Cena z 3 domami: " + x.PaymentThreeHouse.ToString();
                label8.Text = "Cena z 4 domami: " + x.PaymentFourHouse.ToString();
                label9.Text = "Cena z hotelem: " + x.PaymentHotel.ToString();
            }
        }

       

        //public CardInfo(int id, string city, Color color, int price)
        //{
        //    InitializeComponent();
        //    label1.Text = id.ToString();
        //    label2.Text = city;
        //    label2.BackColor = color;
        //    label3.Text = "Cena: " + price.ToString();
        //}

    }
}
