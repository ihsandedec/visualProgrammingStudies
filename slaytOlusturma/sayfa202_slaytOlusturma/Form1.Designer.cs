
namespace sayfa202_slaytOlusturma
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
            this.components = new System.ComponentModel.Container();
            this.button_resimgoster = new System.Windows.Forms.Button();
            this.button_dosyasil = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_resimgoster
            // 
            this.button_resimgoster.Location = new System.Drawing.Point(33, 41);
            this.button_resimgoster.Name = "button_resimgoster";
            this.button_resimgoster.Size = new System.Drawing.Size(114, 29);
            this.button_resimgoster.TabIndex = 0;
            this.button_resimgoster.Text = "Resim Gösterisi";
            this.button_resimgoster.UseVisualStyleBackColor = true;
            this.button_resimgoster.Click += new System.EventHandler(this.button_resimgoster_Click);
            // 
            // button_dosyasil
            // 
            this.button_dosyasil.Location = new System.Drawing.Point(203, 41);
            this.button_dosyasil.Name = "button_dosyasil";
            this.button_dosyasil.Size = new System.Drawing.Size(114, 29);
            this.button_dosyasil.TabIndex = 1;
            this.button_dosyasil.Text = "Dosya Sil";
            this.button_dosyasil.UseVisualStyleBackColor = true;
            this.button_dosyasil.Click += new System.EventHandler(this.button_dosyasil_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(46, 112);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(271, 268);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.HelpRequest += new System.EventHandler(this.openFileDialog1_HelpRequest);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            this.openFileDialog2.HelpRequest += new System.EventHandler(this.openFileDialog2_HelpRequest);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 436);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_dosyasil);
            this.Controls.Add(this.button_resimgoster);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_resimgoster;
        private System.Windows.Forms.Button button_dosyasil;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.Timer timer1;
    }
}

