using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace harmonischeSchwingung
{
    public partial class Form_WerteAnsicht : Form
    {
        public Form_WerteAnsicht(string header)
        {
            InitializeComponent();
            this.Text = header;
        }

        public void textausgeb(double[,] x)
        {
            for (int i = 0; i < x.GetLength(0); i++)
            {
                double outputI = Convert.ToByte(i);
                listBox1.Items.Add(Convert.ToString(x[i,0] + ": " + Math.Round(x[i,1], 4)));
            }
        }

        private void WerteAnsicht_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (this.Text)
            {
                case "Window 1":
                    Class1.window1open = false;
                    break;
                case "Window 2":
                    Class1.window2open = false;
                    break;
                case "Window 3":
                    Class1.window3open = false;
                    break;
                default:
                    break;
            }
        }
    }
}
