﻿namespace FunWithCodeWinForms
{
    partial class RectanglesRandomFill
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
            this.buttonRandomFill = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // buttonRandomFill
            // 
            this.buttonRandomFill.Location = new System.Drawing.Point(0, 28);
            this.buttonRandomFill.Name = "buttonRandomFill";
            this.buttonRandomFill.Size = new System.Drawing.Size(75, 23);
            this.buttonRandomFill.TabIndex = 0;
            this.buttonRandomFill.Text = "buttonRandomFill";
            this.buttonRandomFill.UseVisualStyleBackColor = true;
            this.buttonRandomFill.Click += new System.EventHandler(this.buttonRandomFill_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(124, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(579, 391);
            this.panel1.TabIndex = 1;
            // 
            // RectanglesRandomFill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonRandomFill);
            this.Name = "RectanglesRandomFill";
            this.Text = "RectanglesRandomFill";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonRandomFill;
        private System.Windows.Forms.Panel panel1;
    }
}