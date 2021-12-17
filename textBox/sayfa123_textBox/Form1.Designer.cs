
namespace sayfa123_textBox
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_buyuk = new System.Windows.Forms.Button();
            this.btn_kucuk = new System.Windows.Forms.Button();
            this.btn_normal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(111, 53);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(119, 23);
            this.textBox1.TabIndex = 0;
            // 
            // btn_buyuk
            // 
            this.btn_buyuk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_buyuk.Location = new System.Drawing.Point(33, 123);
            this.btn_buyuk.Name = "btn_buyuk";
            this.btn_buyuk.Size = new System.Drawing.Size(89, 32);
            this.btn_buyuk.TabIndex = 1;
            this.btn_buyuk.Text = "Büyük Harf";
            this.btn_buyuk.UseVisualStyleBackColor = true;
            this.btn_buyuk.Click += new System.EventHandler(this.btn_buyuk_Click);
            // 
            // btn_kucuk
            // 
            this.btn_kucuk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kucuk.Location = new System.Drawing.Point(128, 123);
            this.btn_kucuk.Name = "btn_kucuk";
            this.btn_kucuk.Size = new System.Drawing.Size(98, 32);
            this.btn_kucuk.TabIndex = 2;
            this.btn_kucuk.Text = "Küçük Harf";
            this.btn_kucuk.UseVisualStyleBackColor = true;
            this.btn_kucuk.Click += new System.EventHandler(this.btn_kucuk_Click);
            // 
            // btn_normal
            // 
            this.btn_normal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_normal.Location = new System.Drawing.Point(232, 123);
            this.btn_normal.Name = "btn_normal";
            this.btn_normal.Size = new System.Drawing.Size(81, 32);
            this.btn_normal.TabIndex = 3;
            this.btn_normal.Text = "Normal";
            this.btn_normal.UseVisualStyleBackColor = true;
            this.btn_normal.Click += new System.EventHandler(this.btn_normal_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 225);
            this.Controls.Add(this.btn_normal);
            this.Controls.Add(this.btn_kucuk);
            this.Controls.Add(this.btn_buyuk);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_buyuk;
        private System.Windows.Forms.Button btn_kucuk;
        private System.Windows.Forms.Button btn_normal;
    }
}

