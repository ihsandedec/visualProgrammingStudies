
namespace sayfa188_pixel_ile_calisma
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
            this.button_resimyukle = new System.Windows.Forms.Button();
            this.button_negatifgoruntu = new System.Windows.Forms.Button();
            this.button_embossefekti = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // button_resimyukle
            // 
            this.button_resimyukle.Location = new System.Drawing.Point(40, 44);
            this.button_resimyukle.Name = "button_resimyukle";
            this.button_resimyukle.Size = new System.Drawing.Size(112, 35);
            this.button_resimyukle.TabIndex = 0;
            this.button_resimyukle.Text = "Resim Yükle";
            this.button_resimyukle.UseVisualStyleBackColor = true;
            this.button_resimyukle.Click += new System.EventHandler(this.button_resimyukle_Click);
            // 
            // button_negatifgoruntu
            // 
            this.button_negatifgoruntu.Location = new System.Drawing.Point(210, 44);
            this.button_negatifgoruntu.Name = "button_negatifgoruntu";
            this.button_negatifgoruntu.Size = new System.Drawing.Size(112, 35);
            this.button_negatifgoruntu.TabIndex = 1;
            this.button_negatifgoruntu.Text = "Negatif Görüntü";
            this.button_negatifgoruntu.UseVisualStyleBackColor = true;
            this.button_negatifgoruntu.Click += new System.EventHandler(this.button_negatifgoruntu_Click);
            // 
            // button_embossefekti
            // 
            this.button_embossefekti.Location = new System.Drawing.Point(375, 44);
            this.button_embossefekti.Name = "button_embossefekti";
            this.button_embossefekti.Size = new System.Drawing.Size(112, 35);
            this.button_embossefekti.TabIndex = 2;
            this.button_embossefekti.Text = "Emboss Efekti";
            this.button_embossefekti.UseVisualStyleBackColor = true;
            this.button_embossefekti.Click += new System.EventHandler(this.button_embossefekti_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(52, 109);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(166, 114);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(321, 109);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(166, 114);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(40, 277);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(447, 31);
            this.progressBar1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 386);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_embossefekti);
            this.Controls.Add(this.button_negatifgoruntu);
            this.Controls.Add(this.button_resimyukle);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_resimyukle;
        private System.Windows.Forms.Button button_negatifgoruntu;
        private System.Windows.Forms.Button button_embossefekti;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

