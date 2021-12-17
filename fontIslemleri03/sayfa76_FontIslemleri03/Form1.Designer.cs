
namespace sayfa76_FontIslemleri03
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
            this.listBox_fontlar = new System.Windows.Forms.ListBox();
            this.txt_yazi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBox_fontlar
            // 
            this.listBox_fontlar.FormattingEnabled = true;
            this.listBox_fontlar.Location = new System.Drawing.Point(33, 55);
            this.listBox_fontlar.Name = "listBox_fontlar";
            this.listBox_fontlar.Size = new System.Drawing.Size(154, 329);
            this.listBox_fontlar.TabIndex = 0;
            this.listBox_fontlar.SelectedIndexChanged += new System.EventHandler(this.listBox_fontlar_SelectedIndexChanged_1);
            // 
            // txt_yazi
            // 
            this.txt_yazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_yazi.Location = new System.Drawing.Point(209, 175);
            this.txt_yazi.Multiline = true;
            this.txt_yazi.Name = "txt_yazi";
            this.txt_yazi.Size = new System.Drawing.Size(163, 65);
            this.txt_yazi.TabIndex = 1;
            this.txt_yazi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 450);
            this.Controls.Add(this.txt_yazi);
            this.Controls.Add(this.listBox_fontlar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_fontlar;
        private System.Windows.Forms.TextBox txt_yazi;
    }
}

