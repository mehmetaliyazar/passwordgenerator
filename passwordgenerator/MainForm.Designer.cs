
namespace passwordgenerator
{
    partial class MainForm
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
            this.btnGenerate = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkIncludeSimilar = new System.Windows.Forms.CheckBox();
            this.checkIncludeUppercase = new System.Windows.Forms.CheckBox();
            this.checkIncludeLowercase = new System.Windows.Forms.CheckBox();
            this.checkIncludeNumbers = new System.Windows.Forms.CheckBox();
            this.checkIncludeSymbols = new System.Windows.Forms.CheckBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.lblLength = new System.Windows.Forms.Label();
            this.lblMinimum = new System.Windows.Forms.Label();
            this.lblMaximum = new System.Windows.Forms.Label();
            this.btnTR = new System.Windows.Forms.Button();
            this.btnEN = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(13, 53);
            this.btnGenerate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(382, 72);
            this.btnGenerate.TabIndex = 0;
            this.btnGenerate.Text = "button1";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 14);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(296, 29);
            this.textBox1.TabIndex = 1;
            // 
            // checkIncludeSimilar
            // 
            this.checkIncludeSimilar.Location = new System.Drawing.Point(423, 154);
            this.checkIncludeSimilar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkIncludeSimilar.Name = "checkIncludeSimilar";
            this.checkIncludeSimilar.Size = new System.Drawing.Size(191, 84);
            this.checkIncludeSimilar.TabIndex = 2;
            this.checkIncludeSimilar.Text = "checkIncludeSimilar";
            this.checkIncludeSimilar.UseVisualStyleBackColor = true;
            // 
            // checkIncludeUppercase
            // 
            this.checkIncludeUppercase.AutoSize = true;
            this.checkIncludeUppercase.Checked = true;
            this.checkIncludeUppercase.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkIncludeUppercase.Location = new System.Drawing.Point(423, 14);
            this.checkIncludeUppercase.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkIncludeUppercase.Name = "checkIncludeUppercase";
            this.checkIncludeUppercase.Size = new System.Drawing.Size(191, 25);
            this.checkIncludeUppercase.TabIndex = 3;
            this.checkIncludeUppercase.Text = "checkIncludeUppercase";
            this.checkIncludeUppercase.UseVisualStyleBackColor = true;
            // 
            // checkIncludeLowercase
            // 
            this.checkIncludeLowercase.AutoSize = true;
            this.checkIncludeLowercase.Checked = true;
            this.checkIncludeLowercase.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkIncludeLowercase.Location = new System.Drawing.Point(423, 49);
            this.checkIncludeLowercase.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkIncludeLowercase.Name = "checkIncludeLowercase";
            this.checkIncludeLowercase.Size = new System.Drawing.Size(191, 25);
            this.checkIncludeLowercase.TabIndex = 4;
            this.checkIncludeLowercase.Text = "checkIncludeLowercase";
            this.checkIncludeLowercase.UseVisualStyleBackColor = true;
            // 
            // checkIncludeNumbers
            // 
            this.checkIncludeNumbers.AutoSize = true;
            this.checkIncludeNumbers.Checked = true;
            this.checkIncludeNumbers.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkIncludeNumbers.Location = new System.Drawing.Point(423, 84);
            this.checkIncludeNumbers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkIncludeNumbers.Name = "checkIncludeNumbers";
            this.checkIncludeNumbers.Size = new System.Drawing.Size(183, 25);
            this.checkIncludeNumbers.TabIndex = 5;
            this.checkIncludeNumbers.Text = "checkIncludeNumbers";
            this.checkIncludeNumbers.UseVisualStyleBackColor = true;
            // 
            // checkIncludeSymbols
            // 
            this.checkIncludeSymbols.AutoSize = true;
            this.checkIncludeSymbols.Location = new System.Drawing.Point(423, 119);
            this.checkIncludeSymbols.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkIncludeSymbols.Name = "checkIncludeSymbols";
            this.checkIncludeSymbols.Size = new System.Drawing.Size(178, 25);
            this.checkIncludeSymbols.TabIndex = 6;
            this.checkIncludeSymbols.Text = "checkIncludeSymbols";
            this.checkIncludeSymbols.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(163, 205);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(122, 29);
            this.numericUpDown1.TabIndex = 7;
            this.numericUpDown1.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(12, 207);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(75, 21);
            this.lblLength.TabIndex = 8;
            this.lblLength.Text = "lblLength";
            // 
            // lblMinimum
            // 
            this.lblMinimum.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMinimum.Location = new System.Drawing.Point(291, 204);
            this.lblMinimum.Name = "lblMinimum";
            this.lblMinimum.Size = new System.Drawing.Size(122, 17);
            this.lblMinimum.TabIndex = 9;
            this.lblMinimum.Text = "lblMinimum";
            // 
            // lblMaximum
            // 
            this.lblMaximum.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMaximum.Location = new System.Drawing.Point(291, 221);
            this.lblMaximum.Name = "lblMaximum";
            this.lblMaximum.Size = new System.Drawing.Size(122, 17);
            this.lblMaximum.TabIndex = 10;
            this.lblMaximum.Text = "lblMaximum";
            // 
            // btnTR
            // 
            this.btnTR.Location = new System.Drawing.Point(13, 133);
            this.btnTR.Name = "btnTR";
            this.btnTR.Size = new System.Drawing.Size(96, 32);
            this.btnTR.TabIndex = 13;
            this.btnTR.Text = "Türkçe";
            this.btnTR.UseVisualStyleBackColor = true;
            this.btnTR.Click += new System.EventHandler(this.BringLanguageButton);
            // 
            // btnEN
            // 
            this.btnEN.Location = new System.Drawing.Point(115, 133);
            this.btnEN.Name = "btnEN";
            this.btnEN.Size = new System.Drawing.Size(96, 32);
            this.btnEN.TabIndex = 14;
            this.btnEN.Text = "English";
            this.btnEN.UseVisualStyleBackColor = true;
            this.btnEN.Click += new System.EventHandler(this.BringLanguageButton);
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(316, 14);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(79, 29);
            this.btnCopy.TabIndex = 15;
            this.btnCopy.Text = "btnCopy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 246);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnEN);
            this.Controls.Add(this.btnTR);
            this.Controls.Add(this.lblMaximum);
            this.Controls.Add(this.lblMinimum);
            this.Controls.Add(this.lblLength);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.checkIncludeSymbols);
            this.Controls.Add(this.checkIncludeNumbers);
            this.Controls.Add(this.checkIncludeLowercase);
            this.Controls.Add(this.checkIncludeUppercase);
            this.Controls.Add(this.checkIncludeSimilar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnGenerate);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(645, 285);
            this.MinimumSize = new System.Drawing.Size(645, 285);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Password Generator";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox checkIncludeSimilar;
        private System.Windows.Forms.CheckBox checkIncludeUppercase;
        private System.Windows.Forms.CheckBox checkIncludeLowercase;
        private System.Windows.Forms.CheckBox checkIncludeNumbers;
        private System.Windows.Forms.CheckBox checkIncludeSymbols;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.Label lblMinimum;
        private System.Windows.Forms.Label lblMaximum;
        private System.Windows.Forms.Button btnTR;
        private System.Windows.Forms.Button btnEN;
        private System.Windows.Forms.Button btnCopy;
    }
}

