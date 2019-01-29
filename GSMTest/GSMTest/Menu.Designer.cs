using System;

namespace GSMTest
{
    partial class Menu
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
            this.EncodeASCII = new System.Windows.Forms.Button();
            this.FindComplement = new System.Windows.Forms.Button();
            this.LCS = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(75, 35);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(330, 26);
            this.Title.TabIndex = 0;
            this.Title.Text = "GSM PROGRAMMING TEST";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EncodeASCII
            // 
            this.EncodeASCII.Location = new System.Drawing.Point(158, 169);
            this.EncodeASCII.Name = "EncodeASCII";
            this.EncodeASCII.Size = new System.Drawing.Size(158, 42);
            this.EncodeASCII.TabIndex = 1;
            this.EncodeASCII.Text = "ASCII to DNA";
            this.EncodeASCII.UseVisualStyleBackColor = true;
            this.EncodeASCII.Click += new System.EventHandler(this.ASCII_to_DNA_Clicked);
            // 
            // FindComplement
            // 
            this.FindComplement.Location = new System.Drawing.Point(158, 217);
            this.FindComplement.Name = "FindComplement";
            this.FindComplement.Size = new System.Drawing.Size(158, 42);
            this.FindComplement.TabIndex = 3;
            this.FindComplement.Text = "DNA to ASCII";
            this.FindComplement.UseVisualStyleBackColor = true;
            this.FindComplement.Click += new System.EventHandler(this.DNA_to_ASCII_Clicked);
            // 
            // LCS
            // 
            this.LCS.Location = new System.Drawing.Point(158, 265);
            this.LCS.Name = "LCS";
            this.LCS.Size = new System.Drawing.Size(158, 42);
            this.LCS.TabIndex = 4;
            this.LCS.Text = "Find LCS";
            this.LCS.UseVisualStyleBackColor = true;
            this.LCS.Click += new System.EventHandler(this.LCS_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(482, 453);
            this.Controls.Add(this.LCS);
            this.Controls.Add(this.FindComplement);
            this.Controls.Add(this.EncodeASCII);
            this.Controls.Add(this.Title);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button EncodeASCII;
        private System.Windows.Forms.Button FindComplement;
        private System.Windows.Forms.Button LCS;
    }
}