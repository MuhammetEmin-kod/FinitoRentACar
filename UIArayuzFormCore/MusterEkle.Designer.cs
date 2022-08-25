namespace UIArayuzFormCore
{
    partial class MusterEkle
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
            this.txt_Tel = new System.Windows.Forms.MaskedTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_Adr = new System.Windows.Forms.TextBox();
            this.txt_MusSoy = new System.Windows.Forms.TextBox();
            this.txt_Mail = new System.Windows.Forms.TextBox();
            this.txt_MusAd = new System.Windows.Forms.TextBox();
            this.txt_Tc = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_Tel
            // 
            this.txt_Tel.Location = new System.Drawing.Point(162, 192);
            this.txt_Tel.Mask = "0(999) 000-0000";
            this.txt_Tel.Name = "txt_Tel";
            this.txt_Tel.Size = new System.Drawing.Size(100, 23);
            this.txt_Tel.TabIndex = 26;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(69, 279);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 28);
            this.button2.TabIndex = 25;
            this.button2.Text = "İptal";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(173, 279);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 28);
            this.button1.TabIndex = 24;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_Adr
            // 
            this.txt_Adr.Location = new System.Drawing.Point(162, 232);
            this.txt_Adr.Name = "txt_Adr";
            this.txt_Adr.Size = new System.Drawing.Size(100, 23);
            this.txt_Adr.TabIndex = 22;
            // 
            // txt_MusSoy
            // 
            this.txt_MusSoy.Location = new System.Drawing.Point(162, 108);
            this.txt_MusSoy.Name = "txt_MusSoy";
            this.txt_MusSoy.Size = new System.Drawing.Size(100, 23);
            this.txt_MusSoy.TabIndex = 23;
            // 
            // txt_Mail
            // 
            this.txt_Mail.Location = new System.Drawing.Point(162, 150);
            this.txt_Mail.Name = "txt_Mail";
            this.txt_Mail.Size = new System.Drawing.Size(100, 23);
            this.txt_Mail.TabIndex = 19;
            // 
            // txt_MusAd
            // 
            this.txt_MusAd.Location = new System.Drawing.Point(162, 65);
            this.txt_MusAd.Name = "txt_MusAd";
            this.txt_MusAd.Size = new System.Drawing.Size(100, 23);
            this.txt_MusAd.TabIndex = 21;
            // 
            // txt_Tc
            // 
            this.txt_Tc.Location = new System.Drawing.Point(162, 27);
            this.txt_Tc.Name = "txt_Tc";
            this.txt_Tc.Size = new System.Drawing.Size(100, 23);
            this.txt_Tc.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(124, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 30);
            this.label7.TabIndex = 18;
            this.label7.Text = "TC:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(94, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 30);
            this.label5.TabIndex = 17;
            this.label5.Text = "Adres:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(80, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 30);
            this.label4.TabIndex = 16;
            this.label4.Text = "Telefon:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(107, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 30);
            this.label3.TabIndex = 15;
            this.label3.Text = "Mail:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(15, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 30);
            this.label2.TabIndex = 14;
            this.label2.Text = "Müşteri Soyad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(45, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 30);
            this.label1.TabIndex = 13;
            this.label1.Text = "Müşteri Ad:";
            // 
            // MusterEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 571);
            this.Controls.Add(this.txt_Tel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_Adr);
            this.Controls.Add(this.txt_MusSoy);
            this.Controls.Add(this.txt_Mail);
            this.Controls.Add(this.txt_MusAd);
            this.Controls.Add(this.txt_Tc);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MusterEkle";
            this.Text = "MusterEkle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaskedTextBox txt_Tel;
        private Button button2;
        private Button button1;
        private TextBox txt_Adr;
        private TextBox txt_MusSoy;
        private TextBox txt_Mail;
        private TextBox txt_MusAd;
        private TextBox txt_Tc;
        private Label label7;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}