namespace weeklab5
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.phonetextbox = new System.Windows.Forms.TextBox();
            this.nametextbox = new System.Windows.Forms.TextBox();
            this.agetextbox = new System.Windows.Forms.TextBox();
            this.daycombobox = new System.Windows.Forms.ComboBox();
            this.moviecombobox = new System.Windows.Forms.ComboBox();
            this.sessioncombobox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.MediumBlue;
            this.label1.Location = new System.Drawing.Point(253, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "HKU CINEMA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name Surname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Phone number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(96, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Day";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(594, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Age";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(594, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "movie";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(594, 283);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Session";
            // 
            // phonetextbox
            // 
            this.phonetextbox.Location = new System.Drawing.Point(58, 214);
            this.phonetextbox.Name = "phonetextbox";
            this.phonetextbox.Size = new System.Drawing.Size(121, 20);
            this.phonetextbox.TabIndex = 7;
            // 
            // nametextbox
            // 
            this.nametextbox.Location = new System.Drawing.Point(58, 115);
            this.nametextbox.Name = "nametextbox";
            this.nametextbox.Size = new System.Drawing.Size(121, 20);
            this.nametextbox.TabIndex = 8;
            // 
            // agetextbox
            // 
            this.agetextbox.Location = new System.Drawing.Point(556, 105);
            this.agetextbox.Name = "agetextbox";
            this.agetextbox.Size = new System.Drawing.Size(121, 20);
            this.agetextbox.TabIndex = 9;
            // 
            // daycombobox
            // 
            this.daycombobox.FormattingEnabled = true;
            this.daycombobox.Location = new System.Drawing.Point(58, 327);
            this.daycombobox.Name = "daycombobox";
            this.daycombobox.Size = new System.Drawing.Size(121, 21);
            this.daycombobox.TabIndex = 10;
            // 
            // moviecombobox
            // 
            this.moviecombobox.FormattingEnabled = true;
            this.moviecombobox.Location = new System.Drawing.Point(556, 224);
            this.moviecombobox.Name = "moviecombobox";
            this.moviecombobox.Size = new System.Drawing.Size(121, 21);
            this.moviecombobox.TabIndex = 11;
            this.moviecombobox.SelectedIndexChanged += new System.EventHandler(this.moviecombobox_SelectedIndexChanged);
            // 
            // sessioncombobox
            // 
            this.sessioncombobox.FormattingEnabled = true;
            this.sessioncombobox.Location = new System.Drawing.Point(544, 327);
            this.sessioncombobox.Name = "sessioncombobox";
            this.sessioncombobox.Size = new System.Drawing.Size(121, 21);
            this.sessioncombobox.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(325, 371);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Buy Ticket";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.sessioncombobox);
            this.Controls.Add(this.moviecombobox);
            this.Controls.Add(this.daycombobox);
            this.Controls.Add(this.agetextbox);
            this.Controls.Add(this.nametextbox);
            this.Controls.Add(this.phonetextbox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox phonetextbox;
        private System.Windows.Forms.TextBox nametextbox;
        private System.Windows.Forms.TextBox agetextbox;
        private System.Windows.Forms.ComboBox daycombobox;
        private System.Windows.Forms.ComboBox moviecombobox;
        private System.Windows.Forms.ComboBox sessioncombobox;
        private System.Windows.Forms.Button button1;
    }
}

