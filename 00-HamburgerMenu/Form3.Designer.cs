
namespace _00_HamburgerMenu
{
    partial class Form3
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
            this.grpEkstraMalzEkle = new System.Windows.Forms.GroupBox();
            this.txtEkstraAdi = new System.Windows.Forms.TextBox();
            this.nudEkstraFiyati = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEkstraEkle = new System.Windows.Forms.Button();
            this.grpEkstraMalzEkle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEkstraFiyati)).BeginInit();
            this.SuspendLayout();
            // 
            // grpEkstraMalzEkle
            // 
            this.grpEkstraMalzEkle.Controls.Add(this.txtEkstraAdi);
            this.grpEkstraMalzEkle.Controls.Add(this.nudEkstraFiyati);
            this.grpEkstraMalzEkle.Controls.Add(this.label2);
            this.grpEkstraMalzEkle.Controls.Add(this.label1);
            this.grpEkstraMalzEkle.Controls.Add(this.btnEkstraEkle);
            this.grpEkstraMalzEkle.Location = new System.Drawing.Point(12, 12);
            this.grpEkstraMalzEkle.Name = "grpEkstraMalzEkle";
            this.grpEkstraMalzEkle.Size = new System.Drawing.Size(285, 167);
            this.grpEkstraMalzEkle.TabIndex = 4;
            this.grpEkstraMalzEkle.TabStop = false;
            this.grpEkstraMalzEkle.Text = "EKSTRA MALZEME BİLGİLERİ";
            // 
            // txtEkstraAdi
            // 
            this.txtEkstraAdi.Location = new System.Drawing.Point(144, 37);
            this.txtEkstraAdi.Name = "txtEkstraAdi";
            this.txtEkstraAdi.Size = new System.Drawing.Size(135, 24);
            this.txtEkstraAdi.TabIndex = 4;
            // 
            // nudEkstraFiyati
            // 
            this.nudEkstraFiyati.DecimalPlaces = 2;
            this.nudEkstraFiyati.Increment = new decimal(new int[] {
            50,
            0,
            0,
            131072});
            this.nudEkstraFiyati.Location = new System.Drawing.Point(144, 66);
            this.nudEkstraFiyati.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudEkstraFiyati.Name = "nudEkstraFiyati";
            this.nudEkstraFiyati.Size = new System.Drawing.Size(135, 24);
            this.nudEkstraFiyati.TabIndex = 3;
            this.nudEkstraFiyati.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fiyatı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ekstra Malzeme Adı";
            // 
            // btnEkstraEkle
            // 
            this.btnEkstraEkle.Location = new System.Drawing.Point(103, 96);
            this.btnEkstraEkle.Name = "btnEkstraEkle";
            this.btnEkstraEkle.Size = new System.Drawing.Size(176, 59);
            this.btnEkstraEkle.TabIndex = 0;
            this.btnEkstraEkle.Text = "EKSTRA MALZEME EKLE";
            this.btnEkstraEkle.UseVisualStyleBackColor = true;
            this.btnEkstraEkle.Click += new System.EventHandler(this.btnEkstraEkle_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 189);
            this.Controls.Add(this.grpEkstraMalzEkle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form3";
            this.Text = "Form3";
            this.grpEkstraMalzEkle.ResumeLayout(false);
            this.grpEkstraMalzEkle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEkstraFiyati)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpEkstraMalzEkle;
        private System.Windows.Forms.TextBox txtEkstraAdi;
        private System.Windows.Forms.NumericUpDown nudEkstraFiyati;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEkstraEkle;
    }
}