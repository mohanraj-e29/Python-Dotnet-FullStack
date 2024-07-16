namespace secondlargnumbr
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
            this.ri = new System.Windows.Forms.RichTextBox();
            this.pr = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ri
            // 
            this.ri.Location = new System.Drawing.Point(51, 108);
            this.ri.Name = "ri";
            this.ri.Size = new System.Drawing.Size(165, 59);
            this.ri.TabIndex = 1;
            this.ri.Text = "";
            // 
            // pr
            // 
            this.pr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pr.Location = new System.Drawing.Point(79, 45);
            this.pr.Name = "pr";
            this.pr.Size = new System.Drawing.Size(106, 32);
            this.pr.TabIndex = 2;
            this.pr.Text = "Print";
            this.pr.UseVisualStyleBackColor = true;
            this.pr.Click += new System.EventHandler(this.pr_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.pr);
            this.Controls.Add(this.ri);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox ri;
        private System.Windows.Forms.Button pr;

    }
}

