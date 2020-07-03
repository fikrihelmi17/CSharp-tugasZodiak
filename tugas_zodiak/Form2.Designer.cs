namespace tugas_zodiak
{
    partial class Form2
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
            this.btnHasil = new System.Windows.Forms.Button();
            this.Nilai = new System.Windows.Forms.Label();
            this.Hasul = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.txtHasil = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHasil
            // 
            this.btnHasil.Location = new System.Drawing.Point(113, 110);
            this.btnHasil.Name = "btnHasil";
            this.btnHasil.Size = new System.Drawing.Size(75, 23);
            this.btnHasil.TabIndex = 0;
            this.btnHasil.Text = "Hasil";
            this.btnHasil.UseVisualStyleBackColor = true;
            this.btnHasil.Click += new System.EventHandler(this.btnHasil_Click);
            // 
            // Nilai
            // 
            this.Nilai.AutoSize = true;
            this.Nilai.Location = new System.Drawing.Point(13, 23);
            this.Nilai.Name = "Nilai";
            this.Nilai.Size = new System.Drawing.Size(80, 13);
            this.Nilai.TabIndex = 1;
            this.Nilai.Text = "Masukkan Nilai";
            // 
            // Hasul
            // 
            this.Hasul.AutoSize = true;
            this.Hasul.Location = new System.Drawing.Point(13, 65);
            this.Hasul.Name = "Hasul";
            this.Hasul.Size = new System.Drawing.Size(36, 13);
            this.Hasul.TabIndex = 2;
            this.Hasul.Text = "Grade";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(113, 15);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(100, 20);
            this.txtInput.TabIndex = 3;
            this.txtInput.TextChanged += new System.EventHandler(this.txtInput_TextChanged);
            // 
            // txtHasil
            // 
            this.txtHasil.Location = new System.Drawing.Point(113, 57);
            this.txtHasil.Name = "txtHasil";
            this.txtHasil.Size = new System.Drawing.Size(100, 20);
            this.txtHasil.TabIndex = 4;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(113, 139);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtHasil);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.Hasul);
            this.Controls.Add(this.Nilai);
            this.Controls.Add(this.btnHasil);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHasil;
        private System.Windows.Forms.Label Nilai;
        private System.Windows.Forms.Label Hasul;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.TextBox txtHasil;
        private System.Windows.Forms.Button btnClear;
    }
}