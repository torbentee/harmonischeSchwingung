namespace harmonischeSchwingung
{
    partial class Form_Haupt
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Haupt));
            this.label_Amplitute = new System.Windows.Forms.Label();
            this.label_Frequenz = new System.Windows.Forms.Label();
            this.label_Phasenverschiebung = new System.Windows.Forms.Label();
            this.button_berechnen = new System.Windows.Forms.Button();
            this.numeric_Amplitude = new System.Windows.Forms.NumericUpDown();
            this.numeric_Frequenz = new System.Windows.Forms.NumericUpDown();
            this.numeric_Phasenversc = new System.Windows.Forms.NumericUpDown();
            this.chrt_zeitGeschwin = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chrt_zeitBeschleu = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chrt_zeitOrt = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportierenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zeitGeordnetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kategorienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.überToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.checkBox_oneGraph = new System.Windows.Forms.CheckBox();
            this.chrt_threeGraph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textBox_Kreisfrequenz = new System.Windows.Forms.TextBox();
            this.label_Periodendauer = new System.Windows.Forms.Label();
            this.label_PhasenverschiebungBogenmaß = new System.Windows.Forms.Label();
            this.textBox_PhasenverschiebungBogenmaß = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Amplitude)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Frequenz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Phasenversc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrt_zeitGeschwin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrt_zeitBeschleu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrt_zeitOrt)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrt_threeGraph)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Amplitute
            // 
            this.label_Amplitute.AutoSize = true;
            this.label_Amplitute.Location = new System.Drawing.Point(12, 32);
            this.label_Amplitute.Name = "label_Amplitute";
            this.label_Amplitute.Size = new System.Drawing.Size(72, 13);
            this.label_Amplitute.TabIndex = 2;
            this.label_Amplitute.Text = "Amplitude / m";
            // 
            // label_Frequenz
            // 
            this.label_Frequenz.AutoSize = true;
            this.label_Frequenz.Location = new System.Drawing.Point(152, 32);
            this.label_Frequenz.Name = "label_Frequenz";
            this.label_Frequenz.Size = new System.Drawing.Size(75, 13);
            this.label_Frequenz.TabIndex = 4;
            this.label_Frequenz.Text = "Frequenz / Hz";
            // 
            // label_Phasenverschiebung
            // 
            this.label_Phasenverschiebung.AutoSize = true;
            this.label_Phasenverschiebung.Location = new System.Drawing.Point(408, 32);
            this.label_Phasenverschiebung.Name = "label_Phasenverschiebung";
            this.label_Phasenverschiebung.Size = new System.Drawing.Size(141, 13);
            this.label_Phasenverschiebung.TabIndex = 6;
            this.label_Phasenverschiebung.Text = "Phasenverschiebung / Grad";
            // 
            // button_berechnen
            // 
            this.button_berechnen.Location = new System.Drawing.Point(719, 48);
            this.button_berechnen.Name = "button_berechnen";
            this.button_berechnen.Size = new System.Drawing.Size(75, 23);
            this.button_berechnen.TabIndex = 0;
            this.button_berechnen.Text = "berechnen";
            this.button_berechnen.UseVisualStyleBackColor = true;
            this.button_berechnen.Click += new System.EventHandler(this.button_berechnen_Click);
            // 
            // numeric_Amplitude
            // 
            this.numeric_Amplitude.DecimalPlaces = 2;
            this.numeric_Amplitude.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numeric_Amplitude.Location = new System.Drawing.Point(12, 51);
            this.numeric_Amplitude.Name = "numeric_Amplitude";
            this.numeric_Amplitude.Size = new System.Drawing.Size(120, 20);
            this.numeric_Amplitude.TabIndex = 13;
            this.numeric_Amplitude.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numeric_Amplitude.ValueChanged += new System.EventHandler(this.numeric_Amplitude_ValueChanged);
            // 
            // numeric_Frequenz
            // 
            this.numeric_Frequenz.DecimalPlaces = 2;
            this.numeric_Frequenz.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numeric_Frequenz.Location = new System.Drawing.Point(155, 50);
            this.numeric_Frequenz.Name = "numeric_Frequenz";
            this.numeric_Frequenz.Size = new System.Drawing.Size(120, 20);
            this.numeric_Frequenz.TabIndex = 14;
            this.numeric_Frequenz.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numeric_Frequenz.ValueChanged += new System.EventHandler(this.numeric_Frequenz_ValueChanged);
            // 
            // numeric_Phasenversc
            // 
            this.numeric_Phasenversc.DecimalPlaces = 2;
            this.numeric_Phasenversc.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numeric_Phasenversc.Location = new System.Drawing.Point(411, 50);
            this.numeric_Phasenversc.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numeric_Phasenversc.Minimum = new decimal(new int[] {
            360,
            0,
            0,
            -2147483648});
            this.numeric_Phasenversc.Name = "numeric_Phasenversc";
            this.numeric_Phasenversc.Size = new System.Drawing.Size(138, 20);
            this.numeric_Phasenversc.TabIndex = 15;
            this.numeric_Phasenversc.ValueChanged += new System.EventHandler(this.numeric_Phasenversc_ValueChanged);
            // 
            // chrt_zeitGeschwin
            // 
            chartArea1.AxisX.IsMarginVisible = false;
            chartArea1.AxisX.IsStartedFromZero = false;
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisX.Title = "Zeit / s";
            chartArea1.AxisX.TitleAlignment = System.Drawing.StringAlignment.Far;
            chartArea1.AxisY.Title = "Geschwindigkeit / m/s";
            chartArea1.AxisY.TitleAlignment = System.Drawing.StringAlignment.Far;
            chartArea1.Name = "ChartArea1";
            this.chrt_zeitGeschwin.ChartAreas.Add(chartArea1);
            this.chrt_zeitGeschwin.Location = new System.Drawing.Point(12, 274);
            this.chrt_zeitGeschwin.Name = "chrt_zeitGeschwin";
            this.chrt_zeitGeschwin.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(95)))), ((int)(((byte)(165)))));
            series1.Name = "Series1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Color = System.Drawing.Color.Black;
            series2.Name = "unitCircle";
            this.chrt_zeitGeschwin.Series.Add(series1);
            this.chrt_zeitGeschwin.Series.Add(series2);
            this.chrt_zeitGeschwin.Size = new System.Drawing.Size(860, 185);
            this.chrt_zeitGeschwin.TabIndex = 18;
            this.chrt_zeitGeschwin.Text = "Zeit-Geschwindigkeit";
            this.chrt_zeitGeschwin.Click += new System.EventHandler(this.chrt_zeitGeschwin_Click);
            // 
            // chrt_zeitBeschleu
            // 
            chartArea2.AxisX.IsMarginVisible = false;
            chartArea2.AxisX.IsStartedFromZero = false;
            chartArea2.AxisX.Minimum = 0D;
            chartArea2.AxisX.Title = "Zeit / s";
            chartArea2.AxisX.TitleAlignment = System.Drawing.StringAlignment.Far;
            chartArea2.AxisY.Title = "Beschleunigung / m/s²";
            chartArea2.AxisY.TitleAlignment = System.Drawing.StringAlignment.Far;
            chartArea2.Name = "ChartArea1";
            this.chrt_zeitBeschleu.ChartAreas.Add(chartArea2);
            this.chrt_zeitBeschleu.Location = new System.Drawing.Point(12, 465);
            this.chrt_zeitBeschleu.Name = "chrt_zeitBeschleu";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(226)))), ((int)(((byte)(0)))));
            series3.Name = "Series1";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Color = System.Drawing.Color.Black;
            series4.Name = "unitCircle";
            this.chrt_zeitBeschleu.Series.Add(series3);
            this.chrt_zeitBeschleu.Series.Add(series4);
            this.chrt_zeitBeschleu.Size = new System.Drawing.Size(860, 185);
            this.chrt_zeitBeschleu.TabIndex = 19;
            this.chrt_zeitBeschleu.Text = "Zeit-Beschleunigung";
            this.chrt_zeitBeschleu.Click += new System.EventHandler(this.chrt_zeitBeschleu_Click);
            // 
            // chrt_zeitOrt
            // 
            chartArea3.AxisX.IsMarginVisible = false;
            chartArea3.AxisX.IsStartedFromZero = false;
            chartArea3.AxisX.Minimum = 0D;
            chartArea3.AxisX.ScaleBreakStyle.Spacing = 1D;
            chartArea3.AxisX.Title = "Zeit / s";
            chartArea3.AxisX.TitleAlignment = System.Drawing.StringAlignment.Far;
            chartArea3.AxisY.Title = "Ort / m";
            chartArea3.AxisY.TitleAlignment = System.Drawing.StringAlignment.Far;
            chartArea3.Name = "ChartArea1";
            this.chrt_zeitOrt.ChartAreas.Add(chartArea3);
            this.chrt_zeitOrt.Location = new System.Drawing.Point(12, 83);
            this.chrt_zeitOrt.Name = "chrt_zeitOrt";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series5.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(76)))), ((int)(((byte)(0)))));
            series5.Name = "zeitOrt";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series6.Color = System.Drawing.Color.Gray;
            series6.Name = "unitCircle";
            series6.ShadowColor = System.Drawing.Color.Black;
            this.chrt_zeitOrt.Series.Add(series5);
            this.chrt_zeitOrt.Series.Add(series6);
            this.chrt_zeitOrt.Size = new System.Drawing.Size(860, 185);
            this.chrt_zeitOrt.TabIndex = 20;
            this.chrt_zeitOrt.Text = "chrt_zeitOrt";
            this.chrt_zeitOrt.Click += new System.EventHandler(this.chrt_zeitOrt_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(884, 24);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dateiToolStripMenuItem
            // 
            this.dateiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportierenToolStripMenuItem,
            this.beendenToolStripMenuItem});
            this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            this.dateiToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.dateiToolStripMenuItem.Text = "Datei";
            // 
            // exportierenToolStripMenuItem
            // 
            this.exportierenToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.exportierenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zeitGeordnetToolStripMenuItem,
            this.kategorienToolStripMenuItem});
            this.exportierenToolStripMenuItem.Name = "exportierenToolStripMenuItem";
            this.exportierenToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.exportierenToolStripMenuItem.Text = "Exportieren";
            // 
            // zeitGeordnetToolStripMenuItem
            // 
            this.zeitGeordnetToolStripMenuItem.Name = "zeitGeordnetToolStripMenuItem";
            this.zeitGeordnetToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.zeitGeordnetToolStripMenuItem.Text = "nach Zeit";
            this.zeitGeordnetToolStripMenuItem.Click += new System.EventHandler(this.zeitGeordnetToolStripMenuItem_Click);
            // 
            // kategorienToolStripMenuItem
            // 
            this.kategorienToolStripMenuItem.Name = "kategorienToolStripMenuItem";
            this.kategorienToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.kategorienToolStripMenuItem.Text = "nach Kategorien";
            this.kategorienToolStripMenuItem.Click += new System.EventHandler(this.kategorienToolStripMenuItem_Click);
            // 
            // beendenToolStripMenuItem
            // 
            this.beendenToolStripMenuItem.Name = "beendenToolStripMenuItem";
            this.beendenToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.beendenToolStripMenuItem.Text = "Beenden";
            this.beendenToolStripMenuItem.Click += new System.EventHandler(this.beendenToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.überToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(24, 20);
            this.toolStripMenuItem1.Text = "?";
            // 
            // überToolStripMenuItem
            // 
            this.überToolStripMenuItem.Name = "überToolStripMenuItem";
            this.überToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.überToolStripMenuItem.Text = "Über...";
            this.überToolStripMenuItem.Click += new System.EventHandler(this.überToolStripMenuItem_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "csv";
            this.saveFileDialog1.FileName = "export.csv";
            // 
            // checkBox_oneGraph
            // 
            this.checkBox_oneGraph.AutoSize = true;
            this.checkBox_oneGraph.Location = new System.Drawing.Point(800, 52);
            this.checkBox_oneGraph.Name = "checkBox_oneGraph";
            this.checkBox_oneGraph.Size = new System.Drawing.Size(72, 17);
            this.checkBox_oneGraph.TabIndex = 22;
            this.checkBox_oneGraph.Text = "ein Graph";
            this.checkBox_oneGraph.UseVisualStyleBackColor = true;
            // 
            // chrt_threeGraph
            // 
            chartArea4.AxisX.IsMarginVisible = false;
            chartArea4.AxisX.IsStartedFromZero = false;
            chartArea4.AxisX.Minimum = 0D;
            chartArea4.AxisX.ScaleBreakStyle.Spacing = 1D;
            chartArea4.AxisX.Title = "Zeit / s";
            chartArea4.AxisX.TitleAlignment = System.Drawing.StringAlignment.Far;
            chartArea4.AxisY.TitleAlignment = System.Drawing.StringAlignment.Far;
            chartArea4.Name = "ChartArea1";
            this.chrt_threeGraph.ChartAreas.Add(chartArea4);
            this.chrt_threeGraph.Location = new System.Drawing.Point(12, 83);
            this.chrt_threeGraph.Name = "chrt_threeGraph";
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series7.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(76)))), ((int)(((byte)(0)))));
            series7.Name = "zeitOrt";
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series8.Color = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(95)))), ((int)(((byte)(165)))));
            series8.Name = "zeitGeschwindigkeit";
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series9.Color = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(226)))), ((int)(((byte)(0)))));
            series9.Name = "zeitBeschleunigung";
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series10.Color = System.Drawing.Color.Black;
            series10.Name = "uniCircle";
            this.chrt_threeGraph.Series.Add(series7);
            this.chrt_threeGraph.Series.Add(series8);
            this.chrt_threeGraph.Series.Add(series9);
            this.chrt_threeGraph.Series.Add(series10);
            this.chrt_threeGraph.Size = new System.Drawing.Size(860, 185);
            this.chrt_threeGraph.TabIndex = 23;
            this.chrt_threeGraph.Text = "threeGraph";
            // 
            // textBox_Kreisfrequenz
            // 
            this.textBox_Kreisfrequenz.Location = new System.Drawing.Point(281, 51);
            this.textBox_Kreisfrequenz.Name = "textBox_Kreisfrequenz";
            this.textBox_Kreisfrequenz.ReadOnly = true;
            this.textBox_Kreisfrequenz.Size = new System.Drawing.Size(100, 20);
            this.textBox_Kreisfrequenz.TabIndex = 24;
            // 
            // label_Periodendauer
            // 
            this.label_Periodendauer.AutoSize = true;
            this.label_Periodendauer.Location = new System.Drawing.Point(278, 32);
            this.label_Periodendauer.Name = "label_Periodendauer";
            this.label_Periodendauer.Size = new System.Drawing.Size(92, 13);
            this.label_Periodendauer.TabIndex = 25;
            this.label_Periodendauer.Text = "Periodendauer / s";
            // 
            // label_PhasenverschiebungBogenmaß
            // 
            this.label_PhasenverschiebungBogenmaß.AutoSize = true;
            this.label_PhasenverschiebungBogenmaß.Location = new System.Drawing.Point(555, 32);
            this.label_PhasenverschiebungBogenmaß.Name = "label_PhasenverschiebungBogenmaß";
            this.label_PhasenverschiebungBogenmaß.Size = new System.Drawing.Size(138, 13);
            this.label_PhasenverschiebungBogenmaß.TabIndex = 26;
            this.label_PhasenverschiebungBogenmaß.Text = "Phasenverschiebung / Rad";
            // 
            // textBox_PhasenverschiebungBogenmaß
            // 
            this.textBox_PhasenverschiebungBogenmaß.Location = new System.Drawing.Point(555, 50);
            this.textBox_PhasenverschiebungBogenmaß.Name = "textBox_PhasenverschiebungBogenmaß";
            this.textBox_PhasenverschiebungBogenmaß.ReadOnly = true;
            this.textBox_PhasenverschiebungBogenmaß.Size = new System.Drawing.Size(138, 20);
            this.textBox_PhasenverschiebungBogenmaß.TabIndex = 27;
            // 
            // Form_Haupt
            // 
            this.AcceptButton = this.button_berechnen;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 662);
            this.Controls.Add(this.textBox_PhasenverschiebungBogenmaß);
            this.Controls.Add(this.label_PhasenverschiebungBogenmaß);
            this.Controls.Add(this.label_Periodendauer);
            this.Controls.Add(this.textBox_Kreisfrequenz);
            this.Controls.Add(this.checkBox_oneGraph);
            this.Controls.Add(this.chrt_zeitBeschleu);
            this.Controls.Add(this.chrt_zeitGeschwin);
            this.Controls.Add(this.numeric_Phasenversc);
            this.Controls.Add(this.numeric_Frequenz);
            this.Controls.Add(this.numeric_Amplitude);
            this.Controls.Add(this.button_berechnen);
            this.Controls.Add(this.label_Phasenverschiebung);
            this.Controls.Add(this.label_Frequenz);
            this.Controls.Add(this.label_Amplitute);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.chrt_zeitOrt);
            this.Controls.Add(this.chrt_threeGraph);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form_Haupt";
            this.Text = "Schwingung";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Amplitude)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Frequenz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Phasenversc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrt_zeitGeschwin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrt_zeitBeschleu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrt_zeitOrt)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrt_threeGraph)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Amplitute;
        private System.Windows.Forms.Label label_Frequenz;
        private System.Windows.Forms.Label label_Phasenverschiebung;
        private System.Windows.Forms.Button button_berechnen;
        private System.Windows.Forms.NumericUpDown numeric_Amplitude;
        private System.Windows.Forms.NumericUpDown numeric_Frequenz;
        private System.Windows.Forms.NumericUpDown numeric_Phasenversc;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrt_zeitGeschwin;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrt_zeitBeschleu;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrt_zeitOrt;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dateiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beendenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exportierenToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem zeitGeordnetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kategorienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem überToolStripMenuItem;
        private System.Windows.Forms.CheckBox checkBox_oneGraph;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrt_threeGraph;
        private System.Windows.Forms.TextBox textBox_Kreisfrequenz;
        private System.Windows.Forms.Label label_Periodendauer;
        private System.Windows.Forms.Label label_PhasenverschiebungBogenmaß;
        private System.Windows.Forms.TextBox textBox_PhasenverschiebungBogenmaß;
    }
}

