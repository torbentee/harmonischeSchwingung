using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Diagnostics;
using System.IO;


namespace harmonischeSchwingung
{
	public partial class Form_Haupt : Form
	{
        //Arrays für die Lösungen der Formeln
        //101 steht für die Zahl der x Werte im Graphen
        //#############################################
        //ACHTUNG müssen alle gemeinsam geändert werden
        //#############################################
        double[,] a = new double[101,2];
        double[,] b = new double[101,2];
        double[,] c = new double[101,2];
        //Arrays für den Einheitskreis
        double[] d = new double[101];
        double[] e = new double[101];
        double[] f = new double[101];

        double[] pi = new double[101];

		public Form_Haupt()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
            graphClear();

            if(checkBox_oneGraph.Checked)
            {
                chartShowAndFormSize(1);
                berechne_oneGraph();
            }
            else
            {
                chartShowAndFormSize(3);
                berechne_threeGraph();
            }

            printPeriodtime();
            berechnePhasenverschiebungNachRad();

            //Tooltip für die Detailansicht
            ToolTip toolipooli = new ToolTip();
            toolipooli.SetToolTip(this.chrt_zeitBeschleu, "Für eine Detailansicht bitte klicken");
            toolipooli.SetToolTip(this.chrt_zeitGeschwin, "Für eine Detailansicht bitte klicken");
            toolipooli.SetToolTip(this.chrt_zeitOrt, "Für eine Detailansicht bitte klicken"); 
		}

        //Anzeige der verschiedenen Charts handeln
        private void chartShowAndFormSize(int diagrammAnzahl)
        {
            switch(diagrammAnzahl)
            {
                case 1:
                    chrt_threeGraph.Visible = true;
                    chrt_zeitOrt.Visible = false;
                    chrt_zeitGeschwin.Visible = false;
                    chrt_zeitBeschleu.Visible = false;
                    this.Size = new System.Drawing.Size(this.Size.Width, 320);
                    break;

                case 3:
                    chrt_threeGraph.Visible = false;
                    chrt_zeitOrt.Visible = true;
                    chrt_zeitGeschwin.Visible = true;
                    chrt_zeitBeschleu.Visible = true;
                    this.Size = new System.Drawing.Size(this.Size.Width, 700);
                    break;
            }
        }

        private void button_berechnen_Click(object sender, EventArgs e)
        {
            graphClear();

            if (checkBox_oneGraph.Checked)
            {
                if (checkInput())
                {
                    berechne_unitCircle(1, printPeriodtime());
                }
                chartShowAndFormSize(1);
                berechne_oneGraph();
            }
            else
            {
                if (checkInput())
                {
                    berechne_unitCircle(3, printPeriodtime());
                }
                chartShowAndFormSize(3);
                berechne_threeGraph();
            }
        }

        //Methode zum berechnen des Sinus-Einheitskreis
        private void berechne_unitCircle(int anzahlDiagramme, double periodLength)
        {
            schwingung harmon = new schwingung(1L, 1L, 0);
            for (int i = 0; i < a.GetLength(0); i++)
            {
                double inside = Convert.ToByte(i);      //i in byte Konvertieren um 0,01er Schritte zu bekommen
                inside = inside / 100 * periodLength; 
                d[i] = harmon.zeitOrtCalc(inside);
                e[i] = harmon.zeitGeschwindigkeitCalc(inside);
                f[i] = harmon.zeitBeschleunigungCalc(inside);


                //Auswahl des Diagramms bei mehreren oder nur einem Diagramm
                switch (anzahlDiagramme)
                {
                    case 1:
                        chrt_threeGraph.Series[3].Points.AddXY(inside, d[i]);
                        break;
                    case 3:
                        chrt_zeitOrt.Series[1].Points.AddXY(inside, d[i]);
                        chrt_zeitGeschwin.Series[1].Points.AddXY(inside, e[i]);
                        chrt_zeitBeschleu.Series[1].Points.AddXY(inside, f[i]);
                        break;
                    default:
                        break;
                }
            }
        }

