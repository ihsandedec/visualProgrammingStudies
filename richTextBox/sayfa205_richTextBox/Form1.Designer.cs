
namespace sayfa205_richTextBox
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
            this.button_farklıkaydet = new System.Windows.Forms.Button();
            this.buttonkaydet = new System.Windows.Forms.Button();
            this.button_ac = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // button_farklıkaydet
            // 
            this.button_farklıkaydet.Location = new System.Drawing.Point(333, 309);
            this.button_farklıkaydet.Name = "button_farklıkaydet";
            this.button_farklıkaydet.Size = new System.Drawing.Size(97, 23);
            this.button_farklıkaydet.TabIndex = 7;
            this.button_farklıkaydet.Text = "Farklı Kaydet";
            this.button_farklıkaydet.UseVisualStyleBackColor = true;
            this.button_farklıkaydet.Click += new System.EventHandler(this.button_farklıkaydet_Click);
            // 
            // buttonkaydet
            // 
            this.buttonkaydet.Location = new System.Drawing.Point(174, 309);
            this.buttonkaydet.Name = "buttonkaydet";
            this.buttonkaydet.Size = new System.Drawing.Size(75, 23);
            this.buttonkaydet.TabIndex = 6;
            this.buttonkaydet.Text = "Kaydet";
            this.buttonkaydet.UseVisualStyleBackColor = true;
            this.buttonkaydet.Click += new System.EventHandler(this.buttonkaydet_Click);
            // 
            // button_ac
            // 
            this.button_ac.Location = new System.Drawing.Point(23, 309);
            this.button_ac.Name = "button_ac";
            this.button_ac.Size = new System.Drawing.Size(75, 23);
            this.button_ac.TabIndex = 5;
            this.button_ac.Text = "Aç";
            this.button_ac.UseVisualStyleBackColor = true;
            this.button_ac.Click += new System.EventHandler(this.button_ac_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(23, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(407, 284);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "richTexBox";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 377);
            this.Controls.Add(this.button_farklıkaydet);
            this.Controls.Add(this.buttonkaydet);
            this.Controls.Add(this.button_ac);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_farklıkaydet;
        private System.Windows.Forms.Button buttonkaydet;
        private System.Windows.Forms.Button button_ac;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

