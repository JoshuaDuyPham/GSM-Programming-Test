namespace GSMTest
{
    partial class LCS
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
            this.Title = new System.Windows.Forms.Label();
            this.OutputLabel = new System.Windows.Forms.Label();
            this.Submit = new System.Windows.Forms.Button();
            this.Input2 = new System.Windows.Forms.TextBox();
            this.InputLabel = new System.Windows.Forms.Label();
            this.Input1 = new System.Windows.Forms.TextBox();
            this.Return = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Output = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Title.Location = new System.Drawing.Point(16, 60);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(402, 29);
            this.Title.TabIndex = 1;
            this.Title.Text = "Longest Common Subsequence";
            // 
            // OutputLabel
            // 
            this.OutputLabel.AutoSize = true;
            this.OutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.OutputLabel.Location = new System.Drawing.Point(44, 303);
            this.OutputLabel.Name = "OutputLabel";
            this.OutputLabel.Size = new System.Drawing.Size(353, 25);
            this.OutputLabel.TabIndex = 5;
            this.OutputLabel.Text = "The longest common subsequence is : ";
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(370, 260);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(75, 31);
            this.Submit.TabIndex = 7;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // Input2
            // 
            this.Input2.Location = new System.Drawing.Point(231, 223);
            this.Input2.Name = "Input2";
            this.Input2.Size = new System.Drawing.Size(214, 22);
            this.Input2.TabIndex = 4;
            // 
            // InputLabel
            // 
            this.InputLabel.AutoSize = true;
            this.InputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputLabel.Location = new System.Drawing.Point(33, 191);
            this.InputLabel.Name = "InputLabel";
            this.InputLabel.Size = new System.Drawing.Size(181, 25);
            this.InputLabel.TabIndex = 2;
            this.InputLabel.Text = "DNA Sequence 1 : ";
            // 
            // Input1
            // 
            this.Input1.Location = new System.Drawing.Point(231, 191);
            this.Input1.Name = "Input1";
            this.Input1.Size = new System.Drawing.Size(214, 22);
            this.Input1.TabIndex = 3;
            // 
            // Return
            // 
            this.Return.Location = new System.Drawing.Point(13, 13);
            this.Return.Name = "Return";
            this.Return.Size = new System.Drawing.Size(75, 28);
            this.Return.TabIndex = 8;
            this.Return.Text = "Back";
            this.Return.UseVisualStyleBackColor = true;
            this.Return.Click += new System.EventHandler(this.Return_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "DNA Sequence 2 : ";
            // 
            // Output
            // 
            this.Output.AutoSize = true;
            this.Output.Location = new System.Drawing.Point(46, 346);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(0, 17);
            this.Output.TabIndex = 10;
            // 
            // LCS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(482, 453);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Return);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.OutputLabel);
            this.Controls.Add(this.Input2);
            this.Controls.Add(this.Input1);
            this.Controls.Add(this.InputLabel);
            this.Controls.Add(this.Title);
            this.Name = "LCS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label OutputLabel;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.TextBox Input2;
        private System.Windows.Forms.Label InputLabel;
        private System.Windows.Forms.TextBox Input1;
        private System.Windows.Forms.Button Return;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Output;
    }
}

