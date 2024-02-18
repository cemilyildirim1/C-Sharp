namespace BilgisayarGrafikleriÖğrenciİşlemleri
{
    partial class OgrenciListeleme
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
            goMain = new Button();
            ((System.ComponentModel.ISupportInitialize)dgwListe).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(512, 41);
            label1.Name = "label1";
            label1.Size = new Size(172, 20);
            label1.TabIndex = 0;
            label1.Text = "Ogrenci Listeleme Ekranı";
            // 
            // dgwListe
            // 
            dgwListe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwListe.Location = new Point(327, 73);
            dgwListe.Name = "dgwListe";
            dgwListe.RowHeadersWidth = 51;
            dgwListe.Size = new Size(519, 308);
            dgwListe.TabIndex = 1;
            // 
            // goMain
            // 
            goMain.Location = new Point(957, 397);
            goMain.Name = "goMain";
            goMain.Size = new Size(94, 29);
            goMain.TabIndex = 2;
            goMain.Text = "Ana menü";
            goMain.UseVisualStyleBackColor = true;
            goMain.Click += goMain_Click;
            // 
            // OgrenciListeleme
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1174, 450);
            Controls.Add(goMain);
            Controls.Add(dgwListe);
            Controls.Add(label1);
            Name = "OgrenciListeleme";
            Text = "OgrenciListeleme";
            Load += OgrenciListeleme_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgwListe).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgwListe;
        private Button goMain;
    }
}