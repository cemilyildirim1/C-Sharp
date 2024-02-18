namespace BilgisayarGrafikleriÖğrenciİşlemleri
{
    partial class OgrenciDuzenleme
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
            btnDuzenle = new Button();
            lblSurname = new Label();
            lblNo = new Label();
            lblName = new Label();
            txtSurname = new TextBox();
            txtNo = new TextBox();
            txtName = new TextBox();
            btnSelect = new Button();
            label2 = new Label();
            goMain = new Button();
            ((System.ComponentModel.ISupportInitialize)dgwListe).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(303, 9);
            label1.Name = "label1";
            label1.Size = new Size(128, 20);
            label1.TabIndex = 0;
            label1.Text = "Düzenleme Ekranı";
            // 
            // dgwListe
            // 
            dgwListe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwListe.Location = new Point(138, 69);
            dgwListe.Name = "dgwListe";
            dgwListe.RowHeadersWidth = 51;
            dgwListe.Size = new Size(519, 308);
            dgwListe.TabIndex = 2;
            dgwListe.CellContentClick += dgwListe_CellContentClick;
            // 
            // btnDuzenle
            // 
            btnDuzenle.Location = new Point(1017, 272);
            btnDuzenle.Name = "btnDuzenle";
            btnDuzenle.Size = new Size(123, 64);
            btnDuzenle.TabIndex = 4;
            btnDuzenle.Text = "Öğrenci Düzenle";
            btnDuzenle.UseVisualStyleBackColor = true;
            btnDuzenle.Click += btnDuzenle_Click;
            // 
            // lblSurname
            // 
            lblSurname.AutoSize = true;
            lblSurname.Location = new Point(831, 133);
            lblSurname.Name = "lblSurname";
            lblSurname.Size = new Size(113, 20);
            lblSurname.TabIndex = 16;
            lblSurname.Text = "Öğrenci Soyad :";
            // 
            // lblNo
            // 
            lblNo.AutoSize = true;
            lblNo.Location = new Point(831, 197);
            lblNo.Name = "lblNo";
            lblNo.Size = new Size(135, 20);
            lblNo.TabIndex = 15;
            lblNo.Text = "Öğrenci Numarası :";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(831, 83);
            lblName.Name = "lblName";
            lblName.Size = new Size(99, 20);
            lblName.TabIndex = 14;
            lblName.Text = "Öğrenci İsmi :";
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(979, 136);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(161, 27);
            txtSurname.TabIndex = 2;
            // 
            // txtNo
            // 
            txtNo.Location = new Point(979, 190);
            txtNo.Name = "txtNo";
            txtNo.Size = new Size(161, 27);
            txtNo.TabIndex = 3;
            // 
            // txtName
            // 
            txtName.Location = new Point(979, 83);
            txtName.Name = "txtName";
            txtName.Size = new Size(161, 27);
            txtName.TabIndex = 1;
            // 
            // btnSelect
            // 
            btnSelect.Location = new Point(525, 441);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(132, 29);
            btnSelect.TabIndex = 17;
            btnSelect.Text = "Öğrenci Seç";
            btnSelect.UseVisualStyleBackColor = true;
            btnSelect.Click += btnSelect_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(388, 405);
            label2.Name = "label2";
            label2.Size = new Size(269, 20);
            label2.TabIndex = 18;
            label2.Text = "Düzenlemek İstediğiniz Öğrenciyi Seçin";
            // 
            // goMain
            // 
            goMain.Location = new Point(1201, 463);
            goMain.Name = "goMain";
            goMain.Size = new Size(94, 29);
            goMain.TabIndex = 19;
            goMain.Text = "Ana menü";
            goMain.UseVisualStyleBackColor = true;
            goMain.Click += goMain_Click;
            // 
            // OgrenciDuzenleme
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1409, 571);
            Controls.Add(goMain);
            Controls.Add(label2);
            Controls.Add(btnSelect);
            Controls.Add(lblSurname);
            Controls.Add(lblNo);
            Controls.Add(lblName);
            Controls.Add(txtSurname);
            Controls.Add(txtNo);
            Controls.Add(txtName);
            Controls.Add(btnDuzenle);
            Controls.Add(dgwListe);
            Controls.Add(label1);
            Name = "OgrenciDuzenleme";
            Text = "OgrenciDuzenleme";
            Load += OgrenciDuzenleme_Load;
            ((System.ComponentModel.ISupportInitialize)dgwListe).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgwListe;
        private Button btnDuzenle;
        private Label lblSurname;
        private Label lblNo;
        private Label lblName;
        private TextBox txtSurname;
        private TextBox txtNo;
        private TextBox txtName;
        private Button btnSelect;
        private Label label2;
        private Button goMain;
    }
}