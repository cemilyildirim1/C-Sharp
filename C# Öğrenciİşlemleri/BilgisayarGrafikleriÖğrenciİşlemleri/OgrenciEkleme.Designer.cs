namespace BilgisayarGrafikleriÖğrenciİşlemleri
{
    partial class OgrenciEkleme
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
            btnOgrenciEkle = new Button();
            txtName = new TextBox();
            txtNo = new TextBox();
            txtSurname = new TextBox();
            lblName = new Label();
            lblNo = new Label();
            lblSurname = new Label();
            goMain = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(620, 18);
            label1.Name = "label1";
            label1.Size = new Size(157, 20);
            label1.TabIndex = 0;
            label1.Text = "Ogrenci Ekleme Ekranı";
            // 
            // btnOgrenciEkle
            // 
            btnOgrenciEkle.Location = new Point(653, 285);
            btnOgrenciEkle.Name = "btnOgrenciEkle";
            btnOgrenciEkle.Size = new Size(128, 29);
            btnOgrenciEkle.TabIndex = 4;
            btnOgrenciEkle.Text = "Ekle";
            btnOgrenciEkle.UseVisualStyleBackColor = true;
            btnOgrenciEkle.Click += btnOgrenciEkle_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(620, 110);
            txtName.Name = "txtName";
            txtName.Size = new Size(161, 27);
            txtName.TabIndex = 1;
            // 
            // txtNo
            // 
            txtNo.Location = new Point(620, 217);
            txtNo.Name = "txtNo";
            txtNo.Size = new Size(161, 27);
            txtNo.TabIndex = 3;
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(620, 163);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(161, 27);
            txtSurname.TabIndex = 2;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(472, 110);
            lblName.Name = "lblName";
            lblName.Size = new Size(99, 20);
            lblName.TabIndex = 6;
            lblName.Text = "Öğrenci İsmi :";
            // 
            // lblNo
            // 
            lblNo.AutoSize = true;
            lblNo.Location = new Point(472, 224);
            lblNo.Name = "lblNo";
            lblNo.Size = new Size(135, 20);
            lblNo.TabIndex = 7;
            lblNo.Text = "Öğrenci Numarası :";
            // 
            // lblSurname
            // 
            lblSurname.AutoSize = true;
            lblSurname.Location = new Point(472, 160);
            lblSurname.Name = "lblSurname";
            lblSurname.Size = new Size(113, 20);
            lblSurname.TabIndex = 9;
            lblSurname.Text = "Öğrenci Soyad :";
            // 
            // goMain
            // 
            goMain.Location = new Point(1169, 347);
            goMain.Name = "goMain";
            goMain.Size = new Size(94, 29);
            goMain.TabIndex = 10;
            goMain.Text = "Ana menü";
            goMain.UseVisualStyleBackColor = true;
            goMain.Click += goMain_Click;
            // 
            // OgrenciEkleme
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1436, 450);
            Controls.Add(goMain);
            Controls.Add(lblSurname);
            Controls.Add(lblNo);
            Controls.Add(lblName);
            Controls.Add(txtSurname);
            Controls.Add(txtNo);
            Controls.Add(txtName);
            Controls.Add(btnOgrenciEkle);
            Controls.Add(label1);
            Name = "OgrenciEkleme";
            Text = "Ogrenci Ekleme";
            Load += OgrenciEkleme_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnOgrenciEkle;
        private TextBox txtName;
        private TextBox txtNo;
        private TextBox txtSurname;
        private Label lblName;
        private Label lblNo;
        private Label lblSurname;
        private Button goMain;
    }
}