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
            txt_baslik = new TextBox();
            txt_icerik = new TextBox();
            Cmb_kategori = new ComboBox();
            listBox1 = new ListBox();
            button1 = new Button();
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
            // txt_baslik
            // 
            txt_baslik.Location = new Point(91, 20);
            txt_baslik.Name = "txt_baslik";
            txt_baslik.Size = new Size(125, 27);
            txt_baslik.TabIndex = 1;
            // 
            // txt_icerik
            // 
            txt_icerik.Location = new Point(91, 115);
            txt_icerik.Multiline = true;
            txt_icerik.Name = "txt_icerik";
            txt_icerik.Size = new Size(125, 34);
            txt_icerik.TabIndex = 2;
            // 
            // Cmb_kategori
            // 
            Cmb_kategori.FormattingEnabled = true;
            Cmb_kategori.Location = new Point(91, 189);
            Cmb_kategori.Name = "Cmb_kategori";
            Cmb_kategori.Size = new Size(125, 28);
            Cmb_kategori.TabIndex = 3;
            Cmb_kategori.SelectedIndexChanged += txt_kategori_SelectedIndexChanged;
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
            // button1
            // 
            button1.Location = new Point(91, 250);
            button1.Name = "button1";
            button1.Size = new Size(125, 44);
            button1.TabIndex = 5;
            button1.Text = "Ekle";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(758, 450);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Controls.Add(Cmb_kategori);
            Controls.Add(txt_icerik);
            Controls.Add(txt_baslik);
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
        private TextBox txt_baslik;
        private TextBox txt_icerik;
        private ComboBox Cmb_kategori;
        private ListBox listBox1;
        private Button button1;
    }
}
