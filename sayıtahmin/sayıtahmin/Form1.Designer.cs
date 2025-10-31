namespace sayıtahmin
{
    partial class Form1
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
            btnKontrol = new Button();
            lblGecmis = new Label();
            tbxTahmin = new TextBox();
            label1 = new Label();
            btnReset = new Button();
            rtbxSonuc = new RichTextBox();
            SuspendLayout();
            // 
            // btnKontrol
            // 
            btnKontrol.Font = new Font("Segoe UI", 14F);
            btnKontrol.Location = new Point(232, 76);
            btnKontrol.Name = "btnKontrol";
            btnKontrol.Size = new Size(154, 47);
            btnKontrol.TabIndex = 0;
            btnKontrol.Text = "Kontrol et";
            btnKontrol.UseVisualStyleBackColor = true;
            btnKontrol.Click += btnKontrol_Click;
            // 
            // lblGecmis
            // 
            lblGecmis.AutoSize = true;
            lblGecmis.Font = new Font("Segoe UI", 14F);
            lblGecmis.Location = new Point(12, 126);
            lblGecmis.Name = "lblGecmis";
            lblGecmis.Size = new Size(214, 25);
            lblGecmis.TabIndex = 2;
            lblGecmis.Text = "Geçmiş Denemeleriniz : ";
            // 
            // tbxTahmin
            // 
            tbxTahmin.Font = new Font("Segoe UI", 22F);
            tbxTahmin.Location = new Point(12, 76);
            tbxTahmin.MaxLength = 3;
            tbxTahmin.Name = "tbxTahmin";
            tbxTahmin.Size = new Size(214, 47);
            tbxTahmin.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25F);
            label1.Location = new Point(45, 9);
            label1.Name = "label1";
            label1.Size = new Size(302, 46);
            label1.TabIndex = 4;
            label1.Text = "Sayı Tahmin Oyunu";
            // 
            // btnReset
            // 
            btnReset.Font = new Font("Segoe UI", 14F);
            btnReset.Location = new Point(232, 154);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(154, 47);
            btnReset.TabIndex = 5;
            btnReset.Text = "Yeniden Başla";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // rtbxSonuc
            // 
            rtbxSonuc.Location = new Point(12, 154);
            rtbxSonuc.Name = "rtbxSonuc";
            rtbxSonuc.ReadOnly = true;
            rtbxSonuc.Size = new Size(214, 284);
            rtbxSonuc.TabIndex = 6;
            rtbxSonuc.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(398, 450);
            Controls.Add(rtbxSonuc);
            Controls.Add(btnReset);
            Controls.Add(label1);
            Controls.Add(tbxTahmin);
            Controls.Add(lblGecmis);
            Controls.Add(btnKontrol);
            Name = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnKontrol;
        private Label lblGecmis;
        private TextBox tbxTahmin;
        private Label label1;
        private Button btnReset;
        private RichTextBox rtbxSonuc;
    }
}
