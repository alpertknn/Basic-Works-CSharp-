namespace LastTask
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
            this.Addition = new System.Windows.Forms.Button();
            this.Multiplication = new System.Windows.Forms.Button();
            this.Subtraction = new System.Windows.Forms.Button();
            this.Division = new System.Windows.Forms.Button();
            this.header = new System.Windows.Forms.Label();
            this.Number1 = new System.Windows.Forms.Label();
            this.Number2 = new System.Windows.Forms.Label();
            this.Result11 = new System.Windows.Forms.Label();
            this.second = new System.Windows.Forms.TextBox();
            this.first = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Addition
            // 
            this.Addition.Location = new System.Drawing.Point(54, 150);
            this.Addition.Name = "Addition";
            this.Addition.Size = new System.Drawing.Size(100, 23);
            this.Addition.TabIndex = 0;
            this.Addition.Text = "Addition";
            this.Addition.UseVisualStyleBackColor = true;
            this.Addition.Click += new System.EventHandler(this.Addition_Click);
            // 
            // Multiplication
            // 
            this.Multiplication.Location = new System.Drawing.Point(248, 150);
            this.Multiplication.Name = "Multiplication";
            this.Multiplication.Size = new System.Drawing.Size(100, 23);
            this.Multiplication.TabIndex = 1;
            this.Multiplication.Text = "Multiplication";
            this.Multiplication.UseVisualStyleBackColor = true;
            this.Multiplication.Click += new System.EventHandler(this.Multiplication_Click);
            // 
            // Subtraction
            // 
            this.Subtraction.Location = new System.Drawing.Point(54, 209);
            this.Subtraction.Name = "Subtraction";
            this.Subtraction.Size = new System.Drawing.Size(100, 23);
            this.Subtraction.TabIndex = 2;
            this.Subtraction.Text = "Subtraction";
            this.Subtraction.UseVisualStyleBackColor = true;
            this.Subtraction.Click += new System.EventHandler(this.Subtraction_Click);
            // 
            // Division
            // 
            this.Division.Location = new System.Drawing.Point(248, 209);
            this.Division.Name = "Division";
            this.Division.Size = new System.Drawing.Size(100, 23);
            this.Division.TabIndex = 3;
            this.Division.Text = "Division";
            this.Division.UseVisualStyleBackColor = true;
            this.Division.Click += new System.EventHandler(this.Division_Click);
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.header.Location = new System.Drawing.Point(172, 18);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(331, 31);
            this.header.TabIndex = 4;
            this.header.Text = "CENG201-CALCULATOR";
            // 
            // Number1
            // 
            this.Number1.AutoSize = true;
            this.Number1.Location = new System.Drawing.Point(78, 70);
            this.Number1.Name = "Number1";
            this.Number1.Size = new System.Drawing.Size(50, 13);
            this.Number1.TabIndex = 5;
            this.Number1.Text = "Number1";
            // 
            // Number2
            // 
            this.Number2.AutoSize = true;
            this.Number2.Location = new System.Drawing.Point(276, 70);
            this.Number2.Name = "Number2";
            this.Number2.Size = new System.Drawing.Size(50, 13);
            this.Number2.TabIndex = 6;
            this.Number2.Text = "Number2";
            // 
            // Result11
            // 
            this.Result11.AutoSize = true;
            this.Result11.Location = new System.Drawing.Point(477, 130);
            this.Result11.Name = "Result11";
            this.Result11.Size = new System.Drawing.Size(37, 13);
            this.Result11.TabIndex = 7;
            this.Result11.Text = "Result";
            // 
            // second
            // 
            this.second.Location = new System.Drawing.Point(248, 113);
            this.second.Name = "second";
            this.second.Size = new System.Drawing.Size(100, 20);
            this.second.TabIndex = 8;
            this.second.TextChanged += new System.EventHandler(this.second_TextChanged);
            // 
            // first
            // 
            this.first.Location = new System.Drawing.Point(54, 113);
            this.first.Name = "first";
            this.first.Size = new System.Drawing.Size(100, 20);
            this.first.TabIndex = 9;
            this.first.TextChanged += new System.EventHandler(this.first_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(447, 176);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 10;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 328);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.first);
            this.Controls.Add(this.second);
            this.Controls.Add(this.Result11);
            this.Controls.Add(this.Number2);
            this.Controls.Add(this.Number1);
            this.Controls.Add(this.header);
            this.Controls.Add(this.Division);
            this.Controls.Add(this.Subtraction);
            this.Controls.Add(this.Multiplication);
            this.Controls.Add(this.Addition);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Addition;
        private System.Windows.Forms.Button Multiplication;
        private System.Windows.Forms.Button Subtraction;
        private System.Windows.Forms.Button Division;
        private System.Windows.Forms.Label header;
        private System.Windows.Forms.Label Number1;
        private System.Windows.Forms.Label Number2;
        private System.Windows.Forms.Label Result11;
        private System.Windows.Forms.TextBox second;
        private System.Windows.Forms.TextBox first;
        private System.Windows.Forms.TextBox textBox3;
    }
}