        private void berechne_oneGraph()
        {
            double kreisFrequenz = 2 * Math.PI * (double)numeric_Frequenz.Value;
            schwingung harmon = new schwingung(Convert.ToDouble(numeric_Amplitude.Value),Convert.ToDouble(numeric_Frequenz.Value), berechneWinkelBogenmaß(Convert.ToDouble(numeric_Phasenversc.Value)));
            //MessageBox.Show(harmon.Periodendauer.ToString());
            for (int i = 0; i < a.Length; i++)
            {

                double inside = Convert.ToByte(i);      //i in byte Konvertieren um 0,01er Schritte zu bekommen
                inside = inside / 100 * harmon.Periodendauer; 
                //a[i] = harmon.zeitOrtCalc(inside);
                //b[i] = harmon.zeitGeschwindigkeitCalc(inside);
                //c[i] = harmon.zeitBeschleunigungCalc(inside);

                //chrt_threeGraph.Series[0].Points.AddXY(inside, a[i]);
                //chrt_threeGraph.Series[1].Points.AddXY(inside, b[i]);
                //chrt_threeGraph.Series[2].Points.AddXY(inside, c[i]);

            }
        }

        private void berechne_threeGraph()
        {
            //Objekt das die Methoden für die Berechnungen enthält
            schwingung harmon = new schwingung(Convert.ToDouble(numeric_Amplitude.Value), Convert.ToDouble(numeric_Frequenz.Value), berechneWinkelBogenmaß(Convert.ToDouble(numeric_Phasenversc.Value)));

            //Array komplett durchlaufen
            for (int i = 0; i < a.GetLength(0) ; i++)
            {
                double inside = (byte)i;      //i in byte Konvertieren um 0,01er Schritte zu bekommen
                inside = inside / 100 * harmon.Periodendauer;
                a[i, 1] = harmon.zeitOrtCalc(inside);
                a[i, 0] = inside;
                //if (inside > harmon.Periodendauer) break;
                b[i,1] = harmon.zeitGeschwindigkeitCalc(inside);
                b[i,0] = inside;
                c[i,1] = harmon.zeitBeschleunigungCalc(inside);
                c[i,0] = inside;

                chrt_zeitOrt.Series[0].Points.AddXY(a[i,0] , a[i,1]);
                chrt_zeitGeschwin.Series[0].Points.AddXY(b[i,0], b[i,1]);
                chrt_zeitBeschleu.Series[0].Points.AddXY(c[i,0], c[i,1]);
            }

        }

        //Methode die die/den Graphen leert vor z.B. dem erneuten Aufruf
		public void graphClear()
		{
            chrt_threeGraph.Series[0].Points.Clear();
            chrt_threeGraph.Series[1].Points.Clear();
            chrt_threeGraph.Series[2].Points.Clear();
            chrt_threeGraph.Series[3].Points.Clear();
			chrt_zeitOrt.Series[0].Points.Clear();
            chrt_zeitOrt.Series[1].Points.Clear();
            chrt_zeitGeschwin.Series[0].Points.Clear();
            chrt_zeitGeschwin.Series[1].Points.Clear();
            chrt_zeitBeschleu.Series[0].Points.Clear();
            chrt_zeitBeschleu.Series[1].Points.Clear();
		}

        private void numeric_Phasenversc_ValueChanged(object sender, EventArgs e)
        {
            berechnePhasenverschiebungNachRad();
           
        }
        
        private void berechnePhasenverschiebungNachRad()
        {
            textBox_PhasenverschiebungBogenmaß.Text = Convert.ToString(numeric_Phasenversc.Value * (decimal)Math.PI / 180);
        }

        private double berechneWinkelBogenmaß(double Phasenwinkel)
        {
            double Bogenmaß = Phasenwinkel * Math.PI / 180;
            return (Bogenmaß);
        }

        //Events zum überprüfen der Eingabe der Frequenz und Amplitude die nicht null sein darf
        #region Werte der Regler NOT 0
        private void numeric_Frequenz_ValueChanged(object sender, EventArgs e)
		{
			if (numeric_Frequenz.Value == 0)
			{
				MessageBox.Show("Der Wert darf nicht '0' oder negativ sein");
				numeric_Frequenz.Value = 1;
			}
            /*if (numeric_Frequenz.Value > 21)
            {
                MessageBox.Show("Der Wert darf nicht größer als '21' sein");
                numeric_Frequenz.Value = 21;
            }*/

            printPeriodtime();
		}

        private double printPeriodtime()
        {
            double periodtime = 1/(double)numeric_Frequenz.Value;
            textBox_Kreisfrequenz.Text = Convert.ToString(periodtime);
            return(periodtime);
        }

