
namespace sayfa198__contextMenuStrip02
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.renkDeğiştirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.simgeDurumunuKüçültToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ekranıKapaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.renkDeğiştirToolStripMenuItem,
            this.simgeDurumunuKüçültToolStripMenuItem,
            this.ekranıKapaToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(206, 70);
            // 
            // renkDeğiştirToolStripMenuItem
            // 
            this.renkDeğiştirToolStripMenuItem.Name = "renkDeğiştirToolStripMenuItem";
            this.renkDeğiştirToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.renkDeğiştirToolStripMenuItem.Text = "Renk Değiştir";
            this.renkDeğiştirToolStripMenuItem.Click += new System.EventHandler(this.renkDeğiştirToolStripMenuItem_Click);
            // 
            // simgeDurumunuKüçültToolStripMenuItem
            // 
            this.simgeDurumunuKüçültToolStripMenuItem.Name = "simgeDurumunuKüçültToolStripMenuItem";
            this.simgeDurumunuKüçültToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.simgeDurumunuKüçültToolStripMenuItem.Text = "Simge Durumunu Küçült";
            this.simgeDurumunuKüçültToolStripMenuItem.Click += new System.EventHandler(this.simgeDurumunuKüçültToolStripMenuItem_Click);
            // 
            // ekranıKapaToolStripMenuItem
            // 
            this.ekranıKapaToolStripMenuItem.Name = "ekranıKapaToolStripMenuItem";
            this.ekranıKapaToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.ekranıKapaToolStripMenuItem.Text = "Ekranı Kapla";
            this.ekranıKapaToolStripMenuItem.Click += new System.EventHandler(this.ekranıKapaToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 278);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem renkDeğiştirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem simgeDurumunuKüçültToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ekranıKapaToolStripMenuItem;
    }
}

