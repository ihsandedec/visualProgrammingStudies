﻿
namespace sayfa151_uygulama01
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_adisoyadi = new System.Windows.Forms.TextBox();
            this.listBox_adisoyadi = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBox_bolum = new System.Windows.Forms.ListBox();
            this.txt_bolum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listBox_babaadi = new System.Windows.Forms.ListBox();
            this.txt_babaadi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBox_adisoyadi);
            this.groupBox1.Controls.Add(this.txt_adisoyadi);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(58, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 303);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(23, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Öğrencinin Adı Soyadı";
            // 
            // txt_adisoyadi
            // 
            this.txt_adisoyadi.Location = new System.Drawing.Point(26, 67);
            this.txt_adisoyadi.Name = "txt_adisoyadi";
            this.txt_adisoyadi.Size = new System.Drawing.Size(145, 20);
            this.txt_adisoyadi.TabIndex = 2;
            // 
            // listBox_adisoyadi
            // 
            this.listBox_adisoyadi.FormattingEnabled = true;
            this.listBox_adisoyadi.Location = new System.Drawing.Point(26, 106);
            this.listBox_adisoyadi.Name = "listBox_adisoyadi";
            this.listBox_adisoyadi.Size = new System.Drawing.Size(145, 173);
            this.listBox_adisoyadi.TabIndex = 3;
            this.listBox_adisoyadi.SelectedIndexChanged += new System.EventHandler(this.eleman_tiklanirsa);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBox_bolum);
            this.groupBox2.Controls.Add(this.txt_bolum);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(293, 35);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 303);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // listBox_bolum
            // 
            this.listBox_bolum.FormattingEnabled = true;
            this.listBox_bolum.Location = new System.Drawing.Point(26, 106);
            this.listBox_bolum.Name = "listBox_bolum";
            this.listBox_bolum.Size = new System.Drawing.Size(145, 173);
            this.listBox_bolum.TabIndex = 3;
            this.listBox_bolum.SelectedIndexChanged += new System.EventHandler(this.eleman_tiklanirsa);
            // 
            // txt_bolum
            // 
            this.txt_bolum.Location = new System.Drawing.Point(26, 67);
            this.txt_bolum.Name = "txt_bolum";
            this.txt_bolum.Size = new System.Drawing.Size(145, 20);
            this.txt_bolum.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(23, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Öğrencinin Bölümü";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listBox_babaadi);
            this.groupBox3.Controls.Add(this.txt_babaadi);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(522, 35);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 303);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            // 
            // listBox_babaadi
            // 
            this.listBox_babaadi.FormattingEnabled = true;
            this.listBox_babaadi.Location = new System.Drawing.Point(26, 106);
            this.listBox_babaadi.Name = "listBox_babaadi";
            this.listBox_babaadi.Size = new System.Drawing.Size(145, 173);
            this.listBox_babaadi.TabIndex = 3;
            this.listBox_babaadi.SelectedIndexChanged += new System.EventHandler(this.eleman_tiklanirsa);
            // 
            // txt_babaadi
            // 
            this.txt_babaadi.Location = new System.Drawing.Point(26, 67);
            this.txt_babaadi.Name = "txt_babaadi";
            this.txt_babaadi.Size = new System.Drawing.Size(145, 20);
            this.txt_babaadi.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(23, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Öğrencinin Baba Adı";
            // 
            // btn_ekle
            // 
            this.btn_ekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ekle.Location = new System.Drawing.Point(113, 361);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(237, 60);
            this.btn_ekle.TabIndex = 5;
            this.btn_ekle.Text = "Listeye Ekle";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_sil.Location = new System.Drawing.Point(422, 361);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(237, 60);
            this.btn_sil.TabIndex = 6;
            this.btn_sil.Text = "Listeden Sil";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBox_adisoyadi;
        private System.Windows.Forms.TextBox txt_adisoyadi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listBox_bolum;
        private System.Windows.Forms.TextBox txt_bolum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox listBox_babaadi;
        private System.Windows.Forms.TextBox txt_babaadi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Button btn_sil;
    }
}

