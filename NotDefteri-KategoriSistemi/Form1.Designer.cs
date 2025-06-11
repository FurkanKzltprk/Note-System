namespace NotDefteri_KategoriSistemi
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtBaslik = new TextBox();
            txtIcerik = new TextBox();
            comboBoxKategori = new ComboBox();
            listBox1 = new ListBox();
            btnEkle = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 23);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 0;
            label1.Text = "Başlık :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 125);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 0;
            label2.Text = "İçerik :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 192);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 0;
            label3.Text = "Kategori :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 365);
            label4.Name = "label4";
            label4.Size = new Size(58, 20);
            label4.TabIndex = 0;
            label4.Text = "Notlar :";
            // 
            // txtBaslik
            // 
            txtBaslik.Location = new Point(91, 20);
            txtBaslik.Name = "txtBaslik";
            txtBaslik.Size = new Size(125, 27);
            txtBaslik.TabIndex = 1;
            // 
            // txtIcerik
            // 
            txtIcerik.Location = new Point(91, 115);
            txtIcerik.Multiline = true;
            txtIcerik.Name = "txtIcerik";
            txtIcerik.Size = new Size(125, 34);
            txtIcerik.TabIndex = 2;
            // 
            // comboBoxKategori
            // 
            comboBoxKategori.FormattingEnabled = true;
            comboBoxKategori.Location = new Point(91, 189);
            comboBoxKategori.Name = "comboBoxKategori";
            comboBoxKategori.Size = new Size(125, 28);
            comboBoxKategori.TabIndex = 3;
            comboBoxKategori.SelectedIndexChanged += txt_kategori_SelectedIndexChanged;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(92, 331);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(150, 104);
            listBox1.TabIndex = 4;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(91, 250);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(125, 44);
            btnEkle.TabIndex = 5;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(758, 450);
            Controls.Add(btnEkle);
            Controls.Add(listBox1);
            Controls.Add(comboBoxKategori);
            Controls.Add(txtIcerik);
            Controls.Add(txtBaslik);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtBaslik;
        private TextBox txtIcerik;
        private ComboBox comboBoxKategori;
        private ListBox listBox1;
        private Button btnEkle;
    }
}
