namespace Not_system_new
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtBaslik = new TextBox();
            label2 = new Label();
            txtIcerik = new TextBox();
            label3 = new Label();
            comboBoxKategori = new ComboBox();
            btnEkle = new Button();
            label4 = new Label();
            txtAra = new TextBox();
            listBox1 = new ListBox();
            label5 = new Label();
            txtYeniKategori = new TextBox();
            btnKategoriEkle = new Button();
            btnSil = new Button();
            txtNotDetay = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 25);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 0;
            label1.Text = "Başlık:";
            // 
            // txtBaslik
            // 
            txtBaslik.Location = new Point(88, 22);
            txtBaslik.Name = "txtBaslik";
            txtBaslik.Size = new Size(125, 27);
            txtBaslik.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 74);
            label2.Name = "label2";
            label2.Size = new Size(47, 20);
            label2.TabIndex = 2;
            label2.Text = "İçerik:";
            // 
            // txtIcerik
            // 
            txtIcerik.Location = new Point(88, 76);
            txtIcerik.Multiline = true;
            txtIcerik.Name = "txtIcerik";
            txtIcerik.Size = new Size(213, 113);
            txtIcerik.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(5, 214);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 4;
            label3.Text = "Kategori:";
            label3.Click += label3_Click;
            // 
            // comboBoxKategori
            // 
            comboBoxKategori.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxKategori.FormattingEnabled = true;
            comboBoxKategori.Location = new Point(88, 206);
            comboBoxKategori.Name = "comboBoxKategori";
            comboBoxKategori.Size = new Size(151, 28);
            comboBoxKategori.TabIndex = 5;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(88, 240);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(160, 44);
            btnEkle.TabIndex = 6;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 293);
            label4.Name = "label4";
            label4.Size = new Size(35, 20);
            label4.TabIndex = 7;
            label4.Text = "Ara:";
            // 
            // txtAra
            // 
            txtAra.Location = new Point(88, 290);
            txtAra.Name = "txtAra";
            txtAra.Size = new Size(125, 27);
            txtAra.TabIndex = 8;
            txtAra.TextChanged += txtAra_TextChanged;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(88, 323);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(322, 104);
            listBox1.TabIndex = 9;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            listBox1.DoubleClick += listBox1_DoubleClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(304, 29);
            label5.Name = "label5";
            label5.Size = new Size(106, 20);
            label5.TabIndex = 10;
            label5.Text = "Yeni kategori : ";
            // 
            // txtYeniKategori
            // 
            txtYeniKategori.Location = new Point(416, 22);
            txtYeniKategori.Name = "txtYeniKategori";
            txtYeniKategori.Size = new Size(141, 27);
            txtYeniKategori.TabIndex = 11;
            // 
            // btnKategoriEkle
            // 
            btnKategoriEkle.Location = new Point(416, 70);
            btnKategoriEkle.Name = "btnKategoriEkle";
            btnKategoriEkle.Size = new Size(141, 38);
            btnKategoriEkle.TabIndex = 12;
            btnKategoriEkle.Text = "Kategori Ekle";
            btnKategoriEkle.UseVisualStyleBackColor = true;
            btnKategoriEkle.Click += btnKategoriEkle_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(207, 433);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(94, 66);
            btnSil.TabIndex = 13;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // txtNotDetay
            // 
            txtNotDetay.Location = new Point(462, 168);
            txtNotDetay.Multiline = true;
            txtNotDetay.Name = "txtNotDetay";
            txtNotDetay.ReadOnly = true;
            txtNotDetay.ScrollBars = ScrollBars.Vertical;
            txtNotDetay.Size = new Size(239, 331);
            txtNotDetay.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(746, 549);
            Controls.Add(txtNotDetay);
            Controls.Add(btnSil);
            Controls.Add(btnKategoriEkle);
            Controls.Add(txtYeniKategori);
            Controls.Add(label5);
            Controls.Add(listBox1);
            Controls.Add(txtAra);
            Controls.Add(label4);
            Controls.Add(btnEkle);
            Controls.Add(comboBoxKategori);
            Controls.Add(label3);
            Controls.Add(txtIcerik);
            Controls.Add(label2);
            Controls.Add(txtBaslik);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtBaslik;
        private Label label2;
        private TextBox txtIcerik;
        private Label label3;
        private ComboBox comboBoxKategori;
        private Button btnEkle;
        private Label label4;
        private TextBox txtAra;
        private ListBox listBox1;
        private Label label5;
        private TextBox txtYeniKategori;
        private Button btnKategoriEkle;
        private Button btnSil;
        private TextBox txtNotDetay;
    }
}
