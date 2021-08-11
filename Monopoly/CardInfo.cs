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
                label3.Text = "Cena: " + x.Price.ToString();
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
