using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farmer
{
    public partial class Form1 : Form
    {
        Farmer joeTheFarmer;
        public Form1()
        {
            InitializeComponent();
            joeTheFarmer = new Farmer() {NumberOfCows = 15};
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("I need {0} bags of feed for {1} cows", joeTheFarmer.BagsOfFeed, joeTheFarmer.NumberOfCows);
        }

        private void numericInput_ValueChanged(object sender, EventArgs e)
        {
            joeTheFarmer.NumberOfCows = (int)numericInput.Value;
        }
    }
}
