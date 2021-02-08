namespace WindowsFormsApp1
{
    partial class Form1
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
            this.CurrencycomboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.resultlabel = new System.Windows.Forms.Label();
            this.BalancetextBox = new System.Windows.Forms.TextBox();
            this.AmounttextBox = new System.Windows.Forms.TextBox();
            this.Createbutton = new System.Windows.Forms.Button();
            this.Depositbutton = new System.Windows.Forms.Button();
            this.Withdrawbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CurrencycomboBox
            // 
            this.CurrencycomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CurrencycomboBox.FormattingEnabled = true;
            this.CurrencycomboBox.Location = new System.Drawing.Point(75, 75);
            this.CurrencycomboBox.Name = "CurrencycomboBox";
            this.CurrencycomboBox.Size = new System.Drawing.Size(121, 21);
            this.CurrencycomboBox.TabIndex = 0;
            this.CurrencycomboBox.SelectedIndexChanged += new System.EventHandler(this.CurrencycomboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Currency";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Balance";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(393, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Amount";
            // 
            // resultlabel
            // 
            this.resultlabel.AutoSize = true;
            this.resultlabel.Location = new System.Drawing.Point(687, 185);
            this.resultlabel.Name = "resultlabel";
            this.resultlabel.Size = new System.Drawing.Size(46, 13);
            this.resultlabel.TabIndex = 4;
            this.resultlabel.Text = "Balance";
            this.resultlabel.Click += new System.EventHandler(this.resultlabel_Click);
            // 
            // BalancetextBox
            // 
            this.BalancetextBox.Location = new System.Drawing.Point(75, 178);
            this.BalancetextBox.Name = "BalancetextBox";
            this.BalancetextBox.Size = new System.Drawing.Size(100, 20);
            this.BalancetextBox.TabIndex = 6;
            this.BalancetextBox.TextChanged += new System.EventHandler(this.BalancetextBox_TextChanged);
            // 
            // AmounttextBox
            // 
            this.AmounttextBox.Location = new System.Drawing.Point(396, 97);
            this.AmounttextBox.Name = "AmounttextBox";
            this.AmounttextBox.Size = new System.Drawing.Size(100, 20);
            this.AmounttextBox.TabIndex = 7;
            this.AmounttextBox.TextChanged += new System.EventHandler(this.AmounttextBox_TextChanged);
            // 
            // Createbutton
            // 
            this.Createbutton.Location = new System.Drawing.Point(75, 247);
            this.Createbutton.Name = "Createbutton";
            this.Createbutton.Size = new System.Drawing.Size(75, 23);
            this.Createbutton.TabIndex = 8;
            this.Createbutton.Text = "Create acc.";
            this.Createbutton.UseVisualStyleBackColor = true;
            this.Createbutton.Click += new System.EventHandler(this.Createbutton_Click);
            // 
            // Depositbutton
            // 
            this.Depositbutton.Location = new System.Drawing.Point(396, 166);
            this.Depositbutton.Name = "Depositbutton";
            this.Depositbutton.Size = new System.Drawing.Size(75, 23);
            this.Depositbutton.TabIndex = 9;
            this.Depositbutton.Text = "Deposit";
            this.Depositbutton.UseVisualStyleBackColor = true;
            this.Depositbutton.Click += new System.EventHandler(this.Depositbutton_Click);
            // 
            // Withdrawbutton
            // 
            this.Withdrawbutton.Location = new System.Drawing.Point(396, 247);
            this.Withdrawbutton.Name = "Withdrawbutton";
            this.Withdrawbutton.Size = new System.Drawing.Size(75, 23);
            this.Withdrawbutton.TabIndex = 10;
            this.Withdrawbutton.Text = "Withdraw";
            this.Withdrawbutton.UseVisualStyleBackColor = true;
            this.Withdrawbutton.Click += new System.EventHandler(this.Withdrawbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Withdrawbutton);
            this.Controls.Add(this.Depositbutton);
            this.Controls.Add(this.Createbutton);
            this.Controls.Add(this.AmounttextBox);
            this.Controls.Add(this.BalancetextBox);
            this.Controls.Add(this.resultlabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CurrencycomboBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CurrencycomboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label resultlabel;
        private System.Windows.Forms.TextBox BalancetextBox;
        private System.Windows.Forms.TextBox AmounttextBox;
        private System.Windows.Forms.Button Createbutton;
        private System.Windows.Forms.Button Depositbutton;
        private System.Windows.Forms.Button Withdrawbutton;
    }
}

