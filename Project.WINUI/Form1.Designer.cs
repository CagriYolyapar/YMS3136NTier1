namespace Project.WINUI
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.btn_yoket = new System.Windows.Forms.Button();
            this.btn_silinenler = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btn_guncellenenler = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_aktifler = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(619, 308);
            this.dataGridView1.TabIndex = 0;
            // 
            // btn_sil
            // 
            this.btn_sil.Location = new System.Drawing.Point(13, 367);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(87, 71);
            this.btn_sil.TabIndex = 1;
            this.btn_sil.Text = "Sil";
            this.btn_sil.UseVisualStyleBackColor = true;
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.Location = new System.Drawing.Point(106, 367);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(87, 71);
            this.btn_guncelle.TabIndex = 1;
            this.btn_guncelle.Text = "Güncelle";
            this.btn_guncelle.UseVisualStyleBackColor = true;
            // 
            // btn_yoket
            // 
            this.btn_yoket.Location = new System.Drawing.Point(199, 367);
            this.btn_yoket.Name = "btn_yoket";
            this.btn_yoket.Size = new System.Drawing.Size(87, 71);
            this.btn_yoket.TabIndex = 1;
            this.btn_yoket.Text = "Yok Et";
            this.btn_yoket.UseVisualStyleBackColor = true;
            // 
            // btn_silinenler
            // 
            this.btn_silinenler.Location = new System.Drawing.Point(385, 367);
            this.btn_silinenler.Name = "btn_silinenler";
            this.btn_silinenler.Size = new System.Drawing.Size(87, 71);
            this.btn_silinenler.TabIndex = 1;
            this.btn_silinenler.Text = "Silinenler";
            this.btn_silinenler.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(478, 367);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(87, 71);
            this.button6.TabIndex = 1;
            this.button6.Text = "Aktifler";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // btn_guncellenenler
            // 
            this.btn_guncellenenler.Location = new System.Drawing.Point(571, 367);
            this.btn_guncellenenler.Name = "btn_guncellenenler";
            this.btn_guncellenenler.Size = new System.Drawing.Size(87, 71);
            this.btn_guncellenenler.TabIndex = 1;
            this.btn_guncellenenler.Text = "Güncellenenler";
            this.btn_guncellenenler.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(638, 41);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 34);
            this.textBox1.TabIndex = 2;
            // 
            // btn_aktifler
            // 
            this.btn_aktifler.Location = new System.Drawing.Point(638, 97);
            this.btn_aktifler.Multiline = true;
            this.btn_aktifler.Name = "btn_aktifler";
            this.btn_aktifler.Size = new System.Drawing.Size(150, 34);
            this.btn_aktifler.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(635, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Isim";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(638, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Açıklama";
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(638, 149);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(66, 59);
            this.btn_add.TabIndex = 4;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_aktifler);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_guncellenenler);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.btn_silinenler);
            this.Controls.Add(this.btn_yoket);
            this.Controls.Add(this.btn_guncelle);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.Button btn_yoket;
        private System.Windows.Forms.Button btn_silinenler;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btn_guncellenenler;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox btn_aktifler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_add;
    }
}

