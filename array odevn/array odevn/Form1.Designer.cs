namespace array_odevn
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
            this.submit = new System.Windows.Forms.Label();
            this.son = new System.Windows.Forms.RichTextBox();
            this.sen = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "sum of odd number";
            // 
            // submit
            // 
            this.submit.AutoSize = true;
            this.submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit.Location = new System.Drawing.Point(110, 28);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(55, 16);
            this.submit.TabIndex = 1;
            this.submit.Text = "Submit";
            this.submit.Click += new System.EventHandler(this.label2_Click);
            // 
            // son
            // 
            this.son.Location = new System.Drawing.Point(148, 66);
            this.son.Name = "son";
            this.son.Size = new System.Drawing.Size(175, 84);
            this.son.TabIndex = 4;
            this.son.Text = "";
            this.son.TextChanged += new System.EventHandler(this.son_TextChanged);
            // 
            // sen
            // 
            this.sen.Location = new System.Drawing.Point(148, 167);
            this.sen.Name = "sen";
            this.sen.Size = new System.Drawing.Size(175, 82);
            this.sen.TabIndex = 5;
            this.sen.Text = "";
            this.sen.TextChanged += new System.EventHandler(this.sen_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "sum of even number";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 293);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sen);
            this.Controls.Add(this.son);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label submit;
        private System.Windows.Forms.RichTextBox son;
        private System.Windows.Forms.RichTextBox sen;
        private System.Windows.Forms.Label label3;
    }
}

