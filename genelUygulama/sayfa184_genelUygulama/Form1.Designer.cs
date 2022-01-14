
namespace sayfa184_genelUygulama
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
            this.button_dosyadanYukle = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.radioButton_normal = new System.Windows.Forms.RadioButton();
            this.radioButton_sıgdır = new System.Windows.Forms.RadioButton();
            this.radioButton_otoboyut = new System.Windows.Forms.RadioButton();
            this.radioButton_ortala = new System.Windows.Forms.RadioButton();
            this.checkBox_dose = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_dosyadanYukle
            // 
            this.button_dosyadanYukle.Location = new System.Drawing.Point(12, 22);
            this.button_dosyadanYukle.Name = "button_dosyadanYukle";
            this.button_dosyadanYukle.Size = new System.Drawing.Size(141, 23);
            this.button_dosyadanYukle.TabIndex = 0;
            this.button_dosyadanYukle.Text = "Resmi Dosyadan Yükle";
            this.button_dosyadanYukle.UseVisualStyleBackColor = true;
            this.button_dosyadanYukle.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 60);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Resmi Panodan Yapıştır";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // radioButton_normal
            // 
            this.radioButton_normal.AutoSize = true;
            this.radioButton_normal.Location = new System.Drawing.Point(6, 44);
            this.radioButton_normal.Name = "radioButton_normal";
            this.radioButton_normal.Size = new System.Drawing.Size(58, 17);
            this.radioButton_normal.TabIndex = 2;
            this.radioButton_normal.TabStop = true;
            this.radioButton_normal.Text = "Normal";
            this.radioButton_normal.UseVisualStyleBackColor = true;
            this.radioButton_normal.CheckedChanged += new System.EventHandler(this.radioButton_normal_CheckedChanged);
            // 
            // radioButton_sıgdır
            // 
            this.radioButton_sıgdır.AutoSize = true;
            this.radioButton_sıgdır.Location = new System.Drawing.Point(81, 44);
            this.radioButton_sıgdır.Name = "radioButton_sıgdır";
            this.radioButton_sıgdır.Size = new System.Drawing.Size(51, 17);
            this.radioButton_sıgdır.TabIndex = 3;
            this.radioButton_sıgdır.TabStop = true;
            this.radioButton_sıgdır.Text = "Sığdır";
            this.radioButton_sıgdır.UseVisualStyleBackColor = true;
            this.radioButton_sıgdır.CheckedChanged += new System.EventHandler(this.radioButton_sıgdır_CheckedChanged);
            // 
            // radioButton_otoboyut
            // 
            this.radioButton_otoboyut.AutoSize = true;
            this.radioButton_otoboyut.Location = new System.Drawing.Point(138, 44);
            this.radioButton_otoboyut.Name = "radioButton_otoboyut";
            this.radioButton_otoboyut.Size = new System.Drawing.Size(122, 17);
            this.radioButton_otoboyut.TabIndex = 4;
            this.radioButton_otoboyut.TabStop = true;
            this.radioButton_otoboyut.Text = "Otomatik Boyutlandır";
            this.radioButton_otoboyut.UseVisualStyleBackColor = true;
            this.radioButton_otoboyut.CheckedChanged += new System.EventHandler(this.radioButton_otoboyut_CheckedChanged);
            // 
            // radioButton_ortala
            // 
            this.radioButton_ortala.AutoSize = true;
            this.radioButton_ortala.Location = new System.Drawing.Point(266, 44);
            this.radioButton_ortala.Name = "radioButton_ortala";
            this.radioButton_ortala.Size = new System.Drawing.Size(53, 17);
            this.radioButton_ortala.TabIndex = 5;
            this.radioButton_ortala.TabStop = true;
            this.radioButton_ortala.Text = "Ortala";
            this.radioButton_ortala.UseVisualStyleBackColor = true;
            this.radioButton_ortala.CheckedChanged += new System.EventHandler(this.radioButton_ortala_CheckedChanged);
            // 
            // checkBox_dose
            // 
            this.checkBox_dose.AutoSize = true;
            this.checkBox_dose.Location = new System.Drawing.Point(325, 44);
            this.checkBox_dose.Name = "checkBox_dose";
            this.checkBox_dose.Size = new System.Drawing.Size(51, 17);
            this.checkBox_dose.TabIndex = 6;
            this.checkBox_dose.Text = "Döşe";
            this.checkBox_dose.UseVisualStyleBackColor = true;
            this.checkBox_dose.CheckedChanged += new System.EventHandler(this.checkBox_dose_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox_dose);
            this.groupBox1.Controls.Add(this.radioButton_normal);
            this.groupBox1.Controls.Add(this.radioButton_ortala);
            this.groupBox1.Controls.Add(this.radioButton_sıgdır);
            this.groupBox1.Controls.Add(this.radioButton_otoboyut);
            this.groupBox1.Location = new System.Drawing.Point(202, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(411, 88);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gösterim Modu";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(38, 128);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(174, 89);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 252);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button_dosyadanYukle);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_dosyadanYukle;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton radioButton_normal;
        private System.Windows.Forms.RadioButton radioButton_sıgdır;
        private System.Windows.Forms.RadioButton radioButton_otoboyut;
        private System.Windows.Forms.RadioButton radioButton_ortala;
        private System.Windows.Forms.CheckBox checkBox_dose;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

