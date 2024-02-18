namespace BilgisayarGrafikleriÖğrenciİşlemleri
{
    partial class AnaEkran
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            label1 = new Label();
            ogrenciEkle = new Button();
            Listeleme = new Button();
            OgrenciDuzenleme = new Button();
            OgrenciSilme = new Button();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(480, 62);
            label1.Name = "label1";
            label1.Size = new Size(120, 28);
            label1.TabIndex = 2;
            label1.Text = "ANA EKRAN";
            label1.Click += label1_Click;
            // 
            // ogrenciEkle
            // 
            ogrenciEkle.Location = new Point(460, 164);
            ogrenciEkle.Name = "ogrenciEkle";
            ogrenciEkle.Size = new Size(160, 29);
            ogrenciEkle.TabIndex = 3;
            ogrenciEkle.Text = "Öğrenci Ekleme";
            ogrenciEkle.UseVisualStyleBackColor = true;
            ogrenciEkle.Click += ogrenciEkle_Click;
            // 
            // Listeleme
            // 
            Listeleme.Location = new Point(460, 212);
            Listeleme.Name = "Listeleme";
            Listeleme.Size = new Size(160, 29);
            Listeleme.TabIndex = 4;
            Listeleme.Text = "Listeleme";
            Listeleme.UseVisualStyleBackColor = true;
            Listeleme.Click += Listeleme_Click;
            // 
            // OgrenciDuzenleme
            // 
            OgrenciDuzenleme.Location = new Point(460, 311);
            OgrenciDuzenleme.Name = "OgrenciDuzenleme";
            OgrenciDuzenleme.Size = new Size(160, 29);
            OgrenciDuzenleme.TabIndex = 5;
            OgrenciDuzenleme.Text = "Düzenleme";
            OgrenciDuzenleme.UseVisualStyleBackColor = true;
            OgrenciDuzenleme.Click += OgrenciDuzenleme_Click;
            // 
            // OgrenciSilme
            // 
            OgrenciSilme.Location = new Point(460, 263);
            OgrenciSilme.Name = "OgrenciSilme";
            OgrenciSilme.Size = new Size(160, 29);
            OgrenciSilme.TabIndex = 6;
            OgrenciSilme.Text = "Silme";
            OgrenciSilme.UseVisualStyleBackColor = true;
            OgrenciSilme.Click += OgrenciSilme_Click;
            // 
            // AnaEkran
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1142, 493);
            Controls.Add(OgrenciSilme);
            Controls.Add(OgrenciDuzenleme);
            Controls.Add(Listeleme);
            Controls.Add(ogrenciEkle);
            Controls.Add(label1);
            Name = "AnaEkran";
            Text = "AnaEkran";
            Load += AnaEkran_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ContextMenuStrip contextMenuStrip1;
        private Label label1;
        private Button ogrenciEkle;
        private Button Listeleme;
        private Button OgrenciDuzenleme;
        private Button OgrenciSilme;
    }
}