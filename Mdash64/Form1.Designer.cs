namespace Mdash64
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
            this.btnPick = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.fdPick = new System.Windows.Forms.OpenFileDialog();
            this.cmbOutput = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnPick
            // 
            this.btnPick.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPick.Location = new System.Drawing.Point(178, 15);
            this.btnPick.Name = "btnPick";
            this.btnPick.Size = new System.Drawing.Size(81, 23);
            this.btnPick.TabIndex = 0;
            this.btnPick.Text = "Select file...";
            this.btnPick.UseVisualStyleBackColor = true;
            this.btnPick.Click += new System.EventHandler(this.btnPick_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(12, 44);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(247, 157);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Selet a file";
            // 
            // cmbOutput
            // 
            this.cmbOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbOutput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOutput.FormattingEnabled = true;
            this.cmbOutput.Items.AddRange(new object[] {
            "Base64",
            "Hex (lc)",
            "Hex (uc)",
            "UTF-8 (raw)"});
            this.cmbOutput.Location = new System.Drawing.Point(12, 17);
            this.cmbOutput.Name = "cmbOutput";
            this.cmbOutput.Size = new System.Drawing.Size(160, 21);
            this.cmbOutput.Sorted = true;
            this.cmbOutput.TabIndex = 6;
            this.cmbOutput.SelectedIndexChanged += new System.EventHandler(this.cmbOutput_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 213);
            this.Controls.Add(this.cmbOutput);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnPick);
            this.Name = "Form1";
            this.Text = "Mdash64";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPick;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.OpenFileDialog fdPick;
        private System.Windows.Forms.ComboBox cmbOutput;

    }
}

