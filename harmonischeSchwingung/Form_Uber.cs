using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace harmonischeSchwingung
{
    public partial class Form_Uber : Form
    {
        public Form_Uber()
        {
            InitializeComponent();
        }

        private void Form_Uber_Load(object sender, EventArgs e)
        {
            DateTime currentTime = DateTime.Now;
            label1_uber.Text += "\r\n\r\nDie Uhrzeit ist: " + currentTime;


            string path = Environment.CurrentDirectory;
            FileInfo fi1 = new FileInfo(path);
            label1_uber.Text += "\r\n\r\n " + fi1.LastWriteTime;
        }
    }
}
