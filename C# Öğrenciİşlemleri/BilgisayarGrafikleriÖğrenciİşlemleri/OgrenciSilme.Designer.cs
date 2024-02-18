namespace BilgisayarGrafikleriÖğrenciİşlemleri
{
    partial class OgrenciSilme
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
            label1 = new Label();
            dgwListe = new DataGridView();
            btnSil = new Button();
            goMain = new Button();
            ((System.ComponentModel.ISupportInitialize)dgwListe).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(274, 37);
            label1.Name = "label1";
            label1.Size = new Size(146, 20);
            label1.TabIndex = 0;
            label1.Text = "Ogrenci Silme Ekrani";
            // 
            // dgwListe
            // 
            dgwListe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwListe.Location = new Point(205, 77);
            dgwListe.Name = "dgwListe";
            dgwListe.RowHeadersWidth = 51;
            dgwListe.RowTemplate.Height = 29;
            dgwListe.Size = new Size(382, 224);
            dgwListe.TabIndex = 1;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(495, 341);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(94, 29);
            btnSil.TabIndex = 2;
            btnSil.Text = "Öğrenci Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // goMain
            // 
            goMain.Location = new Point(670, 396);
            goMain.Name = "goMain";
            goMain.Size = new Size(94, 29);
            goMain.TabIndex = 3;
            goMain.Text = "Ana menü";
            goMain.UseVisualStyleBackColor = true;
            goMain.Click += goMain_Click;
            // 
            // OgrenciSilme
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(goMain);
            Controls.Add(btnSil);
            Controls.Add(dgwListe);
            Controls.Add(label1);
            Name = "OgrenciSilme";
            Text = "Ogrenci Silme";
            Load += OgrenciSilme_Load;
            ((System.ComponentModel.ISupportInitialize)dgwListe).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgwListe;
        private Button btnSil;
        private Button goMain;
    }
}