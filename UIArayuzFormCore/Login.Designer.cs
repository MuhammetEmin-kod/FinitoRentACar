namespace UIArayuzFormCore
{
    partial class Login
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
            this.btn_Finito = new System.Windows.Forms.Button();
            this.btn_Log = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_KulSif = new System.Windows.Forms.TextBox();
            this.txt_KulAd = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Finito
            // 
            this.btn_Finito.BackgroundImage = global::UIArayuzFormCore.Properties.Resources.FINiTrentacar;
            this.btn_Finito.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Finito.FlatAppearance.BorderSize = 0;
            this.btn_Finito.Location = new System.Drawing.Point(456, 99);
            this.btn_Finito.Name = "btn_Finito";
            this.btn_Finito.Size = new System.Drawing.Size(452, 244);
            this.btn_Finito.TabIndex = 16;
            this.btn_Finito.UseVisualStyleBackColor = true;
            // 
            // btn_Log
            // 
            this.btn_Log.BackColor = System.Drawing.Color.Transparent;
            this.btn_Log.BackgroundImage = global::UIArayuzFormCore.Properties.Resources.girişyap;
            this.btn_Log.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Log.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Log.FlatAppearance.BorderSize = 0;
            this.btn_Log.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Log.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Log.ForeColor = System.Drawing.Color.Turquoise;
            this.btn_Log.Location = new System.Drawing.Point(685, 428);
            this.btn_Log.Name = "btn_Log";
            this.btn_Log.Size = new System.Drawing.Size(124, 127);
            this.btn_Log.TabIndex = 15;
            this.btn_Log.UseVisualStyleBackColor = false;
            this.btn_Log.Click += new System.EventHandler(this.btn_Log_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(382, 387);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 23);
            this.label2.TabIndex = 13;
            this.label2.Text = "Sifre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(301, 349);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 23);
            this.label1.TabIndex = 14;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // txt_KulSif
            // 
            this.txt_KulSif.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_KulSif.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_KulSif.ForeColor = System.Drawing.Color.Black;
            this.txt_KulSif.Location = new System.Drawing.Point(456, 387);
            this.txt_KulSif.Name = "txt_KulSif";
            this.txt_KulSif.Size = new System.Drawing.Size(353, 22);
            this.txt_KulSif.TabIndex = 12;
            // 
            // txt_KulAd
            // 
            this.txt_KulAd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_KulAd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_KulAd.ForeColor = System.Drawing.Color.Black;
            this.txt_KulAd.Location = new System.Drawing.Point(456, 349);
            this.txt_KulAd.Name = "txt_KulAd";
            this.txt_KulAd.Size = new System.Drawing.Size(353, 22);
            this.txt_KulAd.TabIndex = 11;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 766);
            this.Controls.Add(this.btn_Finito);
            this.Controls.Add(this.btn_Log);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_KulSif);
            this.Controls.Add(this.txt_KulAd);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_Finito;
        private Button btn_Log;
        private Label label2;
        private Label label1;
        private TextBox txt_KulSif;
        private TextBox txt_KulAd;
    }
}