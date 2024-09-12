namespace sosyalKutuphane
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gradientPanel1 = new sosyalKutuphane.gradientPanel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.sifreText = new System.Windows.Forms.TextBox();
            this.tcText = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.elipseTool1 = new ElipseToolDemo.ElipseTool();
            this.elipseTool2 = new ElipseToolDemo.ElipseTool();
            this.elipseTool3 = new ElipseToolDemo.ElipseTool();
            this.elipseTool4 = new ElipseToolDemo.ElipseTool();
            this.elipseTool5 = new ElipseToolDemo.ElipseTool();
            this.elipseTool6 = new ElipseToolDemo.ElipseTool();
            this.elipseTool7 = new ElipseToolDemo.ElipseTool();
            this.elipseTool8 = new ElipseToolDemo.ElipseTool();
            this.elipseTool9 = new ElipseToolDemo.ElipseTool();
            this.gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.BackgroundImage = global::sosyalKutuphane.Properties.Resources.OIG4;
            this.gradientPanel1.ColorBottom = System.Drawing.Color.Transparent;
            this.gradientPanel1.ColorTop = System.Drawing.Color.Transparent;
            this.gradientPanel1.Controls.Add(this.pictureBox3);
            this.gradientPanel1.Controls.Add(this.sifreText);
            this.gradientPanel1.Controls.Add(this.tcText);
            this.gradientPanel1.Controls.Add(this.button2);
            this.gradientPanel1.Controls.Add(this.button1);
            this.gradientPanel1.Controls.Add(this.pictureBox1);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(994, 1016);
            this.gradientPanel1.TabIndex = 0;
            this.gradientPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.gradientPanel1_Paint);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::sosyalKutuphane.Properties.Resources.png1;
            this.pictureBox3.Location = new System.Drawing.Point(422, 274);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(150, 150);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // sifreText
            // 
            this.sifreText.BackColor = System.Drawing.Color.White;
            this.sifreText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifreText.ForeColor = System.Drawing.Color.Gray;
            this.sifreText.Location = new System.Drawing.Point(323, 519);
            this.sifreText.Multiline = true;
            this.sifreText.Name = "sifreText";
            this.sifreText.Size = new System.Drawing.Size(374, 50);
            this.sifreText.TabIndex = 7;
            this.sifreText.Text = "Şifre";
            this.sifreText.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.sifreText.Enter += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // tcText
            // 
            this.tcText.BackColor = System.Drawing.Color.White;
            this.tcText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tcText.ForeColor = System.Drawing.Color.Gray;
            this.tcText.Location = new System.Drawing.Point(323, 441);
            this.tcText.Multiline = true;
            this.tcText.Name = "tcText";
            this.tcText.Size = new System.Drawing.Size(374, 50);
            this.tcText.TabIndex = 6;
            this.tcText.Text = "TC. Kimlik No";
            this.tcText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.tcText.Enter += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button2.Location = new System.Drawing.Point(446, 700);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 50);
            this.button2.TabIndex = 5;
            this.button2.Text = "KAYIT OL";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Location = new System.Drawing.Point(446, 635);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 50);
            this.button1.TabIndex = 4;
            this.button1.Text = "GİRİŞ YAP";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::sosyalKutuphane.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(30, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // elipseTool1
            // 
            this.elipseTool1.CornerRadius = 90;
            this.elipseTool1.TargetControl = null;
            // 
            // elipseTool2
            // 
            this.elipseTool2.CornerRadius = 100;
            this.elipseTool2.TargetControl = null;
            // 
            // elipseTool3
            // 
            this.elipseTool3.CornerRadius = 100;
            this.elipseTool3.TargetControl = null;
            // 
            // elipseTool4
            // 
            this.elipseTool4.CornerRadius = 20;
            this.elipseTool4.TargetControl = this.tcText;
            // 
            // elipseTool5
            // 
            this.elipseTool5.CornerRadius = 20;
            this.elipseTool5.TargetControl = this.sifreText;
            // 
            // elipseTool6
            // 
            this.elipseTool6.CornerRadius = 40;
            this.elipseTool6.TargetControl = this.button1;
            // 
            // elipseTool7
            // 
            this.elipseTool7.CornerRadius = 40;
            this.elipseTool7.TargetControl = this.button2;
            // 
            // elipseTool8
            // 
            this.elipseTool8.CornerRadius = 200;
            this.elipseTool8.TargetControl = this.pictureBox3;
            // 
            // elipseTool9
            // 
            this.elipseTool9.CornerRadius = 300;
            this.elipseTool9.TargetControl = this.pictureBox3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(994, 1016);
            this.Controls.Add(this.gradientPanel1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private gradientPanel gradientPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox sifreText;
        private System.Windows.Forms.TextBox tcText;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private ElipseToolDemo.ElipseTool elipseTool1;
        private ElipseToolDemo.ElipseTool elipseTool2;
        private ElipseToolDemo.ElipseTool elipseTool3;
        private ElipseToolDemo.ElipseTool elipseTool4;
        private ElipseToolDemo.ElipseTool elipseTool5;
        private ElipseToolDemo.ElipseTool elipseTool6;
        private ElipseToolDemo.ElipseTool elipseTool7;
        private System.Windows.Forms.PictureBox pictureBox3;
        private ElipseToolDemo.ElipseTool elipseTool8;
        private ElipseToolDemo.ElipseTool elipseTool9;
    }
}

