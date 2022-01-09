namespace BiletOtomasyon
{
    partial class SecimEkrani
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_biletSatis = new System.Windows.Forms.Button();
            this.btn_satilanBiletler = new System.Windows.Forms.Button();
            this.btn_oturumKapat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_biletSatis
            // 
            this.btn_biletSatis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_biletSatis.Location = new System.Drawing.Point(49, 38);
            this.btn_biletSatis.Name = "btn_biletSatis";
            this.btn_biletSatis.Size = new System.Drawing.Size(173, 50);
            this.btn_biletSatis.TabIndex = 0;
            this.btn_biletSatis.Text = "Bilet Satış";
            this.btn_biletSatis.UseVisualStyleBackColor = true;
            this.btn_biletSatis.Click += new System.EventHandler(this.btn_biletSatis_Click);
            // 
            // btn_satilanBiletler
            // 
            this.btn_satilanBiletler.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_satilanBiletler.Location = new System.Drawing.Point(49, 110);
            this.btn_satilanBiletler.Name = "btn_satilanBiletler";
            this.btn_satilanBiletler.Size = new System.Drawing.Size(173, 50);
            this.btn_satilanBiletler.TabIndex = 1;
            this.btn_satilanBiletler.Text = "Satılan Biletler";
            this.btn_satilanBiletler.UseVisualStyleBackColor = true;
            this.btn_satilanBiletler.Click += new System.EventHandler(this.btn_satilanBiletler_Click);
            // 
            // btn_oturumKapat
            // 
            this.btn_oturumKapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_oturumKapat.Location = new System.Drawing.Point(306, 214);
            this.btn_oturumKapat.Name = "btn_oturumKapat";
            this.btn_oturumKapat.Size = new System.Drawing.Size(139, 33);
            this.btn_oturumKapat.TabIndex = 2;
            this.btn_oturumKapat.Text = "Oturum Kapat";
            this.btn_oturumKapat.UseVisualStyleBackColor = true;
            this.btn_oturumKapat.Click += new System.EventHandler(this.btn_oturumKapat_Click);
            // 
            // SecimEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(457, 259);
            this.Controls.Add(this.btn_oturumKapat);
            this.Controls.Add(this.btn_satilanBiletler);
            this.Controls.Add(this.btn_biletSatis);
            this.Name = "SecimEkrani";
            this.Text = "SecimEkrani";
            this.Load += new System.EventHandler(this.SecimEkrani_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_biletSatis;
        private System.Windows.Forms.Button btn_satilanBiletler;
        private System.Windows.Forms.Button btn_oturumKapat;
    }
}