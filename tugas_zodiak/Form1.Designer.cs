namespace tugas_zodiak
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
            this.label3 = new System.Windows.Forms.Label();
            this.rtbZodiak = new System.Windows.Forms.RichTextBox();
            this.btnHasil = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dtpZodiak = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Zodiak";
            // 
            // rtbZodiak
            // 
            this.rtbZodiak.Location = new System.Drawing.Point(16, 129);
            this.rtbZodiak.Name = "rtbZodiak";
            this.rtbZodiak.Size = new System.Drawing.Size(243, 126);
            this.rtbZodiak.TabIndex = 3;
            this.rtbZodiak.Text = "";
            // 
            // btnHasil
            // 
            this.btnHasil.Location = new System.Drawing.Point(214, 80);
            this.btnHasil.Name = "btnHasil";
            this.btnHasil.Size = new System.Drawing.Size(45, 23);
            this.btnHasil.TabIndex = 8;
            this.btnHasil.Text = "Cek";
            this.btnHasil.UseVisualStyleBackColor = true;
            this.btnHasil.Click += new System.EventHandler(this.btnHasil_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(90, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(46, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtpZodiak
            // 
            this.dtpZodiak.CustomFormat = "dd/MMMM/yyyy";
            this.dtpZodiak.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpZodiak.Location = new System.Drawing.Point(90, 31);
            this.dtpZodiak.Name = "dtpZodiak";
            this.dtpZodiak.Size = new System.Drawing.Size(169, 20);
            this.dtpZodiak.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.dtpZodiak);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnHasil);
            this.Controls.Add(this.rtbZodiak);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtbZodiak;
        private System.Windows.Forms.Button btnHasil;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dtpZodiak;
    }
}

