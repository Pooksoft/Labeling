﻿namespace Interface
{
    partial class Panel
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components;

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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "Panel";
            this.Size = new System.Drawing.Size(200, 200);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseDown);
            this.MouseEnter += new System.EventHandler(this.Panel_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.Panel_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseUp);
            this.Resize += new System.EventHandler(this.Panel_Resize);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
