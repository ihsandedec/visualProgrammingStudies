
namespace sayfa78_Koordinat_Boyut01
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown_sol = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_ust = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_genislik = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_yukseklik = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_sol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ust)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_genislik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_yukseklik)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(75, 30);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(225, 173);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 312);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sol";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(195, 310);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Genişlik";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 357);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Üst";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(186, 362);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Yükseklik";
            // 
            // numericUpDown_sol
            // 
            this.numericUpDown_sol.Location = new System.Drawing.Point(100, 310);
            this.numericUpDown_sol.Name = "numericUpDown_sol";
            this.numericUpDown_sol.Size = new System.Drawing.Size(32, 20);
            this.numericUpDown_sol.TabIndex = 5;
            this.numericUpDown_sol.ValueChanged += new System.EventHandler(this.numericUpDown_sol_ValueChanged);
            // 
            // numericUpDown_ust
            // 
            this.numericUpDown_ust.Location = new System.Drawing.Point(100, 355);
            this.numericUpDown_ust.Name = "numericUpDown_ust";
            this.numericUpDown_ust.Size = new System.Drawing.Size(32, 20);
            this.numericUpDown_ust.TabIndex = 6;
            this.numericUpDown_ust.ValueChanged += new System.EventHandler(this.numericUpDown_ust_ValueChanged_1);
            // 
            // numericUpDown_genislik
            // 
            this.numericUpDown_genislik.Location = new System.Drawing.Point(245, 308);
            this.numericUpDown_genislik.Name = "numericUpDown_genislik";
            this.numericUpDown_genislik.Size = new System.Drawing.Size(32, 20);
            this.numericUpDown_genislik.TabIndex = 7;
            this.numericUpDown_genislik.ValueChanged += new System.EventHandler(this.numericUpDown_genislik_ValueChanged_1);
            // 
            // numericUpDown_yukseklik
            // 
            this.numericUpDown_yukseklik.Location = new System.Drawing.Point(245, 360);
            this.numericUpDown_yukseklik.Name = "numericUpDown_yukseklik";
            this.numericUpDown_yukseklik.Size = new System.Drawing.Size(32, 20);
            this.numericUpDown_yukseklik.TabIndex = 8;
            this.numericUpDown_yukseklik.ValueChanged += new System.EventHandler(this.numericUpDown_yukseklik_ValueChanged_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 410);
            this.Controls.Add(this.numericUpDown_yukseklik);
            this.Controls.Add(this.numericUpDown_genislik);
            this.Controls.Add(this.numericUpDown_ust);
            this.Controls.Add(this.numericUpDown_sol);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_sol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ust)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_genislik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_yukseklik)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown_sol;
        private System.Windows.Forms.NumericUpDown numericUpDown_ust;
        private System.Windows.Forms.NumericUpDown numericUpDown_genislik;
        private System.Windows.Forms.NumericUpDown numericUpDown_yukseklik;
    }
}

