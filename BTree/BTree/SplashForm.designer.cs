///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  BTree Project 5
//	File Name:         SplashFormDesigner.cs
//	Description:       This class initializes the GUI for the splash form
//	Course:            CSCI 2210 - Data Structures	
//	Author:            Andrew Haselden, andrewhaselden@gmail.com                                                
//	Created:           Friday, April 14, 2017
//	Copyright:         Andrew Haselden, 2017
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

namespace BTree
{
    /// <summary>
    /// This class initializes the GUI for the splash form
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    partial class SplashForm
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
            this.LabelProgramName = new System.Windows.Forms.Label();
            this.LabelCompanyName = new System.Windows.Forms.Label();
            this.LabelVersion = new System.Windows.Forms.Label();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelProgramName
            // 
            this.LabelProgramName.AutoSize = true;
            this.LabelProgramName.Font = new System.Drawing.Font("Lucida Sans", 15.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelProgramName.Location = new System.Drawing.Point(172, 21);
            this.LabelProgramName.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.LabelProgramName.Name = "LabelProgramName";
            this.LabelProgramName.Size = new System.Drawing.Size(0, 25);
            this.LabelProgramName.TabIndex = 0;
            this.LabelProgramName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelCompanyName
            // 
            this.LabelCompanyName.AutoSize = true;
            this.LabelCompanyName.Font = new System.Drawing.Font("Lucida Sans", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCompanyName.Location = new System.Drawing.Point(138, 279);
            this.LabelCompanyName.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.LabelCompanyName.Name = "LabelCompanyName";
            this.LabelCompanyName.Size = new System.Drawing.Size(0, 17);
            this.LabelCompanyName.TabIndex = 1;
            // 
            // LabelVersion
            // 
            this.LabelVersion.AutoSize = true;
            this.LabelVersion.Font = new System.Drawing.Font("Lucida Sans", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelVersion.Location = new System.Drawing.Point(205, 299);
            this.LabelVersion.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.LabelVersion.Name = "LabelVersion";
            this.LabelVersion.Size = new System.Drawing.Size(0, 17);
            this.LabelVersion.TabIndex = 2;
            // 
            // PictureBox1
            // 
            this.PictureBox1.BackgroundImage = global::BTree.Properties.Resources.tree1;
            this.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PictureBox1.InitialImage = null;
            this.PictureBox1.Location = new System.Drawing.Point(189, 84);
            this.PictureBox1.Margin = new System.Windows.Forms.Padding(1);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(145, 151);
            this.PictureBox1.TabIndex = 3;
            this.PictureBox1.TabStop = false;
            // 
            // SplashForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 341);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.LabelVersion);
            this.Controls.Add(this.LabelCompanyName);
            this.Controls.Add(this.LabelProgramName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(1);
            this.MaximizeBox = false;
            this.Name = "SplashForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SplashForm_FormClosing);
            this.Load += new System.EventHandler(this.SplashForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelProgramName;
        private System.Windows.Forms.Label LabelCompanyName;
        private System.Windows.Forms.Label LabelVersion;
        private System.Windows.Forms.PictureBox PictureBox1;
    }
}