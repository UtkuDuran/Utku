namespace KutuphaneUygulamasi
{
    partial class AnaEkran
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kitaplarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kitapEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.üyelerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ekleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.borçlularToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taleplerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kitapTalepleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dergiTalepleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kitaplar = new System.Windows.Forms.ListBox();
            this.Duzenle = new System.Windows.Forms.Button();
            this.Sil = new System.Windows.Forms.Button();
            this.yazarlar = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Panel2 = new System.Windows.Forms.GroupBox();
            this.SecimKaldir = new System.Windows.Forms.Button();
            this.TumunuSil = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.Panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kitaplarToolStripMenuItem,
            this.üyelerToolStripMenuItem,
            this.taleplerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(658, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kitaplarToolStripMenuItem
            // 
            this.kitaplarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kitapEkleToolStripMenuItem});
            this.kitaplarToolStripMenuItem.Name = "kitaplarToolStripMenuItem";
            this.kitaplarToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.kitaplarToolStripMenuItem.Text = "Kitaplar";
            // 
            // kitapEkleToolStripMenuItem
            // 
            this.kitapEkleToolStripMenuItem.Name = "kitapEkleToolStripMenuItem";
            this.kitapEkleToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.kitapEkleToolStripMenuItem.Text = "Kitap Ekle";
            this.kitapEkleToolStripMenuItem.Click += new System.EventHandler(this.ekleToolStripMenuItem_Click);
            // 
            // üyelerToolStripMenuItem
            // 
            this.üyelerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listeleToolStripMenuItem,
            this.ekleToolStripMenuItem1,
            this.borçlularToolStripMenuItem});
            this.üyelerToolStripMenuItem.Name = "üyelerToolStripMenuItem";
            this.üyelerToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.üyelerToolStripMenuItem.Text = "Üyeler";
            // 
            // listeleToolStripMenuItem
            // 
            this.listeleToolStripMenuItem.Name = "listeleToolStripMenuItem";
            this.listeleToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.listeleToolStripMenuItem.Text = "Listele";
            // 
            // ekleToolStripMenuItem1
            // 
            this.ekleToolStripMenuItem1.Name = "ekleToolStripMenuItem1";
            this.ekleToolStripMenuItem1.Size = new System.Drawing.Size(121, 22);
            this.ekleToolStripMenuItem1.Text = "Ekle";
            // 
            // borçlularToolStripMenuItem
            // 
            this.borçlularToolStripMenuItem.Name = "borçlularToolStripMenuItem";
            this.borçlularToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.borçlularToolStripMenuItem.Text = "Borçlular";
            // 
            // taleplerToolStripMenuItem
            // 
            this.taleplerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kitapTalepleriToolStripMenuItem,
            this.dergiTalepleriToolStripMenuItem});
            this.taleplerToolStripMenuItem.Name = "taleplerToolStripMenuItem";
            this.taleplerToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.taleplerToolStripMenuItem.Text = "Talepler";
            // 
            // kitapTalepleriToolStripMenuItem
            // 
            this.kitapTalepleriToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.kitapTalepleriToolStripMenuItem.Name = "kitapTalepleriToolStripMenuItem";
            this.kitapTalepleriToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.kitapTalepleriToolStripMenuItem.Text = "Kitap Talepleri";
            // 
            // dergiTalepleriToolStripMenuItem
            // 
            this.dergiTalepleriToolStripMenuItem.Name = "dergiTalepleriToolStripMenuItem";
            this.dergiTalepleriToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.dergiTalepleriToolStripMenuItem.Text = "Dergi Talepleri";
            // 
            // kitaplar
            // 
            this.kitaplar.BackColor = System.Drawing.Color.Honeydew;
            this.kitaplar.Font = new System.Drawing.Font("Yu Gothic", 12F);
            this.kitaplar.FormattingEnabled = true;
            this.kitaplar.ItemHeight = 21;
            this.kitaplar.Items.AddRange(new object[] {
            "Tutunamayanlar",
            "Şeker Portakalı",
            "Görünmez Kentler",
            "Aşk",
            "Yeraltından Notlar",
            "Erken Kaybedenler",
            "Büyülü Fener",
            "Ölümsüzlük ",
            "Parfümün Dans",
            "Başarının Anatomisi",
            "Yeni Hayat",
            "Git Kendini Çok Sevdirmeden",
            "Bu Köşedeki Adam",
            "Sonsuzluk İçin Yedi Gün",
            "Hep Yarın",
            "Masumiyet Müzesi",
            "Dehanın Gölgesinde"});
            this.kitaplar.Location = new System.Drawing.Point(236, 31);
            this.kitaplar.Name = "kitaplar";
            this.kitaplar.Size = new System.Drawing.Size(255, 277);
            this.kitaplar.TabIndex = 1;
            this.kitaplar.SelectedIndexChanged += new System.EventHandler(this.listBYazarAdi_SelectedIndexChanged);
            // 
            // Duzenle
            // 
            this.Duzenle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Duzenle.Enabled = false;
            this.Duzenle.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Duzenle.ForeColor = System.Drawing.Color.Black;
            this.Duzenle.Location = new System.Drawing.Point(22, 65);
            this.Duzenle.Name = "Duzenle";
            this.Duzenle.Size = new System.Drawing.Size(88, 28);
            this.Duzenle.TabIndex = 1;
            this.Duzenle.Text = "Düzenle";
            this.Duzenle.UseVisualStyleBackColor = false;
            this.Duzenle.Click += new System.EventHandler(this.button1_Click);
            // 
            // Sil
            // 
            this.Sil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Sil.Enabled = false;
            this.Sil.Font = new System.Drawing.Font("Yu Gothic", 10.2F);
            this.Sil.ForeColor = System.Drawing.Color.Black;
            this.Sil.Location = new System.Drawing.Point(22, 247);
            this.Sil.Name = "Sil";
            this.Sil.Size = new System.Drawing.Size(88, 28);
            this.Sil.TabIndex = 2;
            this.Sil.Text = "Sil";
            this.Sil.UseVisualStyleBackColor = false;
            this.Sil.Click += new System.EventHandler(this.button2_Click);
            // 
            // yazarlar
            // 
            this.yazarlar.BackColor = System.Drawing.Color.Honeydew;
            this.yazarlar.Font = new System.Drawing.Font("Yu Gothic", 12F);
            this.yazarlar.FormattingEnabled = true;
            this.yazarlar.ItemHeight = 21;
            this.yazarlar.Items.AddRange(new object[] {
            "Oğuz Atay",
            "Vasconcelos",
            "Italo Calvino",
            "Elif Şafak",
            "Dostoyevski",
            "Emrah Serbes",
            "Ingmar Bergman",
            "Milan Kundera",
            "Tom Robbins",
            "Jose Mourinho",
            "Orhan Pamuk",
            "Tuna Kiremitçi",
            "Hrant Dink",
            "Marc Levy",
            "Cahit Uçuk",
            "Orhan Pamuk",
            "Maria Publig"});
            this.yazarlar.Location = new System.Drawing.Point(34, 31);
            this.yazarlar.Name = "yazarlar";
            this.yazarlar.Size = new System.Drawing.Size(197, 277);
            this.yazarlar.TabIndex = 4;
            this.yazarlar.SelectedIndexChanged += new System.EventHandler(this.listBKitapAdi_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(97, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Yazar Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic", 12F);
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(328, 6);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Kitap Adı";
            // 
            // Panel2
            // 
            this.Panel2.BackColor = System.Drawing.Color.SlateGray;
            this.Panel2.Controls.Add(this.SecimKaldir);
            this.Panel2.Controls.Add(this.TumunuSil);
            this.Panel2.Controls.Add(this.Sil);
            this.Panel2.Controls.Add(this.Duzenle);
            this.Panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Panel2.Location = new System.Drawing.Point(519, 25);
            this.Panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Panel2.Name = "Panel2";
            this.Panel2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Panel2.Size = new System.Drawing.Size(128, 318);
            this.Panel2.TabIndex = 7;
            this.Panel2.TabStop = false;
            this.Panel2.Text = "İşlemler";
            // 
            // SecimKaldir
            // 
            this.SecimKaldir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SecimKaldir.Enabled = false;
            this.SecimKaldir.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SecimKaldir.ForeColor = System.Drawing.Color.Black;
            this.SecimKaldir.Location = new System.Drawing.Point(22, 31);
            this.SecimKaldir.Name = "SecimKaldir";
            this.SecimKaldir.Size = new System.Drawing.Size(88, 28);
            this.SecimKaldir.TabIndex = 3;
            this.SecimKaldir.Text = "Seçimi Kaldır";
            this.SecimKaldir.UseVisualStyleBackColor = false;
            this.SecimKaldir.Click += new System.EventHandler(this.btnSecimKaldir_Click);
            // 
            // TumunuSil
            // 
            this.TumunuSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.TumunuSil.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TumunuSil.ForeColor = System.Drawing.Color.Black;
            this.TumunuSil.Location = new System.Drawing.Point(22, 280);
            this.TumunuSil.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TumunuSil.Name = "TumunuSil";
            this.TumunuSil.Size = new System.Drawing.Size(88, 28);
            this.TumunuSil.TabIndex = 4;
            this.TumunuSil.TabStop = false;
            this.TumunuSil.Text = "Tümünü Sil";
            this.TumunuSil.UseVisualStyleBackColor = false;
            this.TumunuSil.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateGray;
            this.panel1.Controls.Add(this.yazarlar);
            this.panel1.Controls.Add(this.kitaplar);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(9, 25);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(506, 318);
            this.panel1.TabIndex = 8;
            // 
            // AnaEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(658, 362);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.Black;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(674, 401);
            this.MinimumSize = new System.Drawing.Size(674, 401);
            this.Name = "AnaEkran";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kütüphane Uygulaması - Ana Sayfa";
            this.Load += new System.EventHandler(this.AnaEkran_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.Panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kitaplarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kitapEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem üyelerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ekleToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem borçlularToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem taleplerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kitapTalepleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dergiTalepleriToolStripMenuItem;
        private System.Windows.Forms.ListBox kitaplar;
        private System.Windows.Forms.Button Duzenle;
        private System.Windows.Forms.Button Sil;
        private System.Windows.Forms.ListBox yazarlar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox Panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button TumunuSil;
        private System.Windows.Forms.Button SecimKaldir;
    }
}