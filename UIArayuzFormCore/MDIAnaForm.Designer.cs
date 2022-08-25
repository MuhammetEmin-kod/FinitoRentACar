namespace UIArayuzFormCore
{
    partial class MDIAnaForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDIAnaForm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btn_Sts = new System.Windows.Forms.Button();
            this.btn_Arbkyt = new System.Windows.Forms.Button();
            this.btn_Sözl = new System.Windows.Forms.Button();
            this.btn_MusLis = new System.Windows.Forms.Button();
            this.btn_ArbLis = new System.Windows.Forms.Button();
            this.btn_MusEkl = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::UIArayuzFormCore.Properties.Resources.kiralik_oto_ankara;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 197);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1787, 781);
            this.panel2.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btn_Sts);
            this.panel1.Controls.Add(this.btn_Arbkyt);
            this.panel1.Controls.Add(this.btn_Sözl);
            this.panel1.Controls.Add(this.btn_MusLis);
            this.panel1.Controls.Add(this.btn_ArbLis);
            this.panel1.Controls.Add(this.btn_MusEkl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1787, 197);
            this.panel1.TabIndex = 2;
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button7.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button7.ImageIndex = 1;
            this.button7.ImageList = this.imageList1;
            this.button7.Location = new System.Drawing.Point(1570, 38);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(205, 117);
            this.button7.TabIndex = 3;
            this.button7.Text = "Çıkış";
            this.button7.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "car.png");
            this.imageList1.Images.SetKeyName(1, "cıkıs.png");
            this.imageList1.Images.SetKeyName(2, "listcars.png");
            this.imageList1.Images.SetKeyName(3, "listele.png");
            this.imageList1.Images.SetKeyName(4, "musekle.png");
            this.imageList1.Images.SetKeyName(5, "satislar.png");
            this.imageList1.Images.SetKeyName(6, "sozlesme.png");
            this.imageList1.Images.SetKeyName(7, "login.png");
            // 
            // btn_Sts
            // 
            this.btn_Sts.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Sts.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Sts.ImageKey = "satislar.png";
            this.btn_Sts.ImageList = this.imageList1;
            this.btn_Sts.Location = new System.Drawing.Point(1134, 38);
            this.btn_Sts.Name = "btn_Sts";
            this.btn_Sts.Size = new System.Drawing.Size(205, 117);
            this.btn_Sts.TabIndex = 2;
            this.btn_Sts.Text = "Satışlar";
            this.btn_Sts.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Sts.UseVisualStyleBackColor = true;
            this.btn_Sts.Click += new System.EventHandler(this.btn_Sts_Click);
            // 
            // btn_Arbkyt
            // 
            this.btn_Arbkyt.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Arbkyt.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Arbkyt.ImageIndex = 0;
            this.btn_Arbkyt.ImageList = this.imageList1;
            this.btn_Arbkyt.Location = new System.Drawing.Point(472, 38);
            this.btn_Arbkyt.Name = "btn_Arbkyt";
            this.btn_Arbkyt.Size = new System.Drawing.Size(205, 117);
            this.btn_Arbkyt.TabIndex = 2;
            this.btn_Arbkyt.Text = "Araba Kayıt";
            this.btn_Arbkyt.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Arbkyt.UseVisualStyleBackColor = true;
            this.btn_Arbkyt.Click += new System.EventHandler(this.btn_Arbkyt_Click);
            // 
            // btn_Sözl
            // 
            this.btn_Sözl.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Sözl.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Sözl.ImageKey = "sozlesme.png";
            this.btn_Sözl.ImageList = this.imageList1;
            this.btn_Sözl.Location = new System.Drawing.Point(914, 38);
            this.btn_Sözl.Name = "btn_Sözl";
            this.btn_Sözl.Size = new System.Drawing.Size(205, 117);
            this.btn_Sözl.TabIndex = 1;
            this.btn_Sözl.Text = "Sözleşme ";
            this.btn_Sözl.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Sözl.UseVisualStyleBackColor = true;
            this.btn_Sözl.Click += new System.EventHandler(this.btn_Sözl_Click);
            // 
            // btn_MusLis
            // 
            this.btn_MusLis.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_MusLis.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_MusLis.ImageKey = "listele.png";
            this.btn_MusLis.ImageList = this.imageList1;
            this.btn_MusLis.Location = new System.Drawing.Point(251, 38);
            this.btn_MusLis.Name = "btn_MusLis";
            this.btn_MusLis.Size = new System.Drawing.Size(205, 117);
            this.btn_MusLis.TabIndex = 1;
            this.btn_MusLis.Text = "Müşteri Listele";
            this.btn_MusLis.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_MusLis.UseVisualStyleBackColor = true;
            this.btn_MusLis.Click += new System.EventHandler(this.btn_MusLis_Click);
            // 
            // btn_ArbLis
            // 
            this.btn_ArbLis.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_ArbLis.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_ArbLis.ImageKey = "listcars.png";
            this.btn_ArbLis.ImageList = this.imageList1;
            this.btn_ArbLis.Location = new System.Drawing.Point(693, 38);
            this.btn_ArbLis.Name = "btn_ArbLis";
            this.btn_ArbLis.Size = new System.Drawing.Size(205, 117);
            this.btn_ArbLis.TabIndex = 0;
            this.btn_ArbLis.Text = "Araba Listele";
            this.btn_ArbLis.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_ArbLis.UseVisualStyleBackColor = true;
            this.btn_ArbLis.Click += new System.EventHandler(this.btn_ArbLis_Click);
            // 
            // btn_MusEkl
            // 
            this.btn_MusEkl.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_MusEkl.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_MusEkl.ImageKey = "musekle.png";
            this.btn_MusEkl.ImageList = this.imageList1;
            this.btn_MusEkl.Location = new System.Drawing.Point(31, 38);
            this.btn_MusEkl.Name = "btn_MusEkl";
            this.btn_MusEkl.Size = new System.Drawing.Size(205, 117);
            this.btn_MusEkl.TabIndex = 0;
            this.btn_MusEkl.Text = "Müşteri Ekle";
            this.btn_MusEkl.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_MusEkl.UseVisualStyleBackColor = true;
            this.btn_MusEkl.Click += new System.EventHandler(this.btn_MusEkl_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.ImageIndex = 7;
            this.button1.ImageList = this.imageList1;
            this.button1.Location = new System.Drawing.Point(1354, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(205, 117);
            this.button1.TabIndex = 4;
            this.button1.Text = "Kullanıcılar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MDIAnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1787, 978);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "MDIAnaForm";
            this.Text = "MDIAnaForm";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel2;
        private Panel panel1;
        private Button button7;
        private ImageList imageList1;
        private Button btn_Sts;
        private Button btn_Arbkyt;
        private Button btn_Sözl;
        private Button btn_MusLis;
        private Button btn_ArbLis;
        private Button btn_MusEkl;
        private Button button1;
    }
}