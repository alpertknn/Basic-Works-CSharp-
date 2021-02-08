namespace alpernew
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
            this.agetextBox = new System.Windows.Forms.TextBox();
            this.speciestextBox = new System.Windows.Forms.TextBox();
            this.nametextBox = new System.Windows.Forms.TextBox();
            this.gendercomboBox = new System.Windows.Forms.ComboBox();
            this.animalscomboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.soundlabel = new System.Windows.Forms.Label();
            this.resultlabel = new System.Windows.Forms.Label();
            this.addbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // agetextBox
            // 
            this.agetextBox.Location = new System.Drawing.Point(163, 175);
            this.agetextBox.Name = "agetextBox";
            this.agetextBox.Size = new System.Drawing.Size(100, 20);
            this.agetextBox.TabIndex = 0;
            this.agetextBox.TextChanged += new System.EventHandler(this.agetextBox_TextChanged);
            // 
            // speciestextBox
            // 
            this.speciestextBox.Location = new System.Drawing.Point(393, 89);
            this.speciestextBox.Name = "speciestextBox";
            this.speciestextBox.Size = new System.Drawing.Size(100, 20);
            this.speciestextBox.TabIndex = 1;
            this.speciestextBox.TextChanged += new System.EventHandler(this.speciestextBox_TextChanged);
            // 
            // nametextBox
            // 
            this.nametextBox.Location = new System.Drawing.Point(163, 89);
            this.nametextBox.Name = "nametextBox";
            this.nametextBox.Size = new System.Drawing.Size(100, 20);
            this.nametextBox.TabIndex = 2;
            this.nametextBox.TextChanged += new System.EventHandler(this.nametextBox_TextChanged);
            // 
            // gendercomboBox
            // 
            this.gendercomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gendercomboBox.FormattingEnabled = true;
            this.gendercomboBox.Location = new System.Drawing.Point(393, 175);
            this.gendercomboBox.Name = "gendercomboBox";
            this.gendercomboBox.Size = new System.Drawing.Size(121, 21);
            this.gendercomboBox.TabIndex = 3;
            this.gendercomboBox.SelectedIndexChanged += new System.EventHandler(this.gendercomboBox_SelectedIndexChanged);
            // 
            // animalscomboBox
            // 
            this.animalscomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.animalscomboBox.FormattingEnabled = true;
            this.animalscomboBox.Location = new System.Drawing.Point(163, 289);
            this.animalscomboBox.Name = "animalscomboBox";
            this.animalscomboBox.Size = new System.Drawing.Size(341, 21);
            this.animalscomboBox.TabIndex = 4;
            this.animalscomboBox.SelectedIndexChanged += new System.EventHandler(this.animalscomboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(160, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(387, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Species";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(160, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Age";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(390, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Gender";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(160, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Animals";
            // 
            // soundlabel
            // 
            this.soundlabel.AutoSize = true;
            this.soundlabel.Location = new System.Drawing.Point(128, 353);
            this.soundlabel.Name = "soundlabel";
            this.soundlabel.Size = new System.Drawing.Size(36, 13);
            this.soundlabel.TabIndex = 10;
            this.soundlabel.Text = "sound";
            this.soundlabel.Click += new System.EventHandler(this.soundlabel_Click);
            // 
            // resultlabel
            // 
            this.resultlabel.AutoSize = true;
            this.resultlabel.Location = new System.Drawing.Point(621, 310);
            this.resultlabel.Name = "resultlabel";
            this.resultlabel.Size = new System.Drawing.Size(35, 13);
            this.resultlabel.TabIndex = 11;
            this.resultlabel.Text = "label7";
            this.resultlabel.Click += new System.EventHandler(this.resultlabel_Click);
            // 
            // addbutton
            // 
            this.addbutton.Location = new System.Drawing.Point(643, 125);
            this.addbutton.Name = "addbutton";
            this.addbutton.Size = new System.Drawing.Size(102, 82);
            this.addbutton.TabIndex = 12;
            this.addbutton.Text = "Add";
            this.addbutton.UseVisualStyleBackColor = true;
            this.addbutton.Click += new System.EventHandler(this.addbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addbutton);
            this.Controls.Add(this.resultlabel);
            this.Controls.Add(this.soundlabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.animalscomboBox);
            this.Controls.Add(this.gendercomboBox);
            this.Controls.Add(this.nametextBox);
            this.Controls.Add(this.speciestextBox);
            this.Controls.Add(this.agetextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox agetextBox;
        private System.Windows.Forms.TextBox speciestextBox;
        private System.Windows.Forms.TextBox nametextBox;
        private System.Windows.Forms.ComboBox gendercomboBox;
        private System.Windows.Forms.ComboBox animalscomboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label soundlabel;
        private System.Windows.Forms.Label resultlabel;
        private System.Windows.Forms.Button addbutton;
    }
}