		private void numeric_Amplitude_ValueChanged(object sender, EventArgs e)
		{
            //MessageBox.Show(numeric_Amplitude.Value.ToString());
			if (numeric_Amplitude.Value == 0)
			{
				MessageBox.Show("Der Wert darf nicht '0' oder negativ sein");
				numeric_Amplitude.Value = 1;
			}
		}
        
        //Methode zum überprüfen ob die Eingabefelder nicht 1 bzw. 0 sind um den Einheitskreis zu berechnen
        private bool checkInput()
        {
            if (numeric_Amplitude.Value != 1 || numeric_Frequenz.Value != 1 || numeric_Phasenversc.Value != 0) return true;
            else return false;
        }

        #endregion

        //Events zum öffnen der Detail Ansicht der Charts
        #region Chart Detail

        private void chrt_zeitOrt_Click(object sender, EventArgs e)
        {
            if (Class1.window1open == false)
            {
                Form_WerteAnsicht detailView = new Form_WerteAnsicht("Window 1");
                detailView.textausgeb(a);
                detailView.Show();
                Class1.window1open = true;   
            }           
        }

        private void chrt_zeitGeschwin_Click(object sender, EventArgs e)
        {
            if (Class1.window2open == false)
            {
                Form_WerteAnsicht detailView = new Form_WerteAnsicht("Window 2");
                detailView.textausgeb(b);
                detailView.Show();
                Class1.window2open = true;
            }
        }

        private void chrt_zeitBeschleu_Click(object sender, EventArgs e)
        {
            if (Class1.window3open == false)
            {
                Form_WerteAnsicht detailView = new Form_WerteAnsicht("Window 3");
                detailView.textausgeb(c);
                detailView.Show();
                Class1.window3open = true;
            }
        }

        #endregion

        //Events des HeadToolStrips
        #region ToolStripIem
        private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //export der berechneten Arrays als csv geordnet nach Zeit
        private void zeitGeordnetToolStripMenuItem_Click(object sender, EventArgs e)
        {/*
            saveFileDialog1.ShowDialog();
            string pfad = saveFileDialog1.FileName;
            //MessageBox.Show(pfad);

            StreamWriter outputFile = new StreamWriter(pfad);

            outputFile.Write("Zeit;Ort;Geschwindigkeit;Beschleunigung\r\n");
            for (int i = 0; i < a.Length; i++)
            {
                double insideI = Convert.ToByte(i);
                insideI = insideI / 100;
                //csv gerechte Ausgabe der Werte
                //### Werte getrennt durch ";" Zeilen durch einen Windows Return "\r\n"
                outputFile.Write(insideI + ";" + a[i] + ";" + b[i] + ";" + c[i] + "\r\n");
            }

            outputFile.Close();
            MessageBox.Show("Erfolgreich exportiert", "Hinweis");
            */
        }
        
        //export der berechneten Arrays als csv geordnet nach einzelnen Kategorie
        private void kategorienToolStripMenuItem_Click(object sender, EventArgs e)
        {/*

            saveFileDialog1.ShowDialog();
            string pfad = saveFileDialog1.FileName;
            //MessageBox.Show(pfad);

            StreamWriter outputFile = new StreamWriter(pfad);

            outputFile.Write("Zeit-Orts-Gesetz\r\n");
            outputFile.Write("x;y\r\n");
            for (int i = 0; i < a.Length; i++)
            {
                double insideI = Convert.ToByte(i);
                insideI = insideI / 100;
                outputFile.Write(insideI + ";" + a[i] + "\r\n");
            }

            outputFile.Write("Zeit-Geschwindigkeits-Gesetz\r\n");
            for (int i = 0; i < b.Length; i++)
            {
                double insideI = Convert.ToByte(i);
                insideI = insideI / 100;
                outputFile.Write(insideI + ";" + b[i] + "\r\n");
            }
            outputFile.Write("Zeit-Beschleunigungs-Gesetz\r\n");
            for (int i = 0; i < c.Length; i++)
            {
                double insideI = Convert.ToByte(i);
                insideI = insideI / 100;
                outputFile.Write(insideI + ";" + c[i] + "\r\n");
            }

                outputFile.Close();
                MessageBox.Show("Erfolgreich exportiert", "Hinweis");
        */}
        
        private void überToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Uber überUns = new Form_Uber();
            überUns.Show();
        }
        #endregion


        


    }
}
