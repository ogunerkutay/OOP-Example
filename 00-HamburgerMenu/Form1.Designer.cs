﻿
namespace _00_HamburgerMenu
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnSiparisiTamamla = new System.Windows.Forms.Button();
            this.lblToplamTutar = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbxSiparisler = new System.Windows.Forms.ListBox();
            this.btnSiparisiEkle = new System.Windows.Forms.Button();
            this.nudAdet = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.flpEkstraMalzemeler = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.grpBoyutlar = new System.Windows.Forms.GroupBox();
            this.rbBuyuk = new System.Windows.Forms.RadioButton();
            this.rbOrta = new System.Windows.Forms.RadioButton();
            this.rbKucuk = new System.Windows.Forms.RadioButton();
            this.cbMenuler = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdet)).BeginInit();
            this.grpBoyutlar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSiparisiTamamla
            // 
            this.btnSiparisiTamamla.Location = new System.Drawing.Point(580, 512);
            this.btnSiparisiTamamla.Name = "btnSiparisiTamamla";
            this.btnSiparisiTamamla.Size = new System.Drawing.Size(231, 84);
            this.btnSiparisiTamamla.TabIndex = 51;
            this.btnSiparisiTamamla.Text = "SİPARİŞİ TAMAMLA";
            this.btnSiparisiTamamla.UseVisualStyleBackColor = true;
            this.btnSiparisiTamamla.Click += new System.EventHandler(this.btnSiparisiTamamla_Click);
            // 
            // lblToplamTutar
            // 
            this.lblToplamTutar.AutoSize = true;
            this.lblToplamTutar.ForeColor = System.Drawing.Color.Red;
            this.lblToplamTutar.Location = new System.Drawing.Point(401, 523);
            this.lblToplamTutar.Name = "lblToplamTutar";
            this.lblToplamTutar.Size = new System.Drawing.Size(16, 18);
            this.lblToplamTutar.TabIndex = 50;
            this.lblToplamTutar.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(279, 523);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 18);
            this.label4.TabIndex = 49;
            this.label4.Text = "TOPLAM TUTAR:";
            // 
            // lbxSiparisler
            // 
            this.lbxSiparisler.FormattingEnabled = true;
            this.lbxSiparisler.HorizontalScrollbar = true;
            this.lbxSiparisler.ItemHeight = 18;
            this.lbxSiparisler.Location = new System.Drawing.Point(282, 12);
            this.lbxSiparisler.Name = "lbxSiparisler";
            this.lbxSiparisler.Size = new System.Drawing.Size(529, 490);
            this.lbxSiparisler.TabIndex = 48;
            // 
            // btnSiparisiEkle
            // 
            this.btnSiparisiEkle.Location = new System.Drawing.Point(12, 523);
            this.btnSiparisiEkle.Name = "btnSiparisiEkle";
            this.btnSiparisiEkle.Size = new System.Drawing.Size(249, 73);
            this.btnSiparisiEkle.TabIndex = 47;
            this.btnSiparisiEkle.Text = "SİPARİŞ EKLE";
            this.btnSiparisiEkle.UseVisualStyleBackColor = true;
            this.btnSiparisiEkle.Click += new System.EventHandler(this.btnSiparisiEkle_Click);
            // 
            // nudAdet
            // 
            this.nudAdet.Location = new System.Drawing.Point(88, 491);
            this.nudAdet.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAdet.Name = "nudAdet";
            this.nudAdet.Size = new System.Drawing.Size(173, 24);
            this.nudAdet.TabIndex = 46;
            this.nudAdet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudAdet.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 497);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 18);
            this.label3.TabIndex = 45;
            this.label3.Text = "ADET";
            // 
            // flpEkstraMalzemeler
            // 
            this.flpEkstraMalzemeler.Location = new System.Drawing.Point(12, 291);
            this.flpEkstraMalzemeler.Name = "flpEkstraMalzemeler";
            this.flpEkstraMalzemeler.Size = new System.Drawing.Size(249, 192);
            this.flpEkstraMalzemeler.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 18);
            this.label2.TabIndex = 43;
            this.label2.Text = "MALZEME SEÇİN";
            // 
            // grpBoyutlar
            // 
            this.grpBoyutlar.Controls.Add(this.rbBuyuk);
            this.grpBoyutlar.Controls.Add(this.rbOrta);
            this.grpBoyutlar.Controls.Add(this.rbKucuk);
            this.grpBoyutlar.Location = new System.Drawing.Point(12, 206);
            this.grpBoyutlar.Name = "grpBoyutlar";
            this.grpBoyutlar.Size = new System.Drawing.Size(249, 61);
            this.grpBoyutlar.TabIndex = 42;
            this.grpBoyutlar.TabStop = false;
            this.grpBoyutlar.Text = "BOYUT SEÇİNİZ";
            // 
            // rbBuyuk
            // 
            this.rbBuyuk.AutoSize = true;
            this.rbBuyuk.Location = new System.Drawing.Point(176, 26);
            this.rbBuyuk.Name = "rbBuyuk";
            this.rbBuyuk.Size = new System.Drawing.Size(67, 22);
            this.rbBuyuk.TabIndex = 2;
            this.rbBuyuk.TabStop = true;
            this.rbBuyuk.Text = "Büyük";
            this.rbBuyuk.UseVisualStyleBackColor = true;
            // 
            // rbOrta
            // 
            this.rbOrta.AutoSize = true;
            this.rbOrta.Location = new System.Drawing.Point(95, 26);
            this.rbOrta.Name = "rbOrta";
            this.rbOrta.Size = new System.Drawing.Size(55, 22);
            this.rbOrta.TabIndex = 1;
            this.rbOrta.TabStop = true;
            this.rbOrta.Text = "Orta";
            this.rbOrta.UseVisualStyleBackColor = true;
            // 
            // rbKucuk
            // 
            this.rbKucuk.AutoSize = true;
            this.rbKucuk.Location = new System.Drawing.Point(7, 26);
            this.rbKucuk.Name = "rbKucuk";
            this.rbKucuk.Size = new System.Drawing.Size(68, 22);
            this.rbKucuk.TabIndex = 0;
            this.rbKucuk.TabStop = true;
            this.rbKucuk.Text = "Küçük";
            this.rbKucuk.UseVisualStyleBackColor = true;
            // 
            // cbMenuler
            // 
            this.cbMenuler.FormattingEnabled = true;
            this.cbMenuler.Location = new System.Drawing.Point(12, 174);
            this.cbMenuler.Name = "cbMenuler";
            this.cbMenuler.Size = new System.Drawing.Size(249, 26);
            this.cbMenuler.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 18);
            this.label1.TabIndex = 40;
            this.label1.Text = "MENÜ SEÇİN";
            // 
            // pbxLogo
            // 
            this.pbxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbxLogo.Image")));
            this.pbxLogo.Location = new System.Drawing.Point(12, 12);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(249, 138);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxLogo.TabIndex = 39;
            this.pbxLogo.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 604);
            this.Controls.Add(this.btnSiparisiTamamla);
            this.Controls.Add(this.lblToplamTutar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbxSiparisler);
            this.Controls.Add(this.btnSiparisiEkle);
            this.Controls.Add(this.nudAdet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.flpEkstraMalzemeler);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grpBoyutlar);
            this.Controls.Add(this.cbMenuler);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbxLogo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudAdet)).EndInit();
            this.grpBoyutlar.ResumeLayout(false);
            this.grpBoyutlar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSiparisiTamamla;
        private System.Windows.Forms.Label lblToplamTutar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lbxSiparisler;
        private System.Windows.Forms.Button btnSiparisiEkle;
        private System.Windows.Forms.NumericUpDown nudAdet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel flpEkstraMalzemeler;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpBoyutlar;
        private System.Windows.Forms.RadioButton rbBuyuk;
        private System.Windows.Forms.RadioButton rbOrta;
        private System.Windows.Forms.RadioButton rbKucuk;
        private System.Windows.Forms.ComboBox cbMenuler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbxLogo;
    }
}