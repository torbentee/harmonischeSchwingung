namespace harmonischeSchwingung
{
    partial class Form_Uber
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1_uber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1_uber
            // 
            this.label1_uber.AutoSize = true;
            this.label1_uber.Location = new System.Drawing.Point(12, 46);
            this.label1_uber.Name = "label1_uber";
            this.label1_uber.Size = new System.Drawing.Size(208, 13);
            this.label1_uber.TabIndex = 0;
            this.label1_uber.Text = "Hergestellt in Hannover von Torben Tietze";
            // 
            // Form_Uber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.label1_uber);
            this.Name = "Form_Uber";
            this.Text = "Über";
            this.Load += new System.EventHandler(this.Form_Uber_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1_uber;
    }
}