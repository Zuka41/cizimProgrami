namespace cizim_prog
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.sekilPaneli = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.altigenPanel = new System.Windows.Forms.Panel();
            this.ucgenPanel = new System.Windows.Forms.Panel();
            this.dairePanel = new System.Windows.Forms.Panel();
            this.karePanel = new System.Windows.Forms.Panel();
            this.renkPaneli = new System.Windows.Forms.Panel();
            this.beyaz = new System.Windows.Forms.Panel();
            this.beyazButon = new System.Windows.Forms.Button();
            this.koyuKirmizi = new System.Windows.Forms.Panel();
            this.kKirmiziButon = new System.Windows.Forms.Button();
            this.sari = new System.Windows.Forms.Panel();
            this.sariButon = new System.Windows.Forms.Button();
            this.mor = new System.Windows.Forms.Panel();
            this.morButon = new System.Windows.Forms.Button();
            this.siyah = new System.Windows.Forms.Panel();
            this.siyahButon = new System.Windows.Forms.Button();
            this.turuncu = new System.Windows.Forms.Panel();
            this.turuncuButon = new System.Windows.Forms.Button();
            this.mavi = new System.Windows.Forms.Panel();
            this.maviButon = new System.Windows.Forms.Button();
            this.yesil = new System.Windows.Forms.Panel();
            this.yesilButon = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.kirmizi = new System.Windows.Forms.Panel();
            this.kirmiziButon = new System.Windows.Forms.Button();
            this.sekilIslemPaneli = new System.Windows.Forms.Panel();
            this.temizlePanel = new System.Windows.Forms.Panel();
            this.silPanel = new System.Windows.Forms.Panel();
            this.secPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.dosyaIslemPaneli = new System.Windows.Forms.Panel();
            this.kaydetPanel = new System.Windows.Forms.Panel();
            this.dosyadanAcPanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.sekilPaneli.SuspendLayout();
            this.renkPaneli.SuspendLayout();
            this.beyaz.SuspendLayout();
            this.koyuKirmizi.SuspendLayout();
            this.sari.SuspendLayout();
            this.mor.SuspendLayout();
            this.siyah.SuspendLayout();
            this.turuncu.SuspendLayout();
            this.mavi.SuspendLayout();
            this.yesil.SuspendLayout();
            this.kirmizi.SuspendLayout();
            this.sekilIslemPaneli.SuspendLayout();
            this.dosyaIslemPaneli.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(843, 579);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown_1);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // sekilPaneli
            // 
            this.sekilPaneli.Controls.Add(this.label1);
            this.sekilPaneli.Controls.Add(this.altigenPanel);
            this.sekilPaneli.Controls.Add(this.ucgenPanel);
            this.sekilPaneli.Controls.Add(this.dairePanel);
            this.sekilPaneli.Controls.Add(this.karePanel);
            this.sekilPaneli.Location = new System.Drawing.Point(848, 4);
            this.sekilPaneli.Name = "sekilPaneli";
            this.sekilPaneli.Size = new System.Drawing.Size(218, 188);
            this.sekilPaneli.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Şekil Seçimi";
            // 
            // altigenPanel
            // 
            this.altigenPanel.Location = new System.Drawing.Point(110, 104);
            this.altigenPanel.Name = "altigenPanel";
            this.altigenPanel.Size = new System.Drawing.Size(98, 71);
            this.altigenPanel.TabIndex = 3;
            this.altigenPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.altigenPanel_Paint);
            this.altigenPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.altigenPanel_MouseClick);
            // 
            // ucgenPanel
            // 
            this.ucgenPanel.Location = new System.Drawing.Point(6, 104);
            this.ucgenPanel.Name = "ucgenPanel";
            this.ucgenPanel.Size = new System.Drawing.Size(98, 71);
            this.ucgenPanel.TabIndex = 3;
            this.ucgenPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ucgenPanel_Paint);
            this.ucgenPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ucgenPanel_MouseClick);
            // 
            // dairePanel
            // 
            this.dairePanel.Location = new System.Drawing.Point(110, 27);
            this.dairePanel.Name = "dairePanel";
            this.dairePanel.Size = new System.Drawing.Size(98, 71);
            this.dairePanel.TabIndex = 3;
            this.dairePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.dairePanel_Paint);
            this.dairePanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dairePanel_MouseClick);
            // 
            // karePanel
            // 
            this.karePanel.Location = new System.Drawing.Point(6, 27);
            this.karePanel.Name = "karePanel";
            this.karePanel.Size = new System.Drawing.Size(98, 71);
            this.karePanel.TabIndex = 2;
            this.karePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.karePanel_Paint);
            this.karePanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.karePanel_MouseClick);
            // 
            // renkPaneli
            // 
            this.renkPaneli.Controls.Add(this.beyaz);
            this.renkPaneli.Controls.Add(this.koyuKirmizi);
            this.renkPaneli.Controls.Add(this.sari);
            this.renkPaneli.Controls.Add(this.mor);
            this.renkPaneli.Controls.Add(this.siyah);
            this.renkPaneli.Controls.Add(this.turuncu);
            this.renkPaneli.Controls.Add(this.mavi);
            this.renkPaneli.Controls.Add(this.yesil);
            this.renkPaneli.Controls.Add(this.label2);
            this.renkPaneli.Controls.Add(this.kirmizi);
            this.renkPaneli.Location = new System.Drawing.Point(848, 198);
            this.renkPaneli.Name = "renkPaneli";
            this.renkPaneli.Size = new System.Drawing.Size(218, 188);
            this.renkPaneli.TabIndex = 5;
            // 
            // beyaz
            // 
            this.beyaz.Controls.Add(this.beyazButon);
            this.beyaz.Location = new System.Drawing.Point(146, 135);
            this.beyaz.Name = "beyaz";
            this.beyaz.Size = new System.Drawing.Size(64, 50);
            this.beyaz.TabIndex = 3;
            // 
            // beyazButon
            // 
            this.beyazButon.BackColor = System.Drawing.Color.White;
            this.beyazButon.FlatAppearance.BorderSize = 0;
            this.beyazButon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.beyazButon.Location = new System.Drawing.Point(4, 4);
            this.beyazButon.Margin = new System.Windows.Forms.Padding(4, 2, 2, 2);
            this.beyazButon.Name = "beyazButon";
            this.beyazButon.Size = new System.Drawing.Size(55, 43);
            this.beyazButon.TabIndex = 17;
            this.beyazButon.UseVisualStyleBackColor = false;
            this.beyazButon.Click += new System.EventHandler(this.beyazButon_Click);
            // 
            // koyuKirmizi
            // 
            this.koyuKirmizi.Controls.Add(this.kKirmiziButon);
            this.koyuKirmizi.Location = new System.Drawing.Point(76, 135);
            this.koyuKirmizi.Name = "koyuKirmizi";
            this.koyuKirmizi.Size = new System.Drawing.Size(64, 50);
            this.koyuKirmizi.TabIndex = 3;
            // 
            // kKirmiziButon
            // 
            this.kKirmiziButon.BackColor = System.Drawing.Color.DarkRed;
            this.kKirmiziButon.FlatAppearance.BorderSize = 0;
            this.kKirmiziButon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kKirmiziButon.Location = new System.Drawing.Point(5, 4);
            this.kKirmiziButon.Margin = new System.Windows.Forms.Padding(4, 2, 2, 2);
            this.kKirmiziButon.Name = "kKirmiziButon";
            this.kKirmiziButon.Size = new System.Drawing.Size(55, 43);
            this.kKirmiziButon.TabIndex = 15;
            this.kKirmiziButon.UseVisualStyleBackColor = false;
            this.kKirmiziButon.Click += new System.EventHandler(this.kKirmiziButon_Click);
            // 
            // sari
            // 
            this.sari.Controls.Add(this.sariButon);
            this.sari.Location = new System.Drawing.Point(146, 79);
            this.sari.Name = "sari";
            this.sari.Size = new System.Drawing.Size(64, 50);
            this.sari.TabIndex = 3;
            // 
            // sariButon
            // 
            this.sariButon.BackColor = System.Drawing.Color.Yellow;
            this.sariButon.FlatAppearance.BorderSize = 0;
            this.sariButon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sariButon.Location = new System.Drawing.Point(4, 4);
            this.sariButon.Margin = new System.Windows.Forms.Padding(4, 2, 2, 2);
            this.sariButon.Name = "sariButon";
            this.sariButon.Size = new System.Drawing.Size(55, 43);
            this.sariButon.TabIndex = 16;
            this.sariButon.UseVisualStyleBackColor = false;
            this.sariButon.Click += new System.EventHandler(this.sariButon_Click);
            // 
            // mor
            // 
            this.mor.Controls.Add(this.morButon);
            this.mor.Location = new System.Drawing.Point(6, 135);
            this.mor.Name = "mor";
            this.mor.Size = new System.Drawing.Size(64, 50);
            this.mor.TabIndex = 3;
            // 
            // morButon
            // 
            this.morButon.BackColor = System.Drawing.Color.Purple;
            this.morButon.FlatAppearance.BorderSize = 0;
            this.morButon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.morButon.Location = new System.Drawing.Point(4, 4);
            this.morButon.Margin = new System.Windows.Forms.Padding(4, 2, 2, 2);
            this.morButon.Name = "morButon";
            this.morButon.Size = new System.Drawing.Size(55, 43);
            this.morButon.TabIndex = 13;
            this.morButon.UseVisualStyleBackColor = false;
            this.morButon.Click += new System.EventHandler(this.morButon_Click);
            // 
            // siyah
            // 
            this.siyah.Controls.Add(this.siyahButon);
            this.siyah.Location = new System.Drawing.Point(76, 79);
            this.siyah.Name = "siyah";
            this.siyah.Size = new System.Drawing.Size(64, 50);
            this.siyah.TabIndex = 3;
            // 
            // siyahButon
            // 
            this.siyahButon.BackColor = System.Drawing.Color.Black;
            this.siyahButon.FlatAppearance.BorderSize = 0;
            this.siyahButon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.siyahButon.Location = new System.Drawing.Point(4, 4);
            this.siyahButon.Margin = new System.Windows.Forms.Padding(4, 2, 2, 2);
            this.siyahButon.Name = "siyahButon";
            this.siyahButon.Size = new System.Drawing.Size(55, 43);
            this.siyahButon.TabIndex = 18;
            this.siyahButon.UseVisualStyleBackColor = false;
            this.siyahButon.Click += new System.EventHandler(this.siyahButon_Click);
            // 
            // turuncu
            // 
            this.turuncu.Controls.Add(this.turuncuButon);
            this.turuncu.Location = new System.Drawing.Point(6, 79);
            this.turuncu.Name = "turuncu";
            this.turuncu.Size = new System.Drawing.Size(64, 50);
            this.turuncu.TabIndex = 3;
            // 
            // turuncuButon
            // 
            this.turuncuButon.BackColor = System.Drawing.Color.Orange;
            this.turuncuButon.FlatAppearance.BorderSize = 0;
            this.turuncuButon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.turuncuButon.Location = new System.Drawing.Point(4, 4);
            this.turuncuButon.Margin = new System.Windows.Forms.Padding(4, 2, 2, 2);
            this.turuncuButon.Name = "turuncuButon";
            this.turuncuButon.Size = new System.Drawing.Size(55, 43);
            this.turuncuButon.TabIndex = 14;
            this.turuncuButon.UseVisualStyleBackColor = false;
            this.turuncuButon.Click += new System.EventHandler(this.turuncuButon_Click);
            // 
            // mavi
            // 
            this.mavi.Controls.Add(this.maviButon);
            this.mavi.Location = new System.Drawing.Point(76, 23);
            this.mavi.Name = "mavi";
            this.mavi.Size = new System.Drawing.Size(64, 50);
            this.mavi.TabIndex = 3;
            // 
            // maviButon
            // 
            this.maviButon.BackColor = System.Drawing.Color.Blue;
            this.maviButon.FlatAppearance.BorderSize = 0;
            this.maviButon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maviButon.Location = new System.Drawing.Point(3, 4);
            this.maviButon.Margin = new System.Windows.Forms.Padding(4, 2, 2, 2);
            this.maviButon.Name = "maviButon";
            this.maviButon.Size = new System.Drawing.Size(55, 43);
            this.maviButon.TabIndex = 11;
            this.maviButon.UseVisualStyleBackColor = false;
            this.maviButon.Click += new System.EventHandler(this.maviButon_Click);
            // 
            // yesil
            // 
            this.yesil.Controls.Add(this.yesilButon);
            this.yesil.Location = new System.Drawing.Point(146, 23);
            this.yesil.Name = "yesil";
            this.yesil.Size = new System.Drawing.Size(64, 50);
            this.yesil.TabIndex = 3;
            // 
            // yesilButon
            // 
            this.yesilButon.BackColor = System.Drawing.Color.Green;
            this.yesilButon.FlatAppearance.BorderSize = 0;
            this.yesilButon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yesilButon.Location = new System.Drawing.Point(4, 4);
            this.yesilButon.Margin = new System.Windows.Forms.Padding(4, 2, 2, 2);
            this.yesilButon.Name = "yesilButon";
            this.yesilButon.Size = new System.Drawing.Size(55, 43);
            this.yesilButon.TabIndex = 12;
            this.yesilButon.UseVisualStyleBackColor = false;
            this.yesilButon.Click += new System.EventHandler(this.yesilButon_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Renk Seçimi";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // kirmizi
            // 
            this.kirmizi.Controls.Add(this.kirmiziButon);
            this.kirmizi.Location = new System.Drawing.Point(6, 23);
            this.kirmizi.Name = "kirmizi";
            this.kirmizi.Size = new System.Drawing.Size(64, 50);
            this.kirmizi.TabIndex = 2;
            // 
            // kirmiziButon
            // 
            this.kirmiziButon.BackColor = System.Drawing.Color.Red;
            this.kirmiziButon.FlatAppearance.BorderSize = 0;
            this.kirmiziButon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kirmiziButon.Location = new System.Drawing.Point(4, 4);
            this.kirmiziButon.Margin = new System.Windows.Forms.Padding(4, 2, 2, 2);
            this.kirmiziButon.Name = "kirmiziButon";
            this.kirmiziButon.Size = new System.Drawing.Size(55, 43);
            this.kirmiziButon.TabIndex = 5;
            this.kirmiziButon.UseVisualStyleBackColor = false;
            this.kirmiziButon.Click += new System.EventHandler(this.kirmiziButon_Click);
            // 
            // sekilIslemPaneli
            // 
            this.sekilIslemPaneli.Controls.Add(this.temizlePanel);
            this.sekilIslemPaneli.Controls.Add(this.silPanel);
            this.sekilIslemPaneli.Controls.Add(this.secPanel);
            this.sekilIslemPaneli.Controls.Add(this.label3);
            this.sekilIslemPaneli.Location = new System.Drawing.Point(848, 389);
            this.sekilIslemPaneli.Name = "sekilIslemPaneli";
            this.sekilIslemPaneli.Size = new System.Drawing.Size(218, 102);
            this.sekilIslemPaneli.TabIndex = 5;
            // 
            // temizlePanel
            // 
            this.temizlePanel.AutoSize = true;
            this.temizlePanel.BackgroundImage = global::cizim_prog.Properties.Resources.kalem;
            this.temizlePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.temizlePanel.Location = new System.Drawing.Point(79, 21);
            this.temizlePanel.Name = "temizlePanel";
            this.temizlePanel.Size = new System.Drawing.Size(64, 67);
            this.temizlePanel.TabIndex = 4;
            this.temizlePanel.Click += new System.EventHandler(this.temizlePanel_Click);
            this.temizlePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.temizlePanel_Paint);
            this.temizlePanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.temizlePanel_MouseClick);
            // 
            // silPanel
            // 
            this.silPanel.BackgroundImage = global::cizim_prog.Properties.Resources.çöp_kovası;
            this.silPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.silPanel.Location = new System.Drawing.Point(149, 21);
            this.silPanel.Name = "silPanel";
            this.silPanel.Size = new System.Drawing.Size(64, 67);
            this.silPanel.TabIndex = 4;
            this.silPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.silPanel_MouseClick);
            // 
            // secPanel
            // 
            this.secPanel.BackgroundImage = global::cizim_prog.Properties.Resources.secim;
            this.secPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.secPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.secPanel.Location = new System.Drawing.Point(6, 21);
            this.secPanel.Name = "secPanel";
            this.secPanel.Size = new System.Drawing.Size(64, 67);
            this.secPanel.TabIndex = 4;
            this.secPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.secPanel_Paint);
            this.secPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.secPanel_MouseClick);
            this.secPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.secPanel_MouseDown);
            this.secPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.secPanel_MouseMove);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Şekil İşlemleri";
            // 
            // dosyaIslemPaneli
            // 
            this.dosyaIslemPaneli.Controls.Add(this.kaydetPanel);
            this.dosyaIslemPaneli.Controls.Add(this.dosyadanAcPanel);
            this.dosyaIslemPaneli.Controls.Add(this.label4);
            this.dosyaIslemPaneli.Location = new System.Drawing.Point(848, 483);
            this.dosyaIslemPaneli.Name = "dosyaIslemPaneli";
            this.dosyaIslemPaneli.Size = new System.Drawing.Size(218, 96);
            this.dosyaIslemPaneli.TabIndex = 6;
            // 
            // kaydetPanel
            // 
            this.kaydetPanel.BackgroundImage = global::cizim_prog.Properties.Resources.kaydet;
            this.kaydetPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.kaydetPanel.Location = new System.Drawing.Point(131, 27);
            this.kaydetPanel.Name = "kaydetPanel";
            this.kaydetPanel.Size = new System.Drawing.Size(64, 63);
            this.kaydetPanel.TabIndex = 5;
            this.kaydetPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.kaydetPanel_MouseClick);
            // 
            // dosyadanAcPanel
            // 
            this.dosyadanAcPanel.BackgroundImage = global::cizim_prog.Properties.Resources.dosya_ac;
            this.dosyadanAcPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.dosyadanAcPanel.Location = new System.Drawing.Point(16, 27);
            this.dosyadanAcPanel.Name = "dosyadanAcPanel";
            this.dosyadanAcPanel.Size = new System.Drawing.Size(64, 63);
            this.dosyadanAcPanel.TabIndex = 5;
            this.dosyadanAcPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.dosyadanAcPanel_Paint);
            this.dosyadanAcPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dosyadanAcPanel_MouseClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Dosya İşlemleri";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 585);
            this.Controls.Add(this.dosyaIslemPaneli);
            this.Controls.Add(this.sekilIslemPaneli);
            this.Controls.Add(this.renkPaneli);
            this.Controls.Add(this.sekilPaneli);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.sekilPaneli.ResumeLayout(false);
            this.sekilPaneli.PerformLayout();
            this.renkPaneli.ResumeLayout(false);
            this.renkPaneli.PerformLayout();
            this.beyaz.ResumeLayout(false);
            this.koyuKirmizi.ResumeLayout(false);
            this.sari.ResumeLayout(false);
            this.mor.ResumeLayout(false);
            this.siyah.ResumeLayout(false);
            this.turuncu.ResumeLayout(false);
            this.mavi.ResumeLayout(false);
            this.yesil.ResumeLayout(false);
            this.kirmizi.ResumeLayout(false);
            this.sekilIslemPaneli.ResumeLayout(false);
            this.sekilIslemPaneli.PerformLayout();
            this.dosyaIslemPaneli.ResumeLayout(false);
            this.dosyaIslemPaneli.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel sekilPaneli;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel altigenPanel;
        private System.Windows.Forms.Panel ucgenPanel;
        private System.Windows.Forms.Panel dairePanel;
        private System.Windows.Forms.Panel karePanel;
        private System.Windows.Forms.Panel renkPaneli;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel kirmizi;
        private System.Windows.Forms.Panel beyaz;
        private System.Windows.Forms.Panel koyuKirmizi;
        private System.Windows.Forms.Panel sari;
        private System.Windows.Forms.Panel mor;
        private System.Windows.Forms.Panel siyah;
        private System.Windows.Forms.Panel turuncu;
        private System.Windows.Forms.Panel mavi;
        private System.Windows.Forms.Panel yesil;
        private System.Windows.Forms.Panel sekilIslemPaneli;
        private System.Windows.Forms.Panel temizlePanel;
        private System.Windows.Forms.Panel silPanel;
        private System.Windows.Forms.Panel secPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel dosyaIslemPaneli;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel kaydetPanel;
        private System.Windows.Forms.Panel dosyadanAcPanel;
        private System.Windows.Forms.Button maviButon;
        private System.Windows.Forms.Button yesilButon;
        private System.Windows.Forms.Button morButon;
        private System.Windows.Forms.Button turuncuButon;
        private System.Windows.Forms.Button kKirmiziButon;
        private System.Windows.Forms.Button siyahButon;
        private System.Windows.Forms.Button sariButon;
        private System.Windows.Forms.Button beyazButon;
        private System.Windows.Forms.Button kirmiziButon;
    }
}

