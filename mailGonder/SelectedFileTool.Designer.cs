﻿namespace mailGonder
{
    partial class SelectedFileTool
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblFileName = new System.Windows.Forms.LinkLabel();
            this.btnCancelAttach = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblFileName);
            this.panel2.Controls.Add(this.btnCancelAttach);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(248, 32);
            this.panel2.TabIndex = 17;
            // 
            // lblFileName
            // 
            this.lblFileName.Location = new System.Drawing.Point(7, 5);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(205, 20);
            this.lblFileName.TabIndex = 10;
            this.lblFileName.TabStop = true;
            this.lblFileName.Text = "linkLabel1";
            // 
            // btnCancelAttach
            // 
            this.btnCancelAttach.Image = global::mailGonder.Properties.Resources.cancelAttach;
            this.btnCancelAttach.Location = new System.Drawing.Point(218, 2);
            this.btnCancelAttach.Name = "btnCancelAttach";
            this.btnCancelAttach.Size = new System.Drawing.Size(25, 25);
            this.btnCancelAttach.TabIndex = 9;
            this.btnCancelAttach.Text = "x";
            this.btnCancelAttach.UseVisualStyleBackColor = true;
            this.btnCancelAttach.Click += new System.EventHandler(this.btnCancelAttach_Click);
            // 
            // SelectedFileTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Name = "SelectedFileTool";
            this.Size = new System.Drawing.Size(248, 32);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.LinkLabel lblFileName;
        private System.Windows.Forms.Button btnCancelAttach;
    }
}
