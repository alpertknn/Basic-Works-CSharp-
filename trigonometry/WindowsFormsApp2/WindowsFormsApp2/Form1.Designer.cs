namespace WindowsFormsApp2
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
            this.label1 = new System.Windows.Forms.Label();
            this.angA = new System.Windows.Forms.TextBox();
            this.angB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.angC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.generate = new System.Windows.Forms.Button();
            this.show = new System.Windows.Forms.Button();
            this.resultlabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "AngleA";
            // 
            // angA
            // 
            this.angA.Location = new System.Drawing.Point(160, 69);
            this.angA.Name = "angA";
            this.angA.Size = new System.Drawing.Size(100, 20);
            this.angA.TabIndex = 1;
            
            // 
            // angB
            // 
            this.angB.Location = new System.Drawing.Point(160, 114);
            this.angB.Name = "angB";
            this.angB.Size = new System.Drawing.Size(100, 20);
            this.angB.TabIndex = 3;
            
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "AngleB";
            // 
            // angC
            // 
            this.angC.Location = new System.Drawing.Point(160, 159);
            this.angC.Name = "angC";
            this.angC.Size = new System.Drawing.Size(100, 20);
            this.angC.TabIndex = 5;
            
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "AngleC";
            // 
            // generate
            // 
            this.generate.Location = new System.Drawing.Point(541, 52);
            this.generate.Name = "generate";
            this.generate.Size = new System.Drawing.Size(136, 82);
            this.generate.TabIndex = 6;
            this.generate.Text = "Generate  Random\r\nAngles";
            this.generate.UseVisualStyleBackColor = true;
            this.generate.Click += new System.EventHandler(this.generate_Click);
            // 
            // show
            // 
            this.show.Location = new System.Drawing.Point(541, 166);
            this.show.Name = "show";
            this.show.Size = new System.Drawing.Size(136, 76);
            this.show.TabIndex = 7;
            this.show.Text = "Show Trigonometric\r\nValues\r\n";
            this.show.UseVisualStyleBackColor = true;
            this.show.Click += new System.EventHandler(this.show_Click);
            // 
            // resultlabel
            // 
            this.resultlabel.AutoSize = true;
            this.resultlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultlabel.Location = new System.Drawing.Point(338, 299);
            this.resultlabel.Name = "resultlabel";
            this.resultlabel.Size = new System.Drawing.Size(66, 25);
            this.resultlabel.TabIndex = 8;
            this.resultlabel.Text = "Result";
            this.resultlabel.Click += new System.EventHandler(this.resultlabel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resultlabel);
            this.Controls.Add(this.show);
            this.Controls.Add(this.generate);
            this.Controls.Add(this.angC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.angB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.angA);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox angA;
        private System.Windows.Forms.TextBox angB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox angC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button generate;
        private System.Windows.Forms.Button show;
        private System.Windows.Forms.Label resultlabel;
    }
}

