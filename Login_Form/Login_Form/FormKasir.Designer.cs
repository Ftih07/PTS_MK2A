namespace Login_Form
{
    partial class FormKasir
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtHargaMinuman = new System.Windows.Forms.TextBox();
            this.cbMinuman = new System.Windows.Forms.ComboBox();
            this.txtHargaMakanan = new System.Windows.Forms.TextBox();
            this.cbMakanan = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtSatuanMinuman = new System.Windows.Forms.NumericUpDown();
            this.txtSatuanMakanan = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNamaKasir = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtBayar = new System.Windows.Forms.TextBox();
            this.txtKembali = new System.Windows.Forms.TextBox();
            this.btClear = new System.Windows.Forms.Button();
            this.btProses = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtSubTotalMinuman = new System.Windows.Forms.TextBox();
            this.txtSubTotalMakanan = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSatuanMinuman)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSatuanMakanan)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtHargaMinuman);
            this.groupBox1.Controls.Add(this.cbMinuman);
            this.groupBox1.Controls.Add(this.txtHargaMakanan);
            this.groupBox1.Controls.Add(this.cbMakanan);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(9, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesan";
            // 
            // txtHargaMinuman
            // 
            this.txtHargaMinuman.Location = new System.Drawing.Point(204, 66);
            this.txtHargaMinuman.Name = "txtHargaMinuman";
            this.txtHargaMinuman.ReadOnly = true;
            this.txtHargaMinuman.Size = new System.Drawing.Size(100, 22);
            this.txtHargaMinuman.TabIndex = 9;
            this.txtHargaMinuman.Text = "0";
            // 
            // cbMinuman
            // 
            this.cbMinuman.FormattingEnabled = true;
            this.cbMinuman.Location = new System.Drawing.Point(73, 66);
            this.cbMinuman.Name = "cbMinuman";
            this.cbMinuman.Size = new System.Drawing.Size(121, 24);
            this.cbMinuman.TabIndex = 9;
            this.cbMinuman.SelectedIndexChanged += new System.EventHandler(this.cbMinuman_SelectedIndexChanged);
            // 
            // txtHargaMakanan
            // 
            this.txtHargaMakanan.Location = new System.Drawing.Point(204, 35);
            this.txtHargaMakanan.Name = "txtHargaMakanan";
            this.txtHargaMakanan.ReadOnly = true;
            this.txtHargaMakanan.Size = new System.Drawing.Size(100, 22);
            this.txtHargaMakanan.TabIndex = 8;
            this.txtHargaMakanan.Text = "0";
            this.txtHargaMakanan.TextChanged += new System.EventHandler(this.txtHargaMakanan_TextChanged);
            // 
            // cbMakanan
            // 
            this.cbMakanan.FormattingEnabled = true;
            this.cbMakanan.Location = new System.Drawing.Point(73, 35);
            this.cbMakanan.Name = "cbMakanan";
            this.cbMakanan.Size = new System.Drawing.Size(121, 24);
            this.cbMakanan.TabIndex = 8;
            this.cbMakanan.SelectedIndexChanged += new System.EventHandler(this.cbMakanan_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Makanan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Minuman";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtSatuanMinuman);
            this.groupBox2.Controls.Add(this.txtSatuanMakanan);
            this.groupBox2.Location = new System.Drawing.Point(338, 48);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(91, 100);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Satuan";
            // 
            // txtSatuanMinuman
            // 
            this.txtSatuanMinuman.Location = new System.Drawing.Point(6, 64);
            this.txtSatuanMinuman.Name = "txtSatuanMinuman";
            this.txtSatuanMinuman.Size = new System.Drawing.Size(74, 22);
            this.txtSatuanMinuman.TabIndex = 1;
            this.txtSatuanMinuman.ValueChanged += new System.EventHandler(this.txtSatuanMinuman_ValueChanged);
            // 
            // txtSatuanMakanan
            // 
            this.txtSatuanMakanan.Location = new System.Drawing.Point(6, 35);
            this.txtSatuanMakanan.Name = "txtSatuanMakanan";
            this.txtSatuanMakanan.Size = new System.Drawing.Size(74, 22);
            this.txtSatuanMakanan.TabIndex = 0;
            this.txtSatuanMakanan.ValueChanged += new System.EventHandler(this.txtSatuanMakanan_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label1.Location = new System.Drawing.Point(0, -9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 54);
            this.label1.TabIndex = 1;
            this.label1.Text = "Warung Rahayu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nama Kasir";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(487, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "TOTAL";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(487, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "BAYAR";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(487, 221);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "KEMBALI";
            // 
            // txtNamaKasir
            // 
            this.txtNamaKasir.Location = new System.Drawing.Point(14, 183);
            this.txtNamaKasir.Name = "txtNamaKasir";
            this.txtNamaKasir.Size = new System.Drawing.Size(100, 22);
            this.txtNamaKasir.TabIndex = 10;
            this.txtNamaKasir.TextChanged += new System.EventHandler(this.txtNamaKasir_TextChanged);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(562, 158);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(100, 22);
            this.txtTotal.TabIndex = 10;
            this.txtTotal.Text = "0";
            this.txtTotal.TextChanged += new System.EventHandler(this.txtTotal_TextChanged);
            // 
            // txtBayar
            // 
            this.txtBayar.Location = new System.Drawing.Point(562, 187);
            this.txtBayar.Name = "txtBayar";
            this.txtBayar.Size = new System.Drawing.Size(100, 22);
            this.txtBayar.TabIndex = 11;
            this.txtBayar.Text = "0";
            this.txtBayar.TextChanged += new System.EventHandler(this.txtBayar_TextChanged);
            // 
            // txtKembali
            // 
            this.txtKembali.Location = new System.Drawing.Point(562, 215);
            this.txtKembali.Name = "txtKembali";
            this.txtKembali.ReadOnly = true;
            this.txtKembali.Size = new System.Drawing.Size(100, 22);
            this.txtKembali.TabIndex = 12;
            this.txtKembali.Text = "0";
            this.txtKembali.TextChanged += new System.EventHandler(this.txtKembali_TextChanged);
            // 
            // btClear
            // 
            this.btClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClear.Location = new System.Drawing.Point(232, 234);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(100, 50);
            this.btClear.TabIndex = 13;
            this.btClear.Text = "Clear";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // btProses
            // 
            this.btProses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btProses.Location = new System.Drawing.Point(338, 234);
            this.btProses.Name = "btProses";
            this.btProses.Size = new System.Drawing.Size(100, 50);
            this.btProses.TabIndex = 14;
            this.btProses.Text = "Proses";
            this.btProses.UseVisualStyleBackColor = true;
            this.btProses.Click += new System.EventHandler(this.btProses_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtSubTotalMinuman);
            this.groupBox3.Controls.Add(this.txtSubTotalMakanan);
            this.groupBox3.Location = new System.Drawing.Point(435, 48);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(246, 100);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sub Total";
            // 
            // txtSubTotalMinuman
            // 
            this.txtSubTotalMinuman.Location = new System.Drawing.Point(6, 60);
            this.txtSubTotalMinuman.Name = "txtSubTotalMinuman";
            this.txtSubTotalMinuman.ReadOnly = true;
            this.txtSubTotalMinuman.Size = new System.Drawing.Size(221, 22);
            this.txtSubTotalMinuman.TabIndex = 11;
            this.txtSubTotalMinuman.Text = "0";
            // 
            // txtSubTotalMakanan
            // 
            this.txtSubTotalMakanan.Location = new System.Drawing.Point(6, 34);
            this.txtSubTotalMakanan.Name = "txtSubTotalMakanan";
            this.txtSubTotalMakanan.ReadOnly = true;
            this.txtSubTotalMakanan.Size = new System.Drawing.Size(221, 22);
            this.txtSubTotalMakanan.TabIndex = 10;
            this.txtSubTotalMakanan.Text = "0";
            // 
            // FormKasir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(693, 313);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btProses);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.txtKembali);
            this.Controls.Add(this.txtBayar);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtNamaKasir);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormKasir";
            this.Text = "Aplikasi Kasir";
            this.Load += new System.EventHandler(this.FormKasir_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtSatuanMinuman)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSatuanMakanan)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbMakanan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbMinuman;
        private System.Windows.Forms.TextBox txtHargaMinuman;
        private System.Windows.Forms.TextBox txtHargaMakanan;
        private System.Windows.Forms.TextBox txtNamaKasir;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtBayar;
        private System.Windows.Forms.TextBox txtKembali;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Button btProses;
        private System.Windows.Forms.NumericUpDown txtSatuanMinuman;
        private System.Windows.Forms.NumericUpDown txtSatuanMakanan;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtSubTotalMinuman;
        private System.Windows.Forms.TextBox txtSubTotalMakanan;
    }
}