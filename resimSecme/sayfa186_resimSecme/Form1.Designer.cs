
namespace sayfa186_resimSecme
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
            this.button_kes = new System.Windows.Forms.Button();
            this.button_sagacevir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_resimyukle
            // 
            this.button_resimyukle.Location = new System.Drawing.Point(60, 44);
            this.button_resimyukle.Name = "button_resimyukle";
            this.button_resimyukle.Size = new System.Drawing.Size(98, 36);
            this.button_resimyukle.TabIndex = 0;
            this.button_resimyukle.Text = "Resmi Yükle";
            this.button_resimyukle.UseVisualStyleBackColor = true;
            this.button_resimyukle.Click += new System.EventHandler(this.button_resimyukle_Click);
            // 
            // button_kes
            // 
            this.button_kes.Location = new System.Drawing.Point(208, 44);
            this.button_kes.Name = "button_kes";
            this.button_kes.Size = new System.Drawing.Size(102, 36);
            this.button_kes.TabIndex = 1;
            this.button_kes.Text = "Kes";
            this.button_kes.UseVisualStyleBackColor = true;
            this.button_kes.Click += new System.EventHandler(this.button_kes_Click);
            // 
            // button_sagacevir
            // 
            this.button_sagacevir.Location = new System.Drawing.Point(364, 44);
            this.button_sagacevir.Name = "button_sagacevir";
            this.button_sagacevir.Size = new System.Drawing.Size(109, 36);
            this.button_sagacevir.TabIndex = 2;
            this.button_sagacevir.Text = "20 Derece Sağa Çevir";
            this.button_sagacevir.UseVisualStyleBackColor = true;
            this.button_sagacevir.Click += new System.EventHandler(this.button_sagacevir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(60, 131);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_sagacevir);
            this.Controls.Add(this.button_kes);
            this.Controls.Add(this.button_resimyukle);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_resimyukle;
        private System.Windows.Forms.Button button_kes;
        private System.Windows.Forms.Button button_sagacevir;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

