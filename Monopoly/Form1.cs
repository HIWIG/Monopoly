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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            initializeMap(sender,e);
        }

        public void initializeMap(object sender, EventArgs e)
        {
            List<Label> labels = new List<Label>();
            
            labels.Add(label2);
            labels.Add(label2_2);
            
            labels.ElementAt(0).BackColor=Color.Blue;
            labels.ElementAt(1).BackColor=Color.Green;
            
            //label2.BackColor=Color.Green;
            
            
            
        }

    }
}
