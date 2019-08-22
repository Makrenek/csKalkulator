namespace Kalkulator1
{
    partial class Kalkulator
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TBwynik = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.B7 = new System.Windows.Forms.Button();
            this.B8 = new System.Windows.Forms.Button();
            this.B9 = new System.Windows.Forms.Button();
            this.Bdodawanie = new System.Windows.Forms.Button();
            this.Bodejmowanie = new System.Windows.Forms.Button();
            this.B6 = new System.Windows.Forms.Button();
            this.B5 = new System.Windows.Forms.Button();
            this.B4 = new System.Windows.Forms.Button();
            this.Bmnozenie = new System.Windows.Forms.Button();
            this.B3 = new System.Windows.Forms.Button();
            this.B2 = new System.Windows.Forms.Button();
            this.B1 = new System.Windows.Forms.Button();
            this.Bdzielenie = new System.Windows.Forms.Button();
            this.Bwynik = new System.Windows.Forms.Button();
            this.B0 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TBwynik
            // 
            this.TBwynik.Location = new System.Drawing.Point(12, 12);
            this.TBwynik.Name = "TBwynik";
            this.TBwynik.Size = new System.Drawing.Size(170, 22);
            this.TBwynik.TabIndex = 0;
            this.TBwynik.TextChanged += new System.EventHandler(this.TBwynik_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // B7
            // 
            this.B7.Location = new System.Drawing.Point(12, 40);
            this.B7.Name = "B7";
            this.B7.Size = new System.Drawing.Size(38, 23);
            this.B7.TabIndex = 2;
            this.B7.Text = "7";
            this.B7.UseVisualStyleBackColor = true;
            this.B7.Click += new System.EventHandler(this.B7_Click);
            // 
            // B8
            // 
            this.B8.Location = new System.Drawing.Point(56, 40);
            this.B8.Name = "B8";
            this.B8.Size = new System.Drawing.Size(38, 23);
            this.B8.TabIndex = 3;
            this.B8.Text = "8";
            this.B8.UseVisualStyleBackColor = true;
            this.B8.Click += new System.EventHandler(this.B8_Click);
            // 
            // B9
            // 
            this.B9.Location = new System.Drawing.Point(100, 40);
            this.B9.Name = "B9";
            this.B9.Size = new System.Drawing.Size(38, 23);
            this.B9.TabIndex = 4;
            this.B9.Text = "9";
            this.B9.UseVisualStyleBackColor = true;
            this.B9.Click += new System.EventHandler(this.B9_Click);
            // 
            // Bdodawanie
            // 
            this.Bdodawanie.Location = new System.Drawing.Point(144, 40);
            this.Bdodawanie.Name = "Bdodawanie";
            this.Bdodawanie.Size = new System.Drawing.Size(38, 23);
            this.Bdodawanie.TabIndex = 5;
            this.Bdodawanie.Text = "+";
            this.Bdodawanie.UseVisualStyleBackColor = true;
            this.Bdodawanie.Click += new System.EventHandler(this.Bdodawanie_Click);
            // 
            // Bodejmowanie
            // 
            this.Bodejmowanie.Location = new System.Drawing.Point(144, 69);
            this.Bodejmowanie.Name = "Bodejmowanie";
            this.Bodejmowanie.Size = new System.Drawing.Size(38, 23);
            this.Bodejmowanie.TabIndex = 9;
            this.Bodejmowanie.Text = "-";
            this.Bodejmowanie.UseVisualStyleBackColor = true;
            this.Bodejmowanie.Click += new System.EventHandler(this.Bodejmowanie_Click);
            // 
            // B6
            // 
            this.B6.Location = new System.Drawing.Point(100, 69);
            this.B6.Name = "B6";
            this.B6.Size = new System.Drawing.Size(38, 23);
            this.B6.TabIndex = 8;
            this.B6.Text = "6";
            this.B6.UseVisualStyleBackColor = true;
            this.B6.Click += new System.EventHandler(this.B6_Click);
            // 
            // B5
            // 
            this.B5.Location = new System.Drawing.Point(56, 69);
            this.B5.Name = "B5";
            this.B5.Size = new System.Drawing.Size(38, 23);
            this.B5.TabIndex = 7;
            this.B5.Text = "5";
            this.B5.UseVisualStyleBackColor = true;
            this.B5.Click += new System.EventHandler(this.B5_Click);
            // 
            // B4
            // 
            this.B4.Location = new System.Drawing.Point(12, 69);
            this.B4.Name = "B4";
            this.B4.Size = new System.Drawing.Size(38, 23);
            this.B4.TabIndex = 6;
            this.B4.Text = "4";
            this.B4.UseVisualStyleBackColor = true;
            this.B4.Click += new System.EventHandler(this.B4_Click);
            // 
            // Bmnozenie
            // 
            this.Bmnozenie.Location = new System.Drawing.Point(144, 98);
            this.Bmnozenie.Name = "Bmnozenie";
            this.Bmnozenie.Size = new System.Drawing.Size(38, 23);
            this.Bmnozenie.TabIndex = 13;
            this.Bmnozenie.Text = "*";
            this.Bmnozenie.UseVisualStyleBackColor = true;
            this.Bmnozenie.Click += new System.EventHandler(this.Bmnozenie_Click);
            // 
            // B3
            // 
            this.B3.Location = new System.Drawing.Point(100, 98);
            this.B3.Name = "B3";
            this.B3.Size = new System.Drawing.Size(38, 23);
            this.B3.TabIndex = 12;
            this.B3.Text = "3";
            this.B3.UseVisualStyleBackColor = true;
            this.B3.Click += new System.EventHandler(this.B3_Click);
            // 
            // B2
            // 
            this.B2.Location = new System.Drawing.Point(56, 98);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(38, 23);
            this.B2.TabIndex = 11;
            this.B2.Text = "2";
            this.B2.UseVisualStyleBackColor = true;
            this.B2.Click += new System.EventHandler(this.B2_Click);
            // 
            // B1
            // 
            this.B1.Location = new System.Drawing.Point(12, 98);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(38, 23);
            this.B1.TabIndex = 10;
            this.B1.Text = "1";
            this.B1.UseVisualStyleBackColor = true;
            this.B1.Click += new System.EventHandler(this.B1_Click);
            // 
            // Bdzielenie
            // 
            this.Bdzielenie.Location = new System.Drawing.Point(144, 127);
            this.Bdzielenie.Name = "Bdzielenie";
            this.Bdzielenie.Size = new System.Drawing.Size(38, 23);
            this.Bdzielenie.TabIndex = 17;
            this.Bdzielenie.Text = "/";
            this.Bdzielenie.UseVisualStyleBackColor = true;
            this.Bdzielenie.Click += new System.EventHandler(this.Bdzielenie_Click);
            // 
            // Bwynik
            // 
            this.Bwynik.Location = new System.Drawing.Point(56, 127);
            this.Bwynik.Name = "Bwynik";
            this.Bwynik.Size = new System.Drawing.Size(82, 23);
            this.Bwynik.TabIndex = 15;
            this.Bwynik.Text = "=";
            this.Bwynik.UseVisualStyleBackColor = true;
            this.Bwynik.Click += new System.EventHandler(this.Bwynik_Click);
            // 
            // B0
            // 
            this.B0.Location = new System.Drawing.Point(12, 127);
            this.B0.Name = "B0";
            this.B0.Size = new System.Drawing.Size(38, 23);
            this.B0.TabIndex = 14;
            this.B0.Text = "0";
            this.B0.UseVisualStyleBackColor = true;
            this.B0.Click += new System.EventHandler(this.B0_Click);
            // 
            // Kalkulator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(191, 162);
            this.Controls.Add(this.Bdzielenie);
            this.Controls.Add(this.Bwynik);
            this.Controls.Add(this.B0);
            this.Controls.Add(this.Bmnozenie);
            this.Controls.Add(this.B3);
            this.Controls.Add(this.B2);
            this.Controls.Add(this.B1);
            this.Controls.Add(this.Bodejmowanie);
            this.Controls.Add(this.B6);
            this.Controls.Add(this.B5);
            this.Controls.Add(this.B4);
            this.Controls.Add(this.Bdodawanie);
            this.Controls.Add(this.B9);
            this.Controls.Add(this.B8);
            this.Controls.Add(this.B7);
            this.Controls.Add(this.TBwynik);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Kalkulator";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBwynik;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button B7;
        private System.Windows.Forms.Button B8;
        private System.Windows.Forms.Button B9;
        private System.Windows.Forms.Button Bdodawanie;
        private System.Windows.Forms.Button Bodejmowanie;
        private System.Windows.Forms.Button B6;
        private System.Windows.Forms.Button B5;
        private System.Windows.Forms.Button B4;
        private System.Windows.Forms.Button Bmnozenie;
        private System.Windows.Forms.Button B3;
        private System.Windows.Forms.Button B2;
        private System.Windows.Forms.Button B1;
        private System.Windows.Forms.Button Bdzielenie;
        private System.Windows.Forms.Button Bwynik;
        private System.Windows.Forms.Button B0;
    }
}

