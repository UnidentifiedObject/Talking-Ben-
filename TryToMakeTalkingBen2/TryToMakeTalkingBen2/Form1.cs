using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TryToMakeTalkingBen2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            Random rnd = new Random();
            rnd.Next(1, 4);

            if (rnd.Next(1, 4) == 1)
            {
                label1.Text = "Yes";

            }
            else if (rnd.Next(1, 4) == 2)
            {
                label1.Text = "No";


            }
            else if (rnd.Next(1, 4) == 3)
            {
                label1.Text = "Hohoho";
               
            }
            else
            {
                label1.Text = "höö";
               
            }

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Ben?";
        }
    }
}
