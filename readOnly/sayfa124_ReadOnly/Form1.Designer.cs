
namespace sayfa124_ReadOnly
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_sifre = new System.Windows.Forms.TextBox();
            this.btn_tamam = new System.Windows.Forms.Button();
            this.txt_adiniz = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_soyadiniz = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(56, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Şifre";
            // 
            // txt_sifre
            // 
            this.txt_sifre.Location = new System.Drawing.Point(144, 42);
            this.txt_sifre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_sifre.Name = "txt_sifre";
            this.txt_sifre.Size = new System.Drawing.Size(132, 23);
            this.txt_sifre.TabIndex = 1;
            // 
            // btn_tamam
            // 
            this.btn_tamam.Location = new System.Drawing.Point(144, 89);
            this.btn_tamam.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_tamam.Name = "btn_tamam";
            this.btn_tamam.Size = new System.Drawing.Size(133, 37);
            this.btn_tamam.TabIndex = 2;
            this.btn_tamam.Text = "Tamam";
            this.btn_tamam.UseVisualStyleBackColor = true;
            this.btn_tamam.Click += new System.EventHandler(this.btn_tamam_Click);
            // 
            // txt_adınız
            // 
            this.txt_adiniz.Location = new System.Drawing.Point(144, 154);
            this.txt_adiniz.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_adiniz.Name = "txt_adınız";
            this.txt_adiniz.Size = new System.Drawing.Size(132, 23);
            this.txt_adiniz.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(56, 155);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Adınız";
            // 
            // txt_soyadınız
            // 
            this.txt_soyadiniz.Location = new System.Drawing.Point(144, 214);
            this.txt_soyadiniz.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_soyadiniz.Name = "txt_soyadınız";
            this.txt_soyadiniz.Size = new System.Drawing.Size(132, 23);
            this.txt_soyadiniz.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(25, 214);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Soyadınız";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 282);
            this.Controls.Add(this.txt_soyadiniz);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_adiniz);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_tamam);
            this.Controls.Add(this.txt_sifre);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_sifre;
        private System.Windows.Forms.Button btn_tamam;
        private System.Windows.Forms.TextBox txt_adiniz;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_soyadiniz;
        private System.Windows.Forms.Label label3;
    }
}

