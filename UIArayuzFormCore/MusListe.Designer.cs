namespace UIArayuzFormCore
{
    partial class MusListe
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
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_Gcll = new System.Windows.Forms.Button();
            this.dtg_Mst = new System.Windows.Forms.DataGridView();
            this.btn_Dlt = new System.Windows.Forms.Button();
            this.btn_Listele = new System.Windows.Forms.Button();
            this.txt_Adr = new System.Windows.Forms.TextBox();
            this.txt_MusSoy = new System.Windows.Forms.TextBox();
            this.txt_Mail = new System.Windows.Forms.TextBox();
            this.txt_MusAd = new System.Windows.Forms.TextBox();
            this.txt_Tc = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Mst)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Tel
            // 
            this.txt_Tel.Location = new System.Drawing.Point(166, 266);
            this.txt_Tel.Mask = "0(999) 000-0000";
            this.txt_Tel.Name = "txt_Tel";
            this.txt_Tel.Size = new System.Drawing.Size(100, 23);
            this.txt_Tel.TabIndex = 50;
            // 
            // txt_Id
            // 
            this.txt_Id.Location = new System.Drawing.Point(166, 66);
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.Size = new System.Drawing.Size(100, 23);
            this.txt_Id.TabIndex = 49;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(253, 535);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(912, 65);
            this.label6.TabIndex = 48;
            this.label6.Text = "Unutmayın Müşteri ID\'si Güncellenemez!!!";
            // 
            // btn_Gcll
            // 
            this.btn_Gcll.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Gcll.Location = new System.Drawing.Point(168, 383);
            this.btn_Gcll.Name = "btn_Gcll";
            this.btn_Gcll.Size = new System.Drawing.Size(98, 28);
            this.btn_Gcll.TabIndex = 47;
            this.btn_Gcll.Text = "Güncelle";
            this.btn_Gcll.UseVisualStyleBackColor = true;
            this.btn_Gcll.Click += new System.EventHandler(this.btn_Gcll_Click);
            // 
            // dtg_Mst
            // 
            this.dtg_Mst.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Mst.Location = new System.Drawing.Point(294, 64);
            this.dtg_Mst.Name = "dtg_Mst";
            this.dtg_Mst.RowTemplate.Height = 25;
            this.dtg_Mst.Size = new System.Drawing.Size(871, 455);
            this.dtg_Mst.TabIndex = 46;
            this.dtg_Mst.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_Mst_CellClick);
            // 
            // btn_Dlt
            // 
            this.btn_Dlt.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Dlt.Location = new System.Drawing.Point(168, 417);
            this.btn_Dlt.Name = "btn_Dlt";
            this.btn_Dlt.Size = new System.Drawing.Size(98, 28);
            this.btn_Dlt.TabIndex = 45;
            this.btn_Dlt.Text = "Sil";
            this.btn_Dlt.UseVisualStyleBackColor = true;
            this.btn_Dlt.Click += new System.EventHandler(this.btn_Dlt_Click);
            // 
            // btn_Listele
            // 
            this.btn_Listele.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Listele.Location = new System.Drawing.Point(168, 349);
            this.btn_Listele.Name = "btn_Listele";
            this.btn_Listele.Size = new System.Drawing.Size(98, 28);
            this.btn_Listele.TabIndex = 44;
            this.btn_Listele.Text = "Listele";
            this.btn_Listele.UseVisualStyleBackColor = true;
            this.btn_Listele.Click += new System.EventHandler(this.btn_Listele_Click);
            // 
            // txt_Adr
            // 
            this.txt_Adr.Location = new System.Drawing.Point(166, 308);
            this.txt_Adr.Name = "txt_Adr";
            this.txt_Adr.Size = new System.Drawing.Size(100, 23);
            this.txt_Adr.TabIndex = 42;
            // 
            // txt_MusSoy
            // 
            this.txt_MusSoy.Location = new System.Drawing.Point(166, 184);
            this.txt_MusSoy.Name = "txt_MusSoy";
            this.txt_MusSoy.Size = new System.Drawing.Size(100, 23);
            this.txt_MusSoy.TabIndex = 43;
            // 
            // txt_Mail
            // 
            this.txt_Mail.Location = new System.Drawing.Point(166, 226);
            this.txt_Mail.Name = "txt_Mail";
            this.txt_Mail.Size = new System.Drawing.Size(100, 23);
            this.txt_Mail.TabIndex = 39;
            // 
            // txt_MusAd
            // 
            this.txt_MusAd.Location = new System.Drawing.Point(166, 141);
            this.txt_MusAd.Name = "txt_MusAd";
            this.txt_MusAd.Size = new System.Drawing.Size(100, 23);
            this.txt_MusAd.TabIndex = 41;
            // 
            // txt_Tc
            // 
            this.txt_Tc.Location = new System.Drawing.Point(166, 103);
            this.txt_Tc.Name = "txt_Tc";
            this.txt_Tc.Size = new System.Drawing.Size(100, 23);
            this.txt_Tc.TabIndex = 40;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(130, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 30);
            this.label8.TabIndex = 38;
            this.label8.Text = "ID:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(128, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 30);
            this.label7.TabIndex = 37;
            this.label7.Text = "TC:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(98, 299);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 30);
            this.label5.TabIndex = 36;
            this.label5.Text = "Adres:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(84, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 30);
            this.label4.TabIndex = 35;
            this.label4.Text = "Telefon:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(111, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 30);
            this.label3.TabIndex = 34;
            this.label3.Text = "Mail:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(19, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 30);
            this.label2.TabIndex = 33;
            this.label2.Text = "Müşteri Soyad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(49, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 30);
            this.label1.TabIndex = 32;
            this.label1.Text = "Müşteri Ad:";
            // 
            // MusListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1523, 896);
            this.Controls.Add(this.txt_Tel);
            this.Controls.Add(this.txt_Id);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_Gcll);
            this.Controls.Add(this.dtg_Mst);
            this.Controls.Add(this.btn_Dlt);
            this.Controls.Add(this.btn_Listele);
            this.Controls.Add(this.txt_Adr);
            this.Controls.Add(this.txt_MusSoy);
            this.Controls.Add(this.txt_Mail);
            this.Controls.Add(this.txt_MusAd);
            this.Controls.Add(this.txt_Tc);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MusListe";
            this.Text = "MusListe";
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Mst)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaskedTextBox txt_Tel;
        private TextBox txt_Id;
        private Label label6;
        private Button btn_Gcll;
        private DataGridView dtg_Mst;
        private Button btn_Dlt;
        private Button btn_Listele;
        private TextBox txt_Adr;
        private TextBox txt_MusSoy;
        private TextBox txt_Mail;
        private TextBox txt_MusAd;
        private TextBox txt_Tc;
        private Label label8;
        private Label label7;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}