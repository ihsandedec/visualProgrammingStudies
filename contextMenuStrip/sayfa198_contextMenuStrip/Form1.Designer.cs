
namespace sayfa198_contextMenuStrip
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.büyükHarfeÇevirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.küçükHarfeÇevirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.textBox1.Location = new System.Drawing.Point(66, 79);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(134, 20);
            this.textBox1.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.büyükHarfeÇevirToolStripMenuItem,
            this.küçükHarfeÇevirToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 70);
            // 
            // büyükHarfeÇevirToolStripMenuItem
            // 
            this.büyükHarfeÇevirToolStripMenuItem.Name = "büyükHarfeÇevirToolStripMenuItem";
            this.büyükHarfeÇevirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.büyükHarfeÇevirToolStripMenuItem.Text = "Büyük Harfe Çevir";
            this.büyükHarfeÇevirToolStripMenuItem.Click += new System.EventHandler(this.büyükHarfeÇevirToolStripMenuItem_Click);
            // 
            // küçükHarfeÇevirToolStripMenuItem
            // 
            this.küçükHarfeÇevirToolStripMenuItem.Name = "küçükHarfeÇevirToolStripMenuItem";
            this.küçükHarfeÇevirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.küçükHarfeÇevirToolStripMenuItem.Text = "KüçükHarfe Çevir";
            this.küçükHarfeÇevirToolStripMenuItem.Click += new System.EventHandler(this.küçükHarfeÇevirToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 175);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem büyükHarfeÇevirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem küçükHarfeÇevirToolStripMenuItem;
    }
}

