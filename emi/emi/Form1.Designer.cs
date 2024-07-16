namespace emi
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.eba = new System.Windows.Forms.TextBox();
            this.g = new System.Windows.Forms.TextBox();
            this.t = new System.Windows.Forms.TextBox();
            this.r = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.s = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Bill Amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(139, 83);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(34, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "GST";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(134, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Total";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(97, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Select EMI";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // eba
            // 
            this.eba.Location = new System.Drawing.Point(190, 16);
            this.eba.Name = "eba";
            this.eba.Size = new System.Drawing.Size(206, 20);
            this.eba.TabIndex = 4;
            this.eba.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // g
            // 
            this.g.Location = new System.Drawing.Point(190, 82);
            this.g.Name = "g";
            this.g.Size = new System.Drawing.Size(206, 20);
            this.g.TabIndex = 5;
            this.g.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // t
            // 
            this.t.Location = new System.Drawing.Point(190, 115);
            this.t.Name = "t";
            this.t.Size = new System.Drawing.Size(206, 20);
            this.t.TabIndex = 6;
            this.t.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // r
            // 
            this.r.Location = new System.Drawing.Point(190, 205);
            this.r.Name = "r";
            this.r.Size = new System.Drawing.Size(206, 50);
            this.r.TabIndex = 7;
            this.r.Text = "";
            this.r.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(253, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // s
            // 
            this.s.FormattingEnabled = true;
            this.s.Items.AddRange(new object[] {
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.s.Location = new System.Drawing.Point(190, 153);
            this.s.Name = "s";
            this.s.Size = new System.Drawing.Size(206, 21);
            this.s.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 288);
            this.Controls.Add(this.s);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.r);
            this.Controls.Add(this.t);
            this.Controls.Add(this.g);
            this.Controls.Add(this.eba);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "EB Bill Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox eba;
        private System.Windows.Forms.TextBox g;
        private System.Windows.Forms.TextBox t;
        private System.Windows.Forms.RichTextBox r;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox s;
    }
}

