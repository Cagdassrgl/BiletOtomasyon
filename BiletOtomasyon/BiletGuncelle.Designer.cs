namespace BiletOtomasyon
{
    partial class BiletGuncelle
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.text_koltukGuncelle = new System.Windows.Forms.TextBox();
            this.servisOtomasyonDataSet1 = new BiletOtomasyon.ServisOtomasyonDataSet();
            this.dateTime_guncelle = new System.Windows.Forms.DateTimePicker();
            this.combo_saatGuncelle = new System.Windows.Forms.ComboBox();
            this.buton_guncelle = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.text_rezGuncelle = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.servisOtomasyonDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.text_rezGuncelle);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.buton_guncelle);
            this.groupBox1.Controls.Add(this.combo_saatGuncelle);
            this.groupBox1.Controls.Add(this.dateTime_guncelle);
            this.groupBox1.Controls.Add(this.text_koltukGuncelle);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(30, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(352, 294);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bilet Bilgileri";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tarih:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Saat:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Koltuk No:";
            // 
            // text_koltukGuncelle
            // 
            this.text_koltukGuncelle.Location = new System.Drawing.Point(118, 157);
            this.text_koltukGuncelle.Name = "text_koltukGuncelle";
            this.text_koltukGuncelle.Size = new System.Drawing.Size(200, 24);
            this.text_koltukGuncelle.TabIndex = 5;
            // 
            // servisOtomasyonDataSet1
            // 
            this.servisOtomasyonDataSet1.DataSetName = "ServisOtomasyonDataSet";
            this.servisOtomasyonDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dateTime_guncelle
            // 
            this.dateTime_guncelle.Location = new System.Drawing.Point(118, 84);
            this.dateTime_guncelle.Name = "dateTime_guncelle";
            this.dateTime_guncelle.Size = new System.Drawing.Size(200, 24);
            this.dateTime_guncelle.TabIndex = 6;
            // 
            // combo_saatGuncelle
            // 
            this.combo_saatGuncelle.FormattingEnabled = true;
            this.combo_saatGuncelle.Location = new System.Drawing.Point(118, 117);
            this.combo_saatGuncelle.Name = "combo_saatGuncelle";
            this.combo_saatGuncelle.Size = new System.Drawing.Size(200, 26);
            this.combo_saatGuncelle.TabIndex = 7;
            // 
            // buton_guncelle
            // 
            this.buton_guncelle.Location = new System.Drawing.Point(119, 206);
            this.buton_guncelle.Name = "buton_guncelle";
            this.buton_guncelle.Size = new System.Drawing.Size(200, 47);
            this.buton_guncelle.TabIndex = 8;
            this.buton_guncelle.Text = "Güncelle";
            this.buton_guncelle.UseVisualStyleBackColor = true;
            this.buton_guncelle.Click += new System.EventHandler(this.buton_guncelle_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Rez. No:";
            // 
            // text_rezGuncelle
            // 
            this.text_rezGuncelle.Location = new System.Drawing.Point(119, 48);
            this.text_rezGuncelle.Name = "text_rezGuncelle";
            this.text_rezGuncelle.ReadOnly = true;
            this.text_rezGuncelle.Size = new System.Drawing.Size(199, 24);
            this.text_rezGuncelle.TabIndex = 10;
            // 
            // BiletGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 363);
            this.Controls.Add(this.groupBox1);
            this.Name = "BiletGuncelle";
            this.Text = "BiletGuncelle";
            this.Load += new System.EventHandler(this.BiletGuncelle_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.servisOtomasyonDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_koltukGuncelle;
        private ServisOtomasyonDataSet servisOtomasyonDataSet1;
        private System.Windows.Forms.Button buton_guncelle;
        private System.Windows.Forms.ComboBox combo_saatGuncelle;
        private System.Windows.Forms.DateTimePicker dateTime_guncelle;
        private System.Windows.Forms.TextBox text_rezGuncelle;
        private System.Windows.Forms.Label label4;
    }
}